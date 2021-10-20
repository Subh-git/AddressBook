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
            //below lines of code is executed at the begining to guide the user to enter their choice
            Console.WriteLine("*****Welcome to the address book program*****");
            Console.WriteLine();
            Console.WriteLine("Select the option that you would like to perform.");
            Console.WriteLine("1- Add contact, 2- View contact");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch(num)                                            //this switch case selects or enables the user to select multiple cases
            {
                case 1:
                    AddressBook myobj1 = new AddressBook();
                    myobj1.AddAddress();
                    myobj1.View();
                    break;

                case 2:
                    AddressBook myobj2 = new AddressBook();
                    myobj2.View();
                    break;
            }
        }

    }
}
