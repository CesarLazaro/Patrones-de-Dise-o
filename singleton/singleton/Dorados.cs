using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    class Dorados:Taco
    {
        private string name;
        public Dorados()
        {
            name = "Taquito dorados";
        }
        public string a { get { return name; } set { name = value; } }
    }
}
