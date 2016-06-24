using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Launcher
{
    class PatchMover
    {
        public static void moveAway(Server server)
        {
            string dataDirectory = Path.Combine(server.clientDirectory + "\\Data\\");
            if (!Directory.Exists(dataDirectory)) return;

            string[] files = Directory.GetFiles(dataDirectory);
            string[] whiteList = { "patch.MPQ", "patch-2.MPQ", "patch-3.MPQ", "lichking.MPQ",
                                   "expansion.MPQ", "common.MPQ", "common-2.MPQ"};

            for (int i = 0; i < files.Length; i++)
            {
                if (!Regex.IsMatch(files[i], ".MPQ") && !Regex.IsMatch(files[i], ".mpq"))
                    continue;

                string fileName = Path.GetFileName(files[i]);
                if (shouldPass(fileName, whiteList)) continue;

                string destination = Path.Combine(server.clientDirectory, "ServerData", server.name);
                if (!Directory.Exists(destination)) Directory.CreateDirectory(destination);

                string destinationFile = Path.Combine(destination, fileName);
                if (File.Exists(destinationFile))
                {
                    File.Delete(files[i]);
                    continue;
                }

                try
                {
                    File.Move(files[i], destinationFile);
                } catch (Exception e){ }
                
            }
        }

        public static void moveActive(Server server)
        {
            string serverDirectory = Path.Combine(server.clientDirectory, "ServerData", server.name); 
            if (!Directory.Exists(serverDirectory)) return;

            string[] files = Directory.GetFiles(serverDirectory);
            for (int i = 0; i < files.Length; i++)
            {
                string filePath = files[i];
                string destPath = Path.Combine(server.clientDirectory, "Data", Path.GetFileName(files[i]));
                File.Move(filePath, destPath);
            }   
        }

        private static bool shouldPass(string str, string[] whiteList)
        {
            for (int j = 0; j < whiteList.Length; j++)
                if (str == whiteList[j])
                    return true;

            return false;
        }
    }
}
