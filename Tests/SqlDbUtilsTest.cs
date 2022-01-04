using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

using ACUtils;

using NUnit.Framework;

namespace Tests
{

    public class TestDbModel : DBModel<TestDbModel>
    {
        public string stringValue { get; set; }
        public int? nullableIntValue { get; set; }
        public int intValue { get; set; }
        public decimal decimalValue { get; set; }
        public float floatValue { get; set; }
        public DateTime datetimeValue { get; set; }

    }

    [TestFixture]
    class SqlDbUtilsTest
    {
        DataTable _testDt;
        const int DT_SIZE = 10000;
        [SetUp]
        public void Setup()
        {

            _generateDt();
        }

        void _generateDt()
        {
            _testDt = new DataTable();
            _testDt.Clear();
            _testDt.Columns.Add("stringValue", typeof(string));
            _testDt.Columns.Add("intValue", typeof(int));
            _testDt.Columns.Add("decimalValue", typeof(decimal));
            _testDt.Columns.Add("floatValue", typeof(float));
            _testDt.Columns.Add("datetimeValue", typeof(DateTime));
            for (int i = 0; i < DT_SIZE; i++)
            {
                var dr = _testDt.NewRow();
                dr["stringValue"] = i.ToString();
                dr["intValue"] = i;
                dr["decimalValue"] = new Decimal(i / 2);
                dr["floatValue"] = (float)i / 2;
                dr["datetimeValue"] = DateTime.Now;
                _testDt.Rows.Add(dr);
            }
            _testDt.AcceptChanges();
        }

        [TearDown]
        public void Teardown()
        {
            _generateDt();
        }


        [Test]
        public void testIdrateObj()
        {
            var obj = new TestDbModel();
            for (int i = 0; i < DT_SIZE; i++)
            {
                var dr = this._testDt.Rows[i];
                obj.idrate(dr);
                Assert.AreEqual(i.ToString(), obj.stringValue);
                Assert.AreEqual(i, obj.intValue);
                Assert.AreEqual(new Decimal(i / 2), obj.decimalValue);
                Assert.AreEqual((float)i / 2, obj.floatValue);
                Assert.AreEqual(dr["datetimeValue"], obj.datetimeValue);
            }
        }

        [Test]
        public void testStaticIdrate()
        {
            for (int i = 0; i < DT_SIZE; i++)
            {
                var dr = this._testDt.Rows[i];
                var obj = DBModel<TestDbModel>.Idrate(dr);
                Assert.AreEqual(i.ToString(), obj.stringValue);
                Assert.AreEqual(i, obj.intValue);
                Assert.AreEqual(new Decimal(i / 2), obj.decimalValue);
                Assert.AreEqual((float)i / 2, obj.floatValue);
                Assert.AreEqual(dr["datetimeValue"], obj.datetimeValue);
            }
        }

        [Test]
        public async Task testAsyncIdrateGenerator()
        {
            int i = 0;
            await foreach (var obj in DBModel<TestDbModel>.IdrateAsyncGenerator(this._testDt))
            {
                Assert.AreEqual(i.ToString(), obj.stringValue);
                Assert.AreEqual(i, obj.intValue);
                Assert.AreEqual(new Decimal(i / 2), obj.decimalValue);
                Assert.AreEqual((float)i / 2, obj.floatValue);
                Assert.AreEqual(this._testDt.Rows[i]["datetimeValue"], obj.datetimeValue);
                i++;
            }
        }

         [Test]
         public async Task testAsyncIdrate()
        {
            var objs = await DBModel<TestDbModel>.IdrateAsync(this._testDt);
            for (int i = 0; i < DT_SIZE; i++)
            {
                var dr = _testDt.Rows[i];
                var obj = objs[i];
                Assert.AreEqual(i.ToString(), obj.stringValue);
                Assert.AreEqual(i, obj.intValue);
                Assert.AreEqual(new Decimal(i / 2), obj.decimalValue);
                Assert.AreEqual((float)i / 2, obj.floatValue);
                Assert.AreEqual(dr["datetimeValue"], obj.datetimeValue);
            }
        }
    }
}
