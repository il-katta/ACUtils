using System;
using System.Linq;

using ACUtils;

using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class AXTests
    {
        ACUtils.AXRepository.ArxivarRepository repo;
        [SetUp]
        public void Setup()
        {
            var apiUrl = "http://documentale.poliplast.local/ARXivarNextWebApi/";
            var workflowUrl = "http://documentale.poliplast.local/ARXivarNextWebApi/";
            var managementUrl = "http://documentale.poliplast.local/ARXivarNextWebApi/";
            var appSecret = "A61C0B60ACEA4C768D68EB578EB5A8A4";
            var appId = "addons";
            var username = "admin";
            var password = "PoliplastArxivar2021";

            repo = new ACUtils.AXRepository.ArxivarRepository(
                apiUrl: apiUrl,
                managementUrl: managementUrl,
                workflowUrl: workflowUrl,
                username: username,
                password: password,
                appId: appId,
                appSecret: appSecret
            );
        }

        [Test]
        public void TestProfileGet()
        {
            var doc = repo.GetProfile<Stuff.AXDoc>(4);

            Assert.IsNotNull(doc.DOCNAME);
            Assert.AreEqual(4, doc.DOCNUMBER);
            Assert.IsNotNull(doc.DataDoc);
            Assert.IsNotNull(doc.DestinatariCodiceRubrica);
            //Assert.IsNotNull(doc.DestinatariIdRubrica);
            Assert.IsNotNull(doc.MittenteCodiceRubrica);
            //Assert.IsNotNull(doc.MittenteIdRubrica);
            Assert.IsNotNull(doc.MittenteId);
            Assert.IsNotNull(doc.DestinatariId);
            Assert.IsTrue(doc.DestinatariId.Count() > 0);
            Assert.IsNotNull(doc.Prova);


            var docSearch = repo.Search<Stuff.AXDoc>(doc).First();
            Assert.IsNotNull(docSearch.DOCNAME);
            Assert.AreEqual(4, docSearch.DOCNUMBER);
            Assert.IsNotNull(docSearch.DataDoc);
            Assert.IsNotNull(docSearch.DestinatariCodiceRubrica);
            //Assert.IsNotNull(doc.DestinatariIdRubrica);
            Assert.IsNotNull(docSearch.MittenteCodiceRubrica);
            //Assert.IsNotNull(doc.MittenteIdRubrica);
            Assert.IsNotNull(docSearch.MittenteId);
            Assert.IsNotNull(docSearch.DestinatariId);
            Assert.IsTrue(docSearch.DestinatariId.Count() > 0);
            Assert.IsNotNull(docSearch.Prova);
        }

        [Test]
        public void TestGetUser()
        {
            Assert.IsNotNull(repo.UserGet("PO", "admin"));
        }

        [Test]
        public void TestCreateUser()
        {
            var result = repo.UserCreateIfNotExists(
                username: "test02",
                defaultPassword: "test02",
                description: "test02",
                aoo: "PO",
                mustChangePassword: false,
                workflow: true,
                groups: new[] { "Everybody" }
            );

            Assert.IsTrue(result);
        }
    }
}
