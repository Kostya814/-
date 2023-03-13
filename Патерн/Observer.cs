using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Патерн
{
    class Observer:IObserver
    {
        List<User> users;
        public Observer() 
        {
            users = new List<User>();
        }
        public void Update() 
        { 
            foreach (User user in users) { }
        }
    }
}
