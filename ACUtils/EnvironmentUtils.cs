using System;

namespace ACUtils
{
    public static class EnvironmentUtils
    {
        public static bool IsUnix()
        {
            //int p = (int) Environment.OSVersion.Platform;
            //return ((p == 4) || (p == 6) || (p == 128));
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32S:
                    return false;
                case PlatformID.Win32Windows:
                    return false;
                case PlatformID.Win32NT:
                    return false;
                case PlatformID.WinCE:
                    return false;
                case PlatformID.Unix:
                    return true;
                case PlatformID.Xbox:
                    return false;
                case PlatformID.MacOSX:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsWin()
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32S:
                    return true;
                case PlatformID.Win32Windows:
                    return true;
                case PlatformID.Win32NT:
                    return true;
                case PlatformID.WinCE:
                    return true;
                case PlatformID.Unix:
                    return false;
                case PlatformID.Xbox:
                    return false;
                case PlatformID.MacOSX:
                    return false;
                default:
                    return false;
            }
        }
    }
}