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
    public partial class frmAgent : Form
    {
        public frmAgent()
        {
            InitializeComponent();
        }
        int courant;
        string mode;
        private void frmAgent_Load(object sender, EventArgs e)
        {
            courant = 0;
            dataGridView1.DataSource = clsGlobal.tbAgents;
            Row2Txt();
        }

        private void Row2Txt()
        {
            txtNom.Text = clsGlobal.tbAgents.Rows[courant]["Nom"].ToString();
            txtEmail.Text = clsGlobal.tbAgents.Rows[courant]["Email"].ToString();
            txtNAS.Text = clsGlobal.tbAgents.Rows[courant]["NAS"].ToString();
            txtPhone.Text = clsGlobal.tbAgents.Rows[courant]["Cellulaire"].ToString();
            txtPassword.Text = clsGlobal.tbAgents.Rows[courant]["Password"].ToString();
            dateTimeEmbauche.Value = Convert.ToDateTime(clsGlobal.tbAgents.Rows[courant]["DateEmbauche"]);
            lblInfo.Text = "Les informations de l'agent " +
                (courant + 1) + " sur " + clsGlobal.tbAgents.Rows.Count;
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
            if (courant != clsGlobal.tbAgents.Rows.Count - 1)
            {
                courant++;
                Row2Txt();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            courant = clsGlobal.tbAgents.Rows.Count - 1;
            Row2Txt();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            courant = 0;
            Row2Txt();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtEmail.Text = "";
            txtNAS.Text = "";
            txtPhone.Text = "";
            txtPassword.Text = "";
            lblInfo.Text = "Mode ajout !!";
            mode = "Ajout";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de vouloir supprimer cet administrateur", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clsAgent agent = new clsAgent();
                agent.Id = Convert.ToInt32(clsGlobal.tbAgents.Rows[courant]["AgentID"]);
                clsAdministrator admin = new clsAdministrator();
                admin.DeleteAgent(agent);
                clsDataAdmin.UpdateAgents();
            }
            courant = 0;
            Row2Txt();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            txtNom.Focus();
            mode = "Modifier";
            lblInfo.Text = "Mode modification !!";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsAdministrator admin = new clsAdministrator();
            clsAgent agent = new clsAgent();
            agent.Name = txtNom.Text;
            agent.Email = txtEmail.Text;
            agent.Phone = txtPhone.Text;
            agent.Ssn = txtNAS.Text;
            agent.Password = txtPassword.Text;
            agent.Hire_date = dateTimeEmbauche.Value;
            agent.Id = clsGlobal.tbAgents.Rows.Count + 1;
            clsAgent agent2 = new clsAgent(clsGlobal.tbAgents.Rows.Count + 1, txtNom.Text, txtEmail.Text, txtPhone.Text, dateTimeEmbauche.Value, txtNAS.Text, txtPassword.Text);
            if (mode == "Ajout")
            {
                DataRow myRow = clsGlobal.tbAgents.NewRow();
                myRow["AgentID"] = 50;
                myRow["Nom"] = agent.Name;
                myRow["Email"] = agent.Email;
                myRow["Cellulaire"] = agent.Phone;
                myRow["NAS"] = agent.Ssn;
                myRow["DateEmbauche"] = agent.Hire_date;
                myRow["Password"] = agent.Password;
                clsGlobal.tbAgents.Rows.Add(myRow);
                
                //admin.AddAgent(agent2);
            }
            else if (mode == "Modifier")
            {
                admin.EditAgent(agent);
            }
            clsDataAdmin.UpdateAgents();
            mode = "";
            Row2Txt();
        }
    }
}
