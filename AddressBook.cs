using System;
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
    }
}
    