using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Alicia : IObserver
    {
        public void Update(Publisher pub)
        {
            Console.WriteLine("Alicia:Thanks for the story.");
        }
    }
}
