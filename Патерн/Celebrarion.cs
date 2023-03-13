using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Патерн
{
    class Celebration 
    {
        private DateTime _time;
        private string _name;
        
        public Celebration(DateTime time, string name)
        {
            _time = time;
            _name = name;
        }
        public bool Check(DateTime time)
        { 
            if(time.AddDays(7) == _time) return true;
            return false;

        }
        public string Name
        {   
            get { return _name; }
        }
       

    }
}
