using FactoryMethod.Creators;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creator creator1 = new ConcreteCreator1();

            creator1.CreateProduct().Print();

            Creator creator2 = new ConcreteCreator2();

            creator2.CreateProduct().Print();


            List<Creator> creators = new List<Creator>() {
                new ConcreteCreator1(),
                new ConcreteCreator2()
            };

            foreach (Creator creator in creators)
            {
                creator.CreateProduct().Print();
            }
        }
    }
}
