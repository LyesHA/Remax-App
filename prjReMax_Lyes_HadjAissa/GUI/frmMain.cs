using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjReMax_Lyes_HadjAissa.GUI;
using BusinessLayer;
using prjReMax_Lyes_HadjAissa.DataSource;

namespace prjReMax_Lyes_HadjAissa
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            clsGlobal.tbCompany = clsDataAdmin.GetCompany();
            if (frmLogin.Usermode == "Admin")
            {
                clsGlobal.tbAdministrators = clsDataAdmin.getAdmins();
                clsGlobal.tbAgents = clsDataAdmin.getAgents();
                clsGlobal.tbClients = clsDataAdmin.getClients();
                clsGlobal.tbHouses = clsDataAdmin.getHouses();
                clsGlobal.tbSales = clsDataAdmin.getSales();
            }
            else if (frmLogin.Usermode == "Agent")
            {
                int id = frmLogin.IdAgent;
                clsGlobal.tbClients = clsDataAgent.getClients(id);
                clsGlobal.tbHouses = clsDataAgent.getHouses(id);
                clsGlobal.tbAgents = clsDataAdmin.getAgents();
                Enable_btn(false,false, false, true, true, false, false);
            }
            else if (frmLogin.Usermode == "User")
            {
                MessageBox.Show("Bienvenue à l'entreprise " + clsGlobal.tbCompany.Rows[0]["Nom"].ToString() +
    "\nNotre siège social se situe à : " + clsGlobal.tbCompany.Rows[0]["siege"].ToString(),"Bienvenue!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                clsGlobal.tbAgents = clsDataAdmin.getAgents();
                clsGlobal.tbHouses = clsDataAdmin.getHouses();
                Enable_btn(false,false, false, false, false, true, true);
            }
        }

        private void Enable_btn(bool menuSales,bool menuAdmin,bool menuAgent,bool menuClient,bool menuHouse,bool SearchAgent,bool SearchHouse)
        {
            this.salesToolStripMenuItem.Enabled = menuSales;
            this.administratorsToolStripMenuItem.Enabled = menuAdmin;
            this.agentsToolStripMenuItem1.Enabled = menuAgent;
            this.clientsToolStripMenuItem.Enabled = menuClient;
            this.housesToolStripMenuItem.Enabled = menuHouse;
            this.searchagentsToolStripMenuItem.Enabled = SearchAgent;
            this.searchhouseToolStripMenuItem.Enabled = SearchHouse;
        }

        private void btnSearchHouse_Click(object sender, EventArgs e)
        {
            frmSearchHouse fr = new frmSearchHouse();
            fr.ShowDialog();
        }

        private void btnSearchAgent_Click(object sender, EventArgs e)
        {
            
        }

        private void administratorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin fr = new frmAdmin();
            fr.MdiParent = this;
            fr.Show();
        }

        private void houseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchHouse fr = new frmSearchHouse();
            fr.MdiParent = this;
            fr.Show();
        }

        private void agentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchAgent fr = new frmSearchAgent();
            fr.MdiParent = this;
            fr.Show();
        }

        private void agentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAgent fr = new frmAgent();
            fr.MdiParent = this;
            fr.Show();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClient fr = new frmClient();
            fr.MdiParent = this;
            fr.Show();
        }

        private void housesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHouse fr = new frmHouse();
            fr.MdiParent = this;
            fr.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etês vous sur de vouloir vous déconnecter?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsGlobal.tbAdministrators = null;
                clsGlobal.tbAgents = null;
                clsGlobal.tbClients = null;
                clsGlobal.tbHouses = null;
                clsGlobal.tbSales = null;
                this.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etês vous sur de vouloir quitter?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSales fr = new frmSales();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}
