using AbstractFactory.Creators;
using AbstractFactory.Products.ProductsA;
using AbstractFactory.Products.ProductsB;


namespace AbstractFactory
{
    internal class Client
    {
        private readonly Creator _creator;

        public Client(Creator creator)
        {
            _creator = creator;
        }

        public void Run()
        {
            if(_creator != null )
            {
                ProductA pA = _creator.CreateProductA();
                ProductB pB = _creator.CreateProductB();

                if(pA != null && pB != null) {
                    pA.Interact(pB);
                }
            }
        }
    }
}
