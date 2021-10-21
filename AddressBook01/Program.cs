using System;
using System.Collections.Generic;

namespace AddressBook01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Class variable declaration
            int num;
            string keyPress ="o" ;
            //below lines of code is executed at the begining to guide the user to enter their choice
            Console.WriteLine("*****Welcome to the address book program*****");
            Console.WriteLine();
            Console.WriteLine("Select the option that you would like to perform.");
            Console.WriteLine();
            //declaring address book object to be used in the below cases
            AddressBook Person = new AddressBook();

            while (keyPress != "n")
            {
                Console.WriteLine("1- Add contact, 2- View all contacts, 3- Edit contact");
                num = Convert.ToInt32(Console.ReadLine());
                
                switch (num)                                            //this switch case selects or enables the user to select multiple cases
                {
                    case 1:
                        Person.AddAddress();                            //method to add a new contact
                        break;

                    case 2:
                        Person.View();                                  //method invoking to view all the contacts
                        break;

                    case 3:
                        Person.Edit();                                  //method to edit the contacts
                        break;

                }
                Console.WriteLine("Do you wish to continue?----- Press (y/n)");
                keyPress = Console.ReadLine();

            }
        }

    }
}
