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
        int lemons;
        int cups;
        int sugar;
        double money;
        int ice;
        //constructor
        //member method
        public void FullStock(int lemons, int cups, int sugar, int ice)
        {
            Console.WriteLine("You have "+lemons+" lemons, "+cups+" cups, "+sugar+" sugar, "+ice+" ice.");
        }
    }
}
