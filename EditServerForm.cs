using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class EditServerForm : Form
    {
        private Form1 form;

        private string directoryPath;
        private Dictionary<string, string> versionComboItems = new Dictionary<string, string>();

        public EditServerForm(Form1 form)
        {
            InitializeComponent();

            this.form = form;
            directoryPath = string.Empty;

            versionComboItems.Add("1", "Vanilla");
            versionComboItems.Add("2", "The Burning Crusade");
            versionComboItems.Add("3", "Wrath of the Lich King");

            versionCombo.DataSource = new BindingSource(versionComboItems, null);
            versionCombo.DisplayMember = "Value";
            versionCombo.ValueMember = "Key";
        }

        private void selectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                directoryPath = fbd.SelectedPath;
                clientDirField.Text = directoryPath;
            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (ApplicationStatus.downloading)
            {
                MessageBox.Show("You can't edit the server while downloading!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nameField.Text == string.Empty)
            {
                MessageBox.Show("You must enter the server's name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (websiteField.Text == string.Empty)
            {
                MessageBox.Show("You must enter a website!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (realmlistField.Text == string.Empty)
            {
                MessageBox.Show("You must enter a realmlist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            directoryPath = clientDirField.Text;
            if (directoryPath == string.Empty)
            {
                MessageBox.Show("You must select a client directory!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Server server = new Server();
            Server activeServer = (Server)ApplicationStatus.activeServer;

            server.name = nameField.Text;
            server.website = websiteField.Text;
            server.version = VersionHelper.toVersion(((KeyValuePair<string, string>)versionCombo.SelectedItem).Value).ToString();
            server.patchesDirectory = activeServer.patchesDirectory;
            server.downloadDirectory = activeServer.downloadDirectory;
            server.realmlist = realmlistField.Text;
            server.clientDirectory = directoryPath;
            server.locale = ClientHelper.localeVersion(server);

            form.serverContainer.removeServer(activeServer.name);
            form.addServer(server);
            form.updateServerList();
            this.Close();
        }

        private void EditServerForm_Load(object sender, EventArgs e)
        {
            Server activeServer = (Server)ApplicationStatus.activeServer;

            nameField.Text = activeServer.name;
            websiteField.Text = activeServer.website;
            versionCombo.SelectedIndex = selectedIndex(activeServer);
            realmlistField.Text = activeServer.realmlist;
            clientDirField.Text = activeServer.clientDirectory;
        }

        private int selectedIndex(Server server)
        {
            switch (server.version)
            {
                case "Vanilla":
                    return 0;
                    break;
                case "TBC":
                    return 1;
                    break;
                case "WOTLK":
                    return 2;
                    break;
                default:
                    return -1;
                    break;
            }
        }
    }
}
