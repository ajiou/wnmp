﻿/*
This file is part of Wnmp.

    Wnmp is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Wnmp is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Wnmp.  If not, see <http://www.gnu.org/licenses/>.
*/
namespace Wnmp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wnmpOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localhostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ngx_reload = new System.Windows.Forms.Button();
            this.php_log = new System.Windows.Forms.Button();
            this.mdb_log = new System.Windows.Forms.Button();
            this.ngx_log = new System.Windows.Forms.Button();
            this.php_cfg = new System.Windows.Forms.Button();
            this.mdb_cfg = new System.Windows.Forms.Button();
            this.ngx_config = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phprunning = new System.Windows.Forms.Label();
            this.mariadbrunning = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nginxrunning = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mdb_help = new System.Windows.Forms.Button();
            this.mdb_stop = new System.Windows.Forms.Button();
            this.mdb_start = new System.Windows.Forms.Button();
            this.php_start = new System.Windows.Forms.Button();
            this.php_stop = new System.Windows.Forms.Button();
            this.ngx_start = new System.Windows.Forms.Button();
            this.ngx_stop = new System.Windows.Forms.Button();
            this.mdb_shell = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wnmpdir = new System.Windows.Forms.Button();
            this.log_rtb = new System.Windows.Forms.RichTextBox();
            this.ngx_conf = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mdb_conf = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.php_conf = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mdb_logs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.php_logs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.Icon = ((System.Drawing.Icon)(resources.GetObject("icon.Icon")));
            this.icon.Text = "Wnmp";
            this.icon.Visible = true;
            this.icon.Click += new System.EventHandler(this.icon_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.localhostToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(861, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wnmpOptionsToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // wnmpOptionsToolStripMenuItem
            // 
            this.wnmpOptionsToolStripMenuItem.Name = "wnmpOptionsToolStripMenuItem";
            this.wnmpOptionsToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.wnmpOptionsToolStripMenuItem.Text = "Wnmp Options";
            this.wnmpOptionsToolStripMenuItem.Click += new System.EventHandler(this.wnmpOptionsToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportToolStripMenuItem,
            this.reportBugToolStripMenuItem,
            this.toolStripSeparator2,
            this.websiteToolStripMenuItem,
            this.donateToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.supportToolStripMenuItem.Text = "Support";
            this.supportToolStripMenuItem.Click += new System.EventHandler(this.SupportToolStripMenuItem_Click);
            // 
            // reportBugToolStripMenuItem
            // 
            this.reportBugToolStripMenuItem.Name = "reportBugToolStripMenuItem";
            this.reportBugToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.reportBugToolStripMenuItem.Text = "Report Bug";
            this.reportBugToolStripMenuItem.Click += new System.EventHandler(this.Report_BugToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.websiteToolStripMenuItem.Text = "Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.donateToolStripMenuItem.Text = "Donate";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // localhostToolStripMenuItem
            // 
            this.localhostToolStripMenuItem.Name = "localhostToolStripMenuItem";
            this.localhostToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.localhostToolStripMenuItem.Text = "localhost";
            this.localhostToolStripMenuItem.Click += new System.EventHandler(this.localhostToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ngx_reload);
            this.groupBox1.Controls.Add(this.php_log);
            this.groupBox1.Controls.Add(this.mdb_log);
            this.groupBox1.Controls.Add(this.ngx_log);
            this.groupBox1.Controls.Add(this.php_cfg);
            this.groupBox1.Controls.Add(this.mdb_cfg);
            this.groupBox1.Controls.Add(this.ngx_config);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.phprunning);
            this.groupBox1.Controls.Add(this.mariadbrunning);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nginxrunning);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mdb_help);
            this.groupBox1.Controls.Add(this.mdb_stop);
            this.groupBox1.Controls.Add(this.mdb_start);
            this.groupBox1.Controls.Add(this.php_start);
            this.groupBox1.Controls.Add(this.php_stop);
            this.groupBox1.Controls.Add(this.ngx_start);
            this.groupBox1.Controls.Add(this.ngx_stop);
            this.groupBox1.Location = new System.Drawing.Point(16, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(607, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Applications";
            // 
            // ngx_reload
            // 
            this.ngx_reload.Location = new System.Drawing.Point(368, 55);
            this.ngx_reload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ngx_reload.Name = "ngx_reload";
            this.ngx_reload.Size = new System.Drawing.Size(67, 34);
            this.ngx_reload.TabIndex = 76;
            this.ngx_reload.Text = "Reload";
            this.ngx_reload.UseVisualStyleBackColor = true;
            // 
            // php_log
            // 
            this.php_log.Location = new System.Drawing.Point(517, 155);
            this.php_log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.php_log.Name = "php_log";
            this.php_log.Size = new System.Drawing.Size(67, 34);
            this.php_log.TabIndex = 75;
            this.php_log.Text = "Logs";
            this.php_log.UseVisualStyleBackColor = true;
            // 
            // mdb_log
            // 
            this.mdb_log.Location = new System.Drawing.Point(517, 102);
            this.mdb_log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mdb_log.Name = "mdb_log";
            this.mdb_log.Size = new System.Drawing.Size(67, 34);
            this.mdb_log.TabIndex = 74;
            this.mdb_log.Text = "Logs";
            this.mdb_log.UseVisualStyleBackColor = true;
            // 
            // ngx_log
            // 
            this.ngx_log.Location = new System.Drawing.Point(517, 55);
            this.ngx_log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ngx_log.Name = "ngx_log";
            this.ngx_log.Size = new System.Drawing.Size(67, 34);
            this.ngx_log.TabIndex = 73;
            this.ngx_log.Text = "Logs";
            this.ngx_log.UseVisualStyleBackColor = true;
            // 
            // php_cfg
            // 
            this.php_cfg.Location = new System.Drawing.Point(443, 155);
            this.php_cfg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.php_cfg.Name = "php_cfg";
            this.php_cfg.Size = new System.Drawing.Size(67, 34);
            this.php_cfg.TabIndex = 72;
            this.php_cfg.Text = "Config";
            this.php_cfg.UseVisualStyleBackColor = true;
            // 
            // mdb_cfg
            // 
            this.mdb_cfg.Location = new System.Drawing.Point(443, 102);
            this.mdb_cfg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mdb_cfg.Name = "mdb_cfg";
            this.mdb_cfg.Size = new System.Drawing.Size(67, 34);
            this.mdb_cfg.TabIndex = 71;
            this.mdb_cfg.Text = "Config";
            this.mdb_cfg.UseVisualStyleBackColor = true;
            // 
            // ngx_config
            // 
            this.ngx_config.Location = new System.Drawing.Point(443, 55);
            this.ngx_config.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ngx_config.Name = "ngx_config";
            this.ngx_config.Size = new System.Drawing.Size(67, 34);
            this.ngx_config.TabIndex = 70;
            this.ngx_config.Text = "Config";
            this.ngx_config.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 69;
            this.label8.Text = "PHP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 68;
            this.label7.Text = "MariaDB";
            // 
            // phprunning
            // 
            this.phprunning.AutoSize = true;
            this.phprunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phprunning.ForeColor = System.Drawing.Color.DarkRed;
            this.phprunning.Location = new System.Drawing.Point(29, 166);
            this.phprunning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phprunning.Name = "phprunning";
            this.phprunning.Size = new System.Drawing.Size(27, 25);
            this.phprunning.TabIndex = 67;
            this.phprunning.Text = "X";
            // 
            // mariadbrunning
            // 
            this.mariadbrunning.AutoSize = true;
            this.mariadbrunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mariadbrunning.ForeColor = System.Drawing.Color.DarkRed;
            this.mariadbrunning.Location = new System.Drawing.Point(29, 112);
            this.mariadbrunning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mariadbrunning.Name = "mariadbrunning";
            this.mariadbrunning.Size = new System.Drawing.Size(27, 25);
            this.mariadbrunning.TabIndex = 66;
            this.mariadbrunning.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(219, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Nginx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Application";
            // 
            // nginxrunning
            // 
            this.nginxrunning.AutoSize = true;
            this.nginxrunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nginxrunning.ForeColor = System.Drawing.Color.DarkRed;
            this.nginxrunning.Location = new System.Drawing.Point(29, 58);
            this.nginxrunning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nginxrunning.Name = "nginxrunning";
            this.nginxrunning.Size = new System.Drawing.Size(27, 25);
            this.nginxrunning.TabIndex = 61;
            this.nginxrunning.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Running";
            // 
            // mdb_help
            // 
            this.mdb_help.Location = new System.Drawing.Point(368, 102);
            this.mdb_help.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mdb_help.Name = "mdb_help";
            this.mdb_help.Size = new System.Drawing.Size(67, 34);
            this.mdb_help.TabIndex = 59;
            this.mdb_help.Text = "?";
            this.mdb_help.UseVisualStyleBackColor = true;
            // 
            // mdb_stop
            // 
            this.mdb_stop.Location = new System.Drawing.Point(293, 101);
            this.mdb_stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mdb_stop.Name = "mdb_stop";
            this.mdb_stop.Size = new System.Drawing.Size(67, 34);
            this.mdb_stop.TabIndex = 57;
            this.mdb_stop.Text = "Stop";
            this.mdb_stop.UseVisualStyleBackColor = true;
            // 
            // mdb_start
            // 
            this.mdb_start.Location = new System.Drawing.Point(219, 101);
            this.mdb_start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mdb_start.Name = "mdb_start";
            this.mdb_start.Size = new System.Drawing.Size(67, 34);
            this.mdb_start.TabIndex = 56;
            this.mdb_start.Text = "Start";
            this.mdb_start.UseVisualStyleBackColor = true;
            // 
            // php_start
            // 
            this.php_start.Location = new System.Drawing.Point(219, 156);
            this.php_start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.php_start.Name = "php_start";
            this.php_start.Size = new System.Drawing.Size(67, 34);
            this.php_start.TabIndex = 55;
            this.php_start.Text = "Start";
            this.php_start.UseVisualStyleBackColor = true;
            // 
            // php_stop
            // 
            this.php_stop.Location = new System.Drawing.Point(293, 156);
            this.php_stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.php_stop.Name = "php_stop";
            this.php_stop.Size = new System.Drawing.Size(67, 34);
            this.php_stop.TabIndex = 54;
            this.php_stop.Text = "Stop";
            this.php_stop.UseVisualStyleBackColor = true;
            // 
            // ngx_start
            // 
            this.ngx_start.Location = new System.Drawing.Point(219, 55);
            this.ngx_start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ngx_start.Name = "ngx_start";
            this.ngx_start.Size = new System.Drawing.Size(67, 34);
            this.ngx_start.TabIndex = 53;
            this.ngx_start.Text = "Start";
            this.ngx_start.UseVisualStyleBackColor = true;
            // 
            // ngx_stop
            // 
            this.ngx_stop.Location = new System.Drawing.Point(293, 55);
            this.ngx_stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ngx_stop.Name = "ngx_stop";
            this.ngx_stop.Size = new System.Drawing.Size(67, 34);
            this.ngx_stop.TabIndex = 52;
            this.ngx_stop.Text = "Stop";
            this.ngx_stop.UseVisualStyleBackColor = true;
            // 
            // mdb_shell
            // 
            this.mdb_shell.Location = new System.Drawing.Point(768, 114);
            this.mdb_shell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mdb_shell.Name = "mdb_shell";
            this.mdb_shell.Size = new System.Drawing.Size(84, 60);
            this.mdb_shell.TabIndex = 58;
            this.mdb_shell.Text = "Open MariaDB Shell";
            this.mdb_shell.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(768, 4);
            this.start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(84, 44);
            this.start.TabIndex = 49;
            this.start.Text = "Start all";
            this.start.UseVisualStyleBackColor = true;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(768, 63);
            this.stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(84, 44);
            this.stop.TabIndex = 50;
            this.stop.Text = "Stop all";
            this.stop.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wnmpdir);
            this.panel1.Controls.Add(this.log_rtb);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.mdb_shell);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 411);
            this.panel1.TabIndex = 5;
            // 
            // wnmpdir
            // 
            this.wnmpdir.Location = new System.Drawing.Point(768, 182);
            this.wnmpdir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wnmpdir.Name = "wnmpdir";
            this.wnmpdir.Size = new System.Drawing.Size(84, 49);
            this.wnmpdir.TabIndex = 59;
            this.wnmpdir.Text = "Wnmp Directory";
            this.wnmpdir.UseVisualStyleBackColor = true;
            this.wnmpdir.Click += new System.EventHandler(this.wnmpdir_Click);
            // 
            // log_rtb
            // 
            this.log_rtb.BackColor = System.Drawing.Color.White;
            this.log_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_rtb.Location = new System.Drawing.Point(0, 246);
            this.log_rtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.log_rtb.Name = "log_rtb";
            this.log_rtb.ReadOnly = true;
            this.log_rtb.Size = new System.Drawing.Size(859, 170);
            this.log_rtb.TabIndex = 49;
            this.log_rtb.Text = "";
            // 
            // ngx_conf
            // 
            this.ngx_conf.Name = "contextMenuStrip1";
            this.ngx_conf.Size = new System.Drawing.Size(61, 4);
            // 
            // mdb_conf
            // 
            this.mdb_conf.Name = "contextMenuStrip2";
            this.mdb_conf.Size = new System.Drawing.Size(61, 4);
            // 
            // php_conf
            // 
            this.php_conf.Name = "contextMenuStrip3";
            this.php_conf.Size = new System.Drawing.Size(61, 4);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // logs
            // 
            this.logs.Name = "contextMenuStrip4";
            this.logs.Size = new System.Drawing.Size(61, 4);
            // 
            // mdb_logs
            // 
            this.mdb_logs.Name = "contextMenuStrip5";
            this.mdb_logs.Size = new System.Drawing.Size(61, 4);
            // 
            // php_logs
            // 
            this.php_logs.Name = "contextMenuStrip6";
            this.php_logs.Size = new System.Drawing.Size(61, 4);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(879, 484);
            this.MinimumSize = new System.Drawing.Size(879, 484);
            this.Name = "Main";
            this.Text = "Wnmp";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon icon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mdb_help;
        internal System.Windows.Forms.Button mdb_shell;
        internal System.Windows.Forms.Button mdb_stop;
        internal System.Windows.Forms.Button php_start;
        internal System.Windows.Forms.Button php_stop;
        internal System.Windows.Forms.Button ngx_stop;
        internal System.Windows.Forms.Button start;
        internal System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ngx_config;
        private System.Windows.Forms.Button php_cfg;
        private System.Windows.Forms.Button mdb_cfg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem wnmpOptionsToolStripMenuItem;
        private System.Windows.Forms.Button php_log;
        private System.Windows.Forms.Button mdb_log;
        private System.Windows.Forms.Button ngx_log;
        private System.Windows.Forms.Button wnmpdir;
        internal System.Windows.Forms.RichTextBox log_rtb;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label nginxrunning;
        internal System.Windows.Forms.Label mariadbrunning;
        internal System.Windows.Forms.Button mdb_start;
        internal System.Windows.Forms.Button ngx_start;
        internal System.Windows.Forms.Button ngx_reload;
        internal System.Windows.Forms.ContextMenuStrip ngx_conf;
        internal System.Windows.Forms.ContextMenuStrip mdb_conf;
        internal System.Windows.Forms.ContextMenuStrip php_conf;
        internal System.Windows.Forms.ContextMenuStrip logs;
        internal System.Windows.Forms.ContextMenuStrip mdb_logs;
        internal System.Windows.Forms.ContextMenuStrip php_logs;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem localhostToolStripMenuItem;
        internal System.Windows.Forms.Label phprunning;

    }
}

