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
        }
        public void simADay()
        {
            customer.Occurrence(day.weatherCall.weather);
            for (int i = 0; i >= 100; i++)
            {
                customer.SpawnTrigger(player.brew.brew, player.brew.perCupPrice, player);
            }
        }
            
        


        

        //Will run the day. this will contain methods that basicly run encounter rates for customers, based on the weather, and each customer will have random preferences
        //that determine when they spawn, if they are interested in your lemonade. It's also going to have to keep track of active stock, as you will be consuming
        // as you sell, thus, the day MUST end when you run out, or cant produce more product
        public void EndOfDayStatus()
    {

    }
        //Gives a run down of the day. should show how much you GAINED that day, howmany people you served, and howmany people walked past. WILL also display stock count.
    }
}
