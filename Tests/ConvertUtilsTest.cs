using System;

using ACUtils;

using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ConvertUtilsTest
    {


        [Test]
        public void DateTest()
        {
            var date = ConvertUtils.ToDateTime("12-31-1999");
            Assert.IsTrue(date.HasValue, "conversione riuscita");
            Assert.AreEqual(date.Value.Year, 1999, "anno");
            Assert.AreEqual(date.Value.Month, 12, "mese");
            Assert.AreEqual(date.Value.Day, 31, "giorno");


        }

        [Test]
        public void LocalDateTest()
        {
            var date = ConvertUtils.ToLocalDateTime("99-99-9999");
            Assert.IsFalse(date.HasValue, "conversione non riuscita");

            date = ConvertUtils.ToLocalDateTime("31-12-1999");
            Assert.IsTrue(date.HasValue, "conversione non riuscita");
            Assert.AreEqual(date.Value.Year, 1999, "anno");
            Assert.AreEqual(date.Value.Month, 12, "mese");
            Assert.AreEqual(date.Value.Day, 31, "giorno");

            date = ConvertUtils.ToLocalDateTime("1999-01-02");
            Assert.IsTrue(date.HasValue, "conversione non riuscita");
            Assert.AreEqual(date.Value.Year, 1999, "anno");
            Assert.AreEqual(date.Value.Month, 1, "mese");
            Assert.AreEqual(date.Value.Day, 2, "giorno");
        }
    }
}
