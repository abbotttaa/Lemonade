using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
     public class DailyBrew
    {
        public double perCupPrice;
        public int[] brew;
        public int BrewCharges;


       public void ReduceLemon(Player player)
        {
            if (brew[0] <= player.stock.lemons.Count)
            {
                for (int i = 0; i < brew[0]; i++)
                {
                    player.stock.lemons.RemoveAt(0);
                }
            }
        }
        public void ReduceIce(Player player)
        {
            if (brew[2] <= player.stock.ice.Count)
            {
                for (int i = 0; i < brew[2]; i++)
                {
                    player.stock.ice.RemoveAt(0);
                }
            }
        }
        public void ReduceSugar(Player player)
        {
            if (brew[1] <= player.stock.sugar.Count)
            {
                for (int i = 0; i < brew[1]; i++)
                {
                    player.stock.sugar.RemoveAt(0);
                }
            }
        }
        public void CheckCharges(Player player)
        {
            if (BrewCharges <= 0)
            {
                if(brew[2] <= player.stock.ice.Count && brew[1] <= player.stock.sugar.Count && brew[0] <= player.stock.lemons.Count)
                {
                    ReduceLemon(player);
                    ReduceSugar(player);
                    ReduceIce(player);
                    BrewCharges = 3;
                }
                else
                {
                    Console.WriteLine("You're short on ingredients to make another batch!");
                }
            }             
        }
    }
}
