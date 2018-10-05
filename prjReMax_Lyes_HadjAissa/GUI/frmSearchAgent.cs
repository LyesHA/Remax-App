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
    public partial class frmSearchAgent : Form
    {
        public frmSearchAgent()
        {
            InitializeComponent();
        }
        DataTable tableAgent;

        private void frmSearchAgent_Load(object sender, EventArgs e)
        {
            cboAgentID.Enabled = false;
            tableAgent = clsGlobal.tbAgents;
            DisplayRefAgent();
            cbo.Enabled = false;
        }
        private void DisplayRefAgent()
        {
            cboAgentID.DisplayMember = "AgentID";
            cboAgentID.ValueMember = "AgentID";
            cboAgentID.DataSource = tableAgent;
        }

        private void chkAgentID_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAgentID.Checked)
            {
                cboAgentID.Enabled = true;
            }
            if (!chkAgentID.Checked)
            {
                cboAgentID.Enabled = false;
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chkAgentID.Checked && !chkAllAgent.Checked)
            {
                var result = from DataRow myrow in tableAgent.Rows
                             where myrow.Field<Int32>("AgentID").ToString() == cboAgentID.SelectedValue.ToString()
                             select new {Reference_Agent = myrow.Field<Int32>("AgentID"), Nom = myrow.Field<string>("Nom"), Email = myrow.Field<string>("Email"), Telephone = myrow.Field<string>("Cellulaire"), DateEmbauche = myrow.Field<DateTime>("DateEmbauche") };
                GridAgent.DataSource = result.ToList();
            }
            else if (!chkAgentID.Checked && chkAllAgent.Checked)
            {
                GridAgent.DataSource = tableAgent;
                GridAgent.Columns["Password"].Visible = false;
                GridAgent.Columns["NAS"].Visible = false;
            }
            else
            {
                MessageBox.Show("Veuillez choisir qu'un seule choix !!", "Information !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
