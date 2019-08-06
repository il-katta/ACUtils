using ACUtils;
using NUnit.Framework;
using System;
using System.Threading;

namespace Tests
{
    [TestFixture]
    public class ProgramUtilsTest
    {
        [Test]
        public void UnblockTest()
        {
            using (var client = new System.Net.WebClient())
            {
                var downloadedFile = $"{System.IO.Path.GetTempFileName()}.exe";
                client.DownloadFile("https://dist.nuget.org/win-x86-commandline/latest/nuget.exe", downloadedFile);
                ProgramUtils.Unblock(downloadedFile);
            }
        }
    }
}
