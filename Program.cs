using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PteroController
{
    internal static class Program
    {
        public static string appversion = "0.0.3";

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AttachConsole(int dwProcessId);

        private const int ATTACH_PARENT_PROCESS = -1;

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //EXAMPLE OF A CLI COMMAND
            if (args.Contains("-version"))
            {
                AttachConsole(ATTACH_PARENT_PROCESS);
                Console.Title = "PteroController | CLI";
                Console.WriteLine("@echo off");
                Console.Clear();
                Console.WriteLine("PteroController version " + appversion + " by MythicalSystems");
                Console.WriteLine("");
                Console.WriteLine("Press any key to exit");
            }

            Application.Run(new FrmLogin());
        }
    }
}
