namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();
            
            creator.CreateProduct(1).Print();

            creator.CreateProduct(2).Print();

            creator.CreateProduct(3).Print();

            int[] ids = { 1, 2, 3, 4, 5 };

            foreach (int id in ids) {
                try
                {
                    creator.CreateProduct(id).Print();
                } 
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.ToString());
                }
            }
        }
    }
}
