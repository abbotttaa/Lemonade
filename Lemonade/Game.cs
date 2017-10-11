using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Game
    {
        Weather weatherCall = new Weather();
        Stock stockCheck = new Stock();
        string weather;
        string stock;
        startDayCheck()
        {
            weather = weatherCall.DetermineWeather();
            Console.WriteLine("Today's forcast is" + weather + ".");
            stockCheck.FullStock();
            Console.WriteLine("In stock you currently have...Do you want to purchase more at the market?");

        }
        //gives you the weather, your balance, your stock, the day, and will prompt you asking if you want to buy more supplies, how you want to make your lemo,
        // and how much you want to charge. 
        simADay();
        //Will run the day. this will contain methods that basicly run encounter rates for customers, based on the weather, and each customer will have random preferences
        //that determine when they spawn, if they are interested in your lemonade. It's also going to have to keep track of active stock, as you will be consuming
        // as you sell, thus, the day MUST end when you run out, or cant produce more product
        EoDStatus();
        //Gives a run down of the day. should show how much you GAINED that day, howmany people you served, and howmany people walked past. WILL also display stock count.
    }
}
