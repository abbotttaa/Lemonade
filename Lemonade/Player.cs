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
        public void PonderMarketTrip(Player player, Market market)
        {
            Console.WriteLine("Would you like to restock at the market? Yes(1) or No(2).");
            string response = Console.ReadLine();
            if (response == "1")
            {
                market.GoToMarket(player);
            }
            
        }
        public void StockCheck()
        {
            stock.FullStock();            
        }
        public void CheckForSale(double pricePref , double perCupPrice, Player player)
        {
            if (pricePref <= perCupPrice)
            {
                brew.CheckCharges(player);
                piggybank.money += perCupPrice;
                brew.BrewCharges -= brew.BrewCharges;
                
                

            }
        }
    }
}
