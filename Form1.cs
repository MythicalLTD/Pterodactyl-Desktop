using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PteroController
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();
        private Process externalProcess;

        public Form1()
        {
            InitializeComponent();
        }
        private void EmbedExternalApplication()
        {
            string externalAppPath = "C:\\Users\\NaysKutzu\\Documents\\GitHub\\PteroController\\Controller\\bin\\Debug\\net6.0-windows\\PteroConsole.exe";
            externalProcess = new Process();
            externalProcess.StartInfo.FileName = externalAppPath;
            externalProcess.StartInfo.UseShellExecute = false;
            externalProcess.StartInfo.CreateNoWindow = true;

            // Redirect standard input, output, and error streams
            externalProcess.StartInfo.RedirectStandardInput = true;
            externalProcess.StartInfo.RedirectStandardOutput = true;
            externalProcess.StartInfo.RedirectStandardError = true;

            externalProcess.OutputDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    // Write the console output to the console window
                    Console.WriteLine(e.Data);
                }
            };

            externalProcess.ErrorDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    // Write the console error output to the console window
                    Console.Error.WriteLine(e.Data);
                }
            };

            externalProcess.Start();

            // Attach the console window to the form
            AllocConsole();

            // Start reading the standard output and error streams
            externalProcess.BeginOutputReadLine();
            externalProcess.BeginErrorReadLine();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            // Close the external console application and free the console when the form is closed
            if (externalProcess != null && !externalProcess.HasExited)
            {
                externalProcess.CloseMainWindow();
                externalProcess.WaitForExit();
                FreeConsole();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EmbedExternalApplication();
        }
    }
}
