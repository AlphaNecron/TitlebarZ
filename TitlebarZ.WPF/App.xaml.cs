using System.Windows;
using HandyControl.Tools;
using MessageBox = HandyControl.Controls.MessageBox;

namespace TitlebarZ.WPF
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            if (!OSVersionHelper.IsWindows10) return;
            MessageBox.Show("This app can't run on your PC.\nWindows 10 is required.");
            Current.Shutdown(10);
        }
    }
}