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
        public void CraftYourBrew()
        {
            Console.WriteLine("Now, you need to make a recipe. Lemonade should have parts Lemon, Sugar, and Ice, and how much of each, you'll determine between 1 and 5. Each batch makes 3 servings. \n Please input these parts in order, and without spaces. \n Example \"224\" would make your batch 2 parts Lemon, 2 parts Sugar, and 4 parts Ice");
            
            string brewInput = Console.ReadLine();            
            int[] brew = new int[3];
            brew[1] = brewInput[1];
            brew[2] = brewInput[2];
            brew[3] = brewInput[3];

            Console.WriteLine("And how much do you want to charge per cup?");
            double PerCupPrice = Int32.Parse(Console.ReadLine());
        }
    }
}
