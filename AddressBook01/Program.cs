using System;

namespace AddressBook01
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacts myobj = new Contacts("Subhadeep", "Bhattacharjee", "Dohabora chuk", "123456", "subh@gmail.com", "jorhat", "assam", "111111");
            Console.WriteLine("First Name: {0} Last Name: {1} Address: {2} Phone Number: {3} Email: {4} City: {5} State: {6} ZipCode: {7}",myobj.firstName,myobj.lastName, myobj.address, myobj.phoneNumber, myobj.email,myobj.city,myobj.state,myobj.zip);
        }
    }
}
