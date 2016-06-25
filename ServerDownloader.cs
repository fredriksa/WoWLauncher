using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Windows.Forms;

namespace Launcher
{
    class ServerDownloader
    {
        private Form1 form;
        private Stopwatch stopWatch;

        private string directoryPath;

        public ServerDownloader(Form1 form)
        {
            this.form = form;
            stopWatch = new Stopwatch();
            stopWatch.Stop();
            directoryPath = string.Empty;
        }

        public void downloadServer(string url, string directoryPath)
        {
            this.directoryPath = directoryPath;

            using (WebClient webClient = new WebClient())
            {
                if (!ResourceHelper.resourceExists(URLFormatter.format(url) + "/server.dat"))
                {
                    MessageBox.Show("Server does not support the launcher's simple setup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                webClient.DownloadProgressChanged += downloadServerProgressChanged;
                webClient.DownloadFileAsync(new System.Uri(URLFormatter.format(url) + "/server.dat"), "server.dat");
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(this.downloadServerCompleted);
                stopWatch.Reset();
                stopWatch.Start();
            }
        }

        private void downloadServerProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            form.progressBar.Value = e.ProgressPercentage;
            form.downloadStatusLabel.Text = $"{e.BytesReceived / 1024f}Kb / {e.TotalBytesToReceive / 1024f}Kb @ {(e.BytesReceived / 1024d / stopWatch.Elapsed.TotalSeconds).ToString("0.00")} Kb/s Downloaded";
        }

        public void downloadServerCompleted(object sender, AsyncCompletedEventArgs e)
        {
            form.downloadStatusLabel.Text = "Status: Download complete";
            form.progressBar.Value = 0;

            WebClient client = (WebClient)sender;
            client.CancelAsync();
            client.Dispose();

            form.addServer("server.dat", directoryPath);
            stopWatch.Stop();
        }
    }
}
