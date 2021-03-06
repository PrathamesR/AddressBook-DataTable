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
                Console.WriteLine(contact["firstName"] + " " + contact["lastName"] + " " + contact["address"] + " " + contact["city"] + " " + contact["state"] + " " + contact["zip"] + " " + contact["phoneNumber"] + " " + contact["email"]);
        }

        public void EditContact()
        {
            Console.WriteLine("Enter First Name to edit: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter value \n1.firstName \n2.lastName \n3.address \n4.city \n5.state \n6.zip \n7.phoneNumber \n8.email");
            int choice = int.Parse(Console.ReadLine());
            string[] properties = { "firstName", "lastName", "address", "city", "state", "zip", "phoneNumber", "email" };

            var row = (from contact in addressBook.AsEnumerable()
                       where (string)contact["firstName"] == name
                       select contact);

            Console.WriteLine("Enter new Value");
            Type type = row.First()[properties[choice - 1]].GetType();
            row.First()[properties[choice - 1]] = Convert.ChangeType(Console.ReadLine(), type);

            Console.WriteLine("Edited contact successfully");
        }

        public void DeleteContact()
        {

            Console.WriteLine("Enter First Name to delete: ");
            string name = Console.ReadLine();

            var row = from contact in addressBook.AsEnumerable()
                      where (string)contact["firstName"] == name
                      select contact;

            for (int i = 0; i < row.AsEnumerable().Count(); i++)
                row.ElementAt(i).Delete();

            Console.WriteLine("Deleted contact successfully");
        }

        public void GetRecordsByCity()
        {
            Console.WriteLine("Enter City: ");
            string city = Console.ReadLine();

            var row = from contact in addressBook.AsEnumerable()
                      where (string)contact["city"] == city
                      select contact;

            foreach (var contact in row)
                Console.WriteLine(contact["firstName"] + " " + contact["lastName"] + " " + contact["address"] + " " + contact["city"] + " " + contact["state"] + " " + contact["zip"] + " " + contact["phoneNumber"] + " " + contact["email"]);
        }

        public void GetRecordsByState()
        {
            Console.WriteLine("Enter State: ");
            string state = Console.ReadLine();

            var row = from contact in addressBook.AsEnumerable()
                      where (string)contact["state"] == state
                      select contact;

            foreach (var contact in row)
                Console.WriteLine(contact["firstName"] + " " + contact["lastName"] + " " + contact["address"] + " " + contact["city"] + " " + contact["state"] + " " + contact["zip"] + " " + contact["phoneNumber"] + " " + contact["email"]);
        }

        public void GetSizeByState()
        {
            var Data = from contact in addressBook.AsEnumerable()
                       group contact by contact["state"] into States
                       select new { State = States.Key, Count = States.Count() };

            foreach (var row in Data)
                Console.WriteLine("State: " + row.State + " Count: " + row.Count);
        }

        public void GetSizeByCity()
        {
            var Data = from contact in addressBook.AsEnumerable()
                       group contact by contact["city"] into City
                       select new { City = City.Key, Count = City.Count() };

            foreach (var row in Data)
                Console.WriteLine("City: " + row.City + " Count: " + row.Count);
        }

        public void GetSortedRecordsByCity()
        {
            Console.WriteLine("Enter City: ");
            string city = Console.ReadLine();

            var row = from contact in addressBook.AsEnumerable()
                      where (string)contact["city"] == city
                      orderby ((string)contact["firstName"] + (string)contact["lastName"])
                      select contact;

            foreach (var contact in row)
                Console.WriteLine(contact["firstName"] + " " + contact["lastName"] + " " + contact["address"] + " " + contact["city"] + " " + contact["state"] + " " + contact["zip"] + " " + contact["phoneNumber"] + " " + contact["email"]);

        }

        public void GetSortedRecordsByState()
        {
            Console.WriteLine("Enter State: ");
            string state = Console.ReadLine();

            var row = from contact in addressBook.AsEnumerable()
                      where (string)contact["state"] == state
                      orderby ((string)contact["firstName"] + (string)contact["lastName"])
                      select contact;

            foreach (var contact in row)
                Console.WriteLine(contact["firstName"] + " " + contact["lastName"] + " " + contact["address"] + " " + contact["city"] + " " + contact["state"] + " " + contact["zip"] + " " + contact["phoneNumber"] + " " + contact["email"]);
        }

        public void AddNameandType()
        {
            Console.WriteLine("Enter Address Book Name: ");
            addressBook.TableName = Console.ReadLine();

            addressBook.Columns.Add("Type", typeof(string));
            addressBook.Columns["Type"].DefaultValue = "NA";
        }

        public void InsertNewContact(string firstname, string lastName, string address, string city, string state, decimal zip, decimal phoneNumber, string email, string type)
        {
            addressBook.Rows.Add(firstname, lastName, address, city, state, zip, phoneNumber, email, type);
        }

        public void GetCountByType()
        {
            var Data = from contact in addressBook.AsEnumerable()
                       group contact by contact["Type"] into Type
                       select new { Type = Type.Key, Count = Type.Count() };

            foreach (var row in Data)
                Console.WriteLine("City: " + row.Type + " Count: " + row.Count);
        }
    }
}    