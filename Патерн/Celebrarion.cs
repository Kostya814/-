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
        private Root _root;
        
        public Celebration(DateTime time, string name,Root root)
        {
            _time = time;
            _root = root;
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
       public Root Root { get { return _root; } }

    }
}
