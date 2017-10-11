using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
     public class DailyBrew
    {
        public void CraftYourBrew()
        {
            Console.WriteLine("Now, you need to make a recipe. Lemonade should have parts Lemons, Sugar, and Ice, and how much of each you determine between 1 and 5. Each batch makes 10 servings. \n Please input these parts in order, and without spaces. \n Example \"224\" would make your batch 2 parts Lemon, 2 parts Sugar, and 4 parts Ice");
            
            int BrewInput = Int32.Parse(Console.ReadLine());

            int[] Brew = new int[3];

            Console.WriteLine("And how much do you want to charge per cup?");
            double PerCupPrice = Int32.Parse(Console.ReadLine());
        }
    }
}
