using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Products
{
    internal class ConcreteProduct1 : Product
    {
        public override void Print()
        {
            Console.WriteLine("Produkt 1 - wywołano metodę Print()");
        }
    }
}
