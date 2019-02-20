using System;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace ACUtils
{
    public class RegEditUtil
    {
        private static string RegKey;

        private static RegistryKey BaseKey = Registry.LocalMachine;

        public RegEditUtil(RegistryKey baseKey, string regKey)
        {
            BaseKey = baseKey;
            RegKey = regKey;
            Init();
        }

        public static void Init()
        {
            // creazione chiave
            BaseKey.CreateSubKey(RegKey, RegistryKeyPermissionCheck.ReadWriteSubTree).Close();

            // apertura con permessi per modifica permesssi
            RegistryKey key = BaseKey.OpenSubKey(
                RegKey,
                RegistryKeyPermissionCheck.ReadWriteSubTree,
                RegistryRights.ChangePermissions | RegistryRights.ReadKey | RegistryRights.WriteKey |
                RegistryRights.FullControl
            );

            // permessi da applicare
            RegistryRights acl = RegistryRights.WriteKey | RegistryRights.ReadKey | RegistryRights.Delete;

            // attuale policy
            if (EnvironmentUtils.IsWin())
            {
                RegistrySecurity reg_sec = key?.GetAccessControl();

                // aggiunta policy all'attuale
                reg_sec?.AddAccessRule(
                    new RegistryAccessRule(
                        $"{Environment.UserDomainName}\\{Environment.UserName}",
                        acl,
                        InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                        PropagationFlags.InheritOnly,
                        AccessControlType.Allow
                    )
                );

                // definizione proprietario
                reg_sec?.SetOwner(new NTAccount($"{Environment.UserDomainName}\\{Environment.UserName}"));

                // applicazione della policy
                key?.SetAccessControl(reg_sec);
            }

            key?.Close();
        }

        public static void Write(string keyname, string subkeyname, string value)
        {
            using (RegistryKey key = BaseKey.CreateSubKey($"{RegKey}\\{keyname}", true))
            {
                key.SetValue(subkeyname, value);
            }
        }

        public static string Read(string keyname, string sub_keyname)
        {
            try
            {
                using (RegistryKey sub_key = BaseKey.OpenSubKey($"{RegKey}\\{keyname}", false))
                {
                    return Convert.ToString(sub_key.GetValue(sub_keyname, null));
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /*
         public static void StringaConnessione_Set(string StringaConnessione, string profile)
         {
             Init();
             Write($"{RegKey}\\{profile}", REG_KEY_STRINGA_CONNESSIONE, StringaConnessione);
         }

         /// <summary>
         /// ritorna la stringa di connessione dal registro di sistema
         /// </summary>
         /// <param name="StringaConnessione"></param>
         /// <returns></returns>
         public static string StringaConnessione_Get(string profile)
         {
             return Read($"{RegKey}\\{profile}", REG_KEY_STRINGA_CONNESSIONE);
         }
         */
    }
}