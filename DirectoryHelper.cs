using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Launcher
{
    class DirectoryHelper
    {
        public static void clearDirectory(string directoryPath)
        {
            DirectoryInfo dir = new DirectoryInfo(directoryPath);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                clearDirectory(di.FullName);
                di.Delete();
            }
        }
    }
}
