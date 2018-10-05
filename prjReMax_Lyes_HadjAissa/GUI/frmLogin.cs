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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public static string usermode = "";
        public static string Usermode
        {
            get { return usermode; }
            set { usermode = value; }
        }

        public static int idAgent = 0;
        public static int IdAgent
        {
            get { return idAgent; }
            set { idAgent = value; }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Usermode = "User";
            frmMain fr = new frmMain();
            fr.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            grpboxLogin.Hide();
            txtPassword.PasswordChar = '*';
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Usermode = "Admin";
            grpboxLogin.Show();
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            Usermode = "Agent";
            grpboxLogin.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (Usermode == "Admin")
            {
                if(clsDataAdmin.GetAdmin(txtEmail.Text, txtPassword.Text))
                {
                    frmMain fr = new frmMain();
                    fr.ShowDialog();
                    grpboxLogin.Hide();
                }else
                {
                    MessageBox.Show("L'email ou le mot de passe est incorrect.", "Échec de la connexion!",MessageBoxButtons.OK);
                    txtEmail.Focus();
                    txtPassword.Text = "";
                }
            }
            else if (Usermode == "Agent")
            {
                IdAgent = clsDataAgent.GetAgent(txtEmail.Text, txtPassword.Text);
                if (IdAgent != 0) 
                {
                    frmMain fr = new frmMain();
                    fr.ShowDialog();
                    grpboxLogin.Hide();
                }
                else
                {
                    MessageBox.Show("L'email ou le mot de passe est incorrect.", "Échec de la connexion!", MessageBoxButtons.OK);
                    txtEmail.Focus();
                    txtPassword.Text = "";
                }
            }
        }
    }
}
