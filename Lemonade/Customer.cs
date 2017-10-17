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
        
        public double pricePref;
        public double spawnChance;
        public int[] brewPref;
        
        Random random = new Random();
        //constructor
        //member method
        public void Occurrence(string weather)
        {
            switch (weather)
            {
                case "Scorching Hot":
                    spawnChance = 90;
                    break;
                case "Sunny and Hot":
                    spawnChance = 70;
                    break;
                case "Mild and Warm":
                    spawnChance = 50;
                    break;
                case "Cloudy and Mild":
                    spawnChance = 40;
                    break;
                case "Foggy and Cold":
                    spawnChance = 20;
                    break;
                default:
                    break;
            }
            return;
        }
        public void SpawnTrigger(int[] brew, double perCupPrice, Player player)
        { 
        int randomPick = random.Next(1, 101);
            if(randomPick >= spawnChance)
            {
                CustomerPrefBrew();
                CustomerPricePref(brewPref, brew);
                player.CheckForSale(pricePref,perCupPrice, player);
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
            int[] brewPref = new int[3];
            for (int i = 0; i >= brewPref.Length; i++)
            {
                int randomPick = random.Next(1, 6);
                brewPref[i] = randomPick; 
                
            }

        }

        public void CustomerPricePref(int[] brewPref, int[] brew)
        {
            double pricePref = 0;
            for(int i = 0; i >=brewPref.Length; i++)
            {
                if(brewPref[i] == brew[i])
                {
                    pricePref += .50;
                }
                else
                {
                    int result = brewPref[i] - brew[i];
                     if(result == -1 ||result == 1)
                    {
                        pricePref += .35;
                    }
                     else if(result == -2 || result == 2)
                    {
                        pricePref += .25;
                    }
                     else if(result == -3 || result == 3)
                    {
                        pricePref += .15;
                    }
                     else if(result == -4 ||result == 4)
                    {
                        pricePref += .10;
                    }
                }
            }
        }
        
    }
}
