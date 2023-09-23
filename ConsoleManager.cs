namespace PteroController.ConsoleManager;

public class ConsoleManager
{
    public static void CheckInstall()
    {
        if (!File.Exists(Application.StartupPath+ @"\PteroConsole.exe"))
        {
            MessageBox.Show("Sorry but it looks like the app is missing");
        }
    }
}
