namespace PteroController
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static string AppSettings = Application.StartupPath + @"\settings.ini";
        public static string AppAccountInfo = Application.StartupPath + @"\account.ini";
        public static string AppVersion = "1.0.0";
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            if (!OperatingSystem.IsWindows())
            {
                Console.WriteLine("We are sorry, but we blocked this app from running on any other OS than Windows!");
                Application.Exit();
            }
            if (!File.Exists(Application.StartupPath + @"\PteroConsole.exe"))
            {
                Application.Run(new FrmInstallTools());
            } else
            {
                Application.Run(new FrmLoader());
            }
            
        }
        public static void Alert(string msg, FrmAlert.enmType type)
        {
            FrmAlert frm = new FrmAlert();
            frm.showAlert(msg, type);
        }
    }
}