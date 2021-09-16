using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace JSON
{
    class Library
    {
        //using property
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public Library(string Name, double Weight, double Price)
        {
            this.Name = Name;
            this.Weight = Weight;
            this.Price = Price;
        }
    }
}