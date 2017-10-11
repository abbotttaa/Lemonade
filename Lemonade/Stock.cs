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
            Console.WriteLine("You have "+lemons+" lemons, "+cups+" cups, "+sugar+" sugar, "+ice+" ice.");
        }
    }
}
