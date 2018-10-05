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
using System.Data.OleDb;

namespace prjReMax_Lyes_HadjAissa.GUI
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        int courant;
        string mode;
        
        private void frmEmployee_Load(object sender, EventArgs e)
        {       
            courant = 0;
            Row2Txt();
        }

        private void Row2Txt()
        {
            txtNom.Text = clsGlobal.tbAdministrators.Rows[courant]["Nom"].ToString();
            txtEmail.Text = clsGlobal.tbAdministrators.Rows[courant]["Email"].ToString();
            txtNAS.Text = clsGlobal.tbAdministrators.Rows[courant]["NAS"].ToString();
            txtPhone.Text = clsGlobal.tbAdministrators.Rows[courant]["Cellulaire"].ToString();
            txtPassword.Text = clsGlobal.tbAdministrators.Rows[courant]["Password"].ToString();
          //  dateTimeEmbauche.Value = Convert.ToDateTime(clsGlobal.tbAdministrators.Rows[courant]["DateEmbauche"].ToString());
            lblInfo.Text = "Les informations de l'administrateur " +
                (courant + 1) + " sur " + clsGlobal.tbAdministrators.Rows.Count;
        }

        private void label6_Click(object sender, EventArgs e)
        {

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

        private void btnModify_Click(object sender, EventArgs e)
        {
            txtNom.Focus();
            mode = "Modifier";
            lblInfo.Text = "Mode modification !!";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de vouloir supprimer cet administrateur", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clsAdministrator administrator = new clsAdministrator();
                administrator.Id = Convert.ToInt32(clsGlobal.tbAdministrators.Rows[courant]["AdminID"]);
                administrator.DeleteAdministrator(administrator);
                clsDataAdmin.UpdateAdmin(clsGlobal.tbAdministrators);
            }
            
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsAdministrator administrator = new clsAdministrator();
            int id = clsGlobal.tbAdministrators.Rows.Count;

            administrator.Name = txtNom.Text;
            administrator.Email = txtEmail.Text;
            administrator.Phone = txtPhone.Text;
            administrator.Ssn = txtNAS.Text;
            administrator.Password = txtPassword.Text;
            if (mode == "Ajout")
            {
                administrator.Id = (Convert.ToInt32(clsGlobal.tbAdministrators.Rows[id - 1]["AdminID"]) + 1);
                administrator.AddAdministrator(administrator);
            }
            else if (mode == "Modifier")
            {
                administrator.Id = Convert.ToInt32(clsGlobal.tbAdministrators.Rows[courant]["AdminID"]);
                administrator.EditAdministrator(administrator);
            }
            clsDataAdmin.UpdateAdmin(clsGlobal.tbAdministrators);
            mode = "";
            Row2Txt();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(courant != 0)
            {
                courant--;
                Row2Txt();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(courant != clsGlobal.tbAdministrators.Rows.Count - 1)
            {
                courant++;
                Row2Txt();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            courant = clsGlobal.tbAdministrators.Rows.Count - 1;
            Row2Txt();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            courant = 0;
            Row2Txt();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            courant = 0;
            Row2Txt();
        }
    }
}
