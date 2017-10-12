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
        public List<Lemon> lemons;
        public List<Cups> cups;
        public List<Sugar> sugar;
        public List<Ice> ice;
        //constructor
        //member method
        public void FullStock()
        {
            Console.WriteLine("You have "+lemons.Count+" lemons, "+cups.Count+" cups, "+sugar.Count+" sugar, "+ice.Count+" ice.");
        }
    }
}
