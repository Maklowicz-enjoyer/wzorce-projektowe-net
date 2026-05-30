using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Subsystem3
    {
        public void S3F1()
        {
            Console.WriteLine("Metoda F1 w klasie {0}", this.GetType());
        }

        public void S3F2()
        {
            Console.WriteLine("Metoda F2 w klasie {0}", this.GetType());
        }

        public void S3F3()
        {
            Console.WriteLine("Metoda F1 w klasie {0}", this.GetType());
        }
    }
}
