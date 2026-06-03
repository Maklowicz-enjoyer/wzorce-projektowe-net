using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample
{
    internal class Composite : Component
    {
        private readonly List<Component> components = new List<Component>();

        public Composite(string name) : base(name) { }

        public override void Add(Component component)
        {
            if (component != null)
            {
                components.Add(component);
            }
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"+{new string('-', depth)} {this.Name}");

            foreach(Component component in components)
            {
                component.Display(depth + 2);
            }
        }

        public override void Remove(Component component)
        {
            if (component != null)
            {
                components.Remove(component);
            }
        }
    }
}
