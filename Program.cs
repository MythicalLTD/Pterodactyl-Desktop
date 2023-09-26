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
            Application.Run(new FrmLoader());
        }
        public static void Alert(string msg, FrmAlert.enmType type)
        {
            FrmAlert frm = new FrmAlert();
            frm.showAlert(msg, type);
        }
    }
}