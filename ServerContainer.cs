using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public class ServerContainer
    {
        private List<Server> servers = new List<Server>();
        private Form1 form;

        public ServerContainer(Form1 form)
        {
            this.form = form;
        }

        public void addServer(Server server)
        {
            servers.Add(server);
            form.updateServerList();
        }

        public void addServer(string file)
        {
            ServerReader reader = new ServerReader();
            Server? server = reader.read(file);

            if (server == null)
            {
                Console.WriteLine("COULD NOT LOAD SERVER");
                return;
            }

            servers.Add((Server) server);
            form.updateServerList();
        }

        public void addServer(string file, string directoryPath)
        {
            ServerReader reader = new ServerReader();
            Server? server = reader.read(file);

            if (server == null)
            {
                Console.WriteLine("COULD NOT LOAD SERVER");
                return;
            }

            Server srv = (Server)server;
            srv.clientDirectory = directoryPath;
            servers.Add(srv);
            form.updateServerList();
        }

        public void removeServer(string serverName)
        {
            Server? removeTarget = null;

            foreach (Server server in servers)
                if (server.name == serverName)
                    removeTarget = server;

            if (removeTarget != null)
                servers.Remove((Server)removeTarget);
        }

        public Nullable<Server> getServerByName(string name)
        {
            foreach (Server server in servers)
                if (server.name == name)
                    return server;

            return null;
        }

        public List<Server> getServers() { return servers; }
    }
}
