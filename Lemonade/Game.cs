using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Game
    {
        Date day = new Date();
        Player player = new Player();
        Market market = new Market();
        Customer customer = new Customer();
        string startAgain = "1";

        public void MasterGame()
        {
            if (startAgain == "1")
            {
                StartDayTasks(player);
                simADay();
                EndOfDaySum();
            }
        }
        public void ExplainRules()
        {
            Console.WriteLine("You make and sell lemonaid now.  Each day, you'll sell lemonade that you designed, and set the price.  Many things will determine if you are succesful or not. Weather will change each day, which will mean more or less buisness. You should also set wise prices. \n You'll need to stock up on the components to make and sell your lemonade aswell.");

        }
        public void StartDayTasks(Player player)
        {
            day.StartDayCheck(player);
            player.StockCheck();
            player.PonderMarketTrip(player, market);
            player.CraftYourBrew();
        }
        public void simADay()
        {
            customer.Occurrence(day.weatherCall.weather);

            
                for (int i = 0; i <= 50; i++)
                {
                    if (player.stock.cups.Count > 0 && player.buisnessStatus != "closed")
                    {
                        customer.SpawnTrigger(player.brew.brew, player.brew.perCupPrice, player);
                    }
                    else
                    {
                        Console.WriteLine("You're out of supplies!");
                        break;
                    }
                }
            
        }        
        public void EndOfDaySum()
        {
            day.endDayTick();
            Console.WriteLine("Alright! That's a wrap for today! \n \n You've made "+player.salesMade+" sales today and "+player.salesMadeTotal+" in your whole run! \n \n You have"+player.piggybank.money.ToString("C")+", and have made "+player.piggybank.allTimeMoney.ToString("C")+" in your whole run! \n \n You have finished "+day.days+" days.");
            player.resetDailys();
            Console.WriteLine("Do you want to start the next day? Yes(1) or No(2)");
            startAgain = Console.ReadLine();
            if(startAgain == "1")
            {
                MasterGame();
            }
            else
            {
                Console.WriteLine("GG");
                Console.ReadLine();
            }
        }        
    }
}
