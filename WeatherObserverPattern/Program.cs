namespace WeatherObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create the Weather station
            WeatherStation weatherStation = new WeatherStation();

            //Create observer
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay();

            //Attach observer to the weather station
            weatherStation.Attach(currentDisplay);
            weatherStation.Attach(statisticsDisplay);

            //Update weather data
            weatherStation.Temperature = 10.0f;
            weatherStation.Humidity = 100.0f;
            weatherStation.Pressure = 1007.0f;

            // Update weather data again
            weatherStation.Temperature = 09.0f;
            weatherStation.Humidity = 84.0f;
            weatherStation.Pressure = 1012.5f;

            // Detach one observer
            weatherStation.Detach(currentDisplay);

            // Update weather data once more
            weatherStation.Temperature = 07.0f;
            weatherStation.Humidity = 79.0f;
            weatherStation.Pressure = 1011.0f;
        }
    }
}