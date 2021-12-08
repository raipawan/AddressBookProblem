using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblem
{
    class AddressBook
    {
        Dictionary<string, Contact> ContactList;

        public AddressBook()
        {
            this.ContactList = new Dictionary<string, Contact>();
        }
        public bool AddContact(Contact contact)
        {
            string name = contact.FirstName + " " + contact.LastName;
            if (!ContactList.ContainsKey(name))
            {
                ContactList.Add(name, contact);
                return true;
            }
            return false;
        }

        public bool RemoveContact(string name)
        {
            if (ContactList.ContainsKey(name))
            {
                ContactList.Remove(name);
                return true;
            }
            return false;
        }

        public Contact SearchContact(string name)
        {
            Contact contact = null;
            if (ContactList.ContainsKey(name))
            {
                contact = ContactList[name];
                Console.WriteLine("Contact name is :" + contact.FirstName + " " + contact.LastName);
                Console.WriteLine("Contact mob No. is :" + contact.PhoneNumber);
                Console.WriteLine("Contact email is :" + contact.Email);
                Console.WriteLine("Contact address is :" + contact.Address());
            }
            return contact;
        }

        public bool EditContact(Contact newContact)
        {
            string name = newContact.FirstName + " " + newContact.LastName;
            if (ContactList.ContainsKey(name))
            {
                ContactList[name] = newContact;
                return true;
            }
            return false;

        }

        public string GetAddress(string name)
        {
            if (ContactList.ContainsKey(name))
            {
                Contact contact = null;
                string address = contact.City + " " + contact.State + " " + contact.PinCode;
                return address;
            }
            return null;
        }
    }
}
