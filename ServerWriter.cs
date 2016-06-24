using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Launcher
{
    class ServerWriter
    {
        public static double version = 1.0;

        public static void write(List<Server> servers, string fileName)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(version);
                writer.Write(servers.Count);
            }

            foreach (Server server in servers)
                write(server, fileName);
        }

        public static void write(Server server, string fileName)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Append)))
            {
                writer.Write(server.name);
                writer.Write(server.website);
                writer.Write(server.version);
                writer.Write(server.patchesDirectory == null ? string.Empty : server.patchesDirectory);
                writer.Write(server.downloadDirectory == null ? string.Empty : server.downloadDirectory);
                writer.Write(server.realmlist);
                writer.Write(server.clientDirectory);
            }
        }
    }
}
