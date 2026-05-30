using AbstractFactory.Products.ProductsB;

namespace AbstractFactory.Products.ProductsA
{
    internal abstract class ProductA : Product
    {
        public abstract void Interact(ProductB productB);
    }
}
