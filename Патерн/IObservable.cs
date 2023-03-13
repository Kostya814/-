using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Патерн
{
     interface IObservable
    {
        void AddObserver(User us);
        void RemoveObserver(User us);
        void NotifyObservers(Celebration name);
    }
}
