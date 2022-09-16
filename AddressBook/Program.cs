using System;

namespace AddressBookProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome To Address Book Program!");
            //CreateContacts createContacts = new CreateContacts();
            //createContacts.CreateContact();

            // Console.WriteLine("Add New Contacts Program");
            // AddNewContacts addNewCon = new AddNewContacts();
            // addNewCon.addNewContacts();

            //Console.WriteLine("Update Existing Contact Program");
            //UpdateExistingContact update = new UpdateExistingContact();
            //update.UpdateContact();

            //Console.WriteLine("Delete a Contact Program");
            //DeleteContact deleteContact = new DeleteContact();
            //deleteContact.ContactDelete();
            //Console.ReadKey();

            Console.WriteLine("Welcome to Address Book Program in AddressBookMain class on  Branch UC5");
            //Console.WriteLine("Enter first name");
            //String firstName = Console.ReadLine();
            AddressBook.SetAddress();
        }
    }
}