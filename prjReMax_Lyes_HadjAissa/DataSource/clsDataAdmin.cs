using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using System.Data.OleDb;
using System.Data;

namespace prjReMax_Lyes_HadjAissa.DataSource
{
    public static class clsDataAdmin
    {
        public static OleDbDataAdapter adpAgent;
        public static DataSet myset;

        public static DataTable GetCompany()
        {
            DataSet myset = new DataSet();
            OleDbConnection connection = clsDATARemax.GetConnection();
            connection.Open();
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM Company", connection);
            OleDbDataAdapter adpCompany = new OleDbDataAdapter(mycmd);
            adpCompany.Fill(myset, "Company");
            return myset.Tables["Company"];
        }

        public static void UpdateAdmin(DataTable tbAdmin)
        {
            DataSet myset = new DataSet();
            OleDbConnection connection = clsDATARemax.GetConnection();
            connection.Open();
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM Administrateur", connection);
            OleDbDataAdapter adpAdmin = new OleDbDataAdapter(mycmd);
            adpAdmin.Fill(myset, "Administrateur");
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adpAdmin);
            adpAdmin.Update(tbAdmin);
        }

        public static DataTable getAdmins()
        {
            DataSet myset = new DataSet();
            OleDbConnection connection = clsDATARemax.GetConnection();
            connection.Open();
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM Administrateur", connection);
            OleDbDataAdapter adpAdmin = new OleDbDataAdapter(mycmd);
            adpAdmin.Fill(myset, "Administrateur");
            return myset.Tables["Administrateur"];
        }

        public static bool GetAdmin(string email,string password)
        {
            try
            {
                OleDbConnection connection = clsDATARemax.GetConnection();
                connection.Open();
                OleDbCommand mycmd = new OleDbCommand("SELECT EMAIL,PASSWORD FROM Administrateur WHERE EMAIL= @email AND PASSWORD = @password", connection);
                mycmd.Parameters.AddWithValue("@email", email);
                mycmd.Parameters.AddWithValue("@password", password);
                OleDbDataReader myred = mycmd.ExecuteReader();
                if (myred.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getAgents()
        {
            myset = new DataSet();
            OleDbConnection connection = clsDATARemax.GetConnection();
            connection.Open();
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM Agent", connection);
            adpAgent = new OleDbDataAdapter(mycmd);
            adpAgent.Fill(myset, "Agent");
            return myset.Tables["Agent"];
        }

        public static void UpdateAgents()
        {
            //OleDbConnection connection = clsDATARemax.GetConnection();
            //connection.Open();
            //OleDbCommand mycmd = new OleDbCommand("SELECT * FROM AGENT", connection);
            //OleDbDataAdapter adpAgent = new OleDbDataAdapter(mycmd);
            //adpAgent.Fill(myset, "Agent");
            try
            {
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adpAgent);
                // System.Windows.Forms.MessageBox.Show(builder.GetInsertCommand().CommandText.ToString());
                //  myset.AcceptChanges();
                adpAgent.Update(clsGlobal.tbAgents);
            }catch(Exception ex)
            {
                 System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public static DataTable getClients()
        {
            DataSet myset = new DataSet();
            OleDbConnection connection = clsDATARemax.GetConnection();
            connection.Open();
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM Client", connection);
            OleDbDataAdapter adpClient = new OleDbDataAdapter(mycmd);
            adpClient.Fill(myset, "Client");
            return myset.Tables["Client"];
        }

        public static void UpdateClients(DataTable tbClient)
        {
            DataSet myset = new DataSet();
            OleDbConnection connection = clsDATARemax.GetConnection();
            connection.Open();
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM Client", connection);
            OleDbDataAdapter adpClient = new OleDbDataAdapter(mycmd);
            adpClient.Fill(myset, "Client");
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adpClient);
            adpClient.Update(tbClient);
        }

        public static DataTable getHouses()
        {
            DataSet myset = new DataSet();
            OleDbConnection connection = clsDATARemax.GetConnection();
            connection.Open();
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM House", connection);
            OleDbDataAdapter adpHouses = new OleDbDataAdapter(mycmd);
            adpHouses.Fill(myset, "House");
            return myset.Tables["House"];
        }

        public static void UpdateHouses(DataTable tbHouses)
        {
            DataSet myset = new DataSet();
            OleDbConnection connection = clsDATARemax.GetConnection();
            connection.Open();
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM House", connection);
            OleDbDataAdapter adpHouses = new OleDbDataAdapter(mycmd);
            adpHouses.Fill(myset, "House");
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adpHouses);
            adpHouses.Update(tbHouses);
        }

        public static DataTable getSales()
        {
            DataSet myset = new DataSet();
            OleDbConnection connection = clsDATARemax.GetConnection();
            connection.Open();
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM Sales", connection);
            OleDbDataAdapter adpSales = new OleDbDataAdapter(mycmd);
            adpSales.Fill(myset, "Sales");
            return myset.Tables["Sales"];
        }

        public static void UpdateSales(DataTable tbSales)
        {
            DataSet myset = new DataSet();
            OleDbConnection connection = clsDATARemax.GetConnection();
            connection.Open();
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM Sales", connection);
            OleDbDataAdapter adpSale = new OleDbDataAdapter(mycmd);
            adpSale.Fill(myset, "Sales");
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adpSale);
            adpSale.Update(tbSales);
        }
    }
}
