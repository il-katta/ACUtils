using System;
using System.Linq;
using System.Transactions;
using ACUtils;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    class SqlDbTest
    {
        private TransactionScope scope;
        private SqlDb db;

        [SetUp]
        public void Setup()
        {
            db = new SqlDb("Data Source=(local);Initial Catalog=master;Integrated Security=SSPI;");
            scope = new TransactionScope();
        }

        [TearDown]
        public void Teardown()
        {
            if (Transaction.Current.TransactionInformation.Status == TransactionStatus.Active)
            {
                scope?.Dispose();
            }
        }

        [Test]
        [TestCase("")]
        [TestCase("1")]
        [TestCase("123")]
        [TestCase("1234")]
        [TestCase(null)]
        public void TestSelect(string value)
        {
            db.QueryDataRow(
                "SELECT @a AS A",
                "@a".WithValue(value, 3)
            );
        }
    }
}
