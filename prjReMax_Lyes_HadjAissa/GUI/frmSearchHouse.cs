using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using prjReMax_Lyes_HadjAissa.DataSource;

namespace prjReMax_Lyes_HadjAissa.GUI
{
    public partial class frmSearchHouse : Form
    {
        public frmSearchHouse()
        {
            InitializeComponent();
        }

        private void frmSearchHouse_Load(object sender, EventArgs e)
        {
            cbo.Enabled = false;
            cboHouseReference.Enabled = false;
            Show_house();
        }

        private void Show_house()
        {
            cboHouseReference.DataSource = clsGlobal.tbHouses;
            cboHouseReference.DisplayMember = "HouseID";
            cboHouseReference.ValueMember = "HouseID";
        }

        private void chkRefHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRefHouse.Checked)
            {
                cboHouseReference.Enabled = true;
       
            }
            if (!chkRefHouse.Checked)
            {
                cboHouseReference.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chkRefHouse.Checked && !chkAllHouses.Checked)
            {
                var result = from DataRow myrow in clsGlobal.tbHouses.Rows
                             where myrow.Field<Int32>("HouseID").ToString() == cboHouseReference.SelectedValue.ToString()
                             select new
                             {
                                 House_Reference = myrow.Field<Int32>("HouseID"),
                                 Type = myrow.Field<string>("Type"),
                                 Localistation = myrow.Field<string>("Localisation"),
                                 Prix = myrow.Field<decimal>("Prix"),
                                 NombreChambre = myrow.Field<Int32>("NombreChambre"),
                                 NombreSalleDeBain = myrow.Field<Int32>("NombreSalleDeBain"),
                                 Description = myrow.Field<string>("Description"),
                                 Agent = myrow.Field<Int32>("AgentID")                           
                             };
                GridHouse.DataSource = result.ToList();
            }
            else if (!chkRefHouse.Checked && chkAllHouses.Checked)
            {
                GridHouse.DataSource = clsGlobal.tbHouses;
            }
            else
            {
                MessageBox.Show("Veuillez choisir qu'un seule choix !!","Information !",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
