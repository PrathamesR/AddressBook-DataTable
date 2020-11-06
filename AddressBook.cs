﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDataTable
{
    class AddressBook
    {
        static DataTable addressBook = new DataTable();

        public void CreateAddressBook()
        {
            addressBook.Columns.Add("firstName", typeof(string));
            addressBook.Columns.Add("lastName", typeof(string));
            addressBook.Columns.Add("address", typeof(string));
            addressBook.Columns.Add("city", typeof(string));
            addressBook.Columns.Add("state", typeof(string));
            addressBook.Columns.Add("zip", typeof(decimal));
            addressBook.Columns.Add("phoneNumber", typeof(decimal));
            addressBook.Columns.Add("email", typeof(string));
        }
        
        public void InsertNewContact(string firstname, string lastName, string address, string city, string state, decimal zip, decimal phoneNumber, string email)
        {
            addressBook.Rows.Add(firstname, lastName, address, city, state, zip, phoneNumber, email);
        }

        public void DisplayAddressBook()
        {
            foreach (var contact in addressBook.AsEnumerable())
                Console.WriteLine(contact["firstName"] +" " + contact["lastName"] + " " + contact["address"] + " " + contact["city"] + " " + contact["state"] + " " + contact["zip"] + " " + contact["phoneNumber"] + " " + contact["email"]);
        }
    }
}
    