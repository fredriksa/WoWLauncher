using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using System.ComponentModel;

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
                if (!resourceExists(URLFormatter.format(url) + "/server.dat"))
                {
                    form.downloadStatusLabel.Text = "Server does not support the launcher's simple setup";
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
            form.downloadStatusLabel.Text = "Download complete";
            form.progressBar.Value = 0;

            WebClient client = (WebClient)sender;
            client.CancelAsync();
            client.Dispose();

            form.addServer("server.dat", directoryPath);
            stopWatch.Stop();
        }

        private bool resourceExists(string url)
        {
            HttpWebResponse response = null;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "HEAD";

            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                return false;
            }
            finally
            {
                if (response != null)
                    response.Close();
            }

            return true;
        }
    }
}
