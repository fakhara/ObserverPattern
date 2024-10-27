using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserverPattern
{
    public class WeatherStation : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private float temperature;
        private float humidity;
        private float pressure;

        public float Temperature
        {
            get { return temperature; }
            set
            {
                temperature = value;
                NotifyObservers();
            }
        }
        public float Humidity
        {
            get { return humidity; }
            set
            {
                humidity = value;
                NotifyObservers();
            }
        }
        public float Pressure
        {
            get { return pressure; }
            set
            {
                pressure = value;
                NotifyObservers();
            }
        }
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

    }
}
