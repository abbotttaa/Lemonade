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
        public DailyBrew brew = new DailyBrew();        
        //constructor
        //member method
        public void StockCheck()
        {
            stock.FullStock();            
        }
        public void CheckForSale(double pricePref , double perCupPrice)
        {
            if (pricePref <= perCupPrice)
            {
                piggybank.money += perCupPrice;
                
            }
        }
    }
}
