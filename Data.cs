using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Data
{
    public class Data
    {
        
        private int number;
        private string name;
        private string surname;
        private string email;
        private string gender;
        private string ip;

        
        public Data(int number, string name, string surname, string email, string gender, string ip)
        {
            this.number = number;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.gender = gender;
            this.ip = ip;
        }

        // Properties
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string IP
        {
            get { return ip; }
            set { ip = value; }
        }
    }

}
