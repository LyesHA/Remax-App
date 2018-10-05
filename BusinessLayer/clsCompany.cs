using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class clsCompany
    {
        private string name;
        private string siege;


        public clsCompany(string name, string siege)
        {
            this.Name = name;
            this.Siege = siege;
        }

        public clsCompany() { }

        public string Name { get => name; set => name = value; }
        public string Siege { get => siege; set => siege = value; }
    }
}
