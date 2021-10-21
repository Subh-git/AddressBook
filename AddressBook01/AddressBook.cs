using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook01
{
    class AddressBook
    {
       public List<Contacts> contact = new List<Contacts>();
        public void AddAddress()
        {
            Contacts contactBook = new Contacts();
            Console.WriteLine("Enter First Name");
            contactBook.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            contactBook.lastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contactBook.address = Console.ReadLine();
            Console.WriteLine("Enter Phone number");
            contactBook.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email ID");
            contactBook.email = Console.ReadLine();
            Console.WriteLine("Enter City");
            contactBook.city = Console.ReadLine();
            Console.WriteLine("Enter State");
            contactBook.state = Console.ReadLine();
            Console.WriteLine("Enter ZIP code");
            contactBook.zip = Console.ReadLine();

            contact.Add(contactBook);
        }

        public void View()
        {
            foreach (var Details in contact)
            {
                Console.WriteLine("First Name -" + Details.firstName);
                Console.WriteLine("Last Name -" + Details.lastName);
                Console.WriteLine("Address -" + Details.address);
                Console.WriteLine("Phone Number -" + Details.phoneNumber);
                Console.WriteLine("Email ID -" + Details.email);
                Console.WriteLine("City -" + Details.city);
                Console.WriteLine("State -" + Details.state);
                Console.WriteLine("ZIP code -" + Details.zip);
                Console.WriteLine("-----------------------------------------------------------");
            }


        }
    }
}
