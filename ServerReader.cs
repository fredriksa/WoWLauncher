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
        private double formVersion = 1.0;

        public Nullable<Server> read(string fileName)
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

        private bool verifyVersion(BinaryReader reader)
        {
            double serverDataVersion = reader.ReadDouble();

            if (serverDataVersion != formVersion)
            {
                if (serverDataVersion > formVersion)
                    MessageBox.Show("Error: server reader and server data version mismatch!\nServer data supports a later version of the launcher");
                else if (serverDataVersion < formVersion)
                    MessageBox.Show("Error: server reader and server data version mismatch!\nServer data supports a older version of the launcher");

                return false;
            }

            return true;
        }
    }
}
