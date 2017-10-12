using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Player
    {
        //member variable
        public Stock stock = new Stock();
        public PiggyBank piggybank = new PiggyBank();           
        //constructor
        //member method
        public void StockCheck()
        {
            stock.FullStock();            
        }
    }
}
