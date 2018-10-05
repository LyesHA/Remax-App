namespace prjReMax_Lyes_HadjAissa.GUI
{
    partial class frmSearchHouse
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
            this.GridHouse = new System.Windows.Forms.DataGridView();
            this.chkRefHouse = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.chkAllHouses = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboHouseReference = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridHouse)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridHouse
            // 
            this.GridHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHouse.Location = new System.Drawing.Point(12, 118);
            this.GridHouse.Name = "GridHouse";
            this.GridHouse.RowTemplate.Height = 24;
            this.GridHouse.Size = new System.Drawing.Size(909, 269);
            this.GridHouse.TabIndex = 0;
            // 
            // chkRefHouse
            // 
            this.chkRefHouse.AutoSize = true;
            this.chkRefHouse.Location = new System.Drawing.Point(37, 29);
            this.chkRefHouse.Name = "chkRefHouse";
            this.chkRefHouse.Size = new System.Drawing.Size(148, 21);
            this.chkRefHouse.TabIndex = 1;
            this.chkRefHouse.Text = "Reference number";
            this.chkRefHouse.UseVisualStyleBackColor = true;
            this.chkRefHouse.CheckedChanged += new System.EventHandler(this.chkRefHouse_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo);
            this.groupBox1.Controls.Add(this.chkAllHouses);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cboHouseReference);
            this.groupBox1.Controls.Add(this.chkRefHouse);
            this.groupBox1.Location = new System.Drawing.Point(155, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // cbo
            // 
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(191, 57);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(192, 24);
            this.cbo.TabIndex = 37;
            // 
            // chkAllHouses
            // 
            this.chkAllHouses.AutoSize = true;
            this.chkAllHouses.Location = new System.Drawing.Point(37, 59);
            this.chkAllHouses.Name = "chkAllHouses";
            this.chkAllHouses.Size = new System.Drawing.Size(95, 21);
            this.chkAllHouses.TabIndex = 36;
            this.chkAllHouses.Text = "All houses";
            this.chkAllHouses.UseVisualStyleBackColor = true;
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
            // cboHouseReference
            // 
            this.cboHouseReference.FormattingEnabled = true;
            this.cboHouseReference.Location = new System.Drawing.Point(191, 27);
            this.cboHouseReference.Name = "cboHouseReference";
            this.cboHouseReference.Size = new System.Drawing.Size(192, 24);
            this.cboHouseReference.TabIndex = 3;
            // 
            // frmSearchHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(933, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridHouse);
            this.Name = "frmSearchHouse";
            this.Text = "Search houses";
            this.Load += new System.EventHandler(this.frmSearchHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridHouse)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridHouse;
        private System.Windows.Forms.CheckBox chkRefHouse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboHouseReference;
        private System.Windows.Forms.ComboBox cbo;
        private System.Windows.Forms.CheckBox chkAllHouses;
        private System.Windows.Forms.Button btnSearch;
    }
}