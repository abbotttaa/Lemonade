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

        public void ExplainRules()
        {
            Console.WriteLine("You make and sell lemonaid now.  Each day, you'll sell lemonade that you designed, and set the price.  Many things will determine if you are succesful or not. Weather will change each day, which will mean more or less buisness. You should also set wise prices. \n You'll need to stock up on the components to make and sell your lemonade aswell.");

        }
        public void StartDayTasks()
        {
            day.StartDayCheck();
            player.StockCheck();
            player.PonderMarketTrip(player, market);
            player.CraftYourBrew();
        }
        public void simADay()
        {
            customer.Occurrence(day.weatherCall.weather);

            
                for (int i = 0; i <= 100; i++)
                {
                    if (player.stock.cups.Count > 0)
                    {
                        customer.SpawnTrigger(player.brew.brew, player.brew.perCupPrice, player);
                    }
                    else
                    {
                        break;
                    }
                }
            
        }        
        public void EndOfDaySum()
        {
            day.endDayTick();
            Console.WriteLine("Alright! That's a wrap for today! \n \n You made "+player.salesMade+" sales today, and have "+player.piggybank.money.ToString("C")+". You have finished "+day.days+" days.");
            player.resetDailySales();
            Console.ReadLine();
        }        
    }
}
