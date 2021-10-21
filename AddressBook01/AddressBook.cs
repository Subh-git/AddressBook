﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook01
{
    /// <summary>
    /// This is the main address book class that has all the methods defined in it.
    /// </summary>
    class AddressBook
    {
        //declaring a list with the class Contacts as the type
        public List<Contacts> contact = new List<Contacts>();
        public void AddAddress()
        {
            //creating a new object contactBook of the class Contacts to add addressess
            Contacts contactBook = new Contacts();
            Console.Write("Enter First Name - ");
            contactBook.firstName = Console.ReadLine();
            Console.Write("Enter Last Name - ");
            contactBook.lastName = Console.ReadLine();
            Console.Write("Enter Address - ");
            contactBook.address = Console.ReadLine();
            Console.Write("Enter Phone number - ");
            contactBook.phoneNumber = Console.ReadLine();
            Console.Write("Enter Email ID - ");
            contactBook.email = Console.ReadLine();
            Console.Write("Enter City - ");
            contactBook.city = Console.ReadLine();
            Console.Write("Enter State - ");
            contactBook.state = Console.ReadLine();
            Console.Write("Enter ZIP code - ");
            contactBook.zip = Console.ReadLine();

            //Addidng to the list
            contact.Add(contactBook);
        }

        public void View()                                              //this is  the method to view all the contacts stored currently
        {
            if (contact.Count==0)                                       // this if statement shows that there is nothing in the list
            {
                Console.WriteLine("Currently there are no people added in your addressbook.");
            }
            else
            {
                Console.WriteLine("Here is the list and details of all the contacts in your addressbook.");

                foreach (var Details in contact)                  //this foreacch loops iterates through all the contacts objects in the contacts class
                {
                    //this returns the variables that we have stored 
                    Console.WriteLine("First Name -" + Details.firstName);
                    Console.WriteLine("Last Name -" + Details.lastName);
                    Console.WriteLine("Address -" + Details.address);
                    Console.WriteLine("Phone Number - " + Details.phoneNumber);
                    Console.WriteLine("Email ID -" + Details.email);
                    Console.WriteLine("City -" + Details.city);
                    Console.WriteLine("State -" + Details.state);
                    Console.WriteLine("ZIP code -" + Details.zip);
                    Console.WriteLine("-----------------------------------------------------------");
                }
            }

        }

        public void Edit()                          //this method lets the user edit the details based on their firstname
        {
            Console.WriteLine("Enter the first name of the contact you want to Modify.");
            Console.WriteLine();
            string fname = Console.ReadLine();      // taking the input of first name
            foreach (var Details in contact)
            {
                if (fname == Details.firstName)
                {
                    // below codes are similar to that of adding a contact.
                    Console.Write("Enter First Name - ");
                    Details.firstName = Console.ReadLine();
                    Console.Write("Enter Last Name - ");
                    Details.lastName = Console.ReadLine();
                    Console.Write("Enter Address - ");
                    Details.address = Console.ReadLine();
                    Console.Write("Enter Phone number - ");
                    Details.phoneNumber = Console.ReadLine();
                    Console.Write("Enter Email ID - ");
                    Details.email = Console.ReadLine();
                    Console.Write("Enter City - ");
                    Details.city = Console.ReadLine();
                    Console.Write("Enter State - ");
                    Details.state = Console.ReadLine();
                    Console.Write("Enter ZIP code - ");
                    Details.zip = Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("No such entry found. Please check and try again!");
                    break;
                }
            }


        }
    }
}
