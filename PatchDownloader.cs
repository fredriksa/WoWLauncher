using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;

namespace Launcher
{
    class PatchDownloader
    {
        private Form1 form;
        private Stopwatch stopWatch = new Stopwatch();

        private string directoryPath;

        private Server serverToDownload;
        private List<Patch> patchesToDownload;

        public PatchDownloader(Form1 form)
        {
            this.form = form;
            directoryPath = string.Empty;
        }

        public void patch(Server server)
        {
            serverToDownload = server;

            using (WebClient webClient = new WebClient())
            {
                string patchFileURL = URLFormatter.format($"{server.downloadDirectory}/patchfile.dat");

                if (server.downloadDirectory == string.Empty || server.patchesDirectory == string.Empty ||
                    !ResourceHelper.resourceExists(patchFileURL))
                {
                    form.downloadStatusLabel.Text = "Status: Server does not support the launcher's patcher";
                    return;
                }

                webClient.DownloadProgressChanged += downloadPatchProgressChanged;
                webClient.DownloadFileAsync(new System.Uri(patchFileURL), "patchfile.dat");
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(this.downloadPatchFileCompleted);
            }
        }

        public void downloadPatches(List<Patch> patches)
        {
            patchesToDownload = patches;
            downloadPatch(patchesToDownload[0]);
        }

        public void downloadPatch(Patch patch)
        {
            string downloadURL = URLFormatter.format($"{serverToDownload.downloadDirectory}/");
            using (WebClient webClient = new WebClient())
            {
                string patchDownloadURL = downloadURL + patch.fileName;
                if (!ResourceHelper.resourceExists(patchDownloadURL))
                {
                    form.downloadStatusLabel.Text = $"Status: Could not download {patch.fileName} - It does not exist";
                    return;
                }

                webClient.DownloadProgressChanged += downloadPatchProgressChanged;
                webClient.DownloadFileAsync(new System.Uri(patchDownloadURL), $"{serverToDownload.clientDirectory}/Data/{patch.fileName}");
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(this.downloadPatchCompleted);
                stopWatch.Start();

                patchesToDownload.Remove(patch);
            }
        }

        private void downloadPatchProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            form.progressBar.Value = e.ProgressPercentage;
            form.downloadStatusLabel.Text = $"{(e.BytesReceived / 1024f / 1024f).ToString("0.0")}Mb / {(e.TotalBytesToReceive / 1024f / 1024f).ToString("0.0")}Mb @ {(e.BytesReceived / 1024f / 1024f / stopWatch.Elapsed.TotalSeconds).ToString("0.0")} Mb/s Downloaded";
        }

        public void downloadPatchCompleted(object sender, AsyncCompletedEventArgs e)
        {
            stopWatch.Stop();
            stopWatch.Reset();

            if (patchesToDownload.Count > 0)
            {
                downloadPatch(patchesToDownload[0]);
            }
            else
            {
                form.downloadStatusLabel.Text = "Status: Patching Complete";
                form.progressBar.Value = 0;
            }
        }

        public void downloadPatchFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            form.downloadStatusLabel.Text = "Status: Download complete";
            form.progressBar.Value = 0;

            downloadPatches(PatchReader.readPatches("patchfile.dat"));

            WebClient client = (WebClient)sender;
            client.CancelAsync();
            client.Dispose();
        }
    }
}
