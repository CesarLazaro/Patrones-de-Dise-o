using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SigletonWT a = SigletonWT.Instance;
            Console.WriteLine(a.GSname);
            Console.WriteLine("Dame taquito");
            string tipo = Console.ReadLine();
            var taco = Taqueria.EscogerTaquito(tipo);
            Console.WriteLine(" Tu taquito es:" + taco.GetType().Name);
            Console.ReadKey();                   
        }
    }
}
