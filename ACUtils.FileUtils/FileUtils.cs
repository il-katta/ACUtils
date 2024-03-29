﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace ACUtils
{
    /// <summary>
    /// funzioni semplificate per gestione file
    /// </summary>
    public static class FileUtils
    {
        #region test

        /// <summary>
        /// test permessi di lettura dei file
        /// </summary>
        /// <param name="sFilePath">percorso assoluto del file</param>
        /// <returns>true se è leggibile, false altrimenti</returns>
        public static bool FileReadable(string sFilePath)
        {
            try
            {
                using (FileStream stream = File.Open(sFilePath, FileMode.Open, FileAccess.Read))
                {
                    return true;
                }
            }
            catch (IOException)
            {
                return false;
            }
        }
        /// <summary>
        /// controlla che il percorso sia non sia una directory
        /// </summary>
        /// <param name="sPath"></param>
        /// <returns></returns>
        public static bool IsFile(string sPath)
        {
            try
            {
                return FileReadable(sPath) && !File.GetAttributes(sPath).HasFlag(FileAttributes.Directory);
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// controlla che il percorso sia non sia una directory
        /// </summary>
        /// <param name="sPath"></param>
        /// <returns></returns>
        public static bool IsDirectory(string sPath)
        {
            try
            {
                return File.GetAttributes(sPath).HasFlag(FileAttributes.Directory);
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// ritorna true se la directory contiene uno o più file
        /// ritorna false se il path non è una directory o se la directory è vuota
        /// </summary>
        /// <param name="sPath">path della directory</param>
        /// <returns></returns>
        public static bool IsNotEmptyDirectory(string sPath)
        {
            if (!IsDirectory(sPath))
            {
                return false;
            }

            return ListFiles(sPath).Any();
        }
        #endregion

        #region IO

        /// <summary>
        /// sposta un file
        /// </summary>
        /// <param name="sFilePathSrc"></param>
        /// <param name="sFilePathDest"></param>
        /// <param name="bOverride">se true -> sovrascrive il file se esuiste - se false -> genera eccezione se il file esiste già</param>
        /// <returns>il percorso completo del nuovo file</returns>
        public static string MoveFile(string sFilePathSrc, string sFilePathDest, bool bOverride = false, bool fixAcl = false)
        {
            // asserts
            if (!FileReadable(sFilePathSrc))
            {
                throw new IOException(string.Format("{0}: non è accessibile", sFilePathSrc));
            }

            if (!IsFile(sFilePathSrc))
            {
                throw new IOException(string.Format("{0}: non è un file", sFilePathSrc));
            }

            // se la destinazione è una directory
            if (IsDirectory(sFilePathDest))
            {
                // presuppone che il file di destinazione manterrà lo stesso nome nella destinazione
                string filename = Path.GetFileName(sFilePathSrc);
                sFilePathDest = Path.Combine(sFilePathDest, filename);
            }

            if (File.Exists(sFilePathDest))
            {
                if (bOverride)
                {
                    File.Delete(sFilePathDest);
                }
                else
                {
                    throw new Exceptions.FileExistsException($"Impossibile spostare il file '{sFilePathSrc}': il file '{sFilePathDest}' esiste già");
                }
            }

            // move
            if (fixAcl)
            {
                File.Copy(sourceFileName: sFilePathSrc, destFileName: sFilePathDest);
                File.Delete(sFilePathSrc);
                CopyAcl(sFilePathDest);
            }
            else
            {
                File.Move(sourceFileName: sFilePathSrc, destFileName: sFilePathDest);
            }

            return sFilePathDest;
        }

        /// <summary>
        /// crea la directory, se non esiste, copiando le ACL dalla directory padre
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <returns>true se la directory esiste o è stato possibile crearla</returns>
        public static bool AssertIsDirectory(string directoryPath)
        {
            if (IsDirectory(directoryPath))
            {
                return true;
            }

            try
            {
                try
                {
                    // directory da cui copiare le ACL
                    string parentDir = Path.GetDirectoryName(directoryPath);
                    // ricorsione: la cartella padre deve esistere
                    AssertIsDirectory(parentDir);
                    // creazione directory con acl directory padre
                    //Directory.CreateDirectory(directoryPath, new DirectoryInfo(parentDir).GetAccessControl());
                    Directory.CreateDirectory(directoryPath);
                    CopyAcl(directoryPath);
                }
                catch
                {
                    // se fallisce la creazione della cartella con la acl, prova a crearla senza acl
                    Directory.CreateDirectory(directoryPath);
                }
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("non è stato possibile creare la directory '{0}': {1}", directoryPath, e.ToString()));
            }
        }

        #endregion

        #region acl

        /// <summary>
        /// applica le ACL del file sPathSrc al file sPathDest
        /// </summary>
        /// <param name="sPathSrc">path del file/directory da cui copiare le ACL</param>
        /// <param name="sPathDest">path del file/cartella a cui applicare le ACL</param>
        /// <returns></returns>
        public static bool CopyAcl(string sPathSrc, string sPathDest, bool throwException = false)
        {
            try
            {
                CopyAcl(sPathSrc, sPathDest, AccessControlSections.Audit);
                return true;
            }
            catch
            {
                try
                {
                    CopyAcl(sPathSrc, sPathDest, null);
                    return true;
                }
                catch
                {
                    if (throwException)
                    {
                        throw;
                    }
                    return false;
                }
            }
        }


  

        private static bool CopyAcl(string sPathSrc, string sPathDest, AccessControlSections? accessControlSections = null)
        {
            if (IsDirectory(sPathDest) && IsDirectory(sPathSrc))
            {
                FileSystemSecurity acl = accessControlSections == null ? (new DirectoryInfo(sPathSrc)).GetAccessControl() : (new DirectoryInfo(sPathSrc)).GetAccessControl(accessControlSections.Value);
                acl.SetAuditRuleProtection(false, false);
                new DirectoryInfo(sPathDest).SetAccessControl(acl as DirectorySecurity);
            }
            else
            {
                FileSystemSecurity acl = accessControlSections == null ? (new FileInfo(sPathSrc)).GetAccessControl() : (new FileInfo(sPathSrc)).GetAccessControl(accessControlSections.Value);
                acl.SetAuditRuleProtection(false, false);
                new FileInfo(sPathDest).SetAccessControl(acl as FileSecurity);
            }
            return true;
        }

        /// <summary>
        /// applica le ACL della cartella in cui è contenuto il file al file
        /// </summary>
        /// <param name="sPathDest"></param>
        /// <param name="throwException"></param>
        /// <returns>esito corretta applicazione delle acl</returns>
        public static bool CopyAcl(string sPathDest, bool throwException = false)
        {
            string sPathSrc = Path.GetDirectoryName(sPathDest);
            return CopyAcl(sPathSrc, sPathDest, throwException);
        }

        #endregion

        #region write

        /// <summary>
        /// scrive l'eccezione su file
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="ex"></param>
        public static void WriteException(string filePath, Exception ex)
        {
            WriteText(filePath, ex.ToString());
        }

        /// <summary>
        /// scrive il contenuto della stringa nel file
        /// </summary>
        /// <param name="filePath">persorso del file di destinazione</param>
        /// <param name="text">testo da scrivere su file</param>
        public static void WriteText(string filePath, string text)
        {
            File.WriteAllText(filePath, text);
        }

        public static Stream Write(Stream stream, string filepath)
        {
            var fileStream = File.Create(filepath);
            stream.Seek(0, SeekOrigin.Begin);
            stream.CopyTo(fileStream);
            fileStream.Close();
            return stream;
        }

        public static void Write(byte[] stream, string filepath)
        {
            File.WriteAllBytes(filepath, stream);
        }

        #endregion

        #region convert

        /// <summary>
        /// converte un file xml in html applicandogli il foglio di stile
        /// </summary>
        /// <param name="xmlPath">percorso del file xml da convertire</param>
        /// <param name="stylePath">percorso del foglio di stile da apllicare al documento</param>
        /// <param name="outputFile">(opzionale) percorso dove creare il file</param>
        /// <returns>percorso del file generato</returns>
        public static DString XmlToHtml(string xmlPath, string stylePath, string outputFile = null)
        {
            DString doutFile;
            if (string.IsNullOrEmpty(outputFile))
            {
                doutFile = GetTempFilePathWithExtension(".html");
            }
            else
            {
                doutFile = new DString(outputFile);
            }
            XPathDocument doc = new XPathDocument(xmlPath);
            using (XmlWriter writer = XmlWriter.Create(doutFile.Value))
            {
                XslCompiledTransform transform = new XslCompiledTransform();
                XsltSettings settings = new XsltSettings
                {
                    EnableScript = true
                };
                transform.Load(stylePath, settings, null);
                transform.Transform(doc, writer);
            }
            return doutFile;
        }

        #endregion

        #region temp dir

        public static DString GetTempFilePathWithExtension(string extension)
        {
            string path = Path.GetTempPath();
            string fileName = Guid.NewGuid().ToString() + extension;
            return new DString(Path.Combine(path, fileName));
        }

        public static DString GetTempDirPath()
        {
            string path = Path.Combine(
                Path.GetTempPath(),
                Guid.NewGuid().ToString()
            );
            AssertIsDirectory(path);
            return new DString(path);
        }

        #endregion

        #region list

        public static IEnumerable<string> ListFiles(string folderPath, string searchPattern = "*.*")
        {
            return Directory.EnumerateFiles(folderPath, searchPattern, SearchOption.AllDirectories);
        }

        /// <summary>
        /// ritorna la lista di file .xml nella directory
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <returns></returns>
        public static IEnumerable<string> ListXmlFiles(string directoryPath)
        {
            AssertIsDirectory(directoryPath);

            return (
                from filePath in Directory.EnumerateFiles(directoryPath, "*.xml", SearchOption.TopDirectoryOnly)
                where FileReadable(filePath)
                select filePath
             ).ToList();
            /*
            foreach (string filePath in Directory.EnumerateFiles(directoryPath, "*.xml", SearchOption.TopDirectoryOnly))
            {
                if (FileReadable(filePath))
                {
                    yield return filePath;
                }
            }
            */
        }
        #endregion

        #region delete
        public static void RecursiveDelete(string baseDirPath)
        {
            Directory.Delete(baseDirPath, true);
        }

        public static void RecursiveDelete(DirectoryInfo baseDir)
        {
            if (!baseDir.Exists)
            {
                return;
            }

            foreach (DirectoryInfo dir in baseDir.EnumerateDirectories())
            {
                RecursiveDelete(dir);
            }
            baseDir.Delete(true);
        }
        #endregion

        #region checksum

        public static string FileChecksum(string filePath)
        {
            using (BufferedStream stream = new BufferedStream(File.OpenRead(filePath)))
            {
                System.Security.Cryptography.MD5 mng = System.Security.Cryptography.MD5.Create();
                byte[] checksum = mng.ComputeHash(stream);
                return BitConverter.ToString(checksum).Replace("-", string.Empty).ToLower();
            }
        }

        public static string Checksum(string data)
        {
            return Checksum(Encoding.UTF8.GetBytes(data));
        }

        public static string Checksum(byte[] data)
        {
            System.Security.Cryptography.MD5 mng = System.Security.Cryptography.MD5.Create();
            byte[] checksum = mng.ComputeHash(data);
            return BitConverter.ToString(checksum).Replace("-", string.Empty).ToLower();
        }

        #endregion

        #region compression
        /*
        public static string CompressFile(string filePath)
        {
            var outFilePath = $"{filePath}.zst";
            using (var inputStream = new BufferedStream(File.OpenRead(filePath)))
            {
                using (var outputSteam = new BufferedStream(File.OpenWrite(outFilePath)))
                {
                    using (var compressionStream = new ZstandardStream(outputSteam, CompressionMode.Compress))
                    {
                        inputStream.CopyTo(compressionStream);
                        compressionStream.Close();
                        compressionStream.CopyTo(outputSteam);
                    }
                }
            }
            return outFilePath;
        }
        */

        public static string CompressFile(string filePath)
        {
            string outFilePath = $"{filePath}.gz";
            CompressFile(filePath, outFilePath);
            return outFilePath;
        }

        public static void CompressFile(string filePath, string outFilePath)
        {
            using (FileStream originalFileStream = File.OpenRead(filePath))
            {

                using (FileStream compressedFileStream = File.Create(outFilePath))
                {
                    using (GZipStream compressionStream = new GZipStream(compressedFileStream,
                       CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        public static DString DecompressFile(string filePath)
        {
            FileInfo fileToDecompress = new FileInfo(filePath);
            string currentFileName = fileToDecompress.FullName;
            DString newFileName = new DString(currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length));
            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            {
                using (FileStream decompressedFileStream = File.Create(newFileName.Value))
                {
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                    }
                }
            }
            return newFileName;
        }

        #endregion

        #region path

        public static string GetFileNameWithoutExtension(string path)
        {
            string result = Path.GetFileNameWithoutExtension(path);
            if (string.IsNullOrEmpty(result))
            {
                return Path.GetFileName(path);
            }
            return result;
        }

        public static string RelativePath(string folderpath, string filePath)
        {
            // rimuove la directory dal percorso
            string fullFilePath = Path.GetFullPath(filePath);
            string fullFolderPath = Path.GetFullPath(folderpath);
            filePath = fullFilePath.Replace(fullFolderPath, string.Empty);

            // converte il path in formato unix
            if (EnvironmentUtils.IsWin())
            {
                filePath = filePath.Replace('\\', '/');
            }
            // rimuove il sepratatore dall'inizio del percorso
            filePath = filePath.TrimStart('/');

            return filePath;
        }

        public static string SanitizePath(string folderpath, string filePath)
        {
            // regexp caratteri ammessi nel percorso del file
            string unsafeChars = @"[^a-zA-Z0-9 _\-!?^.\/]";
            // persorso relativo e rimosso punto a come primo carattere del nome file
            filePath = RelativePath(folderpath, filePath).Replace("/.", "/_");
            // sostituisce i caratteri non ammessi con il carattere _
            return Regex.Replace(filePath, unsafeChars, "_");
        }



        #endregion

        #region encode

        public static void RecodeTextFile(string filePath)
        {
            string contents = File.ReadAllText(filePath);
            File.WriteAllText(filePath, contents, new UTF8Encoding(false));
        }

        /// <summary>
        /// codifica del contenuto di un file in Base64
        /// </summary>
        /// <param name="filePath">percorso assoluto file</param>
        /// <returns>codifica BASE64 del contenuto del file</returns>
        public static string FileToBase64(string filePath)
        {
            return Convert.ToBase64String(File.ReadAllBytes(filePath));
        }

        #endregion

        #region ftp

        public static void FtpUpload(string localFilePath, string ftpUrl, string ftpPath, string ftpUsername, string ftpPassword)
        {
            // aggiunge la directory di upload se specificata
            if (!string.IsNullOrEmpty(ftpPath))
            {
                ftpUrl = Path.Combine(ftpUrl, ftpPath);
            }
            // aggiunge il nome del file
            ftpUrl = Path.Combine(ftpUrl, Path.GetFileName(localFilePath));

            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                client.Credentials = new System.Net.NetworkCredential(ftpUsername, ftpPassword);
                client.UploadFile(ftpUrl, System.Net.WebRequestMethods.Ftp.UploadFile, localFilePath);
            }
        }

        public static System.Net.FtpWebRequest FtpRequest(string ftpUrl, string ftpPath, string ftpUsername, string ftpPassword, string ftpMethod, bool usePassive = false)
        {
            if (!string.IsNullOrEmpty(ftpPath))
            {
                ftpUrl = $"{ftpUrl}{ftpPath}";
            }
            System.Net.FtpWebRequest request = (System.Net.FtpWebRequest)System.Net.WebRequest.Create(ftpUrl);
            request.UsePassive = usePassive;
            request.UseBinary = true;
            request.KeepAlive = false;
            request.Method = ftpMethod;
            request.Credentials = new System.Net.NetworkCredential(ftpUsername, ftpPassword);
            return request;
        }

        public static System.Net.FtpWebResponse FtpUpload(string localFilePath, string ftpUrl, string ftpPath, string ftpUsername, string ftpPassword, bool usePassive = false)
        {
            // aggiunge il nome del file
            ftpPath = System.IO.Path.Combine(ftpPath, System.IO.Path.GetFileName(localFilePath));

            System.Net.FtpWebRequest request = FtpRequest(
                ftpUrl: ftpUrl,
                ftpPath: ftpPath,
                ftpUsername: ftpUsername,
                ftpPassword: ftpPassword,
                ftpMethod: System.Net.WebRequestMethods.Ftp.UploadFile,
                usePassive: usePassive
            );
            byte[] fileContents;
            using (System.IO.StreamReader sourceStream = new System.IO.StreamReader(localFilePath))
            {
                fileContents = System.Text.Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            }
            request.ContentLength = fileContents.Length;
            using (System.IO.Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(fileContents, 0, fileContents.Length);
            }

            return (System.Net.FtpWebResponse)request.GetResponse();
        }


        public static System.Net.FtpWebResponse FtpDownload(string localFilePath, string ftpUrl, string ftpPath, string ftpUsername, string ftpPassword, bool usePassive = false)
        {
            System.Net.FtpWebRequest request = FtpRequest(
                ftpUrl: ftpUrl,
                ftpPath: ftpPath,
                ftpUsername: ftpUsername,
                ftpPassword: ftpPassword,
                ftpMethod: System.Net.WebRequestMethods.Ftp.DownloadFile,
                usePassive: usePassive
            );

            using (System.Net.FtpWebResponse response = (System.Net.FtpWebResponse)request.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        using (StreamWriter destination = new StreamWriter(localFilePath))
                        {
                            destination.Write(reader.ReadToEnd());
                            destination.Flush();
                        }
                    }
                }
                return response;
            }
        }

        public static List<string> FtpList(string ftpUrl, string ftpPath, string ftpUsername, string ftpPassword, bool usePassive = false, string searchRegEx = ".*")
        {
            System.Net.FtpWebRequest request = FtpRequest(
                ftpUrl: ftpUrl,
                ftpPath: ftpPath,
                ftpUsername: ftpUsername,
                ftpPassword: ftpPassword,
                ftpMethod: System.Net.WebRequestMethods.Ftp.ListDirectory,
                usePassive: usePassive
            );

            using (System.Net.FtpWebResponse response = (System.Net.FtpWebResponse)request.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        List<string> lst_strFiles = new List<string>();
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            if (Regex.Match(line, searchRegEx).Success)
                            {
                                lst_strFiles.Add(line);
                            }
                        }
                        return lst_strFiles;
                    }
                }
            }
        }

        public static bool FtpDelete(string ftpUrl, string ftpPath, string ftpUsername, string ftpPassword, bool usePassive = false)
        {
            System.Net.FtpWebRequest request = FtpRequest(
                ftpUrl: ftpUrl,
                ftpPath: ftpPath,
                ftpUsername: ftpUsername,
                ftpPassword: ftpPassword,
                ftpMethod: System.Net.WebRequestMethods.Ftp.DeleteFile,
                usePassive: usePassive
            );
            try
            {
                using (System.Net.FtpWebResponse response = (System.Net.FtpWebResponse)request.GetResponse())
                {
                    return response.StatusCode == System.Net.FtpStatusCode.FileActionOK;
                }
            }
            catch (System.Net.WebException)
            {
                return false;
            }
        }

        #endregion

        #region current process
        public static string GetCurrentProcessPath()
        {
            return Path.GetFullPath(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
        }

        public static string GetCurrentProcessDirectory()
        {
            return System.IO.Path.GetDirectoryName(GetCurrentProcessPath());
        }

        public static void CwdToCurrentProcessPath()
        {
            System.IO.Directory.SetCurrentDirectory(GetCurrentProcessDirectory());
        }
        #endregion

        // TODO: aggiungere un mime type detector
        // ref. https://github.com/MeaningOfLights/MimeDetect
    }
}
