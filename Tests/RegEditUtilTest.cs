using ACUtils;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class RegEditUtilTest
    {
        private RegEditUtil regedit;
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
            string value = "1234abcde";

            regedit.Write("RegEditUtil_Create", value);
            string readed = regedit.Read("RegEditUtil_Create");
            Assert.IsTrue(value.Equals(readed));
        }

        [Test]
        public void RegEditUtil_List()
        {
            List<string> cVals = new List<string>()
            {
                "a", "b", "c"
            };
            foreach (string v in cVals)
            {
                regedit.Write(v, v);
            }
            List<string> list = regedit.List();
            foreach (string v in cVals)
            {
                Assert.IsTrue(list.Contains(v));
            }
        }


        [Test]
        public void RegEditUtil_ListKeys()
        {
            List<string> cVals = new List<string>()
            {
                "q", "w", "e"
            };
            foreach (string v in cVals)
            {
                Microsoft.Win32.RegistryKey k = regedit.CreateRegKey(v);
            }
            List<string> list = regedit.ListKeys();
            foreach (string v in cVals)
            {
                Assert.IsTrue(list.Contains(v));
            }
        }

        [Test]
        public void RegEditUtil_Read()
        {
            string value = "1234abcde";

            regedit.Write("RegEditUtil_Read", value);

            Assert.IsTrue(value.Equals(regedit.Read("RegEditUtil_Read")));
        }


        [Test]
        public void RegEditUtil_ReadSubkey()
        {
            string subkey = "subkey";
            string keyname = "RegEditUtil_Read";
            regedit.CreateRegKey(subkey);
            string value = "1234abcde";
            regedit.Write(subkey, keyname, value);
            Assert.IsTrue(regedit.RegKeyExists(subkey));
            Assert.IsTrue(regedit.Exists(subkey, keyname));
            var read = regedit.Read(subkey, keyname);
            Assert.IsTrue(value.Equals(read));
        }
    }
}
