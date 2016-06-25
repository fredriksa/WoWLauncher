namespace Launcher
{
    partial class EditServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditServerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.websiteField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.realmlistField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clientDirField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.selectDirectoryButton = new System.Windows.Forms.Button();
            this.versionCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(80, 19);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(192, 20);
            this.nameField.TabIndex = 1;
            // 
            // websiteField
            // 
            this.websiteField.Location = new System.Drawing.Point(80, 55);
            this.websiteField.Name = "websiteField";
            this.websiteField.Size = new System.Drawing.Size(192, 20);
            this.websiteField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Website";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Version";
            // 
            // realmlistField
            // 
            this.realmlistField.Location = new System.Drawing.Point(80, 134);
            this.realmlistField.Name = "realmlistField";
            this.realmlistField.Size = new System.Drawing.Size(192, 20);
            this.realmlistField.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Realmlist";
            // 
            // clientDirField
            // 
            this.clientDirField.Location = new System.Drawing.Point(80, 173);
            this.clientDirField.Name = "clientDirField";
            this.clientDirField.Size = new System.Drawing.Size(192, 20);
            this.clientDirField.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Client Dir";
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(16, 250);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(259, 23);
            this.saveChangesButton.TabIndex = 7;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // selectDirectoryButton
            // 
            this.selectDirectoryButton.Location = new System.Drawing.Point(16, 209);
            this.selectDirectoryButton.Name = "selectDirectoryButton";
            this.selectDirectoryButton.Size = new System.Drawing.Size(259, 23);
            this.selectDirectoryButton.TabIndex = 6;
            this.selectDirectoryButton.Text = "Select WoW Directory";
            this.selectDirectoryButton.UseVisualStyleBackColor = true;
            this.selectDirectoryButton.Click += new System.EventHandler(this.selectDirectory_Click);
            // 
            // versionCombo
            // 
            this.versionCombo.FormattingEnabled = true;
            this.versionCombo.Location = new System.Drawing.Point(80, 92);
            this.versionCombo.Name = "versionCombo";
            this.versionCombo.Size = new System.Drawing.Size(190, 21);
            this.versionCombo.TabIndex = 3;
            // 
            // EditServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 285);
            this.Controls.Add(this.selectDirectoryButton);
            this.Controls.Add(this.versionCombo);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.clientDirField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.realmlistField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.websiteField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditServerForm";
            this.Text = "Edit Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditServerForm_FormClosing);
            this.Load += new System.EventHandler(this.EditServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox websiteField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox realmlistField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clientDirField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button selectDirectoryButton;
        private System.Windows.Forms.ComboBox versionCombo;
    }
}