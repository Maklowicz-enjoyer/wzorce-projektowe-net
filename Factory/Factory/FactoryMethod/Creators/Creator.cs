using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creators
{
    internal abstract class Creator
    {
        public abstract Product CreateProduct();
    }
}
