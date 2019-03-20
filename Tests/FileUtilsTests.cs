using ACUtils;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class FileUtilsTests
    {
        [SetUp]
        public void Setup()
        {
            string codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            path = System.IO.Path.GetDirectoryName(path);
            System.IO.Directory.SetCurrentDirectory(path);
        }

        [Test]
        public void IsFileTest()
        {
            string filePath;
            using (DString tmpFilePath = FileUtils.GetTempFilePathWithExtension(".test"))
            {
                Assert.IsNotNull(tmpFilePath);
                Assert.IsNotNull(tmpFilePath.Value);
                System.IO.File.WriteAllText(tmpFilePath.Value, "test");

                Assert.IsTrue(FileUtils.IsFile(tmpFilePath.Value));
                Assert.IsFalse(FileUtils.IsFile(System.IO.Path.GetDirectoryName(tmpFilePath.Value)));
                filePath = tmpFilePath.Value;
            }

            Assert.IsFalse(FileUtils.IsFile(filePath));
        }

        [Test]
        public void IsDirectoryTest()
        {
            using (DString tmpFilePath = FileUtils.GetTempFilePathWithExtension(".test"))
            {
                Assert.IsNotNull(tmpFilePath);
                Assert.IsNotNull(tmpFilePath.Value);

                Assert.IsNotNull(tmpFilePath);
                Assert.IsFalse(FileUtils.IsDirectory(tmpFilePath.Value));
                Assert.IsTrue(FileUtils.IsDirectory(System.IO.Path.GetDirectoryName(tmpFilePath.Value)));
            }
        }

        [Test]
        public void DisposableFile()
        {
            string filePath;
            using (DString dFile = FileUtils.GetTempFilePathWithExtension(".test"))
            {
                System.IO.File.WriteAllText(dFile.Value, "test");
                Assert.IsTrue(FileUtils.IsFile(dFile.Value));
                filePath = dFile.Value;
            }

            Assert.IsNotEmpty(filePath);
            Assert.IsFalse(FileUtils.IsFile(filePath));
        }

        [Test]
        public void DisposableDirectory()
        {
            string dirPath;
            using (DString dDir = FileUtils.GetTempDirPath())
            {
                Assert.IsTrue(FileUtils.AssertIsDirectory(dDir.Value));
                Assert.IsTrue(FileUtils.IsDirectory(dDir.Value));
                dirPath = dDir.Value;

                string subDirectory = System.IO.Path.Combine(dDir.Value, @"test\test\test");
                string subDirectoryFile = System.IO.Path.Combine(subDirectory, @"text.txt");
                FileUtils.AssertIsDirectory(subDirectory);
                System.IO.File.WriteAllText(subDirectoryFile, "test");
            }

            Assert.IsNotEmpty(dirPath);
            Assert.IsFalse(FileUtils.IsDirectory(dirPath));
        }


        [Test]
        public void ChecksumTest()
        {
            string data = "1234567890";
            string expected_checksum = "e807f1fcf82d132f9bb018ca6738a19f";

            using (DString tmpFile = FileUtils.GetTempFilePathWithExtension(".test"))
            {
                System.IO.File.WriteAllText(tmpFile.Value, data);

                Assert.AreEqual(expected_checksum, FileUtils.FileChecksum(tmpFile.Value));
                Assert.AreEqual(expected_checksum, FileUtils.Checksum(data));
            }
        }

        [Test]
        [TestCase("EmbeddedResourceFile.txt")]
        [TestCase(null)]
        public void FtpUpload(string ftpFile)
        {
            if (string.IsNullOrEmpty(ftpFile))
            {
                ftpFile = Uri.UnescapeDataString(new UriBuilder(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Path);
            }
            FileUtils.FtpUpload(
                ftpFile,
                "ftp://localhost:21/",
                "/",
                "",
                "",
                false
            );

            System.Collections.Generic.List<string> listFtpFiles = FileUtils.FtpList(
                "ftp://localhost:21/",
                "/",
                "",
                "",
                false
            );

            string fileName = System.IO.Path.GetFileName(ftpFile);

            Assert.IsTrue(listFtpFiles.Contains(fileName));
        }

        [Test]
        [TestCase(null)]
        [TestCase("EmbeddedResourceFile.txt")]
        public void FtpDownload(string filePath)
        {
            // se il file non è specificato, utilizza come file il file dell'assembly di questo progetto
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = Uri.UnescapeDataString(new UriBuilder(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Path);
            }

            FtpUpload(filePath);
            using (DString download_path = FileUtils.GetTempFilePathWithExtension(".dat"))
            {
                FileUtils.FtpDownload(
                    download_path.Value,
                    "ftp://localhost:21/",
                    System.IO.Path.GetFileName(filePath),
                    "",
                    "",
                    false
                );

                Assert.IsTrue(FileUtils.IsFile(download_path.Value));
                System.Collections.Generic.List<string> list = FileUtils.FtpList(
                    "ftp://localhost:21/",
                    "/",
                    "",
                    "",
                    false);
                Assert.AreEqual(
                    expected: FileUtils.FileChecksum(filePath),
                    actual: FileUtils.FileChecksum(download_path.Value)
                );
            }
        }


        [Test]
        public void FtpFtpDelete()
        {
            Assert.IsFalse(
                FileUtils.FtpDelete(
                    "ftp://localhost:21/",
                    "file_not_found.txt",
                    "",
                    "",
                    false
                )
            );

            System.Collections.Generic.List<string> listFtpFiles = FileUtils.FtpList(
                "ftp://localhost:21/",
                "/",
                "",
                "",
                false
            );
            foreach (string ftpFile in listFtpFiles)
            {
                Assert.IsTrue(
                    FileUtils.FtpDelete(
                        "ftp://localhost:21/",
                        ftpFile,
                        "",
                        "",
                        false
                    )
                );
            }

            listFtpFiles = FileUtils.FtpList(
                "ftp://localhost:21/",
                "/",
                "",
                "",
                false
            );

            Assert.IsTrue(listFtpFiles.Count == 0);
        }
    }
}