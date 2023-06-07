using Microsoft.Win32;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using PteroController;
using System.Diagnostics;
using System.Reflection;
using Salaros.Configuration;

namespace PteroController
{
    internal static class Program
    {
        static Assembly assembly = Assembly.GetExecutingAssembly();
        static FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
        public static string appversion = fileVersionInfo.ProductVersion;
        private static Mutex mutex = new Mutex(true, "LockApp");
        private static string settings = Application.StartupPath + @"\settings.ini";

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AttachConsole(int dwProcessId);

        private const int ATTACH_PARENT_PROCESS = -1;

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PteroControllerWebServer.StartWebServer("http://localhost:5914/");

            if (!mutex.WaitOne(TimeSpan.Zero, true))
            {
                MessageBox.Show("Another instance of the application is already running.");
                Console.WriteLine("[{0:HH:mm:ss}] (Program) Another instance of the application is already running.", DateTime.Now);
                return;
            }
            if (!IsFirstRun())
            {
                string ptasci = @" 
  _____  _                  _____            _             _ _           
 |  __ \| |                / ____|          | |           | | |          
 | |__) | |_ ___ _ __ ___ | |     ___  _ __ | |_ _ __ ___ | | | ___ _ __ 
 |  ___/| __/ _ \ '__/ _ \| |    / _ \| '_ \| __| '__/ _ \| | |/ _ \ '__|
 | |    | ||  __/ | | (_) | |___| (_) | | | | |_| | | (_) | | |  __/ |   
 |_|     \__\___|_|  \___/ \_____\___/|_| |_|\__|_|  \___/|_|_|\___|_|";

                // EXAMPLE OF A CLI COMMAND
                if (args.Contains("-version"))
                {
                    AttachConsole(ATTACH_PARENT_PROCESS);
                    Console.Title = "PteroController | CLI";
                    Console.WriteLine("@echo off");
                    Console.Clear();
                    Console.WriteLine(ptasci);
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("PteroController version " + appversion + " by MythicalSystems");
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("Press any key to exit");
                    mutex.ReleaseMutex();
                    Console.ReadKey();
                    return;
                }

                if (args.Contains("-debug"))
                {
                    AttachConsole(ATTACH_PARENT_PROCESS);
                    Console.Title = "PteroController | CLI";
                    Console.WriteLine("@echo off");
                    Console.Clear();
                    Console.WriteLine(ptasci);
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("DEBUG MODE ACTIVE");
                    Console.WriteLine("Please do not use this mode if you are not a developer");
                    Console.WriteLine("--------------------------------------------------------------");
                    try
                    {
                        PteroControllerPluginLoader pluginLoader = new PteroControllerPluginLoader();
                        pluginLoader.LoadPlugins();
                        Application.Run(new FrmLoading());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                    mutex.ReleaseMutex();
                    return;
                }
                else if (args.Length > 0)
                {
                    AttachConsole(ATTACH_PARENT_PROCESS);
                    Console.Title = "PteroController | CLI";
                    Console.WriteLine("@echo off");
                    Console.Clear();
                    Console.WriteLine(ptasci);
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("Invalid argument! Type \"-help\" to view available arguments.");
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("Press any key to exit");
                    mutex.ReleaseMutex();
                    return;
                }
                else
                {
                    var cfg = new ConfigParser(settings);
                    string devmode = cfg.GetValue("CONFIG", "devmode");
                    if (devmode == "true")
                    {
                        MessageBox.Show("Hi if you are a developer please use the -debug arg when you start the application to show the console!");
                        PteroControllerPluginLoader pluginLoader = new PteroControllerPluginLoader();
                        pluginLoader.LoadPlugins();
                        Application.Run(new FrmLoading());
                        mutex.ReleaseMutex();
                    }
                    else
                    {
                        PteroControllerPluginLoader pluginLoader = new PteroControllerPluginLoader();
                        pluginLoader.LoadPlugins();
                        Application.Run(new FrmLoading());
                        mutex.ReleaseMutex();
                    }
                }
            }
            else
            {
                Application.Run(new FrmFirstRun());
                SetFirstRunFlag();
            }
        }

        private static bool IsFirstRun()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\PteroController"))
            {
                if (key == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private static void SetFirstRunFlag()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\PteroController"))
                {
                    key.SetValue("FirstRun", true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[{0:HH:mm:ss}] (Program) An error occurred while creating the registry key: " + ex.Message, DateTime.Now);
            }
        }
    }
}
