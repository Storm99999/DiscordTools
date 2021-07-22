using System;
using System.Linq;
using System.Threading;
using System.IO;
using System.Diagnostics;
using DiscordRPC;
using System.Collections.Specialized;
using System.Net;

namespace DiscordTools
{
    class Program
    {
        static string generated { get; set; }
        static void Main()
        {
            if (File.Exists("content.conf"))
            {

            }
            else
            {
                wc.DownloadFile("https://cdn.discordapp.com/attachments/807905560657395752/867033607313948672/content.conf", Environment.CurrentDirectory + "/content.conf");
            }

            if (File.Exists("name.conf"))
            {

            }
            else
            {
                wc.DownloadFile("https://cdn.discordapp.com/attachments/807905560657395752/867033608089632789/name.conf", Environment.CurrentDirectory + "/name.conf");
            }

            if (File.Exists("webhook.conf"))
            {

            }
            else
            {
                wc.DownloadFile("https://cdn.discordapp.com/attachments/807905560657395752/867033609433120798/webhook.conf", Environment.CurrentDirectory + "/webhook.conf");
            }
            RPC.InitalizeRPC();
            long codes;
            Console.Title = "Discord Tools | By Storm.#0120";
            start: Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Discord Tools | By Storm.#0120");
            Console.WriteLine("");
            Console.WriteLine("[1] Nitro Generator\n\n[2] Nitro Checker\n\n[3] Start Discord\n\n[4] Kill Discord\n\n[5] Webhook Spammer");
            var keyInput = Console.ReadLine();
            if (keyInput == "1")
            {
                RPC.client.UpdateDetails("Generating Nitro");
                Console.WriteLine("How many Nitro Codes do you want to generate? [>]");
                try
                {
                    codes = Convert.ToInt64(Console.ReadLine());
                }
                catch
                {
                    goto start;
                }

                Console.WriteLine("Generating Discord Nitro Codes, Do not exit!");
                for (long i = codes; ; i--)
                {

                    Console.Title = "Discord Tools | " + i + "/" + codes + " Left";
                    generated += "https://discord.gift/" + RandomString(24) + Environment.NewLine;
                    if (i == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Finishing..");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Thread.Sleep(3000);
                        Console.WriteLine("Done!");
                        WriteOut();
                        Console.ReadKey();
                        break;
                    }
                }
            }
            else if (keyInput == "2")
            {
                Console.WriteLine("Enter an gift link [>] ");
                var giftLink = Console.ReadLine();
                Process.Start(giftLink);
                Console.ReadLine();
            }
            else if (keyInput == "3")
            {
                Process.Start($@"C:\Users\{Environment.UserName}\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Discord Inc\Discord.lnk");
                Console.WriteLine("Starting Discord Status: [100%]");
                Console.ReadLine();
            }
            else if (keyInput == "4")
            {
                ProcessK.Kill("discord", null);
            }
            else if (keyInput == "5")
            {
                if (read.webHookUrl == "")
                {
                    Console.WriteLine("Enter the webhook url [>] ");
                    var hookUrl = Console.ReadLine();
                    Console.WriteLine("Enter the content you want to spam [>] ");
                    var text = Console.ReadLine();
                    Console.WriteLine("Enter the name of the Webhook [>] ");
                    var Name = Console.ReadLine();
                    Console.WriteLine("Do you want to save the settings you choosed? y/n");
                    var input = Console.ReadLine().ToLower();
                    if (input == "y")
                    {
                        using (StreamWriter sw = new StreamWriter("name.conf"))
                        {
                            sw.BaseStream.Seek(0, SeekOrigin.Begin);
                            sw.Write(Name);
                        }
                        using (StreamWriter sw = new StreamWriter("webhook.conf"))
                        {
                            sw.BaseStream.Seek(0, SeekOrigin.Begin);
                            sw.Write(hookUrl);
                        }
                        using (StreamWriter sw = new StreamWriter("content.conf"))
                        {
                            sw.BaseStream.Seek(0, SeekOrigin.Begin);
                            sw.Write(text);
                        }
                    }
                    else if (input == "n")
                    {
                        
                    }
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Thread.Sleep(2000);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Thread.Sleep(2000);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Thread.Sleep(2000);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Thread.Sleep(2000);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Thread.Sleep(2000);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Thread.Sleep(2000);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Thread.Sleep(2000);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Thread.Sleep(2000);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Thread.Sleep(2000);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Thread.Sleep(2000);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Thread.Sleep(2000);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Thread.Sleep(2000);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Thread.Sleep(2000);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Thread.Sleep(3234);
                    Send(hookUrl, text, Name);
                    Send(hookUrl, text, Name);
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Saved settings found! \n\n Do you want to load them? y/n");
                    var input = Console.ReadLine().ToLower();
                    if (input == "y")
                    {
                        Send(read.webHookUrl, read.webHookText, read.webHookName);
                    }
                    else
                    {
                        Console.WriteLine("Enter the webhook url [>] ");
                        var hookUrl = Console.ReadLine();
                        Console.WriteLine("Enter the content you want to spam [>] ");
                        var text = Console.ReadLine();
                        Console.WriteLine("Enter the name of the Webhook [>] ");
                         var Name = Console.ReadLine();
                         // very messy code, but you can make it better ig
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Thread.Sleep(2000);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Thread.Sleep(2000);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Thread.Sleep(2000);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Thread.Sleep(2000);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Thread.Sleep(2000);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Thread.Sleep(2000);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Thread.Sleep(2000);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Thread.Sleep(2000);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Thread.Sleep(2000);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Thread.Sleep(4000);
                        Send(hookUrl, text, Name);
                        Thread.Sleep(2000);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Thread.Sleep(2000);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Thread.Sleep(2000);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Thread.Sleep(2000);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Thread.Sleep(2000);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Send(hookUrl, text, Name);
                        Thread.Sleep(2032);
                    }
                }
            }
        }

        static void WriteOut()
        {
            while (true)
            {
                using (StreamWriter stream = new StreamWriter("codes.txt"))
                {
                    stream.Write(generated);
                }
                Thread.Sleep(3000);
            }
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            // credits to kye right there I forgot to put "return new" xD
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    class ProcessK
    {
        public static void Kill(string procName, string notes)
        {
            foreach (var proc in Process.GetProcessesByName(procName)) {
                proc.Kill();
            }

            if (notes == null)
            {

            }else
            {
                Console.WriteLine(notes);
            }
        }
    }

    internal class RPC
    {
        public static DiscordRpcClient client;

        public static void InitalizeRPC()
        {
            RPC.client = new DiscordRpcClient("866686321971560468");
            RPC.client.Initialize();
            RPC.SetState("DiscTools", true);
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
            presence.Details = "Using Tools";
            presence.State = "Discord • " + discord;
            presence.Assets = new Assets()
            {
                LargeImageKey = "nitrob",
                LargeImageText = "DiscTools",
                SmallImageKey = "nitros",
                SmallImageText = "Made By Storm.#0120"
            };
            presence.Buttons = buttonArray;
            client.SetPresence(presence);
        }
    }

    public static void Send(string Url, string msg, string Username) {
        Http.Post(Url, new System.Collections.Specialized.NameValueCollection()
        {
            {
                "username",
                Username
            },
            {
                "content",
                msg
            }
        });
         
    }

        public static WebClient wc = new WebClient();
    class Http {
        public static byte[] Post(string uri, NameValueCollection pairs)
        {
            // we use UploadValues because we basically upload a message to the discord database '_'
                return wc.UploadValues(uri, pairs);
        }
    }
  }
}