using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace BusinessLayer
{
    public static class clsGlobal
    {
        public static DataTable tbAgents
        {
            get; set;
        }

        public static DataTable tbAdministrators
        {
            get; set;
        }

        public static DataTable tbClients
        {
            get; set;
        }

        public static DataTable tbHouses
        {
            get; set;
        }


        public static DataTable tbCompany
        {
            get;
            set;
        }

        public static DataTable tbSales
        {
            get;set;
        }

    }
}
