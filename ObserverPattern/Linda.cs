using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Linda : IObserver
    {
        public void Update(Publisher pub)
        {
            Console.WriteLine("Linda:Thanks for the story.");
        }
    }
}
