using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserverPattern
{
    public class StatisticsDisplay : IObserver
    {
        private float maxTemperature = float.MinValue;
        private float minTemperature = float.MaxValue;
        private float temperatureSum;
        private int numReadings;

        public void Update(float temperature, float humidity, float pressure)
        {
            temperatureSum += temperature;
            numReadings++;

            if(temperature > maxTemperature)
            {
                maxTemperature = temperature;
            }
            if( temperature < minTemperature)
            {
                minTemperature = temperature;
            }

            Console.WriteLine($"Avg/Max/Min temperature = {temperatureSum / numReadings}/{maxTemperature}/{minTemperature}"); ;
        }
    }
}
