using System;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace ACUtils
{
    public class RegEditUtil
    {
        readonly string _regKey;

        readonly RegistryKey _baseKey = Registry.LocalMachine;

        public RegEditUtil(RegistryKey baseKey, string regKey = @"Software\ACUtils")
        {
            _baseKey = baseKey;
            _regKey = regKey;
            Init();
        }

        public RegEditUtil(string regKey = @"Software\ACUtils")
        {
            _regKey = regKey;
            Init();
        }

        public void Init()
        {
            // creazione chiave
            _baseKey?.CreateSubKey(_regKey ?? "", RegistryKeyPermissionCheck.ReadWriteSubTree)?.Close();

            // apertura con permessi per modifica permesssi
            RegistryKey key = _baseKey?.OpenSubKey(
                _regKey ?? "",
                RegistryKeyPermissionCheck.ReadWriteSubTree,
                RegistryRights.ChangePermissions | RegistryRights.ReadKey | RegistryRights.WriteKey |
                RegistryRights.FullControl
            );

            // permessi da applicare
            RegistryRights acl = RegistryRights.WriteKey | RegistryRights.ReadKey | RegistryRights.Delete;

            // attuale policy
            if (EnvironmentUtils.IsWin())
            {
                RegistrySecurity regSec = key?.GetAccessControl();

                // aggiunta policy all'attuale
                regSec?.AddAccessRule(
                    new RegistryAccessRule(
                        $"{Environment.UserDomainName}\\{Environment.UserName}",
                        acl,
                        InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                        PropagationFlags.InheritOnly,
                        AccessControlType.Allow
                    )
                );

                // definizione proprietario
                regSec?.SetOwner(new NTAccount($"{Environment.UserDomainName}\\{Environment.UserName}"));

                // applicazione della policy
                key?.SetAccessControl(regSec);
            }

            key?.Close();
        }

        public void Write(string keyname, string subkeyname, string value)
        {
            using (RegistryKey key = _baseKey.CreateSubKey($"{_regKey}\\{keyname}", true))
            {
                key.SetValue(subkeyname, value);
            }
        }

        public void Write(string keyname, string value)
        {
            _baseKey.SetValue(keyname, value);
        }

        public string Read(string keyname, string subKeyname)
        {
            try
            {
                using (RegistryKey subKey = _baseKey.OpenSubKey($"{_regKey}\\{keyname}", false))
                {
                    return Convert.ToString(subKey?.GetValue(subKeyname, null));
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string Read(string keyname)
        {
            try
            {
                return Convert.ToString(_baseKey?.GetValue($"{_regKey}\\{keyname}", null));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Exists(string keyname, string subKeyname)
        {
            try
            {
                using (RegistryKey subKey = _baseKey.OpenSubKey($"{_regKey}\\{keyname}", false))
                {
                    return subKey?.GetValue(subKeyname, null) != null;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Exists(string keyname)
        {
            try
            {
                return _baseKey?.GetValue($"{_regKey}\\{keyname}", null) != null;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}