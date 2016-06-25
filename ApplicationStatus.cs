using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    class ApplicationStatus
    {
        public static Server? activeServer;
        public static Server? oldServer;
        public static bool downloading = false;

        public static void updateActiveServer(Server server)
        {
            if (activeServer != null)
               oldServer = activeServer;

            activeServer = server;
        }
    }
}
