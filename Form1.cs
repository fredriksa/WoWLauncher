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

namespace Launcher
{
    public partial class Form1 : Form
    {
        public string clientDir;
        public ServerContainer serverContainer;

        private Server? selectedServer;
        private Stopwatch stopWatch;
        public AddServerForm addServerForm;

        public Form1()
        {
            InitializeComponent();

            serverContainer = new ServerContainer(this);
            addServerForm = new AddServerForm(this);

            stopWatch = new Stopwatch();
            stopWatch.Stop();

            serverList.View = View.Details;
            serverList.MultiSelect = false;

            int columnWidth = 130;
            serverList.Columns.Add("Name", columnWidth, HorizontalAlignment.Left);
            serverList.Columns.Add("Website", columnWidth, HorizontalAlignment.Left);
            serverList.Columns.Add("Version", columnWidth, HorizontalAlignment.Left);
            serverList.Columns.Add("Realmlist", columnWidth, HorizontalAlignment.Left);
        }

        public void updateServerList()
        {
            serverList.Items.Clear();

            foreach (Server server in serverContainer.getServers())
                serverList.Items.Add(new ListViewItem(new[] { server.name, server.website, server.version, server.realmlist}));
        }

        private void launchgamebtn_Click(object sender, EventArgs e)
        {
            //Process.Start(clientDir + "/Wow.exe");
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
            if (selectedServer == null) return;
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
        }

        private void websiteButton_Click(object sender, EventArgs e)
        {
            if (selectedServer == null) return;
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

            Client.updateRealmlist(srv.realmlist, srv.clientDirectory);
        }

        private void deleteCacheButton_Click(object sender, EventArgs e)
        {
            if (selectedServer == null) return;

            Server server = (Server)selectedServer;
            Client.clearCache(server.clientDirectory + "/Cache");
        }
    }
}
