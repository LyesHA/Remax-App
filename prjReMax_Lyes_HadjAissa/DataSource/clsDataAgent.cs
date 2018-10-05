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
    public static class clsDataAgent
    {
        public static Int32 GetAgent(string email, string password)
        {
            try
            {
                OleDbConnection connection = clsDATARemax.GetConnection();
                connection.Open();
                OleDbCommand mycmd = new OleDbCommand("SELECT AgentID, EMAIL,PASSWORD FROM AGENT WHERE EMAIL= @email AND PASSWORD = @password", connection);
                mycmd.Parameters.AddWithValue("@email", email);
                mycmd.Parameters.AddWithValue("@password", password);
                OleDbDataReader myred = mycmd.ExecuteReader();
                if (myred.Read())
                {
                    int id = Convert.ToInt32(myred["AgentID"].ToString());
                    return id;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetAgents()
        {
            clsDATARemax.myset = new DataSet();
            OleDbConnection connection = clsDATARemax.GetConnection();
            connection.Open();
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM AGENT", connection);
            clsDATARemax.adpAgent = new OleDbDataAdapter(mycmd);
            clsDATARemax.adpAgent.Fill(clsDATARemax.myset, "Agent");
            return clsDATARemax.myset.Tables["Agent"];
        }

        public static DataTable getClients(int RefAgent)
        {
            DataSet myset = new DataSet();
            OleDbConnection connection = clsDATARemax.GetConnection();
            connection.Open();
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM Client WHERE AgentID = @RefAgent", connection);
            mycmd.Parameters.AddWithValue("@RefAgent", RefAgent);
            OleDbDataAdapter adpClient = new OleDbDataAdapter(mycmd);
            adpClient.Fill(myset, "Client");
            return myset.Tables["Client"];
        }

        public static DataTable getHouses(int RefAgent)
        {
            DataSet myset = new DataSet();
            OleDbConnection connection = clsDATARemax.GetConnection();
            connection.Open();
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM House WHERE AgentID = @RefAgent", connection);
            mycmd.Parameters.AddWithValue("@RefAgent", RefAgent);
            OleDbDataAdapter adpHouses = new OleDbDataAdapter(mycmd);
            adpHouses.Fill(myset, "House");
            return myset.Tables["House"];
        }
    }
}
