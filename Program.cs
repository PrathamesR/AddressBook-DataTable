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
            obj.InsertNewContact("dsfons", "fsdf", "VartakNagar", "Thane", "Mno", 132456, 789456123, "rajput@gmail.com");
            obj.InsertNewContact("Abc", "Def", "Ghi", "Jkl", "Mno", 132456, 789456123, "abc@gmail.com");
            obj.DisplayAddressBook();
            /*
            obj.EditContact();
            obj.DisplayAddressBook();
            obj.DeleteContact();
            obj.DisplayAddressBook();           
            obj.GetRecordsByState();
            obj.GetRecordsByCity();
            */
            obj.GetSizeByState();
            obj.GetSizeByCity();
            obj.GetSortedRecordsByCity();
            obj.GetSortedRecordsByState();
            obj.InsertNewContact("Abc", "Def", "Ghi", "Jkl", "Mno", 132456, 789456123, "abc@gmail.com","Friend");
            obj.InsertNewContact("Abcsdf", "Def", "Ghi", "ew", "xcv", 489123, 789456123, "abc@gmail.com","Friend");
            obj.InsertNewContact("sdfc", "sfdsd", "xcv", "sd", "zcxv", 756489, 789456123, "abc@gmail.com","Family");

            Console.Read();
        }
    }
}
