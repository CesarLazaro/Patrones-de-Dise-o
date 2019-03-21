using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    class Birria:Taco
    {
        private string name;
        public Birria()
        {
            name = "Taquito de birria";
        }
        public string a { get { return name; } set { name = value; } }
    }
}
