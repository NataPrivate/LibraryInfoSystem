using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LibraryInfoSystemClient
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string cmdexePath = @"C:\Windows\System32\cmd.exe";
            string myApplication =
                "\"C:\\Users\\Наташа\\Documents\\Visual Studio 2015\\Projects\\LibraryInfoSystem\\Server\\bin\\Debug\\Server.exe\"";
            string cmdArguments = $"/K {myApplication}";
            ProcessStartInfo psi = new ProcessStartInfo(cmdexePath, cmdArguments);
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            Application.Run(new AuthorizationForm());
        }
    }
}
