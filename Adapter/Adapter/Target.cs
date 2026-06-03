using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Target
    {
        public virtual void Print()
        {
            Console.WriteLine("Wydruk z target");

        }
    }
}
