using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class clsPerson
    {
        private int id;
        private string name;
        private string email;
        private string phone;

        public clsPerson() { }

        public clsPerson(int id, string name, string email, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Name {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Email {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string Phone {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }

    }

}
