using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Subsystem4
    {
        public void S4F1()
        {
            Console.WriteLine("Metoda F1 w klasie {0}", this.GetType());
        }

        public void S4F2()
        {
            Console.WriteLine("Metoda F2 w klasie {0}", this.GetType());
        }

        public void S4F3()
        {
            Console.WriteLine("Metoda F1 w klasie {0}", this.GetType());
        }
    }
}
