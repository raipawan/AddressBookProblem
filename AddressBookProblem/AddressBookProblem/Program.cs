using System;

namespace AddressBookProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book program");
            Contact contact = new Contact("pavan", "rai", "jhansi", "UP", "284405", "98778987", "raipawan22@gmail.com");

            AddressBook addressBook = new AddressBook();
            addressBook.AddContact(contact);
            addressBook.DislpayContact(contact);

        }

    }
}
