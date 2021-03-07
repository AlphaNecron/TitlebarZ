using System;
using System.Windows.Forms;

namespace TitlebarZ
{
    internal static class Program
    {
        private static bool IsWin10
        {
            get
            {
                var os = Environment.OSVersion;
                var version = os.Version;
                if (os.Platform != PlatformID.Win32NT) return false;
                return version.Major == 10;
            }
        }

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            if (!IsWin10)
            {
                MessageBox.Show(@"You are not using Windows 10, quitting.", string.Empty, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}