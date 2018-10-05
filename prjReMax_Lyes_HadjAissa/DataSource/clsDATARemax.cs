using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace prjReMax_Lyes_HadjAissa.DataSource
{
    public static  class clsDATARemax
    {
        public static OleDbConnection GetConnection()
        {
            string path = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Lyes\Desktop\Collège Lasalle\4e Session\Programmation évenmentielle\Projet Remax\prjReMax_Lyes_HadjAissa\prjReMax_Lyes_HadjAissa\bin\Data\prjRemaxDataBase.mdb";
            OleDbConnection mycon = new OleDbConnection(path);
            return mycon;
        }
        public static DataSet myset;

        public static OleDbDataAdapter adpAdmin;

        public static OleDbDataAdapter adpAgent;

        public static OleDbDataAdapter adpClient;
        
    }
}
