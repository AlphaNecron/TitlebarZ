﻿using Microsoft.Win32;

namespace TitlebarZ.Utils
{
    class RegUtils
    {
        private const string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\DWM";
        private static readonly RegistryKey DwmRegKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\DWM");
        private const int Color = 0x1;
        private const int Reset = 0x0;

        internal static void SetTitlebarColor(object hex)
        {
            DwmRegKey.SetValue("AccentColor", hex, RegistryValueKind.DWord);
        }

        internal static void SetInactiveTitlebarColor(object hex)
        {
            DwmRegKey.SetValue("AccentColorInactive", hex, RegistryValueKind.DWord);
        }

        internal static void ResetCustomization()
        {
            SetTitlebarColor(Reset);
            SetInactiveTitlebarColor(Reset);
            SetColorPrevalence(false);
        }

        internal static void SetColorPrevalence(bool enable)
        {
            DwmRegKey.SetValue("ColorPrevalence", enable ? Color : Reset,
                RegistryValueKind.DWord);
        }
    }
}

