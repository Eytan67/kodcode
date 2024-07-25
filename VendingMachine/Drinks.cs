using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Drinks
    {
        public List<Drink> drinksList;
        public Drinks() { }
        public Drinks(List<Drink> drinksList)
        {
            this.drinksList = drinksList;
        }
    }

}
