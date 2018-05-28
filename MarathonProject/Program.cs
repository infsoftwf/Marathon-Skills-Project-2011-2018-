using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarathonProject
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

            //AppDomain.CurrentDomain.UnhandledException += (object sender, UnhandledExceptionEventArgs e) =>
            //{
            //    MessageBox.Show(string.Concat(Path.GetFileNameWithoutExtension(Application.ExecutablePath), ".exe has stopped working"), "SEH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Process.GetCurrentProcess().Kill();
            //};

            Application.Run(new MainMenu());
        }
    }
}
