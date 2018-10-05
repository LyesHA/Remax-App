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
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }
        int courant;
        string mode;
        private void frmClient_Load(object sender, EventArgs e)
        {
            if (frmLogin.Usermode == "Agent")
            {
                cboAgent.Enabled = false;
            }
            AddEnumType();
            courant = 0;
            dataGridView1.DataSource = clsGlobal.tbClients;
            RemplirAgent();
            Row2Txt();
        }
        private void AddEnumType()
        {
            foreach (var item in Enum.GetValues(typeof(enumClientType)))
            {
                cboType.Items.Add(item);
            }
        }
        private void RemplirAgent()
        {
            cboAgent.ValueMember = "AgentID";
            cboAgent.DisplayMember = "Nom";
            cboAgent.DataSource = clsGlobal.tbAgents;
        }
        private void Row2Txt()
        {
            txtNom.Text = clsGlobal.tbClients.Rows[courant]["Nom"].ToString();
            txtEmail.Text = clsGlobal.tbClients.Rows[courant]["Email"].ToString();
            txtPhone.Text = clsGlobal.tbClients.Rows[courant]["Phone"].ToString();
            cboType.Text = clsGlobal.tbClients.Rows[courant]["Type"].ToString();    
            lblInfo.Text = "Les informations du client " +
                (courant + 1) + " sur " + clsGlobal.tbClients.Rows.Count;
            DataColumn[] key = new DataColumn[1];
            key[0] = clsGlobal.tbAgents.Columns["AgentID"];
            clsGlobal.tbAgents.PrimaryKey = key;
            DataRow myrow = clsGlobal.tbAgents.Rows.Find(clsGlobal.tbClients.Rows[courant]["AgentID"].ToString());
            cboAgent.Text = myrow["Nom"].ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            courant = 0;
            Row2Txt();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (courant != 0)
            {
                courant--;
                Row2Txt();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(courant !=clsGlobal.tbClients.Rows.Count - 1)
            {
                courant++;
                Row2Txt();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            courant = clsGlobal.tbClients.Rows.Count - 1;
            Row2Txt();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            cboType.Text = "";
            lblInfo.Text = "Mode Ajout !!";
            txtNom.Focus();
            mode = "Ajout";
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            txtNom.Focus();
            lblInfo.Text = "Mode Modif !!";
            mode = "Modifier";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            courant = 0;
            Row2Txt();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsClient client = new clsClient();
            int id = clsGlobal.tbClients.Rows.Count;
            client.Name = txtNom.Text;
            client.Email = txtEmail.Text;
            client.Phone = txtPhone.Text;
            client.Type = (enumClientType)Enum.Parse(typeof(enumClientType), cboType.SelectedItem.ToString());
            client.AgentId = Convert.ToInt32(cboAgent.SelectedValue);

            if (mode == "Ajout")
            {
                client.Id = (Convert.ToInt32(clsGlobal.tbClients.Rows[id - 1]["ClientID"]) + 1);
                client.AddClient(client);
                courant = clsGlobal.tbClients.Rows.Count - 1;
            }
            else if (mode == "Modifier")
            {
                client.Id = Convert.ToInt32(clsGlobal.tbClients.Rows[courant]["ClientID"]);
                client.EditClient(client);
            }
            clsDataAdmin.UpdateClients(clsGlobal.tbClients);
            mode = "";
            Row2Txt();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de vouloir supprimer ce client", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clsClient client = new clsClient();
                client.Id = Convert.ToInt32(clsGlobal.tbClients.Rows[courant]["ClientID"]);
                clsAdministrator admin = new clsAdministrator();
                client.DeleteClient(client);
                clsDataAdmin.UpdateClients(clsGlobal.tbClients);
            }
            courant = 0;
            Row2Txt();
        }
    }
}
