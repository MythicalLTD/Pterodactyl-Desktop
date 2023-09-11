using Newtonsoft.Json;
using PteroControllerConsole;
using System.Net;

class Program
{
    static async Task Main(string[] args)
    {
        string? panelUrl = null;
        string? clientKey = null;
        string? serverUuid = null;

        // Parse command-line arguments
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == "--panel-url" && i + 1 < args.Length)
            {
                panelUrl = args[i + 1];
            }
            else if (args[i] == "--panel-apikey" && i + 1 < args.Length)
            {
                clientKey = args[i + 1];
            }
            else if (args[i] == "--serveruuid" && i + 1 < args.Length)
            {
                serverUuid = args[i + 1];
            }
        }

        if (string.IsNullOrWhiteSpace(panelUrl) || string.IsNullOrWhiteSpace(clientKey) || string.IsNullOrWhiteSpace(serverUuid))
        {
            Console.WriteLine("Usage: PteroConsole.exe --panel-url https://panel.yourdomain.test --panel-apikey test --serveruuid 4");
            return;
        }

        Console.WriteLine($"Using {panelUrl}/api/client/servers/{serverUuid}/websocket");


        var console = new PteroConsole.NET.PteroConsole();


        console.RequestToken += pteroConsole =>
        {
            Console.WriteLine("Revoking token");
            var wc = new WebClient();
            wc.Headers.Add("Authorization", "Bearer " + clientKey);
            var raw = wc.DownloadString($"{panelUrl}/api/client/servers/{serverUuid}/websocket");
            var data = JsonConvert.DeserializeObject<WebsocketDataResource>(raw).Data;
            return data.Token;
        };

        console.OnMessage += (sender, s) =>
        {
            Console.WriteLine(s);
        };

        var wc = new WebClient();
        wc.Headers.Add("Authorization", "Bearer " + clientKey);
        var raw = wc.DownloadString($"{panelUrl}/api/client/servers/{serverUuid}/websocket");
        var data = JsonConvert.DeserializeObject<WebsocketDataResource>(raw).Data;

        await console.Connect(panelUrl, data.Socket, data.Token);

        while (true)
        {
            var command = Console.ReadLine();

            if (command == "exit")
                break;

            // Clear the console screen or overwrite the input line.
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.WriteLine("\n");
            await console.EnterCommand(command);
        }


        await console.Disconnect();
    }
}
