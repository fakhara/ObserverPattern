using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Richard : IObserver
    {
        public void Update(Publisher pub)
        {
            Console.WriteLine("Richard: Thanks for the story.");
        }
    }
}
