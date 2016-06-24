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
        public static Server? lastActiveServer;
        public static bool downloading = false;

        public static void updateActiveServer(Server server)
        {
            if (activeServer != null)
                lastActiveServer = activeServer;

            activeServer = server;
        }
    }
}
