namespace PteroController
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static string AppSettings = Application.StartupPath + @"\settings.ini";
        public static string AppAccountInfo = Application.StartupPath + @"\account.ini";
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLoader());
        }
    }
}