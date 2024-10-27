using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Publisher 
    {
        private List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Publisher: Attached an observer.");
             _observers.Add(observer);
        }
        public void Detach(IObserver observer)
        {
            Console.WriteLine("Publisher: Detached an observer.");
             _observers.Remove(observer);
        }
        public void Notify()
        {
            Console.WriteLine("Publisher: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
        public void ReleaseNewMaterial()
        {
            Console.WriteLine("\nA new story has been released...");
            Notify();
        }
    }
}
