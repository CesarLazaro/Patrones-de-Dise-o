using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public sealed class SigletonWT
    {
        private static SigletonWT instance = null;
        private static readonly object padlock = new object();
        private string name;

        SigletonWT()
        {
            name = "Cesar";

        }
        public string GSname { get { return name; } set { name = value; } }

        public static SigletonWT Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SigletonWT();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
