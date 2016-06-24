namespace Launcher
{
    partial class AddCustomServerForm
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
            this.versionLabel = new System.Windows.Forms.Label();
            this.versionCombo = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.websiteField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.realmlistLabel = new System.Windows.Forms.Label();
            this.realmlistField = new System.Windows.Forms.TextBox();
            this.selectDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(11, 85);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(42, 13);
            this.versionLabel.TabIndex = 9;
            this.versionLabel.Text = "Version";
            // 
            // versionCombo
            // 
            this.versionCombo.FormattingEnabled = true;
            this.versionCombo.Location = new System.Drawing.Point(81, 82);
            this.versionCombo.Name = "versionCombo";
            this.versionCombo.Size = new System.Drawing.Size(190, 21);
            this.versionCombo.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 199);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(259, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Server";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Website";
            // 
            // websiteField
            // 
            this.websiteField.Location = new System.Drawing.Point(81, 47);
            this.websiteField.Name = "websiteField";
            this.websiteField.Size = new System.Drawing.Size(190, 20);
            this.websiteField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(81, 12);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(190, 20);
            this.nameField.TabIndex = 0;
            // 
            // realmlistLabel
            // 
            this.realmlistLabel.AutoSize = true;
            this.realmlistLabel.Location = new System.Drawing.Point(12, 123);
            this.realmlistLabel.Name = "realmlistLabel";
            this.realmlistLabel.Size = new System.Drawing.Size(49, 13);
            this.realmlistLabel.TabIndex = 13;
            this.realmlistLabel.Text = "Realmlist";
            // 
            // realmlistField
            // 
            this.realmlistField.Location = new System.Drawing.Point(81, 120);
            this.realmlistField.Name = "realmlistField";
            this.realmlistField.Size = new System.Drawing.Size(190, 20);
            this.realmlistField.TabIndex = 3;
            // 
            // selectDirectory
            // 
            this.selectDirectory.Location = new System.Drawing.Point(15, 161);
            this.selectDirectory.Name = "selectDirectory";
            this.selectDirectory.Size = new System.Drawing.Size(259, 23);
            this.selectDirectory.TabIndex = 4;
            this.selectDirectory.Text = "Select WoW Directory";
            this.selectDirectory.UseVisualStyleBackColor = true;
            this.selectDirectory.Click += new System.EventHandler(this.selectDirectory_Click);
            // 
            // AddCustomServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 229);
            this.Controls.Add(this.selectDirectory);
            this.Controls.Add(this.realmlistField);
            this.Controls.Add(this.realmlistLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.versionCombo);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.websiteField);
            this.Name = "AddCustomServerForm";
            this.Text = "Add Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCustomServerForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.ComboBox versionCombo;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox websiteField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label realmlistLabel;
        private System.Windows.Forms.TextBox realmlistField;
        private System.Windows.Forms.Button selectDirectory;
    }
}