using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public static class Taqueria
    {
        public static Taco EscogerTaquito(string tipo)
        {
            switch (tipo)
            {
                case "AL PASTOR":
                    return new AlPastor();
                case "BISTEC":
                    return new Bistec();
                case "DORADO":
                    return new Dorados();
                default:
                    return new Birria();             
            }
        }
    }
}
