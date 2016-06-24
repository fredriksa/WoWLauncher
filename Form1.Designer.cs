using System;

namespace Launcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playButton = new System.Windows.Forms.Button();
            this.deleteCacheButton = new System.Windows.Forms.Button();
            this.websiteButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.addServerButton = new System.Windows.Forms.Button();
            this.serverList = new System.Windows.Forms.ListView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.downloadStatusLabel = new System.Windows.Forms.Label();
            this.removeServerButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(569, 284);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(115, 23);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // deleteCacheButton
            // 
            this.deleteCacheButton.Location = new System.Drawing.Point(569, 63);
            this.deleteCacheButton.Name = "deleteCacheButton";
            this.deleteCacheButton.Size = new System.Drawing.Size(115, 23);
            this.deleteCacheButton.TabIndex = 1;
            this.deleteCacheButton.Text = "Delete Cache";
            this.deleteCacheButton.UseVisualStyleBackColor = true;
            this.deleteCacheButton.Click += new System.EventHandler(this.deleteCacheButton_Click);
            // 
            // websiteButton
            // 
            this.websiteButton.Location = new System.Drawing.Point(569, 21);
            this.websiteButton.Name = "websiteButton";
            this.websiteButton.Size = new System.Drawing.Size(115, 23);
            this.websiteButton.TabIndex = 2;
            this.websiteButton.Text = "Website";
            this.websiteButton.UseVisualStyleBackColor = true;
            this.websiteButton.Click += new System.EventHandler(this.websiteButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(696, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // addServerButton
            // 
            this.addServerButton.Location = new System.Drawing.Point(569, 106);
            this.addServerButton.Name = "addServerButton";
            this.addServerButton.Size = new System.Drawing.Size(115, 23);
            this.addServerButton.TabIndex = 6;
            this.addServerButton.Text = "Add Server";
            this.addServerButton.UseVisualStyleBackColor = true;
            this.addServerButton.Click += new System.EventHandler(this.addServerButton_Click);
            // 
            // serverList
            // 
            this.serverList.Location = new System.Drawing.Point(22, 21);
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(520, 207);
            this.serverList.TabIndex = 7;
            this.serverList.UseCompatibleStateImageBehavior = false;
            this.serverList.SelectedIndexChanged += new System.EventHandler(this.serverList_SelectedIndexChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(22, 284);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(520, 23);
            this.progressBar.TabIndex = 8;
            // 
            // downloadStatusLabel
            // 
            this.downloadStatusLabel.AutoSize = true;
            this.downloadStatusLabel.Location = new System.Drawing.Point(250, 268);
            this.downloadStatusLabel.Name = "downloadStatusLabel";
            this.downloadStatusLabel.Size = new System.Drawing.Size(45, 13);
            this.downloadStatusLabel.TabIndex = 9;
            this.downloadStatusLabel.Text = "Inactive";
            this.downloadStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeServerButton
            // 
            this.removeServerButton.Location = new System.Drawing.Point(569, 152);
            this.removeServerButton.Name = "removeServerButton";
            this.removeServerButton.Size = new System.Drawing.Size(115, 23);
            this.removeServerButton.TabIndex = 10;
            this.removeServerButton.Text = "Remove Server";
            this.removeServerButton.UseVisualStyleBackColor = true;
            this.removeServerButton.Click += new System.EventHandler(this.deleteServerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(696, 345);
            this.Controls.Add(this.removeServerButton);
            this.Controls.Add(this.downloadStatusLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.serverList);
            this.Controls.Add(this.addServerButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.websiteButton);
            this.Controls.Add(this.deleteCacheButton);
            this.Controls.Add(this.playButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button deleteCacheButton;
        private System.Windows.Forms.Button websiteButton;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button addServerButton;
        public System.Windows.Forms.ListView serverList;
        public System.Windows.Forms.ProgressBar progressBar;
        public System.Windows.Forms.Label downloadStatusLabel;
        private System.Windows.Forms.Button removeServerButton;
    }
}

