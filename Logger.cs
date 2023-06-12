using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PteroController
{
    public class Logger
    {
        private string logPath;
        private string logFileName;
        private StreamWriter logWriter;
        private TextWriter originalOutput;

        public Logger()
        {
            logPath = Path.Combine(Application.StartupPath, "logs");
            logFileName = "log.txt";
        }

        public void InitLoader()
        {
            CheckDir();
        }

        private void CheckDir()
        {
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }

            string logFilePath = Path.Combine(logPath, logFileName);
            bool isNewFile = !File.Exists(logFilePath);

            if (isNewFile)
            {
                using (StreamWriter writer = File.CreateText(logFilePath))
                {
                    writer.WriteLine(Program.ptasci);
                    writer.WriteLine("This is the log file of PteroController version: " + Program.appversion);
                }
            }
            else
            {
                string timestamp = DateTime.Now.ToString("yyyy.MM.dd.HH.mm");
                string newLogFileName = $"log-{timestamp}.txt";
                string newLogFilePath = Path.Combine(logPath, newLogFileName);

                int seconds = 0;
                while (File.Exists(newLogFilePath))
                {
                    seconds++;
                    newLogFileName = $"log-{timestamp}.{seconds:00}.txt";
                    newLogFilePath = Path.Combine(logPath, newLogFileName);
                }

                File.Move(logFilePath, newLogFilePath);

                using (StreamWriter writer = File.CreateText(logFilePath))
                {
                    writer.WriteLine(Program.ptasci);
                    writer.WriteLine("This is the log file of PteroController version: " + Program.appversion);
                }
            }
        }
    }
}
