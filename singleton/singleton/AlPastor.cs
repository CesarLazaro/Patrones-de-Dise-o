using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    class AlPastor:Taco
    {
        private string name;
       public AlPastor()
        {
            name = "Taquito al pastor";
        }
        public string  a { get { return name; } set { name = value; } }
    }
}
