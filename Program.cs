using System;

namespace my_adapter_implement
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {

            var list = new List<ITarget>()
            {
               new Adapter(),
                new Adapter()
            };
            foreach (var item in list)
            {
                item.Print();
            }
        }
    }

}
