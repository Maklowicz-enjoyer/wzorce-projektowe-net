using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample
{
    internal class Leaf : Component
    {
        public Leaf(string name):base (name) { }

        public override void Add(Component component)
        {
            Console.WriteLine("Nie mozna dodac do komponentu liscia");
            throw new NotImplementedException();
        }
        public override void Remove(Component component)
        {
            Console.WriteLine("Nie mozna usunac z komponentu liscia");
            throw new NotImplementedException();
        }
        public override void Display(int depth)
        {
            Console.WriteLine($"+{new string('-', depth)}| {this.Name}");
        }


    }
}
