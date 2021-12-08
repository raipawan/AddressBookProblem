using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblem
{
    public class AddressBook
    {

        List<Contact> contacts = new List<Contact>();

        public bool AddContact(Contact contact)
        {

            if (contact != null)
            {
                contacts.Add(contact);
                return true;
            }
            return false;
        }
        public void DislpayContact(Contact contact)
        {

            foreach (Contact result in contacts)
            {
                Console.WriteLine(result);
            }
        }




    }
}
