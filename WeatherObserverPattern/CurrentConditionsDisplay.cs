using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserverPattern
{
     public class CurrentConditionsDisplay : IObserver
     {
        public void Update(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"Curren Conditions: {temperature}°C, {humidity}% humidity, {pressure} hPa pressure"); ;
        }
     }
}
