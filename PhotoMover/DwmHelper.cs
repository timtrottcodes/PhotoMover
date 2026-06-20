using System;
using System.Runtime.InteropServices;

namespace PhotoMover
{
    public static class DwmHelper
    {
        [DllImport("dwmapi.dll", PreserveSig = true)]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        /// <summary>
        /// Sets the title bar to use dark mode (Windows 10 1809+)
        /// </summary>
        public static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
        {
            if (!IsWindows10OrGreater(17763))
                return false;

            int attribute = DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;
            if (IsWindows10OrGreater(18985))
            {
                attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;
            }

            int useImmersiveDarkMode = enabled ? 1 : 0;
            return DwmSetWindowAttribute(handle, attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
        }

        private static bool IsWindows10OrGreater(int build = -1)
        {
            var osVersion = Environment.OSVersion;
            if (osVersion.Platform == PlatformID.Win32NT && osVersion.Version.Major >= 10)
            {
                if (build == -1)
                    return true;
                return osVersion.Version.Build >= build;
            }
            return false;
        }
    }
}
