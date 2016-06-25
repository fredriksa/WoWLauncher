using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;

namespace Launcher
{
    public partial class Form1 : Form
    {
        public string clientDir;
        public ServerContainer serverContainer;

        private Server? selectedServer;
        private Timer timer;
        public AddServerForm addServerForm;

        private int pingInterval = 20;

        public Form1()
        {
            InitializeComponent();

            ApplicationStatus.activeServer = null;

            serverContainer = new ServerContainer(this);
            addServerForm = new AddServerForm(this);

            timer = new Timer();
            timer.Interval = pingInterval * 1000;
            timer.Tick += new EventHandler(timerTick);
            timer.Start();

            serverList.View = View.Details;
            serverList.MultiSelect = false;

            int columnWidth = 130;
            serverList.Columns.Add("Name", columnWidth, HorizontalAlignment.Left);
            serverList.Columns.Add("Website", columnWidth, HorizontalAlignment.Left);
            serverList.Columns.Add("Version", columnWidth, HorizontalAlignment.Left);
            serverList.Columns.Add("Status", columnWidth, HorizontalAlignment.Left);
        }

        public void updateServerList()
        {
            serverList.Items.Clear();

            updateStatus();

            foreach (Server server in serverContainer.getServers())
                serverList.Items.Add(new ListViewItem(new[] { server.name, server.website, server.version, server.status}));

            updateStatusColors();
        }

        private void timerTick(object sender, EventArgs e)
        {
            updateStatus();
            updateStatusColors();
        }

        private void addServerButton_Click(object sender, EventArgs e)
        {
            if (addServerForm == null)
                addServerForm = new AddServerForm(this);    

            if (!addServerForm.Visible)
                addServerForm.Show();
        }

        private void deleteServerButton_Click(object sender, EventArgs e)
        {
            if (!isServerSelected()) return;
            Server server = (Server)selectedServer;

            selectedServer = null;
            serverContainer.removeServer(server.name);
            updateServerList();
        }

        public void addServer(string filename)
        {
            serverContainer.addServer("server.dat");
        }

        public void addServer(string filename, string directoryPath)
        {
            serverContainer.addServer(filename, directoryPath);
        }

        public void addServer(Server server)
        {
            serverContainer.addServer(server);
            patch();
        }

        private void websiteButton_Click(object sender, EventArgs e)
        {
            if (!isServerSelected()) return;
            Server server = (Server)selectedServer;

            System.Diagnostics.Process.Start(server.website);
        }

        private void serverList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serverList.SelectedItems.Count <= 0) return;

            ListViewItem selectedItem = serverList.SelectedItems[0];

            if (selectedItem.SubItems.Count <= 0) return;

            string name = selectedItem.SubItems[0].Text;
            if (name == null || name == string.Empty) return;

            Server? server = serverContainer.getServerByName(name);
            if (server == null) return;

            selectedServer = (Server) server;

            Server srv = (Server)server;
            ApplicationStatus.updateActiveServer(srv);
            patch();

            Client.updateRealmlist(srv.clientDirectory, srv);
        }

        private void deleteCacheButton_Click(object sender, EventArgs e)
        {
            if (!isServerSelected()) return;

            Server server = (Server)selectedServer;

            string cacheDirectoryPath = ClientHelper.cacheFolderPath(server);
            if (Directory.Exists(cacheDirectoryPath))
                Client.clearCache(cacheDirectoryPath);
            else
                MessageBox.Show($"Could not find Cache folder!\n{cacheDirectoryPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (!isServerSelected()) return;

            Server server = (Server)selectedServer;
            Client.clearCache(ClientHelper.cacheFolderPath(server));

            Server srv = (Server)selectedServer;

            string executablePath = Path.Combine(srv.clientDirectory, "Wow.exe");
            if (File.Exists(executablePath))
                Process.Start(executablePath);
            else
                MessageBox.Show($"Could not find World of Warcraft executable!\n{executablePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("local_servers.dat"))
            {
                serverContainer.addServers(ServerReader.readMultiple("local_servers.dat"));
                updateServerList();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(serverContainer.getServers().Count > 0)) return;

            ServerWriter.write(serverContainer.getServers(), "local_servers.dat");

            if (ApplicationStatus.activeServer != null)
                PatchMover.moveAway((Server)ApplicationStatus.activeServer);
        }

        private void updateStatus()
        {
            List<Server> servers = serverContainer.getServers();
            List<Server> iterateServers = new List<Server>(servers);

            for (int i = 0; i  < iterateServers.Count; i++)
            {
                Server server = iterateServers[i];

                PingReply reply;
                bool status = false;

                using (Ping ping = new Ping())
                {
                    try
                    {
                        reply = ping.Send(URLFormatter.formatPingUrl(server.realmlist), 15);
                        status = reply.Status == IPStatus.Success;
                    } catch (Exception e){ }
                }

                serverContainer.updateStatus(server, status ? "Online" : "Offline");
            }
        }

        private void updateStatusColors()
        {
            foreach (ListViewItem item in serverList.Items)
            {
                item.UseItemStyleForSubItems = false;
                var subItem = item.SubItems[3];

                if (subItem.Text == "Online")
                    subItem.ForeColor = Color.Green;
                else if (subItem.Text == "Offline")
                    subItem.ForeColor = Color.Red;
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (!isServerSelected()) return;
            Server srv = (Server)selectedServer;

            Process.Start(srv.clientDirectory);
        }

        private void patch()
        {
            playButton.Text = "Downloading";
            playButton.Enabled = false;

            PatchDownloader downloader = new PatchDownloader(this);
            downloader.patch((Server)ApplicationStatus.activeServer);
        }

        private bool isServerSelected()
        {
            if (selectedServer == null)
            {
                MessageBox.Show("You must select a server before continuing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
