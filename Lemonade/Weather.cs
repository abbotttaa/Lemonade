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
        string weather;
        //constructor
        //member methods
        public string DetermineWeather()
        {
            int RandomPick = random.Next(1, 6);
            switch (RandomPick)
            {
                case 1:
                    return weather = "Scorching Hot";
                case 2:
                    return weather = "Sunny and Hot";
                case 3:
                    return weather = "Mild and Warm";
                case 4:
                    return weather = "Cloudy and Mild";
                case 5:
                    return weather = "Foggy and Cold";
                default:
                    return "";
            }
        }
        public void DeclareWeather()
        {
            Console.WriteLine("Today's forcast is" + weather + ".");
        }
    }
}
