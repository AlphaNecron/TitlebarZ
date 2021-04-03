using Microsoft.Win32;

namespace TitlebarZ.WPF.Utils
{
    internal class RegUtils
    {
        private const int Color = 0x1;
        private const int Reset = 0x0;

        private static readonly RegistryKey DwmRegKey =
            Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM", true);

        internal static void SetTitlebarColor(int hex)
        {
            DwmRegKey.SetValue("AccentColor", hex, RegistryValueKind.DWord);
        }

        internal static void SetInactiveTitlebarColor(int hex)
        {
            DwmRegKey.SetValue("AccentColorInactive", int.Parse(hex.ToString()), RegistryValueKind.DWord);
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