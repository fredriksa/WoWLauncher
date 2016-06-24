using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Launcher
{
    class ServerReader
    {
        public static double version = 1.0;

        public static List<Server> readMultiple(string fileName)
        {
            List<Server> list = new List<Server>();

            using (BinaryReader reader = new BinaryReader(new FileStream(fileName, FileMode.Open)))
            {
                if (!verifyVersion(reader)) return null;

                int maxIterations = reader.ReadInt32();
                for (int i = 0; i < maxIterations; i++)
                {
                    Server server = new Server();

                    server.name = reader.ReadString();
                    server.website = reader.ReadString();
                    server.version = reader.ReadString();
                    server.patchesDirectory = reader.ReadString();
                    server.downloadDirectory = reader.ReadString();
                    server.realmlist = reader.ReadString();
                    server.clientDirectory = reader.ReadString();

                    list.Add(server);
                }
            }

            return list;
        }

        public static Nullable<Server> readSingle(string fileName)
        {
            using (BinaryReader reader = new BinaryReader(new FileStream(fileName, FileMode.Open)))
            {
                if (!verifyVersion(reader)) return null;

                Server server = new Server();
                server.name = reader.ReadString();
                server.website = reader.ReadString();
                server.version = reader.ReadString();
                server.patchesDirectory = reader.ReadString();
                server.downloadDirectory = reader.ReadString();
                server.realmlist = reader.ReadString();
                server.clientDirectory = reader.ReadString();

                return server;
            }

            return null;
        }

        public static bool verifyVersion(BinaryReader reader)
        {
            double serverDataVersion = reader.ReadDouble();

            if (serverDataVersion != version)
            {
                if (serverDataVersion > version)
                    MessageBox.Show($"Error: reader and data version mismatch!\nData supports a newer version of the launcher\nData version: {serverDataVersion} : Reader Version: {version}");
                else if (serverDataVersion < version)
                    MessageBox.Show($"Error: reader and data version mismatch!\nData supports a older version of the launcher\nData version: {serverDataVersion} : Reader Version: {version}");

                return false;
            }

            return true;
        }
    }
}
