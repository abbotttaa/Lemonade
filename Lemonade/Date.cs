using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Date
    {
        //member methods
        int days;
        public Weather weatherCall = new Weather();
        DailyBrew recipeCraft = new DailyBrew();
        //constructor
        //member methods
        public Date()
        {

        }
        public void StartDayCheck()
        {
            weatherCall.DeclareWeather();            
            recipeCraft.CraftYourBrew();
        }

    }
}
