using Microsoft.Win32;

namespace TitlebarZ.Utils
{
    public static class RegUtils
    {
        private const string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\DWM";
        private const int Color = 0x1;
        private const int Reset = 0x0;

        internal static void SetTitlebarColor(object hex)
        {
            Registry.SetValue(KeyPath, "AccentColor", hex, RegistryValueKind.DWord);
        }

        internal static void SetInactiveTitlebarColor(object hex)
        {
            Registry.SetValue(KeyPath, "AccentColorInactive", hex, RegistryValueKind.DWord);
        }

        internal static void ResetCustomization()
        {
            SetTitlebarColor(Reset);
            SetInactiveTitlebarColor(Reset);
            SetColorPrevalence(false);
        }

        internal static void SetColorPrevalence(bool enable)
        {
            Registry.SetValue(KeyPath, "ColorPrevalence", enable ? Color : Reset,
                RegistryValueKind.DWord);
        }
    }
}