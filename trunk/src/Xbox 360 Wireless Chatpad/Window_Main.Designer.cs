﻿namespace Xbox360WirelessChatpad
{
    partial class Window_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window_Main));
            this.appLogTextbox = new System.Windows.Forms.TextBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chatpadTextBox = new System.Windows.Forms.TextBox();
            this.deadzoneGroupBox = new System.Windows.Forms.GroupBox();
            this.leftDeadzoneLabel = new System.Windows.Forms.Label();
            this.leftDeadzone = new System.Windows.Forms.TrackBar();
            this.rightDeadzoneLabel = new System.Windows.Forms.Label();
            this.rightDeadzone = new System.Windows.Forms.TrackBar();
            this.leftDeadzonePercentLabel = new System.Windows.Forms.Label();
            this.rightDeadzonePercentLabel = new System.Windows.Forms.Label();
            this.trayIconMenu.SuspendLayout();
            this.deadzoneGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftDeadzone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDeadzone)).BeginInit();
            this.SuspendLayout();
            // 
            // appLogTextbox
            // 
            this.appLogTextbox.Location = new System.Drawing.Point(11, 45);
            this.appLogTextbox.Multiline = true;
            this.appLogTextbox.Name = "appLogTextbox";
            this.appLogTextbox.ReadOnly = true;
            this.appLogTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.appLogTextbox.Size = new System.Drawing.Size(330, 103);
            this.appLogTextbox.TabIndex = 0;
            this.appLogTextbox.TextChanged += new System.EventHandler(this.appLogTextbox_TextChanged);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayIconMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Xbox 360 Wireless Chatpad";
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // trayIconMenu
            // 
            this.trayIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.trayIconMenu.Name = "trayIconMenu";
            this.trayIconMenu.Size = new System.Drawing.Size(104, 26);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(235, 16);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(106, 23);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect Controller";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.MaximumSize = new System.Drawing.Size(230, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Connect Controller and then press the Guide button on your XBOX 360 contro" +
                "ller.";
            // 
            // chatpadTextBox
            // 
            this.chatpadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatpadTextBox.Location = new System.Drawing.Point(12, 153);
            this.chatpadTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.chatpadTextBox.Name = "chatpadTextBox";
            this.chatpadTextBox.Size = new System.Drawing.Size(330, 20);
            this.chatpadTextBox.TabIndex = 3;
            this.chatpadTextBox.Text = "-Test Chatpad Here-";
            this.chatpadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chatpadTextBox.Enter += new System.EventHandler(this.chatpadTextBox_Enter);
            // 
            // deadzoneGroupBox
            // 
            this.deadzoneGroupBox.Controls.Add(this.rightDeadzonePercentLabel);
            this.deadzoneGroupBox.Controls.Add(this.leftDeadzonePercentLabel);
            this.deadzoneGroupBox.Controls.Add(this.rightDeadzone);
            this.deadzoneGroupBox.Controls.Add(this.rightDeadzoneLabel);
            this.deadzoneGroupBox.Controls.Add(this.leftDeadzone);
            this.deadzoneGroupBox.Controls.Add(this.leftDeadzoneLabel);
            this.deadzoneGroupBox.Enabled = false;
            this.deadzoneGroupBox.Location = new System.Drawing.Point(347, 12);
            this.deadzoneGroupBox.Name = "deadzoneGroupBox";
            this.deadzoneGroupBox.Size = new System.Drawing.Size(147, 161);
            this.deadzoneGroupBox.TabIndex = 4;
            this.deadzoneGroupBox.TabStop = false;
            this.deadzoneGroupBox.Text = "Analog Deadzones";
            // 
            // leftDeadzoneLabel
            // 
            this.leftDeadzoneLabel.AutoSize = true;
            this.leftDeadzoneLabel.Location = new System.Drawing.Point(6, 21);
            this.leftDeadzoneLabel.Name = "leftDeadzoneLabel";
            this.leftDeadzoneLabel.Size = new System.Drawing.Size(88, 13);
            this.leftDeadzoneLabel.TabIndex = 0;
            this.leftDeadzoneLabel.Text = "Left Analog Stick";
            // 
            // leftDeadzone
            // 
            this.leftDeadzone.Location = new System.Drawing.Point(7, 37);
            this.leftDeadzone.Maximum = 30;
            this.leftDeadzone.Name = "leftDeadzone";
            this.leftDeadzone.Size = new System.Drawing.Size(134, 45);
            this.leftDeadzone.TabIndex = 1;
            this.leftDeadzone.ValueChanged += new System.EventHandler(this.leftDeadzone_ValueChanged);
            // 
            // rightDeadzoneLabel
            // 
            this.rightDeadzoneLabel.AutoSize = true;
            this.rightDeadzoneLabel.Location = new System.Drawing.Point(6, 90);
            this.rightDeadzoneLabel.Name = "rightDeadzoneLabel";
            this.rightDeadzoneLabel.Size = new System.Drawing.Size(95, 13);
            this.rightDeadzoneLabel.TabIndex = 2;
            this.rightDeadzoneLabel.Text = "Right Analog Stick";
            // 
            // rightDeadzone
            // 
            this.rightDeadzone.Location = new System.Drawing.Point(7, 106);
            this.rightDeadzone.Maximum = 30;
            this.rightDeadzone.Name = "rightDeadzone";
            this.rightDeadzone.Size = new System.Drawing.Size(134, 45);
            this.rightDeadzone.TabIndex = 3;
            this.rightDeadzone.ValueChanged += new System.EventHandler(this.rightDeadzone_ValueChanged);
            // 
            // leftDeadzonePercentLabel
            // 
            this.leftDeadzonePercentLabel.Location = new System.Drawing.Point(111, 21);
            this.leftDeadzonePercentLabel.Name = "leftDeadzonePercentLabel";
            this.leftDeadzonePercentLabel.Size = new System.Drawing.Size(30, 13);
            this.leftDeadzonePercentLabel.TabIndex = 4;
            this.leftDeadzonePercentLabel.Text = "0%";
            this.leftDeadzonePercentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rightDeadzonePercentLabel
            // 
            this.rightDeadzonePercentLabel.Location = new System.Drawing.Point(111, 90);
            this.rightDeadzonePercentLabel.Name = "rightDeadzonePercentLabel";
            this.rightDeadzonePercentLabel.Size = new System.Drawing.Size(30, 13);
            this.rightDeadzonePercentLabel.TabIndex = 5;
            this.rightDeadzonePercentLabel.Text = "0%";
            this.rightDeadzonePercentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Window_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 185);
            this.Controls.Add(this.deadzoneGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chatpadTextBox);
            this.Controls.Add(this.appLogTextbox);
            this.Controls.Add(this.connectButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Window_Main";
            this.Text = "Xbox 360 Wireless Chatpad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window_Main_FormClosing);
            this.Load += new System.EventHandler(this.Window_Main_Load);
            this.Resize += new System.EventHandler(this.Window_Main_Resize);
            this.trayIconMenu.ResumeLayout(false);
            this.deadzoneGroupBox.ResumeLayout(false);
            this.deadzoneGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftDeadzone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDeadzone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox appLogTextbox;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayIconMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chatpadTextBox;
        private System.Windows.Forms.GroupBox deadzoneGroupBox;
        private System.Windows.Forms.TrackBar rightDeadzone;
        private System.Windows.Forms.Label rightDeadzoneLabel;
        private System.Windows.Forms.TrackBar leftDeadzone;
        private System.Windows.Forms.Label leftDeadzoneLabel;
        private System.Windows.Forms.Label rightDeadzonePercentLabel;
        private System.Windows.Forms.Label leftDeadzonePercentLabel;
    }
}
