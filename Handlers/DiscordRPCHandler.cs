using DiscordRPC.Logging;
using DiscordRPC;

namespace Pterodactyl.Handlers
{
    public class DiscordRPCHandler
    {
        public DiscordRpcClient? client;

        public void InitializeRPC()
        {
            try
            {
                client = new DiscordRpcClient("1114229771426078790");
                client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
                client.OnReady += (sender, e) =>
                {
                };
                client.OnPresenceUpdate += (sender, e) =>
                {
                };
                client.Initialize();

                DiscordRPC.Button btns = new DiscordRPC.Button();
                DiscordRPC.Button btns2 = new DiscordRPC.Button();
                btns.Label = "Pterodactyl";
                btns.Url = "https://pterodactyl.io";
                btns2.Label = "Download app";
                btns2.Url = "https://github.com/MythicalLTD/Pterodactyl";

                client.SetPresence(new RichPresence()
                {
                    Details = "Using Pterodactyl",
                    State = "A Pterodactyl Panel Desktop App! <3",
                    Assets = new Assets()
                    {
                        LargeImageKey = "logo",
                        LargeImageText = "Pterodactyl",
                    },
                    Buttons = new DiscordRPC.Button[]
                    {
                        btns,
                        btns2
                    },
                });
            }
            catch (Exception ex)
            {
                Program.logger.Log(Managers.LogType.Error, "[Handlers.DiscordRPCHandler.cs]: \n" + ex.Message);
            }
        }
    }
}
