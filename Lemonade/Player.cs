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
        public int salesMade;
        public int salesMadeTotal;
        public string buisnessStatus = "open";
        //constructor
        //member method
        public void CraftYourBrew()
        {
            Console.WriteLine("Now, you need to make a recipe. Lemonade should have parts Lemon, Sugar, and Ice, and how much of each, you'll determine between 1 and 5. Each batch makes 3 servings. \n Please input these parts in order, and without spaces. \n Example \"224\" would make your batch 2 parts Lemon, 2 parts Sugar, and 4 parts Ice");

            string brewInput = "";
            try
            {
                brewInput = Console.ReadLine();
                Int32.Parse(brewInput);
            }
            catch (Exception e)
            {
                Console.WriteLine(" \n No dummy, try again, and do it right this time!");
                CraftYourBrew();
            }

            brew.brew = new int[3];
            brew.brew[0] = Int32.Parse(brewInput[0].ToString());
            brew.brew[1] = Int32.Parse(brewInput[1].ToString());
            brew.brew[2] = Int32.Parse(brewInput[2].ToString());
            brew.BrewCharges = 3;


            Console.WriteLine("And how much do you want to charge per cup?");
            brew.perCupPrice = Double.Parse(Console.ReadLine());
        }
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
            if (pricePref >= perCupPrice)
            {
                brew.CheckCharges(player);
                if (player.stock.cups.Count > 0 && player.brew.BrewCharges != 0)
                {                    
                    piggybank.money += perCupPrice;
                    brew.BrewCharges--;
                    salesMade++;
                    salesMadeTotal++;
                    piggybank.allTimeMoney += perCupPrice;
                    piggybank.dailyMoney += perCupPrice;
                    player.stock.cups.RemoveAt(0);
                }
                else
                {
                    Console.WriteLine("You're out of supplies!");
                    buisnessStatus = "closed";
                }
            }
        }
        public void resetDailys()
        {
            salesMade = 0;
            piggybank.dailyMoney = 0;
        }
    }
}
