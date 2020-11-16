namespace Pre_School_Managment_System
{
    partial class School_Records_Parent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(School_Records_Parent));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolFeesRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolTransportRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolUniformRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolActivityRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolProjectRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.User_txt = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.windowsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1529, 29);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(41, 23);
            this.fileMenu.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schoolFeesRecordToolStripMenuItem,
            this.schoolTransportRecordToolStripMenuItem,
            this.schoolUniformRecordToolStripMenuItem,
            this.schoolActivityRecordToolStripMenuItem,
            this.schoolProjectRecordToolStripMenuItem,
            this.salaryRecordToolStripMenuItem});
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // schoolFeesRecordToolStripMenuItem
            // 
            this.schoolFeesRecordToolStripMenuItem.Name = "schoolFeesRecordToolStripMenuItem";
            this.schoolFeesRecordToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.schoolFeesRecordToolStripMenuItem.Text = "School Fees Record";
            this.schoolFeesRecordToolStripMenuItem.Click += new System.EventHandler(this.schoolFeesRecordToolStripMenuItem_Click);
            // 
            // schoolTransportRecordToolStripMenuItem
            // 
            this.schoolTransportRecordToolStripMenuItem.Name = "schoolTransportRecordToolStripMenuItem";
            this.schoolTransportRecordToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.schoolTransportRecordToolStripMenuItem.Text = "School Transport Record";
            this.schoolTransportRecordToolStripMenuItem.Click += new System.EventHandler(this.schoolTransportRecordToolStripMenuItem_Click);
            // 
            // schoolUniformRecordToolStripMenuItem
            // 
            this.schoolUniformRecordToolStripMenuItem.Name = "schoolUniformRecordToolStripMenuItem";
            this.schoolUniformRecordToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.schoolUniformRecordToolStripMenuItem.Text = "School Uniform Record";
            this.schoolUniformRecordToolStripMenuItem.Click += new System.EventHandler(this.schoolUniformRecordToolStripMenuItem_Click);
            // 
            // schoolActivityRecordToolStripMenuItem
            // 
            this.schoolActivityRecordToolStripMenuItem.Name = "schoolActivityRecordToolStripMenuItem";
            this.schoolActivityRecordToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.schoolActivityRecordToolStripMenuItem.Text = "School Activity Record";
            this.schoolActivityRecordToolStripMenuItem.Click += new System.EventHandler(this.schoolActivityRecordToolStripMenuItem_Click);
            // 
            // schoolProjectRecordToolStripMenuItem
            // 
            this.schoolProjectRecordToolStripMenuItem.Name = "schoolProjectRecordToolStripMenuItem";
            this.schoolProjectRecordToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.schoolProjectRecordToolStripMenuItem.Text = "School Project Record";
            this.schoolProjectRecordToolStripMenuItem.Click += new System.EventHandler(this.schoolProjectRecordToolStripMenuItem_Click);
            // 
            // salaryRecordToolStripMenuItem
            // 
            this.salaryRecordToolStripMenuItem.Name = "salaryRecordToolStripMenuItem";
            this.salaryRecordToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.salaryRecordToolStripMenuItem.Text = "Salary Record";
            this.salaryRecordToolStripMenuItem.Click += new System.EventHandler(this.salaryRecordToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(161, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAllToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(77, 23);
            this.windowsMenu.Text = "&Windows";
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Location = new System.Drawing.Point(1484, 601);
            this.Password_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(106, 22);
            this.Password_lbl.TabIndex = 60;
            this.Password_lbl.Text = "Password:";
            this.Password_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Password_lbl.Visible = false;
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Location = new System.Drawing.Point(1474, 555);
            this.Username_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(109, 22);
            this.Username_lbl.TabIndex = 59;
            this.Username_lbl.Text = "Username:";
            this.Username_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Username_lbl.Visible = false;
            // 
            // User_txt
            // 
            this.User_txt.AutoSize = true;
            this.User_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.User_txt.ForeColor = System.Drawing.Color.SteelBlue;
            this.User_txt.Location = new System.Drawing.Point(1474, 499);
            this.User_txt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(107, 22);
            this.User_txt.TabIndex = 58;
            this.User_txt.Text = "Main Menu";
            this.User_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.User_txt.Visible = false;
            // 
            // School_Records_Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1529, 660);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.User_txt);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "School_Records_Parent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pre School Managment System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem schoolFeesRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoolTransportRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoolUniformRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoolActivityRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoolProjectRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryRecordToolStripMenuItem;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.Label User_txt;
    }
}



