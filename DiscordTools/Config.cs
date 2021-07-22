using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordTools
{
    public static class Config
    {


        public static void A()
        {
            File.Create("name.conf");
            File.Create("webhook.conf");
            File.Create("content.conf");
        }

        public static void yes()
        {
        }
    }
}
