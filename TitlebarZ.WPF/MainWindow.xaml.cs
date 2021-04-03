using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using HandyControl.Controls;
using HandyControl.Themes;
using HandyControl.Tools;
using TitlebarZ.WPF.Utils;

namespace TitlebarZ.WPF
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : GlowWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ActiveGlowColor = ColorHelper.GetColorFromBrush(ThemeManager.Current.AccentColor);
            ThemeManager.Current.SystemThemeChanged +=
                (_, o) => ActiveGlowColor = ColorHelper.GetColorFromBrush(o.Info.AccentBrush);
            AccentColorPicker.SelectedBrush = (SolidColorBrush) ThemeManager.Current.AccentColor;
        }

        public string AssemblyVersion
        {
            get
            {
                var version = Assembly.GetExecutingAssembly().GetName().Version;
                return $@"{version.Major}.{version.Minor}.{version.Build}";
            }
        }

        private void ChangeSkin(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button button && button.Tag is ApplicationTheme tag)
            {
                PopupConfig.IsOpen = false;
                if (tag.Equals(ThemeManager.Current.ApplicationTheme)) return;
                ThemeManager.Current.ApplicationTheme = tag;
            }
        }

        private void OpenGitHubProfile(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/AlphaNecron/TitlebarZ");
        }

        private void OpenPopup(object sender, RoutedEventArgs e)
        {
            PopupConfig.IsOpen = true;
        }

        private void ResetAppearance(object sender, RoutedEventArgs e)
        {
            try
            {
                RegUtils.ResetCustomization();
                Growl.InfoGlobal("Titlebar color has been reset.");
            }
            catch (Exception ex)
            {
                Growl.ErrorGlobal("Exception occurred:\n" + ex.Message);
            }
        }

        private void ApplyColor(object sender, RoutedEventArgs e)
        {
            var baseColor = AccentColorPicker.SelectedBrushWithoutOpacity.Color;
            var colorBgrHex = $@"FF{baseColor.B:X2}{baseColor.G:X2}{baseColor.R:X2}";
            var targetColor = Convert.ToInt32(colorBgrHex, 16);
            try
            {
                RegUtils.SetColorPrevalence(true);
                if (CbApplyToAt.IsChecked ?? false)
                {
                    RegUtils.SetTitlebarColor(targetColor);
                    Growl.SuccessGlobal("New titlebar color has been applied.");
                }

                if (CbApplyToIat.IsChecked ?? false)
                {
                    RegUtils.SetInactiveTitlebarColor(targetColor);
                    Growl.SuccessGlobal("New inactive titlebar color has been applied.");
                }
            }
            catch (Exception ex)
            {
                Growl.ErrorGlobal("Exception occurred:\n" + ex.Message);
            }
        }
    }
}