using DiscordRPC.Logging;
using DiscordRPC;

namespace PteroController.Handlers
{
    public class RPCHandler
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
                btns2.Url = "https://github.com/MythicalLTD/PteroController";

                client.SetPresence(new RichPresence()
                {
                    Details = "Using PteroController",
                    State = "A Pterodactyl Panel Desktop App! <3",
                    Assets = new Assets()
                    {
                        LargeImageKey = "logo",
                        LargeImageText = "PteroController",
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
                Console.WriteLine("Failed to load discord rpc: " + ex.Message);
            }
        }
    }
}
