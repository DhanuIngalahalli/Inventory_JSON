using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace JSON
{
    class InventoryData
    {
        public InventoryData()
        {

            List<Library> inventoryList = new List<Library>(); //create list 

            Library rice = new Library("Rice", 700, 100); //creating object for rice
            Library pulses = new Library("Pulses", 456, 50);//creating object for pulses
            Library wheats = new Library("Wheats", 874, 90);//creating object for wheats
                                                             //adding grains to inventoryList
            inventoryList.Add(rice);
            inventoryList.Add(pulses);
            inventoryList.Add(wheats);

            //perfroming serialization on inventoryList
            string json = JsonConvert.SerializeObject(inventoryList);
            //json string save to print.json
            File.WriteAllText(@"C:\Users\pooja\Desktop\New folder\InventoryData\print.json", json);

            Console.WriteLine("Data Stored to print.json");
            Console.WriteLine("\n");
            Console.WriteLine("Dispaly Inventory Data");

            //perfroming deserialization on print.json
            string datafile = File.ReadAllText(@"C:\Users\pooja\Desktop\New folder\InventoryData\print.json");
            //to print string datafile
            List<Library> returnDataObj = JsonConvert.DeserializeObject<List<Library>>(datafile);

            foreach (var form in returnDataObj)
            {

                Console.WriteLine("Name : " + form.Name);
                Console.WriteLine("Weight : " + form.Weight);
                Console.WriteLine("Price : " + form.Price);
                Console.WriteLine("Total Value of {0} =  {1}: ", form.Name, (form.Weight * form.Price));
                Console.WriteLine("\n");
            }

        }
    }
}