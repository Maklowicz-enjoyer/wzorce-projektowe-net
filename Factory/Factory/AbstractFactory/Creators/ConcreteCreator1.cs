using AbstractFactory.Products.ProductsA;
using AbstractFactory.Products.ProductsB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Creators
{
    internal class ConcreteCreator1 : Creator
    {
        public override ProductA CreateProductA()
        {
           return new ProductA1();
        }

        public override ProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
