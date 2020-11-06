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
            //UC1
            AddressBook obj = new AddressBook();

            //UC2
            obj.CreateAddressBook();

            //UC3
            obj.InsertNewContact("Prathamesh", "Rajput", "VartakNagar", "Thane", "Maharashtra", 132456, 789456123, "rajput@gmail.com");
            obj.InsertNewContact("dsfons", "fsdf", "VartakNagar", "Thane", "Mno", 132456, 789456123, "rajput@gmail.com");
            obj.InsertNewContact("Abc", "Def", "Ghi", "Jkl", "Mno", 132456, 789456123, "abc@gmail.com");
            obj.DisplayAddressBook();
            
            //UC4
            obj.EditContact();
            obj.DisplayAddressBook();

            //UC5
            obj.DeleteContact();
            obj.DisplayAddressBook(); 
            
            //UC6
            obj.GetRecordsByState();
            obj.GetRecordsByCity();

            //UC7
            obj.GetSizeByState();
            obj.GetSizeByCity();

            //UC8
            obj.GetSortedRecordsByCity();
            obj.GetSortedRecordsByState();

            //UC9
            obj.AddNameandType();

            //UC11
            obj.InsertNewContact("Abc", "Def", "Ghi", "Jkl", "Mno", 132456, 789456123, "abc@gmail.com","Friend");
            obj.InsertNewContact("Abcsdf", "Def", "Ghi", "ew", "xcv", 489123, 789456123, "abc@gmail.com","Friend");
            obj.InsertNewContact("sdfc", "sfdsd", "xcv", "sd", "zcxv", 756489, 789456123, "abc@gmail.com","Family");

            //UC10
            obj.GetCountByType();


            Console.Read();
        }
    }
}
