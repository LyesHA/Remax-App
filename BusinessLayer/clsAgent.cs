using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class clsAgent : clsEmployee
    {
        public clsAgent() : base() { }

        public clsAgent(int id, string name, string email, string phone, DateTime date, string ssn,string password) : base(id, name, email, phone, date, ssn,password)
        {
        }

        public void AddHouse(clsHouse house)
        {
            DataRow myRow = clsGlobal.tbHouses.NewRow();
            myRow["HouseID"] = house.House_id;
            myRow["Type"] = house.Type;
            myRow["Localisation"] = house.Localisation;
            myRow["Prix"] = house.Price;
            myRow["NombreChambre"] = house.Nb_rooms;
            myRow["NombreSalleDeBain"] = house.Nb_bathrooms;
            myRow["Description"] = house.Description;
            myRow["AgentID"] = house.Agent_id;
            clsGlobal.tbHouses.Rows.Add(myRow);
        }

        public void EditHouse(clsHouse house)
        {
            foreach (DataRow myRow in clsGlobal.tbHouses.Rows)
            {
                if (myRow["HouseID"].ToString() == house.House_id.ToString())
                {
                    myRow["Type"] = house.Type;
                    myRow["Localisation"] = house.Localisation;
                    myRow["Prix"] = house.Price;
                    myRow["NombreChambre"] = house.Nb_rooms;
                    myRow["NombreSalleDeBain"] = house.Nb_bathrooms;
                    myRow["Description"] = house.Description;
                    myRow["AgentID"] = house.Agent_id;
                }
            }
        }

        public void DeleteHouse(clsHouse house)
        {
            foreach (DataRow myrow in clsGlobal.tbHouses.Rows)
            {
                myrow.Delete();
            }
        }

        public void AddClient(clsClient client)
        {
            DataRow myrow = clsGlobal.tbClients.NewRow();
            myrow["ClientID"] = client.Id;
            myrow["Nom"] = client.Name;
            myrow["Phone"] = client.Phone;
            myrow["Email"] = client.Email;
            myrow["Type"] = client.Type;
            myrow["AgentID"] = client.AgentId;
            clsGlobal.tbClients.Rows.Add(myrow);
        }

        public void EditClient(clsClient client)
        {
            foreach (DataRow myrow in clsGlobal.tbClients.Rows)
            {
                if(myrow["ClientID"].ToString() == client.Id.ToString())
                {
                    myrow["Nom"] = client.Name;
                    myrow["Phone"] = client.Phone;
                    myrow["Email"] = client.Email;
                    myrow["Type"] = client.Type;
                    myrow["AgentID"] = client.AgentId;
                }
            }
        }

        public void DeleteClient(clsClient client)
        {
            foreach (DataRow myrow in clsGlobal.tbClients.Rows)
            {
                if (myrow["ClientID"].ToString() == client.Id.ToString())
                {
                    myrow.Delete();
                }
            }
        }

    }
}
