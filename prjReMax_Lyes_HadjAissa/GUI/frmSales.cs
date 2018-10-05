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
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }
        int courant;
        string mode;
        private void frmSales_Load(object sender, EventArgs e)
        {
            courant = 0;
            tbClientToCboBuyer();
            tbClientToCboSeller();
            tbAgentToCboAgent();
            GridSales.DataSource = clsGlobal.tbSales;
            GridSales.Columns["RefSale"].Visible = false;
            Row2Txt();
        }

        private void tbClientToCboBuyer()
        {
            var result = from DataRow myrow in clsGlobal.tbClients.Rows
                         where myrow.Field<string>("Type").ToString() == "Buyer"
                         select new { RefBuyer = myrow.Field<Int32>("ClientID").ToString(), Nom = myrow.Field<string>("Nom").ToString() };
            cboBuyer.DataSource = result.ToList();
            cboBuyer.DisplayMember = "Nom";
            cboBuyer.ValueMember = "RefBuyer";
        }

        private void tbClientToCboSeller()
        {
            var result = from DataRow myrow in clsGlobal.tbClients.Rows
                         where myrow.Field<string>("Type").ToString() == "Seller"
                         select new { RefSeller = myrow.Field<Int32>("ClientID").ToString(), Nom = myrow.Field<string>("Nom").ToString() };
            cboSeller.DataSource = result.ToList();
            cboSeller.DisplayMember = "Nom";
            cboSeller.ValueMember = "RefSeller";
        }

        private void tbAgentToCboAgent()
        {
            cboAgent.DataSource = clsGlobal.tbAgents;
            cboAgent.DisplayMember = "Nom";
            cboAgent.ValueMember = "AgentID";
        }

        private void Row2Txt()
        {
            txtRefHouse.Text = clsGlobal.tbSales.Rows[courant]["RefHouse"].ToString();
            DataColumn[] key = new DataColumn[1];
            key[0] = clsGlobal.tbAgents.Columns["AgentID"];
            clsGlobal.tbAgents.PrimaryKey = key;
            DataRow myRow = clsGlobal.tbAgents.Rows.Find(clsGlobal.tbSales.Rows[courant]["RefAgent"].ToString());
            cboAgent.Text = myRow["Nom"].ToString();
            DataRow[] row = clsGlobal.tbClients.Select("ClientID = " + clsGlobal.tbSales.Rows[courant]["RefClientBuyer"]);
            cboBuyer.Text = row[0]["Nom"].ToString();
            row = clsGlobal.tbClients.Select("ClientID = " + clsGlobal.tbSales.Rows[courant]["RefClientSeller"]);
            cboSeller.Text = row[0]["Nom"].ToString();
            dateVente.Value = Convert.ToDateTime(clsGlobal.tbSales.Rows[courant]["DateDeVente"]);
            lblInfo.Text = "Vente #" + (courant + 1) + " sur " + clsGlobal.tbSales.Rows.Count;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            courant = 0;
            Row2Txt();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (courant != clsGlobal.tbSales.Rows.Count - 1)
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

        private void btnLast_Click(object sender, EventArgs e)
        {
            courant = clsGlobal.tbSales.Rows.Count - 1;
            Row2Txt();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mode != "Ajout")
            {
                MessageBox.Show("Veuillez d'abord cliquer sur Ajouter !!","Informations",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                clsSale sale = new clsSale();
                sale.RefAgent = Convert.ToInt32(cboAgent.SelectedValue);
                sale.RefClientBuyer = Convert.ToInt32(cboBuyer.SelectedValue);
                sale.RefClientSeller = Convert.ToInt32(cboSeller.SelectedValue);
                sale.RefHouse = Convert.ToInt32(txtRefHouse.Text);
                sale.DateDeVente = dateVente.Value;
                sale.AddSale(sale);
                clsDataAdmin.UpdateSales(clsGlobal.tbSales);
                courant = clsGlobal.tbSales.Rows.Count - 1;
                
                Row2Txt();
            }
            mode = "";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboAgent.Focus();
            txtRefHouse.Text = "";
            lblInfo.Text = "Mode Ajout!!";
            mode = "Ajout";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            courant = 0;
            Row2Txt();
        }
    }
}
