using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class clsEmployee : clsPerson
    {
        private DateTime hire_date;
        private string ssn;
        private string password;

        public clsEmployee() : base() { }
        public clsEmployee(int id, string name, string email, string phone, DateTime date,string ssn,string password) :base(id,name,email,phone)
        {
            this.Hire_date = date;
            this.Ssn = ssn;
            this.Password = password;
        }

        public DateTime Hire_date { get => hire_date; set => hire_date = value; }
        public string Ssn { get => ssn; set => ssn = value; }
        public string Password { get => password; set => password = value; }
    }
}
