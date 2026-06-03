using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<Target>()
            {
                new Target(),
                new Adapter()
            };
            foreach (var item in list)
            {
                item.Print();
            }
        }
    }
}
