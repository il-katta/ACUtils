using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;

namespace ACUtils
{
    public class RegEditUtil
    {
        private readonly string _regKey;
        private readonly RegistryKey _baseKey = Registry.LocalMachine;

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
                try
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
                catch
                {
                    // ignore
                }
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
            using (RegistryKey key = _baseKey.CreateSubKey(_regKey, true))
            {
                key.SetValue(keyname, value);
            }
        }


        public string Read(string keyname, string subKeyname)
        {
            try
            {
                using (RegistryKey subKey = _baseKey.OpenSubKey($"{_regKey}\\{keyname}", false))
                {
                    return Read(subKey, keyname);
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
                using (RegistryKey subKey = _baseKey.OpenSubKey(_regKey, false))
                {
                    return Read(subKey, keyname);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }


        public string Read(RegistryKey key, string keyname)
        {
            try
            {
                return Convert.ToString(key?.GetValue(keyname, null));
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
                    return Exists(subKey, subKeyname);
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Exists(string keyname)
        {
            return Exists(_baseKey, $"{_regKey}\\{keyname}");
        }

        public bool Exists(RegistryKey regKey, string subKeyname)
        {
            try
            {
                return regKey?.GetValue(subKeyname, null) != null;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<string> List()
        {
            using (RegistryKey subKey = _baseKey.OpenSubKey(_regKey, false))
            {
                return List(subKey);
            }
        }

        public List<string> List(string keyname)
        {
            using (RegistryKey subKey = _baseKey.OpenSubKey($"{_regKey}\\{keyname}", false))
            {
                return List(subKey);
            }
        }


        public List<string> List(RegistryKey regKey)
        {
            /*
            return (
                    from k in regKey?.GetValueNames()
                    select k.Remove(0, this._regKey.Length).TrimStart('\\')
                ).ToList();
            */
            return new List<string>(regKey?.GetValueNames());
        }
    }
}