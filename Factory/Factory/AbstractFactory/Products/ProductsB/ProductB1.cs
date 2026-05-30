using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.ProductsB
{
    internal class ProductB1 : ProductB
    {
        public override void Print()
        {
            Console.WriteLine("Produkt 1B");
        }
    }
}
