using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Products
{
    internal class ConcreteProduct2 : Product
    {
        public override void Print()
        {
            Console.WriteLine("Produkt 2 - wywołano metodę Print()");
        }
    }
}
