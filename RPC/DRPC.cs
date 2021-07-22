//shees

using DiscordRPC;

namespace Nora.RPC
{
    internal class RPC
    {
        public static DiscordRpcClient client;

        public static void InitalizeRPC()
        {
            RPC.client = new DiscordRpcClient("837971230061101138");
            RPC.client.Initialize();
            RPC.SetState("Nora Swapper", false);
        }

        public static void SetState(string state, bool watching)
        {
            string discord = "https://discord.gg/D4jbvAHw";
            if (watching)
            state = "Watching " + state;
            DiscordRpcClient client = RPC.client;
            RichPresence presence = new RichPresence();
            Button[] buttonArray = new Button[1]
            {
        new Button()
        {
          Label = "Discord",
          Url = "https://discord.gg/D4jbvAHw"
        }
            };
            presence.Details = "Nora • 17.10";
            presence.State = "Discord • " + discord;
            presence.Assets = new Assets()
            {
                LargeImageKey = "large",
                LargeImageText = "Nora Swapper • v17.10",
                SmallImageKey = "smallimg",
                SmallImageText = "Made By Storm.#8430"
            };
            presence.Buttons = buttonArray;
            client.SetPresence(presence);
        }
    }
}
