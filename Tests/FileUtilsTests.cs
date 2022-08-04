using ACUtils;

using NUnit.Framework;

using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

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


        private bool _hasPermission(string filePath, string accountName)
        {
            var fileInfo = new FileInfo(filePath);
            var acl = fileInfo.GetAccessControl().GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));
            for (int i = 0; i < acl.Count; i++)
            {
                var currentRule = (FileSystemAccessRule)acl[i];
                Console.WriteLine(currentRule.IdentityReference.Value);
                if (currentRule.IdentityReference.Value.Equals(accountName, StringComparison.CurrentCultureIgnoreCase)) return true;
            }

            acl = fileInfo.GetAccessControl().GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));
            for (int i = 0; i < acl.Count; i++)
            {
                var currentRule = (FileSystemAccessRule)acl[i];
                Console.WriteLine(currentRule.IdentityReference.Value);
                if (currentRule.IdentityReference.Value.Equals(accountName, StringComparison.CurrentCultureIgnoreCase)) return true;
            }

            return false;
        }

        [Test]
        [TestCase(@"ANDREA-C-2021-1\test")]
        [TestCase(@"NT AUTHORITY\NETWORK")]
        [Parallelizable(ParallelScope.All)]
        public void FixAclTest(string identityUPN)
        {
            var basePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            System.IO.Directory.CreateDirectory(basePath);
            var sourceFolderPath = Path.Combine(basePath, "source");
            System.IO.Directory.CreateDirectory(sourceFolderPath);
            var destFolderPath = Path.Combine(basePath, "destination");
            System.IO.Directory.CreateDirectory(destFolderPath);
            DirectoryInfo destFolder = new DirectoryInfo(destFolderPath);


            DirectorySecurity security = destFolder.GetAccessControl();
            var rule = new FileSystemAccessRule(
                identityUPN,
                FileSystemRights.FullControl,
                InheritanceFlags.ObjectInherit,
                PropagationFlags.InheritOnly,
                AccessControlType.Allow
            );
            security.AddAccessRule(rule);
            destFolder.SetAccessControl(security);
            var filename = Path.GetRandomFileName();
            var sourcePath = System.IO.Path.Combine(sourceFolderPath, filename);
            var destPath = System.IO.Path.Combine(destFolderPath, filename);

            File.WriteAllText(sourcePath, "hello there!");

            File.Move(sourcePath, destPath);
            Console.WriteLine($"{sourcePath} -> {destPath}");

            Assert.IsFalse(_hasPermission( destPath, identityUPN));


            File.WriteAllText(sourcePath, "hello there!");
            ACUtils.FileUtils.MoveFile(sourcePath, destPath, bOverride: true, fixAcl: true);

            Assert.IsTrue(_hasPermission(destPath, identityUPN));
        }

    }



    public class UserSecurity
    {
        WindowsIdentity _currentUser;
        WindowsPrincipal _currentPrincipal;

        public UserSecurity(WindowsIdentity user)
        {
            _currentUser = user;
            _currentPrincipal = new WindowsPrincipal(_currentUser);
        }

        public bool HasAccess(DirectoryInfo directory, FileSystemRights right)
        {
            // Get the collection of authorization rules that apply to the directory.
            AuthorizationRuleCollection acl = directory.GetAccessControl()
                .GetAccessRules(true, true, typeof(SecurityIdentifier));
            return HasFileOrDirectoryAccess(right, acl);
        }

        public bool HasAccess(FileInfo file, FileSystemRights right)
        {
            // Get the collection of authorization rules that apply to the file.
            AuthorizationRuleCollection acl = file.GetAccessControl()
                .GetAccessRules(true, true, typeof(SecurityIdentifier));
            return HasFileOrDirectoryAccess(right, acl);
        }

        private bool HasFileOrDirectoryAccess(FileSystemRights right,
                                              AuthorizationRuleCollection acl)
        {
            bool allow = false;
            bool inheritedAllow = false;
            bool inheritedDeny = false;

            for (int i = 0; i < acl.Count; i++)
            {
                var currentRule = (FileSystemAccessRule)acl[i];
                // If the current rule applies to the current user.
                if (_currentUser.User.Equals(currentRule.IdentityReference) ||
                    _currentPrincipal.IsInRole(
                                    (SecurityIdentifier)currentRule.IdentityReference))
                {

                    if (currentRule.AccessControlType.Equals(AccessControlType.Deny))
                    {
                        if ((currentRule.FileSystemRights & right) == right)
                        {
                            if (currentRule.IsInherited)
                            {
                                inheritedDeny = true;
                            }
                            else
                            { // Non inherited "deny" takes overall precedence.
                                return false;
                            }
                        }
                    }
                    else if (currentRule.AccessControlType
                                                    .Equals(AccessControlType.Allow))
                    {
                        if ((currentRule.FileSystemRights & right) == right)
                        {
                            if (currentRule.IsInherited)
                            {
                                inheritedAllow = true;
                            }
                            else
                            {
                                allow = true;
                            }
                        }
                    }
                }
            }

            if (allow)
            { // Non inherited "allow" takes precedence over inherited rules.
                return true;
            }
            return inheritedAllow && !inheritedDeny;
        }
    }
}