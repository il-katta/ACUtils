using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using Newtonsoft.Json.Linq;

using Abletech.Arxivar.Client;
using Abletech.Arxivar.Entities;
using Abletech.Arxivar.Entities.Enums;
using Abletech.Arxivar.Entities.Libraries;

using ACUtils.AXRepository.ArxivarNext.Model;
using ACUtils.AXRepository.ArxivarNextManagement.Model;
using ACUtils.AXRepository.Exceptions;


namespace ACUtils.AXRepository
{
    public class ArxivarRepository
    {
        const string STATO_ELIMINATO = "ELIMINATO";
        private string _username;
        private string _password;
        private string _apiUrl;
        private string _managementUrl;
        private string _workflowUrl;
        private string _appId;
        private string _appSecret;
        private string _wcfUrl;
        private long? _impersonateUserId;

        private string _token;
        private string _refresh_token;

        private WCFConnectorManager GetWcf()
        {

            var logonRequest = new ArxLogonRequest
            {
                ClientId = _appId,
                ClientSecret = _appSecret,
                EnablePushEvents = true,
                Username = _username,
                Password = _password,
                ImpersonateUserId = _impersonateUserId.HasValue ? System.Convert.ToInt32(_impersonateUserId) : default(int?)
            };
            var manager = new WCFConnectorManager(_wcfUrl, logonRequest)
            {
                AutoChunk = true,      //default a true
                AutoReconnect = true,  //default a true
                Lang = "IT"
            };
            manager.ChannelOpening += _manager_ChannelOpening;
            manager.ChannelOpened += _manager_ChannelOpened;
            return manager;

        }

        ACUtils.ILogger _logger = null;

        private ArxivarNext.Client.Configuration configuration =>
            new ArxivarNext.Client.Configuration()
            {
                ApiKey = new Dictionary<string, string>() { { "Authorization", _token } },
                ApiKeyPrefix = new Dictionary<string, string>() { { "Authorization", "Bearer" } },
                BasePath = _apiUrl,
            };

        private ArxivarNextManagement.Client.Configuration configurationManagement =>
            new ArxivarNextManagement.Client.Configuration()
            {
                ApiKey = new Dictionary<string, string>() { { "Authorization", _token } },
                ApiKeyPrefix = new Dictionary<string, string>() { { "Authorization", "Bearer" } },
                BasePath = _managementUrl,
            };

        private Abletech.WebApi.Client.ArxivarWorkflow.Client.Configuration configurationWorkflow =>
            new Abletech.WebApi.Client.ArxivarWorkflow.Client.Configuration()
            {
                ApiKey = new Dictionary<string, string>() { { "Authorization", _token } },
                ApiKeyPrefix = new Dictionary<string, string>() { { "Authorization", "Bearer" } },
                BasePath = _workflowUrl,
            };

        public ArxivarRepository(
            string apiUrl, string managementUrl, string workflowUrl, string username, string password, string appId, string appSecret,
            string wcf_url = "net.tcp://127.0.0.1:8740/Arxivar/Push",
            ACUtils.ILogger logger = null,
            long? impersonateUserId = null
        )
        {
            this._apiUrl = apiUrl;
            this._managementUrl = managementUrl;
            this._workflowUrl = workflowUrl;
            this._username = username;
            this._password = password;
            this._appId = appId;
            this._appSecret = appSecret;
            this._logger = logger;
            this._wcfUrl = wcf_url;
            this._impersonateUserId = impersonateUserId;
        }


        public ArxivarRepository(
           string apiUrl,
           string managementUrl,
           string workflowUrl,
           string authToken,
           ACUtils.ILogger logger = null
        )
        {
            this._apiUrl = apiUrl;
            this._managementUrl = managementUrl;
            this._workflowUrl = workflowUrl;
            this._logger = logger;
            _token = authToken;
        }

        #region file upload
        public List<string> UploadFile(Stream stream)
        {
            Login();
            var bufferApi = new ArxivarNext.Api.BufferApi(configuration);
            return bufferApi.BufferInsert(stream);
        }

        private string GetTemporaryDirectory()
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tempDirectory);
            return tempDirectory;
        }

        public List<string> UploadFile(string filePath, string filename = null)
        {
            Login();

            var bufferApi = new ArxivarNext.Api.BufferApi(configuration);

            // workaround per aprire file su share di rete e cambiare nome al file caricato
            var tmpDir = GetTemporaryDirectory();
            try
            {
                var tmppath = Path.Combine(tmpDir, filename ?? Path.GetFileName(filePath));
                File.Copy(filePath, tmppath);

                using (var stream = File.Open(tmppath, FileMode.Open))
                {
                    return bufferApi.BufferInsert(stream);
                }
            }
            finally
            {
                try
                {
                    System.IO.Directory.Delete(tmpDir, true);
                }
                catch { }
            }

        }
        #endregion

        #region user
        public ACUtils.AXRepository.ArxivarNext.Model.UserProfileDTO GetUserAddressBookEntry(string username, int type = 0)
        {
            Login();

            var addressBookApi = new ArxivarNext.Api.AddressBookApi(configuration);
            var userApi = new ArxivarNext.Api.UsersApi(configuration);
            // Dm_Rubrica.RAGIONE_SOCIALE = username | Dm_Rubrica.TIPO=U | Dm_Rubrica.STATO=P
            var users = userApi.UsersGet_0();
            var id = users.Where(u => u.Description.Equals(username, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault()?.User;
            return addressBookApi.AddressBookGetByUserId(id, type);
        }

        public UserInfoDTO UserInfo()
        {
            Login();
            var api = new ArxivarNext.Api.UsersApi(configuration);
            var userInfo = api.UsersGetUserInfo();
            return userInfo;
        }

        #endregion

        #region address book


        /// <summary>
        /// 
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="addressBookCategoryId"></param>
        /// <param name="type">Possible values:  To => 0 | From => 1 |  CC => 2 | Senders => 3</param>
        /// <returns></returns>
        public ACUtils.AXRepository.ArxivarNext.Model.UserProfileDTO GetAddressBookEntry(string codice, int addressBookCategoryId, UserProfileType type = UserProfileType.To)
        {
            Login();

            var addressBookApi = new ArxivarNext.Api.AddressBookApi(configuration);
            var filter = addressBookApi.AddressBookGetSearchField();
            var select = addressBookApi.AddressBookGetSelectField();
            select.Select("DM_RUBRICA_CODICE");
            select.Select("DM_RUBRICA_AOO");
            select.Select("DM_RUBRICA_CODICE");
            select.Select("ID");

            var result = addressBookApi.AddressBookPostSearch(new AddressBookSearchCriteriaDTO(
                filter: codice,
                addressBookCategoryId: addressBookCategoryId,
                filterFields: filter,
                selectFields: select
            ));

            var addressBookId = result.Data.First().Columns.GetValue<int>("ID");
            var addressBook = addressBookApi.AddressBookGetById(addressBookId: addressBookId);
            return new ArxivarNext.Model.UserProfileDTO(
                id: addressBook.Id,
                externalId: addressBook.ExternalCode,
                description: addressBook.BusinessName,
                docNumber: "-1",
                type: (int) type,
                contactId: addressBook.Id,
                fax: addressBook.Fax,
                address: addressBook.Address,
                postalCode: addressBook.PostalCode,
                contact: "",
                job: "",
                locality: addressBook.Location,
                province: addressBook.Province,
                phone: addressBook.PhoneNumber,
                mobilePhone: addressBook.CellPhone,
                telName: "",
                faxName: "",
                house: "",
                department: "",
                reference: "",
                office: "",
                vat: "",
                mail: "",
                priority: "N", // addressBook.Priority,
                code: null,
                email: addressBook.Email,
                fiscalCode: addressBook.FiscalCode,
                nation: addressBook.Country,
                addressBookId: addressBook.Id,
                society: "",
                officeCode: "",
                publicAdministrationCode: "",
                pecAddressBook: "",
                feaEnabled: false,
                feaExpireDate: null,
                firstName: "",
                lastName: "",
                pec: ""
            );


        }
        #endregion

        #region auth
        private void Login()
        {
            if (string.IsNullOrEmpty(_token)) // TODO: test se è necessario il refresh del token
            {
                var authApi = new ArxivarNext.Api.AuthenticationApi(_apiUrl);
                var auth = authApi.AuthenticationGetToken(
                    new AuthenticationTokenRequestDTO(
                        username: _username,
                        password: _password,
                        clientId: _appId,
                        clientSecret: _appSecret,
                        impersonateUserId: _impersonateUserId.HasValue ? System.Convert.ToInt32(_impersonateUserId) : default(int?)
                    )
                );
                _token = auth.AccessToken;
                _refresh_token = auth.RefreshToken;
            }
        }

        #endregion


        public void DeleteWorkflow(int? processId)
        {
            var workflowApi = new ArxivarNext.Api.WorkflowApi(configuration);
            workflowApi.WorkflowStopWorkflow(processId.Value);
            workflowApi.WorkflowDeleteWorkflow(processId, true);
            workflowApi.WorkflowFreeUserConstraint(processId.Value);
        }

        #region profile - get
        public T GetProfile<T>(int docnumber) where T : AXModel<T>, new()
        {
            Login();
            var profileApi = new ArxivarNext.Api.ProfilesApi(configuration);
            var profile = profileApi.ProfilesGetSchema(docnumber, false);
            var obj = AXModel<T>.Idrate(profile);
            return obj;
        }
        #endregion

        #region profile - search

        public List<T> Search<T>(AXModel<T> model, bool eliminato = false) where T : AXModel<T>, new()
        {
            var searchValues = model.GetPrimaryKeys();
            var classeDoc = model.GetArxivarAttribute().DocumentType;
            var result = Search(
                classeDoc: classeDoc,
                searchValues: searchValues,
                eliminato: eliminato
            );

            var profiles = result.Select(s => GetProfile<T>(s.Columns.GetValue<int>("DOCNUMBER"))).ToList();
            return profiles;
        }
        public List<ACUtils.AXRepository.ArxivarNext.Model.RowSearchResult> Search(string classeDoc, Dictionary<string, object> searchValues = null, bool eliminato = false, bool selectAll = false)
        {
            Login();
            var profileApi = new ArxivarNext.Api.ProfilesApi(configuration);
            var statesApi = new ArxivarNext.Api.StatesApi(configuration);
            var aooApi = new ArxivarNext.Api.BusinessUnitsApi(configuration);
            var aoo = aooApi.BusinessUnitsGet(null, null).First(); // TODO: change me

            var searchApi = new ArxivarNext.Api.SearchesApi(configuration);
            var docTypesApi = new ArxivarNext.Api.DocumentTypesApi(configuration);
            var docTypes = docTypesApi.DocumentTypesGetOld(1, aoo.Code); // TODO replace deprecated method

            var classeDocumento = docTypes.First(i => i.Key == classeDoc);

            var filterSearch = searchApi.SearchesGet();
            //var defaultSelect = searchApi.SearchesGetSelect_0(classeDocumento.Id);
            var defaultSelect = searchApi.SearchesGetSelect_1(classeDocumento.DocumentType, classeDocumento.Type2, classeDocumento.Type3);
            /*
            foreach (var axfield in model.GetArxivarFields())
            {
                defaultSelect.Fields.Select(axfield.Key);
            }
            */

            defaultSelect.Fields.Select("WORKFLOW");
            defaultSelect.Fields.Select("DOCNUMBER");

            filterSearch.Fields.Set("DOCUMENTTYPE", new ACUtils.AXRepository.ArxivarNext.Model.DocumentTypeSearchFilterDto(classeDocumento.DocumentType, classeDocumento.Type2, classeDocumento.Type3));

            var additionals = searchApi.SearchesGetAdditionalByClasse(classeDocumento.DocumentType, classeDocumento.Type2, classeDocumento.Type3, aoo.Code);
            filterSearch.Fields.AddRange(additionals);

            if (!(searchValues is null))
            {
                foreach (var kv in searchValues)
                {
                    filterSearch.Fields.Set(kv.Key, kv.Value);
                }
            }

            if (selectAll)
            {
                foreach (var field in defaultSelect.Fields)
                {
                    if (field.FieldType == 2)
                        defaultSelect.Fields.Select(field.Name);
                }
            }


            if (!eliminato)
            {
                filterSearch.Fields.Set("Stato", STATO_ELIMINATO, 2); // diverso da ELIMINATO
            }

            var values = searchApi.SearchesPostSearch(new SearchCriteriaDto(filterSearch, defaultSelect));
            return values;
        }

        public int GetDocumentNumber(string classeDoc, Dictionary<string, object> searchValues, bool eliminato = false, bool getFirst = false)
        {
            Login();
            var values = Search(classeDoc: classeDoc, searchValues: searchValues, eliminato: eliminato);

            if (values.Count > 1)
            {
                if (getFirst)
                {
                    // con l'opzione getFirst viene restituto il documento con DOCNUMBER inferiore

                    // ordina i risultati per DOCNUMBER
                    values.Sort((x, y) =>
                    {
                        // Valori restituiti:
                        //     Intero con segno che indica i valori relativi di x e y, come illustrato nella
                        //     tabella seguente. Valore Significato Minore di zero x è minore di y. Zero x è
                        //     uguale a y. Maggiore di zero x è maggiore di y.
                        var xVal = (int)x.Columns.Get("DOCNUMBER").Value;
                        var yVal = (int)y.Columns.Get("DOCNUMBER").Value;
                        return xVal.CompareTo(yVal);
                    });
                }
                else
                {
                    throw new TooMuchElementsException($"La ricerca ha ricevuto {values.Count} risultati");
                }
            }

            if (values.Count == 0)
            {
                throw new NotFoundException($"La ricerca ha ricevuto nessun risultato");
            }

            var docNumber = (int)values.First().Columns.Get("DOCNUMBER").Value;
            return docNumber;
        }
        public int GetDocumentNumber<T>(AXModel<T> model, bool eliminato = false, bool getFirst = false) where T : AXModel<T>, new()
        {
            var searchValues = model.GetPrimaryKeys();
            var classeDoc = model.GetArxivarAttribute().DocumentType;
            return GetDocumentNumber(
                classeDoc: classeDoc,
                searchValues: searchValues,
                eliminato: eliminato,
                getFirst: getFirst
            );
        }
        #endregion

        #region profile - update
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="taskid">se il documento è sottoposto a workflow è necessario passare anche il numero di task</param>
        /// <param name="procdocid">se il documento è sottoposto a workflow è necessario passare anche il numero di processo</param>
        /// <param name="checkInOption"></param>
        /// <param name="killWorkflow"></param>
        /// <returns></returns>
        public long? UpdateProfile<T>(AXModel<T> model, int? taskid = null, int? procdocid = null, int checkInOption = 0, bool killWorkflow = false) where T : AXModel<T>, new()
        {
            Login();
            List<string> bufferIds = new List<string>();
            var doc = Search<T>(model).First();
            var workflow = System.Convert.ToInt64(doc.Workflow ?? false);

            //var docNumber = model.DOCNUMBER ?? GetDocumentNumber(model);
            var docNumber = model.DOCNUMBER ?? doc.DOCNUMBER;

            if (workflow == 1 && killWorkflow)
            {
                try
                {
                    var workflowApi = new ArxivarNext.Api.WorkflowApi(configuration);
                    var workflowHistory = workflowApi.WorkflowGetWorkflowInfoByDocnumber(System.Convert.ToInt32(docNumber));

                    var processId = workflowHistory.Where(w => w.State == 1).Select(w => w.Id).FirstOrDefault();
                    if (processId.HasValue)
                    {

                        var taskworkhistoryapi = new ArxivarNext.Api.TaskWorkHistoryApi(configuration);
                        var history = taskworkhistoryapi.TaskWorkHistoryGetHistoryByProcessId(processId);
                        if (!history.Where(r => !r.Columns.GetValue<DateTime?>("CONCLUSO").HasValue).Any()) // WTF? controllare questa condizione
                        {
                            DeleteWorkflow(processId);
                        }
                        workflowApi.WorkflowFreeUserConstraint(processId.Value);
                    }
                    var processDocumentApi = new ArxivarNext.Api.ProcessDocumentApi(configuration);
                    processDocumentApi.ProcessDocumentFreeWorkflowConstraint(System.Convert.ToInt32(docNumber));
                }
                catch { }

            }

            var profilesApi = new ArxivarNext.Api.ProfilesApi(configuration);

            var profileDto = profilesApi.ProfilesGetSchema(docNumber, true);

            if (model.DataDoc.HasValue)
            {
                profileDto.Fields.SetField("DataDoc", model.DataDoc.Value);
            }

            if (!string.IsNullOrEmpty(model.STATO))
            {
                profileDto.Fields.SetState(model.STATO);
            }

            /*
            try
            {
                profileDto.Fields.SetFromField(GetUserAddressBookEntry(model.User, 1));
            }
            catch { }
            */

            foreach (var field in model.GetArxivarFields())
            {
                profileDto.Fields.SetField(field.Key, field.Value);
            }

            if (!string.IsNullOrEmpty(model.FilePath))
            {

                var apiCache = new ArxivarNext.Api.CacheApi(configuration);
                var checkInOutApi = new ArxivarNext.Api.CheckInOutApi(configuration);
                //var taskWorkApi = new ArxivarNext.Api.TaskWorkApi(configuration);

                var isCheckOutForTask = taskid.HasValue && procdocid.HasValue;

                // TODO: prevedere la possibilità di checkin/checkout for task
                if (isCheckOutForTask)
                {
                    //var select = taskWorkApi.TaskWorkGetDefaultSelect();
                    //var tasks = taskWorkApi.TaskWorkGetActiveTaskWork(select, System.Convert.ToInt32(docNumber));
                    //var taskWork = taskWorkApi.TaskWorkGetTaskWorkById(taskid);
                    //checkInOutApi.CheckInOutCheckOutForTask(processDocId: procdocid, taskWorkId: taskid);
                }
                else
                {
                    checkInOutApi.CheckInOutCheckOut(System.Convert.ToInt32(docNumber));
                }
                bufferIds = apiCache.CacheInsert(new MemoryStream(File.ReadAllBytes(model.FilePath)));
                if (isCheckOutForTask)
                {
                    checkInOutApi.CheckInOutCheckInForTask(
                        processDocId: procdocid,
                        taskWorkId: taskid,
                        fileId: bufferIds.First()
                    );
                }
                else
                {
                    checkInOutApi.CheckInOutCheckIn(
                        docnumber: System.Convert.ToInt32(docNumber),
                        fileId: bufferIds.First(),
                        option: checkInOption,
                        undoCheckOut: true
                    );
                }

            }

            profilesApi.ProfilesPut(docNumber, new ProfileDTO()
            {
                Fields = profileDto.Fields,
                Document = bufferIds.Count > 0 ? new FileDTO() { BufferIds = bufferIds } : default(FileDTO),
            });

            return docNumber;
        }
        #endregion

        #region profile - delete

        public bool DeleteProfile<T>(AXModel<T> model) where T : AXModel<T>, new()
        {
            Login();

            int docNumber;
            try
            {
                // vabene prendere il primo documento trovato
                // si suppone che se il documento corretto è già stato inserito questo avrà un DOCNUMBER superiore a quello da eliminare
                // l'opzione getFirst ottiene il documento con DOCNUMBER inferiore
                docNumber = GetDocumentNumber(model, getFirst: true);
            }
            catch (NotFoundException)
            {
                return true;
            }

            var profilesApi = new ArxivarNext.Api.ProfilesApi(configuration);
            var profileDto = profilesApi.ProfilesGetSchema(docNumber, true);
            profileDto.Fields.SetState(STATO_ELIMINATO);
            profilesApi.ProfilesPut(docNumber, new ProfileDTO()
            {
                Fields = profileDto.Fields
            });
            return true;
        }

        public bool HardDeleteProfile(int docNumber)
        {
            Login();
            var profilesApi = new ArxivarNext.Api.ProfilesApi(configuration);
            profilesApi.ProfilesDeleteProfile(docNumber);
            return true;
        }

        #endregion

        #region profile - create

        public int? CreateProfile<T>(AXModel<T> model, bool updateIfExists = false, int checkInOption = 0, bool killworkflow = false) where T : AXModel<T>, new()
        {
            Login();

            if (!model.GetArxivarAttribute().SkipKeyCheck)
            {
                var search = this.Search(model);
                if (search.Any())
                {
                    if (updateIfExists)
                    {
                        var docNumber = UpdateProfile(model, checkInOption: checkInOption, killWorkflow: killworkflow);
                        return System.Convert.ToInt32(docNumber);
                    }
                    else
                    {
                        return System.Convert.ToInt32(search.First().DOCNUMBER);
                    }
                }
            }

            var profileApi = new ArxivarNext.Api.ProfilesApi(configuration);
            var statesApi = new ArxivarNext.Api.StatesApi(configuration);

            var aooApi = new ArxivarNext.Api.BusinessUnitsApi(configuration);
            var aoo = aooApi.BusinessUnitsGet(null, null).First(); // TODO: change me

            List<string> bufferId = new List<string>();

            if (!string.IsNullOrEmpty(model.FilePath))
            {
                bufferId = UploadFile(model.FilePath);
            }
            var documentType = model.GetArxivarAttribute().DocumentType;

            var profileDto = profileApi.ProfilesGet_0();
            profileDto.Attachments = new List<string>();
            profileDto.AuthorityData = new ACUtils.AXRepository.ArxivarNext.Model.AuthorityDataDTO();
            profileDto.Notes = new List<ACUtils.AXRepository.ArxivarNext.Model.NoteDTO>();
            profileDto.PaNotes = new List<string>();
            profileDto.PostProfilationActions = new List<ACUtils.AXRepository.ArxivarNext.Model.PostProfilationActionDTO>();
            profileDto.Document = new FileDTO() { BufferIds = bufferId };


            if (model.Allegati != null)
            {
                foreach (var allegato in model.Allegati)
                {
                    profileDto.Attachments.AddRange(UploadFile(allegato));
                }
            }

            var classeDoc = profileDto.Fields.SetDocumentType(configuration, aoo.Code, documentType);

            var status = statesApi.StatesGet(classeDoc.Id);
            profileDto.Fields.SetState(model.GetArxivarAttribute().Stato ?? status.First().Id);


            var additional = profileApi.ProfilesGetAdditionalByClasse(
                classeDoc.DocumentType,
                classeDoc.Type2,
                classeDoc.Type3,
                aoo.Code
            );
            profileDto.Fields.AddRange(additional);

            profileDto.Fields.SetField("DOCNAME", model.DOCNAME);

            if (model.DataDoc.HasValue)
            {
                profileDto.Fields.SetField("DataDoc", model.DataDoc.Value);
            }

            if (!string.IsNullOrEmpty(model.User))
                profileDto.Fields.SetFromField(GetUserAddressBookEntry(model.User, 1));

            if (!string.IsNullOrEmpty(model.MittenteCodiceRubrica))
            {
                profileDto.Fields.SetFromField(GetAddressBookEntry(
                    model.MittenteCodiceRubrica,
                    model.MittenteIdRubrica.GetValueOrDefault(),
                    type: UserProfileType.From
                ));
            }

            if (model.DestinatariCodiceRubrica != null)
            {
                foreach (var destinatario in model.DestinatariCodiceRubrica)
                {
                    profileDto.Fields.SetToField(GetAddressBookEntry(
                        destinatario,
                        model.DestinatariIdRubrica.GetValueOrDefault(),
                        type: UserProfileType.To
                    ));
                }
            }


            foreach (var field in model.GetArxivarFields())
            {
                profileDto.Fields.SetField(field.Key, field.Value);
            }

            var stato = model.STATO ?? statesApi.StatesGet(classeDoc.Id).First().Id;
            profileDto.Fields.SetState(stato);

            var newProfile = new ProfileDTO()
            {
                Fields = profileDto.Fields,
                Document = profileDto.Document,
                Attachments = profileDto.Attachments,
                AuthorityData = profileDto.AuthorityData,
                Notes = profileDto.Notes,
                PaNotes = profileDto.PaNotes,
                PostProfilationActions = profileDto.PostProfilationActions
            };

            if (model.GetArxivarAttribute().Barcode)
            {
                var result = profileApi.ProfilesPostForBarcode(newProfile);
                return result.DocNumber;
            }
            else
            {
                var result = profileApi.ProfilesPost(newProfile);
                return result.DocNumber;
            }
        }

        #endregion

        #region download attachments
        public string[] DownloadAttachments(int docnumber, string outputFolder, bool ignoreException = false)
        {
            Login();
            var attachmentsApi = new ArxivarNext.Api.AttachmentsApi(configuration);
            var documentsApi = new ArxivarNext.Api.DocumentsApi(configuration);

            var infos = attachmentsApi.AttachmentsGetByDocnumber(docnumber: docnumber);
            var list = new List<string>();
            foreach (var info in infos)
            {
                try
                {
                    var attachment = attachmentsApi.AttachmentsGetById(info.Id);
                    var doc = documentsApi.DocumentsGetForExternalAttachment(info.Id, false);
                    var path = Path.Combine(outputFolder, attachment.Originalname);
                    _write_stream_to_file(doc, path);

                    // fix ACL ( permessi ) sul file
                    try
                    {
                        ACUtils.FileUtils.CopyAcl(path);
                    }
                    catch (Exception e)
                    {
                        _logger?.Exception(e);
                    }

                    list.Add(path);
                }
                catch (Exception e)
                {
                    if (!ignoreException) throw;
                    else _logger?.Exception(e);
                }
            }

            return list.ToArray();
        }
        #endregion

        #region download documento

        public string DownloadDocument(long docnumber, string outputFolder, bool forView = false)
        {
            Login();
            var documentsApi = new ArxivarNext.Api.DocumentsApi(configuration);
            var response = documentsApi.DocumentsGetForProfileWithHttpInfo(System.Convert.ToInt32(docnumber), forView);
            var fileNameInfo = response.Headers["Content-Disposition"];
            //var filename = (new Regex("filename=\"(.*)\"", RegexOptions.IgnoreCase)).Match(fileNameInfo).Groups[0].Value;
            var filename = new System.Net.Mime.ContentDisposition(fileNameInfo).FileName ?? "file.dat";
            var fullPath = Path.Combine(outputFolder, filename);
            _write_stream_to_file(response.Data, fullPath);
            return fullPath;
        }

        #endregion

        #region Tasks
        public int Task_ProcessIdFromTaskid(int taskid)
        {
            Login();
            var task = Task_GetByTaskId(taskid);
            return task.ProcessId.Value;
        }

        public IEnumerable<T> Task_GetAttachments<T>(int taskId, string regexpFilterDoctype = null) where T : AXModel<T>, new()
        {
            Login();

            var processId = Task_ProcessIdFromTaskid(taskId);

            var profileApi = new ArxivarNext.Api.ProfilesApi(configuration);
            var taskWorkAttachmentsV2Api = new ArxivarNext.Api.TaskWorkAttachmentsV2Api(configuration);
            var attachments = taskWorkAttachmentsV2Api.TaskWorkAttachmentsV2GetAttachmentsByProcessId(processId) as JObject;
            var targetDocType = String.IsNullOrEmpty(regexpFilterDoctype) ? Regex.Escape((new T()).GetArxivarAttribute().DocumentType) : regexpFilterDoctype;
            Regex targetDocRx = new Regex(targetDocType, RegexOptions.IgnoreCase);

            int i = 0;
            int docnumber_pos = -1;
            int tipoallegato_pos = -1;

            foreach (var c in attachments["columns"])
            {
                var id = (string)c["id"];
                if (id == "DOCNUMBER")
                {
                    docnumber_pos = i;

                }
                if (id == "TIPOALLEGATO")
                {
                    tipoallegato_pos = i;
                }
                i++;
            }

            foreach (var row in attachments["data"])
            {
                var tipo_allegato = row[tipoallegato_pos].Value<int?>();
                var v = row[docnumber_pos];
                if (tipo_allegato != 2) continue;
                if (!v.Value<int?>().HasValue) continue;
                var docnumber = v.Value<int>();
                try
                {
                    var profile = profileApi.ProfilesGetSchema(docnumber, false);
                    var cDocType = profile.Fields.GetDocumentType();
                    if (!targetDocRx.Match(cDocType).Success) continue;
                }
                catch
                {
                    // se il documento non è accessibile continua
                    // TODO: migliorare questa logica 
                    continue;
                }
                yield return this.GetProfile<T>(docnumber);
            }
        }

        public IEnumerable<(int docnumber, T documento)> Task_GetDocument<T>(int taskId) where T : AXModel<T>, new()
        {
            var processId = Task_ProcessIdFromTaskid(taskId);

            // TaskWorkV2_getDocumentsByProcessId
            Login();
            var profileApi = new ArxivarNext.Api.ProfilesApi(configuration);
            var taskWorkV2Api = new ArxivarNext.Api.TaskWorkV2Api(configuration);

            var targetDocType = (new T()).GetArxivarAttribute().DocumentType;

            var select = taskWorkV2Api.TaskWorkV2GetDefaultSelect();
            select.Fields.Select("DOCNUMBER");

            var docs = taskWorkV2Api.TaskWorkV2GetDocumentsByProcessId(processId, select) as JObject;
            var docnumber_pos = -1;
            var s = docs["columns"].AsEnumerable().Select((d, y) => (d, y));
            int i = 0;
            foreach (var c in docs["columns"])
            {
                if ((string)c["id"] == "DOCNUMBER")
                {
                    docnumber_pos = i;
                    break;
                }
                i++;
            }
            foreach (var row in docs["data"])
            {
                var docnumber = (int)row[docnumber_pos];
                var profile = profileApi.ProfilesGetSchema(docnumber, false);
                var cDocType = profile.Fields.GetDocumentType();
                if (targetDocType != cDocType) continue;
                yield return (docnumber, this.GetProfile<T>(docnumber));
            }
        }
        public TaskWorkDTO Task_GetByTaskId(int taskid)
        {
            Login();
            var taskWorkV2Api = new ArxivarNext.Api.TaskWorkV2Api(configuration);
            return taskWorkV2Api.TaskWorkV2GetTaskWorkById(taskid);
        }
        public void Task_AggiungiAllegato(int taskWorkId, string filePath, string filename = null)
        {
            Login();
            var taskWorkAttachV2Api = new ArxivarNext.Api.TaskWorkAttachmentsV2Api(configuration);
            var bufferId = UploadFile(filePath, filename: filename).First();
            taskWorkAttachV2Api.TaskWorkAttachmentsV2AddNewExternalAttachments(bufferId: bufferId, taskWorkId: taskWorkId);
        }
        public long Task_GetUserIdOfTaskId(int processId, int taskWorkId)
        {
            Login();
            var taskHistoryApi = new ArxivarNext.Api.TaskWorkHistoryApi(configuration);
            var taskHistory = taskHistoryApi.TaskWorkHistoryGetHistoryByProcessId(processId);
            var userId = (from task in taskHistory where task.Columns.GetValue<long>("ID") == taskWorkId select task.Columns.GetValue<long>("UTENTE")).First();
            return userId;
        }
        #endregion

        #region fascioli

        public List<ArxivarNext.Model.RowSearchResult> GetFascicoloDocuments(int id)
        {
            Login();

            var foldersApi = new ArxivarNext.Api.FoldersApi(configuration);
            var searchApi = new ArxivarNext.Api.SearchesApi(configuration);
            var select = searchApi.SearchesGetSelect();
            select.Fields.Select("CLASSEDOC");
            return foldersApi.FoldersGetDocumentsById(id, select);
        }

        public int GetFascicoloLevel(int id)
        {
            Login();
            var folderApi = new ArxivarNext.Api.FoldersApi(configuration);
            var folderInfo = folderApi.FoldersGetById(id);
            return folderInfo.FullPath.Count(f => f == '\\');
        }

        public List<ArxivarNext.Model.FolderDTO> GetFascoloFiglio(int id, string name)
        {
            Login();
            var foldersApi = new ArxivarNext.Api.FoldersApi(configuration);
            return foldersApi.FoldersFindInFolderByName(id, name);
        }


        public List<int> FascicoliGetByDocnumber(int docnumber)
        {
            Login();
            var foldersApi = new ArxivarNext.Api.FoldersApi(configuration);
            var folders = foldersApi.FoldersFindByDocnumber(docnumber);
            return folders.Where(f => f.Id.HasValue).Select(f => f.Id.Value).ToList();
        }

        public int FascicoliFolderExists(int parentFolder, string subfolderName)
        {
            Login();
            var foldersApi = new ArxivarNext.Api.FoldersApi(configuration);

            var folders = foldersApi.FoldersGetByParentId(parentFolder);

            var folderSearch = folders.Where(f => f.Name.ToLower().Equals(subfolderName.ToLower()));
            if (folderSearch.Any())
            {
                return folderSearch.First().Id.GetValueOrDefault();
            }
            else
            {
                return 0;
            }
        }

        public int FascicoliCreateFolder(int parentFolder, string subfodlerName)
        {
            Login();
            var foldersApi = new ArxivarNext.Api.FoldersApi(configuration);
            int subfodler = FascicoliFolderExists(parentFolder, subfodlerName);
            if (subfodler == 0) // se non esiste
            {
                var newfodler = foldersApi.FoldersNew(parentFolder, subfodlerName);
                subfodler = newfodler.Id.Value;
            }
            return subfodler;
        }

        public void FascicoliMoveToFolder(int folderId, int docnumber)
        {
            Login();
            var foldersApi = new ArxivarNext.Api.FoldersApi(configuration);
            foldersApi.FoldersInsertDocnumbers(folderId, new List<int?>() { docnumber });
        }

        public int FascicoliMoveToSubfolder(int parentFolder, string subfolderName, int docnumber)
        {
            Login();
            var foldersApi = new ArxivarNext.Api.FoldersApi(configuration);

            var folders = foldersApi.FoldersGetByParentId(parentFolder);

            var folderSearch = folders.Where(f => f.Name.ToLower().Equals(subfolderName.ToLower()));
            var folder_exists = folderSearch.Any();

            var folderId = FascicoliCreateFolder(parentFolder, subfolderName);

            // rimuovi dalla cartella precedente
            try
            {
                foldersApi.FoldersRemoveDocumentsInFolder(parentFolder, new List<int?>() { docnumber });
            }
            catch { }

            // rimuove se già presente 
            try
            {
                foldersApi.FoldersRemoveDocumentsInFolder(folderId, new List<int?>() { docnumber });
            }
            catch { }

            // aggiungi alla cartella di destinazione
            FascicoliMoveToFolder(folderId, docnumber);
            return folderId;
        }

        #endregion

        #region wfc functions
        private void _manager_ChannelOpened(string message)
        {
            this._logger?.Debug($"WCF ChannelOpened: {message}");
        }

        private void _manager_ChannelOpening(string message)
        {
            this._logger?.Debug($"WCF ChannelOpening: {message}");
        }

        public bool UserCreateIfNotExists_Wcf(
            string username,
            string aoo,
            string description,
            string defaultPassword,
            string email = null,
            string lang = "it",
            int tipo = 1,
            bool mustChangePassword = true,
            bool workflow = true
        )
        {
            try
            {
                if (!UserExists(aoo, username))
                {
                    return UserCreate(
                        username: username,
                        aoo: aoo,
                        description: description,
                        defaultPassword: defaultPassword,
                        email: email,
                        lang: lang,
                        tipo: tipo,
                        mustChangePassword: mustChangePassword,
                        workflow: workflow
                   );
                }
                return true;
            }
            catch (Exception e)
            {
                this._logger?.Error($"UserCreateIfNotExists('{username}'): {e.Message}");
                return false;
            }
        }


        public bool UserExists_Wcf(string aoo, string username)
        {
            using (var manager = GetWcf())
            {
                var user = manager.ARX_CONFIGURATION.Dm_Utenti_Exists(aoo, username);
                return user != null;
            }
        }



        public bool UserCreate_Wcf(
            string username,
            string aoo,
            string description,
            string default_password,
            string email = null,
            string lang = "IT",
            int tipo = 1,
            bool must_change_password = true,
            bool workflow = true
        )
        {
            try
            {
                using (var manager = GetWcf())
                {
                    this._logger?.Information($"Creazione utente {username}");
                    var result = manager.ARX_CONFIGURATION.Dm_Utenti_Insert(new Dm_Utenti_ForInsert()
                    {
                        GRUPPO = Dm_Utenti_Gruppo.User,
                        NOMECOMPLETO = description,
                        DESCRIPTION = username,
                        AOO = aoo,
                        CATEGORIA = Dm_Utenti_Categoria.U,
                        STATOUTENTE = Dm_Utenti_StatoUtente.Attivo,
                        MUSTCHANGEPASSWORD = must_change_password ? Dm_Utenti_MustChangePassword.Yes : Dm_Utenti_MustChangePassword.No,
                        LANG = lang,
                        PASSWORD = default_password,
                        TIPODEFAULT = 0,
                        TIPO2 = 0,
                        TIPO3 = 0,
                        WORKFLOW = workflow,
                        TIPO = tipo,
                        VIEWER = Tipo_Licenza.Standard,
                        EMAIL = email
                    });

                    return true;
                }
            }
            catch (Exception e)
            {
                this._logger?.Error($"UserCreateIfNotExists('{username}'): {e.Message}");
                return false;
            }
        }

        public void StampaBarcode(int docnumber)
        {
            try
            {
                using (var manager = GetWcf())
                {
                    manager.ARX_DATI.Dm_Barcode_Print(
                        docnumber: docnumber,
                        tipoImporta: Dm_Barcode_TipoImpronta.N,
                        insertRecord: false
                    );
                }
            }
            catch (Exception e)
            {
                this._logger?.Error($"Stampa Barcode: {e}"); // TODO: aggiungere log
            }
        }

        #endregion

        #region users
        public List<ACUtils.AXRepository.ArxivarNext.Model.UserCompleteDTO> Users()
        {
            Login();
            var userApi = new ArxivarNext.Api.UsersApi(configuration);
            return userApi.UsersGet_0();
        }


        public UserInfoDTO UserGet(string aoo, string username)
        {
            Login();
            var userSearchApi = new ArxivarNext.Api.UserSearchApi(configuration);
            var select = userSearchApi.UserSearchGetSelect();
            select.Fields.Select("UTENTE");
            var search = userSearchApi.UserSearchGetSearch();
            search.StringFields.Set("DESCRIPTION", username);
            search.StringFields.Set("AOO", aoo);
            var result = userSearchApi.UserSearchPostSearch(new UserSearchCriteriaDTO(selectDto: select, searchDto: search)).FirstOrDefault();
            if (result == null)
            {
                throw new NotFoundException($"user '{aoo}\\{username}' not found");
            }

            var userApi = new ArxivarNext.Api.UsersApi(configuration);
            return userApi.UsersGet(System.Convert.ToInt32(
                result.Columns.First(e => e.Id == "USER").Value
            ));
        }

        public bool UserExists(string aoo, string username)
        {
            try
            {
                UserGet(aoo, username);
                return true;
            }
            catch (NotFoundException)
            {
                return false;
            }
        }

        public bool UserCreate(
            string username,
            string aoo,
            string description,
            string defaultPassword,
            string email = null,
            string lang = "IT",
            int tipo = 1,
            bool mustChangePassword = true,
            bool workflow = true,
            IEnumerable<string> groups = null
        )
        {
            this._logger?.Information($"Creazione utente {username}");
            Login();
            var userApi = new ArxivarNext.Api.UsersApi(configuration);
            var usersManagementApi = new ArxivarNextManagement.Api.UsersManagementApi(configurationManagement);

            var newUser = userApi.UsersInsert(
                new ACUtils.AXRepository.ArxivarNext.Model.UserInsertDTO()
                {
                    Password = defaultPassword,
                    Description = username,
                    CompleteDescription = description,
                    Email = email,
                    Workflow = workflow,
                    MustChangePassword = mustChangePassword ? 1 : 0,
                    PasswordChange = true,
                    Type = tipo,
                    Viewer = 0,
                    Group = 2,
                    UserState = 1,
                    BusinessUnit = aoo,
                    Lang = lang,
                    DefaultType = 0,
                    Type2 = 0,
                    Type3 = 0,
                }
            );
            if (groups != null)
            {
                var existingGroups = userApi.UsersGetGroups();
                var newGroups = existingGroups.Where(
                        group => groups.Select(g => g.ToLower()).Contains(group.CompleteName.ToLower()) ||
                                 groups.Select(g => g.ToLower()).Contains(group.Description.ToLower())
                    )
                    .Select(g => new ArxivarNextManagement.Model.UserSimpleDTO(user: g.Id, description: g.Description))
                    .ToList();
                usersManagementApi.UsersManagementSetUserGroups(userId: newUser.User, groups: newGroups);
            }
            return true;
        }

        public bool UserCreateIfNotExists(
            string username,
            string aoo,
            string description,
            string defaultPassword,
            string email = null,
            string lang = "it",
            int tipo = 1,
            bool mustChangePassword = true,
            bool workflow = true,
            IEnumerable<string> groups = null
        )
        {
            if (!UserExists(aoo, username))
            {
                return UserCreate(
                    username: username,
                    aoo: aoo,
                    description: description,
                    defaultPassword: defaultPassword,
                    email: email,
                    lang: lang,
                    tipo: tipo,
                    mustChangePassword: mustChangePassword,
                    workflow: workflow,
                    groups: groups
                );
            }

            foreach (var group in groups)
            {
                UserAddGroup(aoo, username, group);
            }
            return false;
        }

        public bool UserAddGroup(string aoo, string username, string groupName)
        {
            Login();
            var usersManagementApi = new ArxivarNextManagement.Api.UsersManagementApi(configurationManagement);
            var userApi = new ArxivarNext.Api.UsersApi(configuration);

            var user = UserGet(aoo, username);
            var existingGroups = userApi.UsersGetGroups();
            var group = existingGroups.FirstOrDefault(g =>
                g.Description.Equals(groupName, StringComparison.CurrentCultureIgnoreCase));
            if (group == null)
            {
                throw new NotFoundException($"Arxivar group '{groupName}' not found");
            }
            var userGroups = usersManagementApi.UsersManagementGetUserGroups(user.User);
            if (!userGroups.Any(g => g.Description.Equals(groupName, StringComparison.CurrentCultureIgnoreCase)))
            {

                userGroups.Add(new UserSimpleDTO(user: group.Id, description: group.Description));
                usersManagementApi.UsersManagementSetUserGroups(userId: user.User, groups: userGroups);
                return true;
            }
            return false;
        }

        public void UserUpdate(ACUtils.AXRepository.ArxivarNext.Model.UserCompleteDTO user)
        {
            Login();
            var userApi = new ArxivarNext.Api.UsersApi(configuration);
            var update = new ACUtils.AXRepository.ArxivarNext.Model.UserUpdateDTO()
            {
                User = user.User,
                Group = user.Group,
                Description = user.Description,
                Email = user.Email,
                BusinessUnit = user.BusinessUnit,
                Password = user.Password,
                DefaultType = user.DefaultType,
                Type2 = user.Type2,
                Type3 = user.Type3,
                InternalFax = user.InternalFax,
                LastMail = user.LastMail,
                Category = user.Category,
                Workflow = user.Workflow,
                DefaultState = user.DefaultState,
                AddressBook = user.AddressBook,
                UserState = user.UserState,
                MailServer = user.MailServer,
                WebAccess = user.WebAccess,
                Upload = user.Upload,
                Folders = user.Folders,
                Flow = user.Flow,
                Sign = user.Sign,
                Viewer = user.Viewer,
                Protocol = user.Protocol,
                Models = user.Models,
                Domain = user.Domain,
                OutState = user.OutState,
                MailBody = user.MailBody,
                Notify = user.Notify,
                MailClient = user.MailClient,
                HtmlBody = user.HtmlBody,
                RespAos = user.RespAos,
                AssAos = user.AssAos,
                CodFis = user.CodFis,
                Pin = user.Pin,
                Guest = user.Guest,
                PasswordChange = !string.IsNullOrEmpty(user.Password),
                Marking = user.Marking,
                Type = user.Type,
                MailOutDefault = user.MailOutDefault,
                BarcodeAccess = user.BarcodeAccess,
                MustChangePassword = user.MustChangePassword,
                Lang = user.Lang,
                Ws = user.Ws,
                DisablePswExpired = user.DisablePswExpired,
                CompleteDescription = user.CompleteDescription,
                CanAddVirtualStamps = user.CanAddVirtualStamps,
                CanApplyStaps = user.CanApplyStaps,
            };
            userApi.UsersUpdate(user.User, update);
        }

        #endregion

        public Stream _write_stream_to_file(Stream stream, string filepath)
        {
            var fileStream = File.Create(filepath);
            stream.Seek(0, SeekOrigin.Begin);
            stream.CopyTo(fileStream);
            fileStream.Close();
            return stream;
        }
        public void _write_stream_to_file(byte[] stream, string filepath)
        {
            File.WriteAllBytes(filepath, stream);
        }

    }
}
