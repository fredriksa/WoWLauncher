using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Launcher
{
    class PatchDeleter
    {
        public static void delete(Server server)
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

                if (File.Exists(files[i]))
                    File.Delete(files[i]);
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
