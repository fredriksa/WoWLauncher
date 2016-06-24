using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
