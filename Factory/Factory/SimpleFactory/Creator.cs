using SimpleFactory.Products;


namespace SimpleFactory
{
    internal class Creator
    {
        public Product CreateProduct(int productId) { 
            
            switch (productId)
            {
                case 1: return new ConcreteProduct1();
                case 2: return new ConcreteProduct2();
                case 3: return new ConcreteProduct3();
                default: throw new ArgumentException();
            }
        }
    }
}
