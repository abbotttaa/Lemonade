using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Date
    {
        //member methods
        int days;
        Weather weatherCall = new Weather();
        DailyBrew recipeCraft = new DailyBrew();
        //constructor
        //member methods
        public void StartDayCheck(Player player)
        {
            weatherCall.DeclareWeather();
            
            recipeCraft.CraftYourBrew();
        }
    }
}
