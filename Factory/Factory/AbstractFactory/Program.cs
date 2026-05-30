using AbstractFactory.Creators;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new ConcreteCreator1());

            client.Run();
        }
    }
}
