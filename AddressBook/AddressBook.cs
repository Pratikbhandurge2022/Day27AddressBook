using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    internal class AddressBook
    {
        public String firstName;
        public String lastName;
        public String address;
        public String city;
        public String state;
        public long zip;
        public long phoneNumber;
        public String email;

        static public void SetAddress()
        {

            AddressBook addressBook = new AddressBook();
            addressBook.firstName = "pratik";
            addressBook.lastName = "Bha";
            addressBook.address = "W Pune";
            addressBook.city = "Pune";
            addressBook.state = "Maharashtra";
            addressBook.zip = 12354;
            addressBook.phoneNumber = 6789009876;
            addressBook.email = "pratik@gmail.com";
            Console.WriteLine(addressBook.firstName);
        }
    }
}