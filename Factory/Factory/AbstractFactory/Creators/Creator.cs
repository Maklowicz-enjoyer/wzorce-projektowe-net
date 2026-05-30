using AbstractFactory.Products.ProductsA;
using AbstractFactory.Products.ProductsB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Creators
{
    internal abstract class Creator
    {
        public abstract ProductA CreateProductA();

        public abstract ProductB CreateProductB();

    }
}
