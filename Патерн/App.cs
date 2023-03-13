using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Патерн
{
    class App : IObservable
    {
        List<User> users;
        List<Celebration> celebrations;
        DateTime time;
        public App() 
        {
            users = new List<User>();
            celebrations = new List<Celebration>()
            { 
                new Celebration(new DateTime(2023,3,8), "Международный День Женщин"),
                new Celebration (new DateTime(2023,5,9),"День Победы")
            };
            time = Convert.ToDateTime(Console.ReadLine());
            foreach (var item in celebrations)
            {
                if (item.Check(time)) NotifyObservers(item.Name);
            }          
            
        }
        public void AddObserver(User us)
        {
            users.Add(us);   
        }

        public void NotifyObservers(string name)
        {
            foreach (var user in users)
            {
                
                user.Notify(name);
            }    
        }

        public void RemoveObserver(User us)
        {
            users.Remove(us);
        }
    }
}
