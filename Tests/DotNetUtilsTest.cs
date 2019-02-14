using System;
using ACUtils;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class DotNetUtilsTest
    {
        [Test]
        public void GetAssemblyTest()
        {
            var assembly = DotNetUtils.GetAssembly();
            
            Assert.AreSame(System.Reflection.Assembly.GetExecutingAssembly(), assembly);
            Assert.AreEqual(
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Name,
                assembly.GetName().Name
            );
        }

        [Test]
        public void GetEmbeddedResourcesNamesTest()
        {
            Assert.Contains("Tests.EmbeddedResourceFile.txt", DotNetUtils.GetEmbeddedResourcesNames());
        }
        
        [Test]
        public void GetEmbeddedResourceTest()
        {
            Assert.AreEqual("[test content]", DotNetUtils.GetEmbeddedResource("Tests.EmbeddedResourceFile.txt"));
        }
    }
}