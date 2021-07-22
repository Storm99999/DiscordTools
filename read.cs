using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordTools
{
    public static class read
    {
        public static string webHookUrl = File.ReadAllText("webhook.conf");
        public static string webHookText = File.ReadAllText("content.conf");
        public static string webHookName = File.ReadAllText("name.conf");
    }
}
