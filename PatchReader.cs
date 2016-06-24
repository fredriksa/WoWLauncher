using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Launcher
{
    class PatchReader
    {
        public static double version = 1.0;

        public static List<Patch> readPatches(string fileName)
        {
            List<Patch> patches = new List<Patch>();

            using (BinaryReader reader = new BinaryReader(new FileStream(fileName, FileMode.Open)))
            {
                if (!verifyVersion(reader)) return null;
                int patchesToRead = reader.ReadInt32();

                for (int i = 0; i < patchesToRead; i++)
                {
                    Patch patch = new Patch();

                    patch.fileName = reader.ReadString();
                    int bytesToRead = reader.ReadInt32();
                    patch.md5Hash = reader.ReadBytes(bytesToRead);

                    patches.Add(patch);
                }
            }

            return patches;
        }

        private static bool verifyVersion(BinaryReader reader)
        {
            double serverDataVersion = reader.ReadDouble();

            if (serverDataVersion != version)
            {
                if (serverDataVersion > version)
                    MessageBox.Show($"Error: Patch reader and data version mismatch!\nPatch file supports a newer version of the launcher\nData version: {serverDataVersion} : Reader Version: {version}");
                else if (serverDataVersion < version)
                    MessageBox.Show($"Error: Patch reader and data version mismatch!\nPatch file supports a older version of the launcher\nData version: {serverDataVersion} : Reader Version: {version}");

                return false;
            }

            return true;
        }
    }
}
