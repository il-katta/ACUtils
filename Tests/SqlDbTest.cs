using System;
using System.Collections.Generic;
using System.Data;
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
        private string CONNECTION_STRING => System.Environment.GetEnvironmentVariable("ACUTILS_TEST_CONNECTION_STRING") ?? "Data Source=(local);Initial Catalog=AdventureWorks2019;Integrated Security=SSPI;";

        [SetUp]
        public void Setup()
        {
            db = new SqlDb(CONNECTION_STRING);
            scope = new TransactionScope();
            SqlDb.MissingSchemaAction = System.Data.MissingSchemaAction.AddWithKey;
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
        public void TestSelect(string value)
        {
            SqlDb.MissingSchemaAction = System.Data.MissingSchemaAction.AddWithKey;
            SqlDb_QueryDataRow.QueryDataRow(
                new System.Data.SqlClient.SqlConnection(CONNECTION_STRING),
                 "SELECT @a AS A",
                "@a".WithValue(value, 3)
            );

            SqlDb.MissingSchemaAction = System.Data.MissingSchemaAction.Add;

            db.QueryDataRow(
                "SELECT @a AS A",
                "@a".WithValue(value, 3)
            );

            db.QueryDataRow(
                "SELECT @a AS A",
                "@a".WithValue(value, 3)
            );

            var expected = value ?? default(string);

            var result = db.QuerySingleValue<string>(
                value == null ? "SELECT NULL AS A" : "SELECT @a AS A",
                "@a".WithValue(value, value?.Length ?? 0)
            );
            Assert.AreEqual(expected, result);
        }


        [TestCase(1)]
        [TestCase(123)]
        [TestCase(1234)]
        [TestCase(null)]
        public void TestSelectInt(int value)
        {
            SqlDb.MissingSchemaAction = System.Data.MissingSchemaAction.AddWithKey;
            SqlDb_QueryDataRow.QueryDataRow(
                new System.Data.SqlClient.SqlConnection(CONNECTION_STRING),
                 "SELECT @a AS A",
                "@a".WithValue(value)
            );

            SqlDb.MissingSchemaAction = System.Data.MissingSchemaAction.Add;

            db.QueryDataRow(
                "SELECT @a AS A",
                "@a".WithValue(value)
            );

            var result = db.QuerySingleValue<int>(
                "SELECT @a AS A",
                "@a".WithValue(value)
            );
            Assert.AreEqual(value, result);
        }


        [Test]
        [TestCase(1)]
        [TestCase(123)]
        [TestCase(1234)]
        [TestCase(null)]
        public void TestSelectNullableInt(int? value)
        {
            SqlDb.MissingSchemaAction = System.Data.MissingSchemaAction.AddWithKey;
            SqlDb_QueryDataRow.QueryDataRow(
                new System.Data.SqlClient.SqlConnection(CONNECTION_STRING),
                 "SELECT @a AS A",
                "@a".WithValue(value)
            );

            SqlDb.MissingSchemaAction = System.Data.MissingSchemaAction.Add;

            db.QueryDataRow(
                "SELECT @a AS A",
                "@a".WithValue(value)
            );

            db.QueryDataRow(
                "SELECT @a AS A",
                "@a".WithValue(value)
            );

            int? expected = value ?? default(int?);

            var result = db.QuerySingleValue<int?>(
                value == null ? "SELECT NULL AS A" : "SELECT @a AS A",
                "@a".WithValue(value)
            );
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestQueryDictionary()
        {
            var sqlQuery = "SELECT BusinessEntityID, ISNULL(FirstName + ' ', '') + ISNULL(MiddleName + ' ','') + ISNULL(LastName, '') AS [FullName] FROM Person.Person";
            var keyField = "BusinessEntityID";
            var valueField = "FullName";
            var count = db.QuerySingleValue<int>("SELECT COUNT(*) FROM Person.Person");
            Dictionary<int, string> result;

            using (var connection = new System.Data.SqlClient.SqlConnection(CONNECTION_STRING))
            {
                result = SqlDb_QueryDictionary.QueryDictionary<int, string>(connection, sqlQuery, keyField, valueField);
            }
            Assert.AreEqual(count, result.Count);
            Assert.AreEqual(result[285], "Syed E Abbas");
            Assert.AreEqual(result[8722], "Sara Blue");

            result = db.QueryDictionary<int, string>(sqlQuery, keyField, valueField);
            Assert.AreEqual(count, result.Count);
            Assert.AreEqual(result[285], "Syed E Abbas");
            Assert.AreEqual(result[8722], "Sara Blue");
        }


        class DbPerson : ACUtils.DBModel<DbPerson>
        {
            [DbField("BusinessEntityID")]
            public int Id { get; set; }
            public string PersonType { get; set; }
            public string Title { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
        }


        [Test]
        public void TestQueryMany()
        {
            var count = db.QuerySingleValue<int>("SELECT COUNT(*) FROM Person.Person");
            var allPersons = db.QueryMany<DbPerson>("SELECT * FROM Person.Person");
            Assert.AreEqual(count, allPersons.ToList().Count);
        }



        [TestCase(100, false)]
        [TestCase(100, true)]
        public void TestBulkInsert(int rows, bool async)
        {
            // prepare
            var nextId = db.QuerySingleValue<int>("SELECT MAX(BusinessEntityID) + 1 FROM Person.Person");
            var initialCount = db.QuerySingleValue<int>("SELECT COUNT(*) FROM Person.Person");
            var objects = new List<DbPerson>();
            for (int i = nextId; i < (nextId + rows); i++)
            {
                objects.Add(new DbPerson()
                {
                    Id = i,
                    PersonType = "EM",
                    Title = "Test",
                    FirstName = $"FirstName {i}",
                    MiddleName = $"MiddleName {i}",
                    LastName = $"LastName {i}",
                });
            }

            // execute
            if (async)
            {
                db.BulkInsertAsync("Person.Person", objects).Wait();
            }
            else
            {
                db.BulkInsert("Person.Person", objects);
            }

            // test
            var finalCount = db.QuerySingleValue<int>("SELECT COUNT(*) FROM Person.Person");
            Assert.AreEqual(initialCount + rows, finalCount);

            foreach (var person in objects)
            {
                Assert.IsTrue(person.Id > 0);
                var dr = db.QueryDataRow("SELECT * FROM Person.Person WHERE BusinessEntityID = @ID", "@ID".WithValue(person.Id));
                Assert.AreEqual(person.Id, dr.Field<int>("BusinessEntityID"));
                Assert.AreEqual(person.PersonType, dr.Field<string>("PersonType"));
                Assert.AreEqual(person.Title, dr.Field<string>("Title"));
                Assert.AreEqual(person.FirstName, dr.Field<string>("FirstName"));
                Assert.AreEqual(person.MiddleName, dr.Field<string>("MiddleName"));
                Assert.AreEqual(person.LastName, dr.Field<string>("LastName"));
            }
        }
    }
}
