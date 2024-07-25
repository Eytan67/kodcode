using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Drink
    {
        public string Name {  get; set; }
        public float Suger {  get; set; }
        public float Milk {  get; set; }
        public float Cocoa {  get; set; }
        public float Coffee {  get; set; }
        public float Price { get; set; }

        public Drink(string name, float suger, float milk, float cocoa, float coffee, float price)
        {
            Name = name;
            Suger = suger;
            Milk = milk;
            Cocoa = cocoa;
            Coffee = coffee;
            Price = price;
        }
    }
}
