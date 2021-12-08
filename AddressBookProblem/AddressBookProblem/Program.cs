using System;

namespace AddressBookProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public void CreateContact()
        {
            Console.WriteLine("Please provide contact details in the following pattern");
            Console.WriteLine("FirstName LastName City State Pincode MobileNumber Email");
            string[] contactDetails = Console.ReadLine().Trim().Split(" ");
            Contact contact = AddressBook.SearchContact(contactDetails[0] + " " + contactDetails[1]);
            if (contact == null)
            {
                contact = new Contact(contactDetails[0], contactDetails[1], contactDetails[2], contactDetails[3], contactDetails[4], contactDetails[5], contactDetails[6]);
                bool addResult = AddressBook.AddContact(contact);
                if (addResult)
                    Console.WriteLine("Contact added successfully");
                else
                    Console.WriteLine("Failed to add contact");
            }
            else
                Console.WriteLine("Contact for " + contactDetails[0] + " " + contactDetails[1] + " already present");
        }
    }
}
