using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Products
{
    internal class ConcreteProduct3 : Product
    {
        public override void Print()
        {
            Console.WriteLine("Produkt 3 - wywołano metodę Print()");
        }
    }
}
