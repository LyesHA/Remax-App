namespace prjReMax_Lyes_HadjAissa.GUI
{
    partial class frmSearchAgent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.chkAllAgent = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboAgentID = new System.Windows.Forms.ComboBox();
            this.chkAgentID = new System.Windows.Forms.CheckBox();
            this.GridAgent = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAgent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo);
            this.groupBox1.Controls.Add(this.chkAllAgent);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cboAgentID);
            this.groupBox1.Controls.Add(this.chkAgentID);
            this.groupBox1.Location = new System.Drawing.Point(92, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // cbo
            // 
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(154, 59);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(192, 24);
            this.cbo.TabIndex = 37;
            // 
            // chkAllAgent
            // 
            this.chkAllAgent.AutoSize = true;
            this.chkAllAgent.Location = new System.Drawing.Point(38, 61);
            this.chkAllAgent.Name = "chkAllAgent";
            this.chkAllAgent.Size = new System.Drawing.Size(86, 21);
            this.chkAllAgent.TabIndex = 36;
            this.chkAllAgent.Text = "All Agent";
            this.chkAllAgent.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft NeoGothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(411, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 39);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboAgentID
            // 
            this.cboAgentID.FormattingEnabled = true;
            this.cboAgentID.Location = new System.Drawing.Point(154, 29);
            this.cboAgentID.Name = "cboAgentID";
            this.cboAgentID.Size = new System.Drawing.Size(192, 24);
            this.cboAgentID.TabIndex = 3;
            // 
            // chkAgentID
            // 
            this.chkAgentID.AutoSize = true;
            this.chkAgentID.Location = new System.Drawing.Point(38, 31);
            this.chkAgentID.Name = "chkAgentID";
            this.chkAgentID.Size = new System.Drawing.Size(84, 21);
            this.chkAgentID.TabIndex = 1;
            this.chkAgentID.Text = "Agent ID";
            this.chkAgentID.UseVisualStyleBackColor = true;
            this.chkAgentID.CheckedChanged += new System.EventHandler(this.chkAgentID_CheckedChanged);
            // 
            // GridAgent
            // 
            this.GridAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAgent.Location = new System.Drawing.Point(12, 118);
            this.GridAgent.Name = "GridAgent";
            this.GridAgent.RowTemplate.Height = 24;
            this.GridAgent.Size = new System.Drawing.Size(719, 220);
            this.GridAgent.TabIndex = 3;
            // 
            // frmSearchAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(747, 347);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridAgent);
            this.Name = "frmSearchAgent";
            this.Text = "Search Agent";
            this.Load += new System.EventHandler(this.frmSearchAgent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAgent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboAgentID;
        private System.Windows.Forms.CheckBox chkAgentID;
        private System.Windows.Forms.DataGridView GridAgent;
        private System.Windows.Forms.ComboBox cbo;
        private System.Windows.Forms.CheckBox chkAllAgent;
    }
}