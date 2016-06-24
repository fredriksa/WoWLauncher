using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Launcher
{
    class ClientHelper
    {
        public static string realmlistPath(Server server)
        {
            switch (server.version)
            {
                case "VANILLA":
                case "TBC":
                    return server.clientDirectory + "/realmlist.wtf";
                    break;
                case "WOTLK":
                    return server.clientDirectory + "/Data/realmlist.wtf";
                    break;
            }

            return null;
        }

        public static string cacheFolderPath(Server server)
        {
            switch (server.version)
            {
                case "VANILLA":
                    return server.clientDirectory + "/WDB";
                    break;
                case "TBC":
                case "WOTLK":
                    return server.clientDirectory + "/Cache";
                    break;
            }

            return null;
        }

        public static string localeVersion(Server server)
        {
            if (server.version == "VANILLA")
                return "default";

            string[] locales = { "frFr", "deDE", "enGB", "enUS", "itIT", "koKR", "zhCN", "zhTW", "ruRU", "esES", "esMX", "ptBR" };

            foreach (string locale in locales)
                if (Directory.Exists($"{server.clientDirectory}/Data/{locale}"))
                    return locale;

            return string.Empty;
        }
    }
}
