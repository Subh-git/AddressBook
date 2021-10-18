using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook01
{
   public class Contacts
    {
        public string firstName;
        public string lastName;
        public string address;
        public string phoneNumber;
        public string email;
        public string city;
        public string state;
        public string zip;

        public Contacts(string firstName, string lastName, string address, string phoneNumber, string email, string city, string state, string zip )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.city = city;
            this.state = state;
            this.zip = zip;


        }
    }
}
