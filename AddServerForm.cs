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
    public partial class AddServerForm : Form
    {
        private Form1 form;

        public AddSimpleServerForm simpleServerForm;
        public AddCustomServerForm customServerForm;

        public AddServerForm(Form1 form)
        {
            InitializeComponent();

            this.form = form;

            simpleServerForm = new AddSimpleServerForm(form, this);
            customServerForm = new AddCustomServerForm(form, this);
        }

        private void AddServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.addServerForm = null;

            if (simpleServerForm != null)
                simpleServerForm.Close();

            if (customServerForm != null)
                customServerForm.Close();
        }

        private void fastSetupButton_Click(object sender, EventArgs e)
        {
            if (simpleServerForm == null)
                simpleServerForm = new AddSimpleServerForm(form, this);

            if (!simpleServerForm.Visible)
                simpleServerForm.Show();
        }

        private void customSetupButton_Click(object sender, EventArgs e)
        {
            if (customServerForm == null)
                customServerForm = new AddCustomServerForm(form, this);

            if (!customServerForm.Visible)
                customServerForm.Show();
        }
    }
}
