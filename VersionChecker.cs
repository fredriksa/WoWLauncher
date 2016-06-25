using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace Launcher
{
    class VersionChecker
    {
        public static bool checkForNewVersion()
        {
            using (var client = new WebClient())
            {
                try
                {
                    if (File.Exists("launcher.version"))
                        File.Delete("launcher.version");

                    string resourceTarget = "http://waloria.com/launcher/launcher.version";
                    if (ResourceHelper.resourceExists(resourceTarget))
                        client.DownloadFile(resourceTarget, "launcher.version");
                }
                catch (Exception e) { }
            }

            if (!File.Exists("launcher.version")) return false;

            string versionString = File.ReadAllText("launcher.version");
            double version = double.Parse(versionString);

            if (Form1.version == version)
                return false;

            using (var client = new WebClient())
            {
                try
                {
                    if (File.Exists("message.version"))
                        File.Delete("message.version");

                    string resourceTarget = "http://waloria.com/launcher/message.version";

                    if (ResourceHelper.resourceExists(resourceTarget))
                        client.DownloadFile(resourceTarget, "message.version");

                } catch (Exception e) { }
            } 

            string messageString = File.ReadAllText("message.version");
            MessageBox.Show(messageString, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (File.Exists("launcher.version"))
                File.Delete("launcher.version");

            if (File.Exists("message.version"))
                File.Delete("message.version");

            return true;
        }
    }
}
