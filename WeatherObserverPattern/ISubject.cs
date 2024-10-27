using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserverPattern
{
    public interface ISubject
    {
        void Attach(IObserver observer)
        {
            throw new NotImplementedException();
        }
        void Detach(IObserver observer)
        {
            throw new NotImplementedException();
        }
         void NotifyObservers()
         {
            throw new NotImplementedException();
         }
    }
}
