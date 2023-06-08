using System;
using System.IO;
using System.Net;
using System.Threading;

public class PteroControllerWebServer
{
    private static HttpListener listener;
    private static Thread serverThread;
    private static string webserverDirectory;
    private const string DefaultHtmlContent = "<html><body><h1>How did you find me?</h1></body></html>";

    public static void StartWebServer(string url)
    {
        listener = new HttpListener();
        listener.Prefixes.Add(url);
        serverThread = new Thread(StartServer);
        webserverDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "webserver");

        if (!Directory.Exists(webserverDirectory))
        {
            Directory.CreateDirectory(webserverDirectory);
            CreateDefaultHtmlFile();
        }

        serverThread.Start();
    }
    public static void StopServer()
    {
        listener.Stop();
        listener.Close();
        serverThread.Abort();
    }
    private static void StartServer()
    {
        listener.Start();
        Console.WriteLine("Web server started.");
        Console.WriteLine("Listening on " + listener.Prefixes);

        try
        {
            while (listener.IsListening)
            {
                var context = listener.GetContext();
                ProcessRequest(context);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        listener.Close();
        Console.WriteLine("Web server stopped.");
    }

    private static void ProcessRequest(HttpListenerContext context)
    {
        var request = context.Request;
        var response = context.Response;

        var filePath = request.Url.AbsolutePath;
        filePath = filePath.Substring(1);

        var fullPath = Path.Combine(webserverDirectory, filePath);

        if (File.Exists(fullPath))
        {
            var extension = Path.GetExtension(fullPath);
            var contentType = GetContentType(extension);
            var content = File.ReadAllBytes(fullPath);

            response.ContentType = contentType;
            response.ContentLength64 = content.Length;

            var output = response.OutputStream;
            output.Write(content, 0, content.Length);
            output.Close();
        }
        else
        {
            ServeDefaultHtmlContent(response);
        }
    }

    private static void ServeDefaultHtmlContent(HttpListenerResponse response)
    {
        response.ContentType = "text/html";
        var content = System.Text.Encoding.UTF8.GetBytes(DefaultHtmlContent);
        response.ContentLength64 = content.Length;

        var output = response.OutputStream;
        output.Write(content, 0, content.Length);
        output.Close();
    }

    private static void CreateDefaultHtmlFile()
    {
        var filePath = Path.Combine(webserverDirectory, "index.html");
        File.WriteAllText(filePath, DefaultHtmlContent);
    }

    private static string GetContentType(string fileExtension)
    {
        switch (fileExtension)
        {
            case ".html":
            case ".htm":
                return "text/html";
            case ".css":
                return "text/css";
            case ".js":
                return "application/javascript";
            case ".json":
                return "application/json";
            case ".xml":
                return "application/xml";
            case ".jpg":
            case ".jpeg":
                return "image/jpeg";
            case ".png":
                return "image/png";
            case ".gif":
                return "image/gif";
            default:
                return "application/octet-stream";
        }
    }
}
