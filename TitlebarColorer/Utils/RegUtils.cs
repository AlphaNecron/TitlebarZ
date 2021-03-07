using Microsoft.Win32;

namespace TitlebarColorer.Utils
{
    public static class RegUtils
    {
        private const string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\DWM";
        private const int ColoredTitlebar = 0x1;
        private const int WhiteTitlebar = 0x0;

        internal static void SetTitlebarColor(object hex)
        {
            Registry.SetValue(KeyPath, "AccentColor", hex, RegistryValueKind.DWord);
        }

        internal static void SetInactiveTitlebarColor(object hex)
        {
            Registry.SetValue(KeyPath, "AccentColorInactive", hex, RegistryValueKind.DWord);
        }

        internal static void SetColorPrevalence(bool enable)
        {
            Registry.SetValue(KeyPath, "ColorPrevalence", enable ? ColoredTitlebar : WhiteTitlebar,
                RegistryValueKind.DWord);
        }
    }
}