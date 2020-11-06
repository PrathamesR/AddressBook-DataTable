using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook obj = new AddressBook();
            obj.CreateAddressBook();
            obj.InsertNewContact("Prathamesh", "Rajput", "VartakNagar", "Thane", "Maharashtra", 132456, 789456123, "rajput@gmail.com");
            obj.InsertNewContact("Abc", "Def", "Ghi", "Jkl", "Mno", 132456, 789456123, "abc@gmail.com");
            obj.DisplayAddressBook();

            Console.Read();
        }
    }
}
