using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam2
{
    public class PersonData
    {
        public string password { get; set; }
        public string dateOfBirth { get; set; }

        public PersonData(string password, string dateOfBirth)
        {
            this.password = password;
            this.dateOfBirth = dateOfBirth;
        }

        public PersonData(string password)
        {
            this.password = password;
            dateOfBirth = "";
        }

        public PersonData()
        {

        }
    }
}
