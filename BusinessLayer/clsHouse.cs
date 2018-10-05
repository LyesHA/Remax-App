using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class clsHouse
    {
        private int house_id;
        private string type;
        private string localisation;
        private decimal price;
        private int nb_rooms;
        private int nb_bathrooms;
        private string description;
        private int agent_id;

        public clsHouse() : base() { }

        public clsHouse(int house_id, string type, string localisation, decimal price, int nb_rooms, int nb_bathrooms, string description, int agent_id)
        {
            House_id = house_id;
            Type = type;
            Localisation = localisation;
            Price = price;
            Nb_rooms = nb_rooms;
            Nb_bathrooms = nb_bathrooms;
            Description = description;
            Agent_id = agent_id;
        }

        public int House_id { get => house_id; set => house_id = value; }
        public string Type { get => type; set => type = value; }
        public string Localisation { get => localisation; set => localisation = value; }
        public decimal Price { get => price; set => price = value; }
        public int Nb_rooms { get => nb_rooms; set => nb_rooms = value; }
        public int Nb_bathrooms { get => nb_bathrooms; set => nb_bathrooms = value; }
        public string Description { get => description; set => description = value; }
        public int Agent_id { get => agent_id; set => agent_id = value; }

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
                if (myrow["HouseID"].ToString() == house.House_id.ToString())
                {
                    myrow.Delete();
                }

            }
        }
    }
}
