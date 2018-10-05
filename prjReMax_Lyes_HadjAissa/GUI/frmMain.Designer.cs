namespace prjReMax_Lyes_HadjAissa
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.housesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchhouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchagentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratorsToolStripMenuItem,
            this.agentsToolStripMenuItem1,
            this.clientsToolStripMenuItem,
            this.housesToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.toolStripSeparator1,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // administratorsToolStripMenuItem
            // 
            this.administratorsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("administratorsToolStripMenuItem.Image")));
            this.administratorsToolStripMenuItem.Name = "administratorsToolStripMenuItem";
            this.administratorsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.administratorsToolStripMenuItem.Text = "Administrators";
            this.administratorsToolStripMenuItem.Click += new System.EventHandler(this.administratorsToolStripMenuItem_Click);
            // 
            // agentsToolStripMenuItem1
            // 
            this.agentsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("agentsToolStripMenuItem1.Image")));
            this.agentsToolStripMenuItem1.Name = "agentsToolStripMenuItem1";
            this.agentsToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.agentsToolStripMenuItem1.Text = "Agents";
            this.agentsToolStripMenuItem1.Click += new System.EventHandler(this.agentsToolStripMenuItem1_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientsToolStripMenuItem.Image")));
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // housesToolStripMenuItem
            // 
            this.housesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("housesToolStripMenuItem.Image")));
            this.housesToolStripMenuItem.Name = "housesToolStripMenuItem";
            this.housesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.housesToolStripMenuItem.Text = "Houses";
            this.housesToolStripMenuItem.Click += new System.EventHandler(this.housesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchhouseToolStripMenuItem,
            this.searchagentsToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // searchhouseToolStripMenuItem
            // 
            this.searchhouseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchhouseToolStripMenuItem.Image")));
            this.searchhouseToolStripMenuItem.Name = "searchhouseToolStripMenuItem";
            this.searchhouseToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.searchhouseToolStripMenuItem.Text = "Houses";
            this.searchhouseToolStripMenuItem.Click += new System.EventHandler(this.houseToolStripMenuItem_Click);
            // 
            // searchagentsToolStripMenuItem
            // 
            this.searchagentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchagentsToolStripMenuItem.Image")));
            this.searchagentsToolStripMenuItem.Name = "searchagentsToolStripMenuItem";
            this.searchagentsToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.searchagentsToolStripMenuItem.Text = "Agents";
            this.searchagentsToolStripMenuItem.Click += new System.EventHandler(this.agentsToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salesToolStripMenuItem.Image")));
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(625, 532);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Remax Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem housesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchhouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchagentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
    }
}