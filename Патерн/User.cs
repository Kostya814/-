using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Патерн
{
    class User
    {
        private string _name;
        private Root _root;
        public User(string name, Root root)
        {
            _name = name;
            _root = root;
        }
        public void Notify(Celebration holi)
        {
            if (holi.Root >= this._root) Console.WriteLine(this._name + " - " + holi.Name);
            else Console.WriteLine(this._name + " Купи VIP");
        }
    }
}
