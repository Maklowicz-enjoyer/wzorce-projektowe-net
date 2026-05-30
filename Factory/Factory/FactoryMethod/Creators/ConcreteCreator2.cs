using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creators
{
    internal class ConcreteCreator2 : Creator
    {
        public override Product CreateProduct()
        {
            Console.WriteLine("Tworzę istancję produktu 2");
            return new ConcreteProduct2();
        }
    }
}
