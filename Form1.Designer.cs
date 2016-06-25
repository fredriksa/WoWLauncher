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
            this.editServerButton = new System.Windows.Forms.Button();
            this.websiteButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.addServerButton = new System.Windows.Forms.Button();
            this.serverList = new System.Windows.Forms.ListView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.downloadStatusLabel = new System.Windows.Forms.Label();
            this.removeServerButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(559, 290);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(115, 23);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // editServerButton
            // 
            this.editServerButton.Location = new System.Drawing.Point(559, 118);
            this.editServerButton.Name = "editServerButton";
            this.editServerButton.Size = new System.Drawing.Size(115, 23);
            this.editServerButton.TabIndex = 3;
            this.editServerButton.Text = "Edit Server";
            this.editServerButton.UseVisualStyleBackColor = true;
            this.editServerButton.Click += new System.EventHandler(this.editServerButton_Click_1);
            // 
            // websiteButton
            // 
            this.websiteButton.Location = new System.Drawing.Point(559, 211);
            this.websiteButton.Name = "websiteButton";
            this.websiteButton.Size = new System.Drawing.Size(115, 23);
            this.websiteButton.TabIndex = 5;
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
            this.statusStrip1.Size = new System.Drawing.Size(688, 22);
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
            this.addServerButton.Location = new System.Drawing.Point(559, 27);
            this.addServerButton.Name = "addServerButton";
            this.addServerButton.Size = new System.Drawing.Size(115, 23);
            this.addServerButton.TabIndex = 1;
            this.addServerButton.Text = "Add Server";
            this.addServerButton.UseVisualStyleBackColor = true;
            this.addServerButton.Click += new System.EventHandler(this.addServerButton_Click);
            // 
            // serverList
            // 
            this.serverList.Location = new System.Drawing.Point(12, 27);
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(520, 207);
            this.serverList.TabIndex = 7;
            this.serverList.UseCompatibleStateImageBehavior = false;
            this.serverList.SelectedIndexChanged += new System.EventHandler(this.serverList_SelectedIndexChanged);
            this.serverList.ItemSelectionChanged += serverList_ItemSelectionChanged;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 290);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(520, 23);
            this.progressBar.TabIndex = 8;
            // 
            // downloadStatusLabel
            // 
            this.downloadStatusLabel.Location = new System.Drawing.Point(12, 274);
            this.downloadStatusLabel.Name = "downloadStatusLabel";
            this.downloadStatusLabel.Size = new System.Drawing.Size(520, 13);
            this.downloadStatusLabel.TabIndex = 9;
            this.downloadStatusLabel.Text = "Status: Inactive";
            this.downloadStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeServerButton
            // 
            this.removeServerButton.Location = new System.Drawing.Point(559, 70);
            this.removeServerButton.Name = "removeServerButton";
            this.removeServerButton.Size = new System.Drawing.Size(115, 23);
            this.removeServerButton.TabIndex = 2;
            this.removeServerButton.Text = "Remove Server";
            this.removeServerButton.UseVisualStyleBackColor = true;
            this.removeServerButton.Click += new System.EventHandler(this.deleteServerButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(559, 165);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(115, 23);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Open Directory";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Servers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(688, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.removeServerButton);
            this.Controls.Add(this.downloadStatusLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.serverList);
            this.Controls.Add(this.addServerButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.websiteButton);
            this.Controls.Add(this.editServerButton);
            this.Controls.Add(this.playButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Launcher 1.0 - Created by Fractional";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button editServerButton;
        private System.Windows.Forms.Button websiteButton;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button addServerButton;
        public System.Windows.Forms.ListView serverList;
        public System.Windows.Forms.ProgressBar progressBar;
        public System.Windows.Forms.Label downloadStatusLabel;
        private System.Windows.Forms.Button removeServerButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label label1;
    }
}

