using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Customer
    {
        //member variable
        public int LemonadePref;
        public double PricePref;
        public double SpawnChance;
        Random random = new Random();
        //constructor
        //member method
        public void Occurrence(string weather)
        {
            switch (weather)
            {
                case "Scorching Hot":
                    SpawnChance = 90;
                    break;
                case "Sunny and Hot":
                    SpawnChance = 70;
                    break;
                case "Mild and Warm":
                    SpawnChance = 50;
                    break;
                case "Cloudy and Mild":
                    SpawnChance = 40;
                    break;
                case "Foggy and Cold":
                    SpawnChance = 20;
                    break;
                default:
                    break;
            }
            return;
        }
        public void SpawnTrigger(double SpawnChance)
        { 
        int RandomPick = random.Next(1, 101);
            if(RandomPick >= SpawnChance)
            {
                RollForCustomer();
            }           
        }
        //public void RollForCustomer()
        //{
        //    int RandomPick = random.Next(1, 4);
        //    switch (RandomPick)
        //    {
        //        case 1:
        //            TimmyCheck();
        //            break;
        //        case 2:
        //            JohnnyCheck();
        //            break;
        //        case 3:
        //            SpikeCheck();
        //            break;
        //    }
        //}
        public void CustomerPrefBrew()
        {
            int[] BrewPref = new int[3];
            for (int i = 0; i >= BrewPref.Length; i++)
            {
                int RandomPick = random.Next(1, 6);
                BrewPref[i] = RandomPick; 
            }

        }

        public void CustomerPricePref(int[] BrewPref, int[] Brew)
        {
            for(int i = 0; i >=BrewPref.Length; i++)
            {
                if(BrewPref[i] == Brew[i])
                {
                    double pricePref += .50;
                }
                else
                {
                    int result = BrewPref[i] - Brew[i];
                     if(result == -1 ||result == 1)
                    {
                        double pricePref += .35;
                    }
                     else if(result == -2 || result == 2)
                    {
                        double pricePref += .25;
                    }
                     else if(result == -3 || result == 3)
                    {
                        double pricePref += .15;
                    }
                     else if(result == -4 ||result == 4)
                    {
                        double pricePref += .10;
                    }
                }
            }
        }
        public void 
    }
}
