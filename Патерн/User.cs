using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Патерн
{
    class User
    {
        private string _namme;
        private Root _root;
        public User(string name, Root root)
        {
            _namme = name;
            _root = root;
        }
        public void Notify(string name)
        {
            Console.WriteLine(name);
        }
    }
}
