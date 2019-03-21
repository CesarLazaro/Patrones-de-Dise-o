using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private string name;
        private Singleton()
        {
            name = "Cesar";
        }
        public string GSname { get { return name; } set { name = value; }  }
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

    }
}
