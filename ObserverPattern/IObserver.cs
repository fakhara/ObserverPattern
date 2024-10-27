using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IObserver
    {
        // Receive update from publisher
        void Update(Publisher publisher);
    }
}
