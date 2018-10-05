using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BusinessLayer;

namespace BusinessLayer
{
    public class clsSale
    {
        private int refSale;
        private int refAgent;
        private int refHouse;
        private int refClientBuyer;
        private int refClientSeller;
        private DateTime dateDeVente;

        public clsSale() { }

        public clsSale(int refSale, int refAgent, int refHouse, int refClientBuyer, int refClientSeller, DateTime dateDeVente)
        {
            this.RefSale = refSale;
            this.RefAgent = refAgent;
            this.RefHouse = refHouse;
            this.RefClientBuyer = refClientBuyer;
            this.RefClientSeller = refClientSeller;
            this.DateDeVente = dateDeVente;
        }

        public int RefSale { get => refSale; set => refSale = value; }
        public int RefAgent { get => refAgent; set => refAgent = value; }
        public int RefHouse { get => refHouse; set => refHouse = value; }
        public int RefClientBuyer { get => refClientBuyer; set => refClientBuyer = value; }
        public int RefClientSeller { get => refClientSeller; set => refClientSeller = value; }
        public DateTime DateDeVente { get => dateDeVente; set => dateDeVente = value; }

        public void AddSale(clsSale sale)
        {
            DataRow myRow = clsGlobal.tbSales.NewRow();
            myRow["RefAgent"] = sale.RefAgent;
            myRow["RefHouse"] = sale.RefHouse;
            myRow["RefClientBuyer"] = sale.RefClientBuyer;
            myRow["RefClientSeller"] = sale.RefClientSeller;
            myRow["DateDeVente"] = sale.DateDeVente;
            clsGlobal.tbSales.Rows.Add(myRow);
        }

    }
}
