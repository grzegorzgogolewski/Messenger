﻿namespace Komunikator
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMessenger = new System.Windows.Forms.TabPage();
            this.tabPageGG = new System.Windows.Forms.TabPage();
            this.tabPageWhatsApp = new System.Windows.Forms.TabPage();
            this.tabPageTelegram = new System.Windows.Forms.TabPage();
            this.tabPageSkype = new System.Windows.Forms.TabPage();
            this.tabPageSlackOPGK = new System.Windows.Forms.TabPage();
            this.tabPageSlackGISNET = new System.Windows.Forms.TabPage();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabPageSMS = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabPageMessenger);
            this.tabControl.Controls.Add(this.tabPageGG);
            this.tabControl.Controls.Add(this.tabPageWhatsApp);
            this.tabControl.Controls.Add(this.tabPageTelegram);
            this.tabControl.Controls.Add(this.tabPageSkype);
            this.tabControl.Controls.Add(this.tabPageSlackOPGK);
            this.tabControl.Controls.Add(this.tabPageSlackGISNET);
            this.tabControl.Controls.Add(this.tabPageSMS);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(100, 25);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(992, 719);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            this.tabControl.Click += new System.EventHandler(this.ResetStatus);
            // 
            // tabPageMessenger
            // 
            this.tabPageMessenger.BackColor = System.Drawing.Color.Transparent;
            this.tabPageMessenger.Location = new System.Drawing.Point(4, 4);
            this.tabPageMessenger.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageMessenger.Name = "tabPageMessenger";
            this.tabPageMessenger.Size = new System.Drawing.Size(984, 686);
            this.tabPageMessenger.TabIndex = 0;
            this.tabPageMessenger.Text = "Messenger";
            this.tabPageMessenger.UseVisualStyleBackColor = true;
            // 
            // tabPageGG
            // 
            this.tabPageGG.BackColor = System.Drawing.Color.Transparent;
            this.tabPageGG.Location = new System.Drawing.Point(4, 4);
            this.tabPageGG.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageGG.Name = "tabPageGG";
            this.tabPageGG.Size = new System.Drawing.Size(984, 686);
            this.tabPageGG.TabIndex = 1;
            this.tabPageGG.Text = "GG";
            this.tabPageGG.UseVisualStyleBackColor = true;
            // 
            // tabPageWhatsApp
            // 
            this.tabPageWhatsApp.BackColor = System.Drawing.Color.Transparent;
            this.tabPageWhatsApp.Location = new System.Drawing.Point(4, 4);
            this.tabPageWhatsApp.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageWhatsApp.Name = "tabPageWhatsApp";
            this.tabPageWhatsApp.Size = new System.Drawing.Size(984, 686);
            this.tabPageWhatsApp.TabIndex = 2;
            this.tabPageWhatsApp.Text = "WhatsApp";
            this.tabPageWhatsApp.UseVisualStyleBackColor = true;
            // 
            // tabPageTelegram
            // 
            this.tabPageTelegram.Location = new System.Drawing.Point(4, 4);
            this.tabPageTelegram.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageTelegram.Name = "tabPageTelegram";
            this.tabPageTelegram.Size = new System.Drawing.Size(984, 686);
            this.tabPageTelegram.TabIndex = 7;
            this.tabPageTelegram.Text = "Telegram";
            this.tabPageTelegram.UseVisualStyleBackColor = true;
            // 
            // tabPageSkype
            // 
            this.tabPageSkype.BackColor = System.Drawing.Color.Transparent;
            this.tabPageSkype.Location = new System.Drawing.Point(4, 4);
            this.tabPageSkype.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageSkype.Name = "tabPageSkype";
            this.tabPageSkype.Size = new System.Drawing.Size(984, 686);
            this.tabPageSkype.TabIndex = 3;
            this.tabPageSkype.Text = "Skype";
            this.tabPageSkype.UseVisualStyleBackColor = true;
            // 
            // tabPageSlackOPGK
            // 
            this.tabPageSlackOPGK.BackColor = System.Drawing.Color.Transparent;
            this.tabPageSlackOPGK.Location = new System.Drawing.Point(4, 4);
            this.tabPageSlackOPGK.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageSlackOPGK.Name = "tabPageSlackOPGK";
            this.tabPageSlackOPGK.Size = new System.Drawing.Size(984, 686);
            this.tabPageSlackOPGK.TabIndex = 4;
            this.tabPageSlackOPGK.Text = "Slack OPGK";
            this.tabPageSlackOPGK.UseVisualStyleBackColor = true;
            // 
            // tabPageSlackGISNET
            // 
            this.tabPageSlackGISNET.Location = new System.Drawing.Point(4, 4);
            this.tabPageSlackGISNET.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageSlackGISNET.Name = "tabPageSlackGISNET";
            this.tabPageSlackGISNET.Size = new System.Drawing.Size(984, 686);
            this.tabPageSlackGISNET.TabIndex = 6;
            this.tabPageSlackGISNET.Text = "Slack GISNET";
            this.tabPageSlackGISNET.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipTitle = "Komunikator";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // tabPageSMS
            // 
            this.tabPageSMS.Location = new System.Drawing.Point(4, 4);
            this.tabPageSMS.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageSMS.Name = "tabPageSMS";
            this.tabPageSMS.Size = new System.Drawing.Size(984, 686);
            this.tabPageSMS.TabIndex = 8;
            this.tabPageSMS.Text = "SMS";
            this.tabPageSMS.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(992, 719);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "FormMain";
            this.Text = "Komunikator";
            this.Activated += new System.EventHandler(this.ResetStatus);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMessenger;
        private System.Windows.Forms.TabPage tabPageGG;
        private System.Windows.Forms.TabPage tabPageWhatsApp;
        private System.Windows.Forms.TabPage tabPageSkype;
        private System.Windows.Forms.TabPage tabPageSlackOPGK;
        private System.Windows.Forms.TabPage tabPageSlackGISNET;
        private System.Windows.Forms.TabPage tabPageTelegram;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabPage tabPageSMS;
    }
}

