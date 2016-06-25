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
                    return Path.Combine(server.clientDirectory, "realmlist.wtf");
                    break;
                case "WOTLK":
                    return Path.Combine(server.clientDirectory, "Data", server.locale, "realmlist.wtf");
                    break;
            }

            return null;
        }

        public static string cacheFolderPath(Server server)
        {
            switch (server.version)
            {
                case "VANILLA":
                    return Path.Combine(server.clientDirectory + "WDB");
                    break;
                case "TBC":
                case "WOTLK":
                    return Path.Combine(server.clientDirectory + "Cache");
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
                if (Directory.Exists(Path.Combine(server.clientDirectory, "Data", locale)))
                    return locale;

            return string.Empty;
        }
    }
}
