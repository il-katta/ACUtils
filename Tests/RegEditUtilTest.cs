using ACUtils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class RegEditUtilTest
    {
        RegEditUtil regedit;
        [SetUp]
        public void Setup()
        {
            regedit = new RegEditUtil(
                Microsoft.Win32.Registry.CurrentUser,
                @"Software\RegEditUtilTest"
            );
        }
        [Test]
        public void RegEditUtil_Create()
        {
            var value = "1234abcde";

            regedit.Write("RegEditUtil_Create", value);
            var readed = regedit.Read("RegEditUtil_Create");
            Assert.IsTrue(value.Equals(readed));
        }

        [Test]
        public void RegEditUtil_List()
        {
            var cVals = new List<string>()
            {
                "a", "b", "c"
            };
            foreach (var v in cVals)
            {
                regedit.Write(v, v);
            }
            var list = regedit.List();
            foreach (var v in cVals)
            {
                Assert.IsTrue(list.Contains(v));
            }
        }

        [Test]
        public void RegEditUtil_Read()
        {
            var value = "1234abcde";

            regedit.Write("RegEditUtil_Read", value);

            Assert.IsTrue(value.Equals(regedit.Read("RegEditUtil_Read")));
        }
    }
}
