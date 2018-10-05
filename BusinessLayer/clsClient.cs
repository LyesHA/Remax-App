using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class clsClient : clsPerson
    {
        private enumClientType type;
        private int agentId;

        public enumClientType Type { get => type; set => type = value; }

        public int AgentId { get => agentId; set => agentId = value; }

        public clsClient() : base() { }

        public clsClient(int id, string name, string email, string phone,enumClientType type, int agentId) : base(id, name, email, phone)
        {
            this.Type = type;
            this.AgentId = agentId;
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
                if (myrow["ClientID"].ToString() == client.Id.ToString())
                {
                    myrow["Nom"] = client.Name;
                    myrow["Phone"] = client.Phone;
                    myrow["Email"] = client.Email;
                    myrow["Type"] = client.Type.ToString();
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
