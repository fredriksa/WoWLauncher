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
    public partial class AddCustomServerForm : Form
    {
        private Form1 form;
        private AddServerForm addServerForm;

        private Dictionary<string, string> versionComboItems = new Dictionary<string, string>();
        private string directoryPath;

        public AddCustomServerForm(Form1 form, AddServerForm addServerForm)
        {
            InitializeComponent();

            this.addServerForm = addServerForm;
            this.form = form;

            directoryPath = string.Empty;

            versionComboItems.Add("1", "Vanilla");
            versionComboItems.Add("2", "The Burning Crusade");
            versionComboItems.Add("3", "Wrath of the Lich King");

            versionCombo.DataSource = new BindingSource(versionComboItems, null);
            versionCombo.DisplayMember = "Value";
            versionCombo.ValueMember = "Key";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameField.Text == string.Empty || websiteField.Text == string.Empty)
                return;

            if (realmlistField.Text == string.Empty || directoryPath == string.Empty)
                return;

            Server server = new Server();

            server.name = nameField.Text;
            server.website = websiteField.Text;
            server.version = VersionHelper.toVersion(((KeyValuePair<string, string>)versionCombo.SelectedItem).Value).ToString();
            server.patchesDirectory = string.Empty;
            server.downloadDirectory = string.Empty;
            server.realmlist = realmlistField.Text;

            form.addServer(server);
            addServerForm.Close();
        }

        private void selectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                directoryPath = fbd.SelectedPath;
        }

        private void AddCustomServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            addServerForm.customServerForm = null;
        }

    }
}
