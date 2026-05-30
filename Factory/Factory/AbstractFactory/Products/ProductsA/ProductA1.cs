using AbstractFactory.Products.ProductsB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.ProductsA
{
    internal class ProductA1 : ProductA
    {
        public override void Interact(ProductB productB)
        {
            Console.WriteLine(
                $"Produkt {this.GetType().FullName} wszedł w interację z produktem {productB.GetType().FullName}"
                );
        }

        public override void Print()
        {
            Console.WriteLine("Produkt 1A");
        }
    }
}
