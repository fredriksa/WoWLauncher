namespace Launcher
{
    partial class AddServerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServerForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fastSetupButton = new System.Windows.Forms.Button();
            this.customSetupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fastSetupButton
            // 
            this.fastSetupButton.Location = new System.Drawing.Point(12, 12);
            this.fastSetupButton.Name = "fastSetupButton";
            this.fastSetupButton.Size = new System.Drawing.Size(259, 23);
            this.fastSetupButton.TabIndex = 1;
            this.fastSetupButton.Text = "Fast Setup";
            this.fastSetupButton.UseVisualStyleBackColor = true;
            this.fastSetupButton.Click += new System.EventHandler(this.fastSetupButton_Click);
            // 
            // customSetupButton
            // 
            this.customSetupButton.Location = new System.Drawing.Point(13, 48);
            this.customSetupButton.Name = "customSetupButton";
            this.customSetupButton.Size = new System.Drawing.Size(259, 23);
            this.customSetupButton.TabIndex = 2;
            this.customSetupButton.Text = "Manual Setup";
            this.customSetupButton.UseVisualStyleBackColor = true;
            this.customSetupButton.Click += new System.EventHandler(this.customSetupButton_Click);
            // 
            // AddServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 83);
            this.Controls.Add(this.customSetupButton);
            this.Controls.Add(this.fastSetupButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddServerForm";
            this.Text = "Add Fast Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddServerForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button fastSetupButton;
        private System.Windows.Forms.Button customSetupButton;
    }
}