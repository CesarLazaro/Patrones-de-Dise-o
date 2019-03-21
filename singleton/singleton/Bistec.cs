using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    class Bistec:Taco
    {
        private string name;
        public Bistec()
        {
            name = "Taquito de birria";
        }
        public string a { get { return name; } set { name = value; } }
    }

}
