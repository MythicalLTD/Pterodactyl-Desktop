using System.IO.Compression;

namespace PteroController.ConsoleManager;

public class ConsoleManager
{
    public static async void CheckInstall()
    {
        if (!File.Exists(Application.StartupPath + @"\PteroConsole.exe"))
        {
            await Download();
            await Unzip();
        }
        else
        {

        }
    }
    public static Task Unzip()
    {
        try
        {
            ZipArchive archive = ZipFile.OpenRead("PteroConsole.zip");
            foreach (ZipArchiveEntry entry in archive.Entries)
            {
                entry.ExtractToFile(Application.StartupPath, overwrite: true);
            }
            archive.Dispose();
            return Task.CompletedTask;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());   
            return Task.FromException(ex);
        }
    }

    public static async Task Download()
    {
        string releaseURL = "https://github.com/MythicalLTD/PteroConsole/releases/latest/download/PteroConsole.zip";
        HttpClient client = new HttpClient();
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, releaseURL);
        HttpResponseMessage response = await client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            Stream contentStream = await response.Content.ReadAsStreamAsync();
            FileStream fileStream = new FileStream("PteroConsole.zip", FileMode.Create);
            await contentStream.CopyToAsync(fileStream);
            fileStream.Close();
            contentStream.Close();
            client.Dispose();
            Console.WriteLine("PteroConsole has been downloaded successfully!");
        }
        else
        {
            Console.WriteLine("Failed to download PteroConsole: {0}", response.StatusCode);
        }
    }
}
