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
            if (websiteField.Text == string.Empty)
            {
                MessageBox.Show("You must enter a website!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (directoryPath == string.Empty)
            {
                MessageBox.Show("You must select a directory!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ServerDownloader downloader = new ServerDownloader(form);
            downloader.downloadServer(websiteField.Text, directoryPath);
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
