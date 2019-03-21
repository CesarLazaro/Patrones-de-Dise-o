using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public class Taco
    { 
        private string name;
        public Taco()
        {
            name = "Taquito";
        }
        public string GSName {get { return name; } set { name = value; } }
    }
}
