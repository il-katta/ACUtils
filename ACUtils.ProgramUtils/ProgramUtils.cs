using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace ACUtils
{
    public static class ProgramUtils
    {
        public static bool IsUserAdministrator()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException)
            {
                isAdmin = false;
            }
            catch (Exception)
            {
                isAdmin = false;
            }
            return isAdmin;
        }

        public static bool ReExecAsAdmin(string[] args)
        {
            return new System.Diagnostics.Process()
            {
                StartInfo = {
                  FileName = System.Reflection.Assembly.GetCallingAssembly().Location,
                  Verb = "runas",
                  UseShellExecute = true,
                  Arguments = string.Join(" ", args) // TODO: potrebbe non funzionare con argomenti contenti spazi
                }
            }.Start();
        }

        public static bool ReExec(string[] args)
        {
            return new System.Diagnostics.Process()
            {
                StartInfo = {
                  FileName = System.Reflection.Assembly.GetCallingAssembly().Location,
                  UseShellExecute = true,
                  Arguments = string.Join(" ", args) // TODO: potrebbe non funzionare con argomenti contenti spazi
                }
            }.Start();
        }

        /// <summary>
        /// sostituisce il file del processo attuale con il file scaricato dall'url
        /// se la versione del file scaricato è superiore alla versione attuale
        /// </summary>
        /// <param name="url">url del file da sostituire</param>
        /// <param name="force">se true non effettua il controllo della versione</param>
        /// <returns>true se il file è stato sostituito</returns>
        public static bool SelfUpdate(string url, bool force = false)
        {
            var currentFile = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            
            var newFileName = $"{currentFile}-new.exe";
            var oldFileName = $"{currentFile}-old.exe";
            using (var client = new System.Net.WebClient())
            {
                client.DownloadFile(url, newFileName);
                Unblock(newFileName);
            }

            bool update = force;

            if (!force)
            {
                // controlla che la versione del file scaricato sia successiva alla attuale
                string currentVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(currentFile).FileVersion;
                var currentVersionInfo = new Version(currentVersion);
                var newVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(newFileName).FileVersion;
                var newVersionInfo = new Version(newVersion);
                update = newVersionInfo > currentVersionInfo;
            }

            // viene rinominato il file del processo corrente ( da sostituire )
            // e il file scaricato viene rinominato con il nome del processo attuale
            if (update)
            {
                FileUtils.MoveFile(currentFile, oldFileName, bOverride: true);
                FileUtils.MoveFile(newFileName, currentFile);
                return true;
            }
            else
            {
                File.Delete(newFileName);
                return false;
            }
        }

        /// <summary>
        /// equivalente del comando PS Unblock-File 
        /// </summary>
        /// <param name="path"></param>
        public static void Unblock(string path)
        {
            DeleteFile(BuildStreamPath(path, "Zone.Identifier"));
        }

        [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool DeleteFile(string name);

        static string BuildStreamPath(string filePath, string streamName)
        {
            char StreamSeparator = ':';
            int MaxPath = 256;
            string LongPathPrefix = @"\\?\";
            if (string.IsNullOrEmpty(filePath)) return string.Empty;

            // Trailing slashes on directory paths don't work:

            string result = filePath;
            int length = result.Length;
            while (0 < length && '\\' == result[length - 1])
            {
                length--;
            }

            if (length != result.Length)
            {
                result = 0 == length ? "." : result.Substring(0, length);
            }

            result += StreamSeparator + streamName + StreamSeparator + "$DATA";

            if (MaxPath <= result.Length && !result.StartsWith(LongPathPrefix))
            {
                result = LongPathPrefix + result;
            }

            return result;
        }

    }
}
