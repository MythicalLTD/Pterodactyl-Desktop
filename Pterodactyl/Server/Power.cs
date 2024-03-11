using Pterodactyl.Forms;
using Pterodactyl.Handlers;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pterodactyl.Pterodactyl.Server
{
    public static class Power
    {
        public static void Start(string serverIdentifier)
        {
            try
            {
                var client = new RestClient(Pterodactyl.User.Info.panel_url);
                var request = new RestRequest($"/api/client/servers/{serverIdentifier}/power", Method.Post);
                request.AddHeader("Authorization", $"Bearer {Pterodactyl.User.Info.panel_api_key}");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "Application/vnd.pterodactyl.v1+json");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.93 Safari/537.36");
                request.AddParameter("application/json", "{ \"signal\": \"start\" }", ParameterType.RequestBody);
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    Program.Alert("Server is starting", FrmAlert.enmType.Succes);
                }
                else
                {
                    Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + response.Content);
                    Program.Alert("Failed to start the server", FrmAlert.enmType.Warning);
                }
            }
            catch (Exception ex)
            {
                ProblemHandler.Warning("FrmServerController", ex.ToString());
                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + ex.ToString());
                Program.Alert("Failed to start the server", FrmAlert.enmType.Warning);
            }
        }

        public static void Stop(string serverIdentifier)
        {
            try
            {
                var client = new RestClient(Pterodactyl.User.Info.panel_url);
                var request = new RestRequest($"/api/client/servers/{serverIdentifier}/power", Method.Post);
                request.AddHeader("Authorization", $"Bearer {Pterodactyl.User.Info.panel_api_key}");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "Application/vnd.pterodactyl.v1+json");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.93 Safari/537.36");
                request.AddParameter("application/json", "{ \"signal\": \"stop\" }", ParameterType.RequestBody);
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    Program.Alert("Server is stopping", FrmAlert.enmType.Succes);
                }
                else
                {
                    Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + response.Content);
                    Program.Alert("Failed to stop the server", FrmAlert.enmType.Warning);
                }
            }
            catch (Exception ex)
            {
                ProblemHandler.Warning("FrmServerController", ex.ToString());
                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + ex.ToString());
                Program.Alert("Failed to stop the server", FrmAlert.enmType.Warning);
            }
        }

        public static void Kill(string serverIdentifier)
        {
            try
            {
                var client = new RestClient(Pterodactyl.User.Info.panel_url);
                var request = new RestRequest($"/api/client/servers/{serverIdentifier}/power", Method.Post);
                request.AddHeader("Authorization", $"Bearer {Pterodactyl.User.Info.panel_api_key}");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "Application/vnd.pterodactyl.v1+json");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.93 Safari/537.36");
                request.AddParameter("application/json", "{ \"signal\": \"kill\" }", ParameterType.RequestBody);
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    Program.Alert("Server killed", FrmAlert.enmType.Succes);
                }
                else
                {

                    Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + response.Content);
                    Program.Alert("Failed to kill the server", FrmAlert.enmType.Warning);
                }
            }
            catch (Exception ex)
            {
                ProblemHandler.Warning("FrmServerController", ex.ToString());
                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + ex.ToString());
                Program.Alert("Failed to kill the server", FrmAlert.enmType.Warning);
            }
        }

        public static void Restart(string serverIdentifier)
        {
            try
            {
                var client = new RestClient(Pterodactyl.User.Info.panel_url);
                var request = new RestRequest($"/api/client/servers/{serverIdentifier}/power", Method.Post);
                request.AddHeader("Authorization", $"Bearer {Pterodactyl.User.Info.panel_api_key}");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "Application/vnd.pterodactyl.v1+json");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.93 Safari/537.36");
                request.AddParameter("application/json", "{ \"signal\": \"restart\" }", ParameterType.RequestBody);
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    Program.Alert("Server is restarting", FrmAlert.enmType.Succes);
                }
                else
                {
                    Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + response.Content);
                    Program.Alert("Failed to restart the server", FrmAlert.enmType.Warning);
                }
            }
            catch (Exception ex)
            {
                ProblemHandler.Warning("FrmServerController", ex.ToString());
                Program.logger.Log(Managers.LogType.Error, "[Forms.FrmServerController.cs]: \n" + ex.ToString());
                Program.Alert("Failed to start the server", FrmAlert.enmType.Warning);
            }
        }
    }
}
