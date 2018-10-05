using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class clsAdministrator : clsEmployee
    {     
        public clsAdministrator(int id, string name, string email, string phone, DateTime date, string ssn, string password) : base(id, name, email, phone, date, ssn, password) { }

        public clsAdministrator() : base() { }

        public void AddAgent(clsAgent agent)
        {
            DataRow myRow = clsGlobal.tbAgents.NewRow();
            myRow["AgentID"] = agent.Id;
            myRow["Nom"] = agent.Name;
            myRow["Email"] = agent.Email;
            myRow["Cellulaire"] = agent.Phone;
            myRow["NAS"] = agent.Ssn;
            myRow["DateEmbauche"] = agent.Hire_date;
            myRow["Password"] = agent.Password;
            clsGlobal.tbAgents.Rows.Add(myRow);
        }

        public void EditAgent(clsAgent agent)
        {
            foreach (DataRow myrow in clsGlobal.tbAgents.Rows)
            {
                if (myrow["AgentID"].ToString() == agent.Id.ToString())
                {
                    myrow["Nom"] = agent.Name;
                    myrow["Email"] = agent.Email;
                    myrow["Cellulaire"] = agent.Phone;
                    myrow["NAS"] = agent.Ssn;
                    myrow["DateEmbauche"] = agent.Hire_date;
                    myrow["Password"] = agent.Password;
                }
            }
        }

        public void DeleteAgent(clsAgent agent)
        {
            foreach (DataRow myrow in clsGlobal.tbAgents.Rows)
            {
                if(myrow["AgentID"].ToString() == agent.Id.ToString()){
                    myrow.Delete();
                }
            }
        }

        public void AddAdministrator(clsAdministrator admin)
        {
            DataRow myRow = clsGlobal.tbAdministrators.NewRow();
            myRow["AdminID"] = admin.Id;
            myRow["Nom"] = admin.Name;
            myRow["Email"] = admin.Email;
            myRow["Cellulaire"] = admin.Phone;
            myRow["NAS"] = admin.Ssn;
            myRow["DateEmbauche"] = admin.Hire_date;
            myRow["Password"] = admin.Password;
            clsGlobal.tbAdministrators.Rows.Add(myRow);
        }

        public void EditAdministrator(clsAdministrator admin)
        {
            foreach (DataRow myrow in clsGlobal.tbAdministrators.Rows)
            {
                if (myrow["AdminID"].ToString() == admin.Id.ToString())
                {
                    myrow["Nom"] = admin.Name;
                    myrow["Email"] = admin.Email;
                    myrow["Cellulaire"] = admin.Phone;
                    myrow["NAS"] = admin.Ssn;
                    myrow["DateEmbauche"] = admin.Hire_date;
                    myrow["Password"] = admin.Password;
                }
            }
        }

        public void DeleteAdministrator(clsAdministrator admin)
        {
            foreach (DataRow myrow in clsGlobal.tbAdministrators.Rows)
            {
                if (myrow["AdminID"].ToString() == admin.Id.ToString())
                {
                    myrow.Delete();
                }
            }
        }
    }
}
