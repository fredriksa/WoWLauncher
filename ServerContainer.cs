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
            Server? server = ServerReader.readSingle(file);

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
            Server? server = ServerReader.readSingle(file);

            if (server == null) return;

            Server srv = (Server)server;
            srv.clientDirectory = directoryPath;
            srv.locale = ClientHelper.localeVersion(srv);
            Console.WriteLine($"Locale: {srv.locale}");
            servers.Add(srv);
            form.updateServerList();
        }

        public void addServers(List<Server> _servers)
        {
            servers.AddRange(_servers);
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

        public void updateStatus(Server _server, string status)
        {
            Server? target = null;

            foreach (Server server in servers)
                if (server.name == _server.name)
                    target = server;

            if (target == null) return;

            Server trgt = (Server)target;

            servers.Remove(trgt);
            trgt.status = status;
            servers.Add(trgt);
        }

        public List<Server> getServers() { return servers; }
        public void setServers(List<Server> servers) { this.servers = servers;  }
    }
}
