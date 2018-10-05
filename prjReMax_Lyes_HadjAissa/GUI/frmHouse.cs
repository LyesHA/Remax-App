using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjReMax_Lyes_HadjAissa.DataSource;
using BusinessLayer;

namespace prjReMax_Lyes_HadjAissa.GUI
{
    public partial class frmHouse : Form
    {
        public frmHouse()
        {
            InitializeComponent();
        }
        int courant;
        string mode;

        private void frmHouse_Load(object sender, EventArgs e)
        {
            if (frmLogin.Usermode == "Agent")
            {
                cboAgent.Enabled = false;
            }
            courant = 0;
            remplirAgent();
            Row2Txt();
        }

        private void remplirAgent()
        {
            cboAgent.ValueMember = "AgentID";
            cboAgent.DisplayMember = "Nom";
            cboAgent.DataSource = clsGlobal.tbAgents;
        }
        private void Row2Txt()
        {
            cboType.Text = clsGlobal.tbHouses.Rows[courant]["Type"].ToString();
            cboNbrChambre.Text = clsGlobal.tbHouses.Rows[courant]["NombreChambre"].ToString();
            cboNbrBathroom.Text = clsGlobal.tbHouses.Rows[courant]["NombreSalleDeBain"].ToString();
            txtPrix.Text = clsGlobal.tbHouses.Rows[courant]["Prix"].ToString();
            txtLocalisation.Text = clsGlobal.tbHouses.Rows[courant]["Localisation"].ToString();
            txtDescription.Text = clsGlobal.tbHouses.Rows[courant]["Description"].ToString();
            lblInfo.Text = "Les informations de la maison " +
                (courant + 1) + " sur " + clsGlobal.tbHouses.Rows.Count;
            DataColumn[] key = new DataColumn[1];
            key[0] = clsGlobal.tbAgents.Columns["AgentID"];
            clsGlobal.tbAgents.PrimaryKey = key;
            DataRow myrow = clsGlobal.tbAgents.Rows.Find(clsGlobal.tbHouses.Rows[courant]["AgentID"].ToString());
            cboAgent.Text = myrow["Nom"].ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (courant != clsGlobal.tbHouses.Rows.Count - 1)
            {
                courant++;
                Row2Txt();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (courant != 0)
            {
                courant--;
                Row2Txt();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            courant = 0;
            Row2Txt();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            courant = clsGlobal.tbHouses.Rows.Count - 1;
            Row2Txt();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboType.Text = "";
            cboNbrChambre.Text = "";
            cboNbrBathroom.Text = "";
            txtPrix.Text = "";
            txtLocalisation.Text = "";
            txtDescription.Text = "";
            lblInfo.Text = "Mode Ajout !!";
            cboType.Focus();
            mode = "Ajout";
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            cboType.Focus();
            mode = "Modifier";
            lblInfo.Text = "Mode Modification !! ";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            courant = 0;
            Row2Txt();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsHouse house = new clsHouse();
            int id = clsGlobal.tbHouses.Rows.Count;
            house.Type = cboType.Text;
            house.Localisation = txtLocalisation.Text;
            house.Price = Convert.ToDecimal(txtPrix.Text);
            house.Nb_rooms = Convert.ToInt32(cboNbrChambre.SelectedItem);
            house.Nb_bathrooms = Convert.ToInt32(cboNbrBathroom.SelectedItem);
            house.Agent_id = Convert.ToInt32(cboAgent.SelectedValue);
            house.Description = txtDescription.Text;
            if (mode == "Ajout")
            {
               // house.House_id = (Convert.ToInt32(clsGlobal.tbHouses.Rows[id - 1]["HouseID"]) + 1);
                house.AddHouse(house);
                courant = clsGlobal.tbHouses.Rows.Count - 1;
            }
            else if (mode == "Modifier")
            {
                house.House_id = Convert.ToInt32(clsGlobal.tbHouses.Rows[courant]["HouseID"]);
                house.EditHouse(house);
            }
            clsDataAdmin.UpdateHouses(clsGlobal.tbHouses);
            mode = "";
            Row2Txt();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de vouloir supprimer cette maison", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clsHouse house = new clsHouse();
                house.House_id = Convert.ToInt32(clsGlobal.tbHouses.Rows[courant]["HouseID"]);
                house.DeleteHouse(house);
                clsDataAdmin.UpdateHouses(clsGlobal.tbHouses);
                courant = clsGlobal.tbHouses.Rows.Count - 1;
            }
            
            Row2Txt();
        }
    }
}
