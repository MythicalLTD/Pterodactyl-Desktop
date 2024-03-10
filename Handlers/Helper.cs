using Newtonsoft.Json.Linq;
using Pterodactyl.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pterodactyl.Handlers
{
    public static class Helper
    {
        public static void StartWinSCP(string serverIdentifier, string sftp_ip, string sftp_port)
        {
            try
            {
                if (File.Exists(Application.StartupPath + @"\WinSCP.exe"))
                {
                    string command = Application.StartupPath + @"\WinSCP.exe";
                    string arguments = @"sftp://" + Pterodactyl.User.Info.panel_username + "." + serverIdentifier + ":" + Pterodactyl.User.Info.panel_password + "@" + sftp_ip + ":" + sftp_port + "";
                    ProcessStartInfo processInfo = new ProcessStartInfo(command, arguments);
                    processInfo.RedirectStandardOutput = true;
                    processInfo.UseShellExecute = false;

                    Process process = Process.Start(processInfo);
                }
                else
                {
                    Program.Alert("WinSCP missing please reinstall", FrmAlert.enmType.Error);
                }
            }
            catch (Exception ex)
            {
                ProblemHandler.Error("FrmServerController", ex.ToString());
                Program.Alert("WinSCP failed to start", FrmAlert.enmType.Error);
                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + ex.ToString());
            }
        }

        public static void StartPterodactylConsole(string serverIdentifier) 
        {
            try
            {
                if (File.Exists(Application.StartupPath + @"\PteroConsole.exe"))
                {
                    string executablePath = "PteroConsole.exe";
                    string arguments = $"{Pterodactyl.User.Info.panel_url} {Pterodactyl.User.Info.panel_api_key} {serverIdentifier}";

                    Process process = new Process();
                    process.StartInfo.FileName = executablePath;
                    process.StartInfo.Arguments = arguments;
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.CreateNoWindow = false;
                    process.Start();
                }
                else
                {
                    Program.Alert("PteroConsole is missing please reinstall", FrmAlert.enmType.Error);
                }
            }
            catch (Exception ex)
            {
                ProblemHandler.Error("FrmServerController", ex.ToString());
                Program.Alert("Failed to start console", FrmAlert.enmType.Error);
                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + ex.ToString());
            }
        }

       
    }
}
