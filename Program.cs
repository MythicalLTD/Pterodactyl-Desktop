namespace PteroController;

internal static class Program
{
    public static string AppSettingsFile = Application.StartupPath + @"\settings.ini";
    
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FrmLogin());
    }
}