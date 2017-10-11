using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Weather
    {
        //member variable
        Random random = new Random();
        //constructor
        //member methods
        public string DetermineWeather()
        {
            int RandomPick = random.Next(1, 6);
            switch (RandomPick)
            {
                case 1:
                    return "Scorching Hot";
                case 2:
                    return "Sunny and Hot";
                case 3:
                    return "Mild and Warm";
                case 4:
                    return "Cloudy and Mild";
                case 5:
                    return "Foggy and Cold";
                default:
                    return "";
            }
        }

    }
}
