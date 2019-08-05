using System;
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
    }
}
