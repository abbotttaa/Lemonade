using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Stock
    {
        //member variable        
        public List<Lemon> lemons = new List<Lemon>();
        public List<Cups> cups = new List<Cups>();
        public List<Sugar> sugar = new List<Sugar>();
        public List<Ice> ice = new List<Ice>();
        //constructor
        //member method
        public void FullStock()
        {
            Console.WriteLine("You have "+lemons.Count+" lemons, "+cups.Count+" cups, "+sugar.Count+" sugar, "+ice.Count+" ice.");
        }
    }
}
