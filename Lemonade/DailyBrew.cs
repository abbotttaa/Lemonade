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
                Console.WriteLine(e);
            }
            
            brew = new int[3];
            brew[0] = Int32.Parse(brewInput[0].ToString());
            brew[1] = Int32.Parse(brewInput[1].ToString());
            brew[2] = Int32.Parse(brewInput[2].ToString());
            BrewCharges = 3;

            Console.WriteLine("And how much do you want to charge per cup?");
            double PerCupPrice = Double.Parse(Console.ReadLine());
        }
        public void CheckCharges(Player player)
        {
            if (BrewCharges <= 0)
                if (brew[0] > player.stock.lemons.Count)
                {
                    for (int i = 0; i <= brew[0]; i++)
                    {
                        player.stock.lemons.RemoveAt(0);
                    }
                }
            if (brew[1] > player.stock.lemons.Count)
            {
                for (int i = 0; i <= brew[1]; i++)
                {
                    player.stock.sugar.RemoveAt(0);
                }
            }
            if (brew[1] > player.stock.lemons.Count)
            {
                for (int i = 0; i <= brew[2]; i++)
                {
                    player.stock.ice.RemoveAt(0);
                }
            }                
        }
    }
}
