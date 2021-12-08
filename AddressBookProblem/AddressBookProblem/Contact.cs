using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblem
{
    class Contact
    {
        public string FirstName;
        public string LastName;
        public string City;
        public string State;
        public string PinCode;
        public string PhoneNumber;
        public string Email;

        public Contact(string firstName, string lastName, string city, string state, string pinCode, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            State = state;
            PinCode = pinCode;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public string Address()
        {

            string address = "City" + " " + "State" + " " + "PinCode";
            return address;

        }
    }
