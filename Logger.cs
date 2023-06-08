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
            RedirectConsoleOutput();
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
                    writer.WriteLine("Welcome");
                }
            }
        }


        private void RedirectConsoleOutput()
        {
            string logFilePath = Path.Combine(logPath, logFileName);
            logWriter = new StreamWriter(logFilePath, true);
            logWriter.AutoFlush = true;

            originalOutput = Console.Out;
            TeeTextWriter teeWriter = new TeeTextWriter(logWriter, originalOutput);
            Console.SetOut(teeWriter);
        }

        public void WriteLog(string msg)
        {
            Console.WriteLine(msg);
        }
        public void Close()
        {
            logWriter?.Dispose();
            Console.SetOut(originalOutput); 
        }
        private class TeeTextWriter : TextWriter
        {
            private TextWriter[] writers;

            public TeeTextWriter(params TextWriter[] writers)
            {
                this.writers = writers;
            }

            public override Encoding Encoding => writers[0].Encoding;

            public override void Write(char value)
            {
                foreach (var writer in writers)
                {
                    writer.Write(value);
                }
            }

            public override void Write(string value)
            {
                foreach (var writer in writers)
                {
                    writer.Write(value);
                }
            }
        }
    }
}
