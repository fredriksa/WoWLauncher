using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class AddSimpleServerForm : Form
    {
        private Form1 form;
        private AddServerForm addServerForm;
        private string directoryPath;

        public AddSimpleServerForm(Form1 form, AddServerForm addServerForm)
        {
            InitializeComponent();

            this.form = form;
            this.addServerForm = addServerForm;

            directoryPath = string.Empty;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (directoryPath == string.Empty || websiteField.Text == string.Empty)
                return;

            ServerDownloader downloader = new ServerDownloader(form);
            downloader.downloadServer(websiteField.Text);
            addServerForm.Close();
            this.Close();
        }

        private void AddSimpleServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            addServerForm.simpleServerForm = null;
        }

        private void selectDirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
               directoryPath = fbd.SelectedPath;
        }
    }
}
