using System;
using System.Threading;
using NUnit.Framework;
using ACUtils;

namespace Tests
{
    public class FileUtilsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsFileTest()
        {
            string filePath;
            using (var tmpFilePath = FileUtils.GetTempFilePathWithExtension(".test"))
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
            using (var tmpFilePath = FileUtils.GetTempFilePathWithExtension(".test"))
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
            using (var dFile = FileUtils.GetTempFilePathWithExtension(".test"))
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
            using (var dDir = FileUtils.GetTempDirPath())
            {
                Assert.IsTrue(FileUtils.AssertIsDirectory(dDir.Value));
                Assert.IsTrue(FileUtils.IsDirectory(dDir.Value));
                dirPath = dDir.Value;

                var subDirectory = System.IO.Path.Combine(dDir.Value, @"test\test\test");
                var subDirectoryFile = System.IO.Path.Combine(subDirectory, @"text.txt");
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

            using (var tmpFile = FileUtils.GetTempFilePathWithExtension(".test"))
            {
                System.IO.File.WriteAllText(tmpFile.Value, data);

                Assert.AreEqual(expected_checksum, FileUtils.FileChecksum(tmpFile.Value));
                Assert.AreEqual(expected_checksum, FileUtils.Checksum(data));
            }
        }
    }
}