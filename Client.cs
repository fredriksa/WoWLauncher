using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Launcher
{
    class Client
    {
        public static void updateRealmlist(string realmlist, string directoryPath)
        {
            string realmlistPath = directoryPath + "/data/realmlist.wtf";
            if (!File.Exists(realmlistPath)) return;

            File.Delete(realmlistPath);

            using (StreamWriter file = new StreamWriter(realmlistPath, true))
            {
                file.WriteLine(realmlist);
            }
        }

        public static void clearCache(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                DirectoryHelper.clearDirectory(directoryPath);
                MessageBox.Show("Cache has been cleared");
            }
            else
            {
                MessageBox.Show("Cache folder doesn't exist");
            }
        }
    }
}
