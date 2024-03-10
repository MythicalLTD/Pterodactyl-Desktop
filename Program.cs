using Pterodactyl.Forms;
using Pterodactyl.Managers;

namespace Pterodactyl
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static string AppVersion = "1.0.0";
        public static LoggerManager logger = new LoggerManager();
        public static string osVersion;
        public static string osDescription;
        public static string cpuArchitecture;
        public static string osArchitecture;
        public static string mcascii = @" 

  _____  _                     _            _         _ 
 |  __ \| |                   | |          | |       | |
 | |__) | |_ ___ _ __ ___   __| | __ _  ___| |_ _   _| |
 |  ___/| __/ _ \ '__/ _ \ / _` |/ _` |/ __| __| | | | |
 | |    | ||  __/ | | (_) | (_| | (_| | (__| |_| |_| | |
 |_|     \__\___|_|  \___/ \__,_|\__,_|\___|\__|\__, |_|
                                                 __/ |  
                                                |___/                                                               
    ";
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            osVersion = System.Environment.OSVersion.Version.ToString();
            osDescription = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            cpuArchitecture = System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture.ToString();
            osArchitecture = System.Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit";
            if (!OperatingSystem.IsWindows())
            {
                logger.Log(LogType.Error, "We are sorry, but we blocked this app from running on any other OS than Windows!");
                Application.Exit();
            }
            if (!File.Exists(Application.StartupPath+ @"\styles.yaml"))
            {
                string yamlContent = @"
lblappname:
  Text: Pterodactyl Panel
";

                File.AppendAllText(Application.StartupPath + @"\styles.yaml", yamlContent);

                Application.Restart();
            }
            if (!File.Exists(Application.StartupPath + @"\PteroConsole.exe") && !File.Exists(Application.StartupPath + @"\WinSCP.exe"))
            {
                Application.Run(new FrmInstallTools());
            }
            else
            {
                Application.Run(new FrmLoading());
            }

        }
        public static void Alert(string msg, FrmAlert.enmType type)
        {
            FrmAlert frm = new FrmAlert();
            frm.showAlert(msg, type);
        }
    }
}