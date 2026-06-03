using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample
{
    public abstract class Component
    {
        public string Name { get; set; }
        public Component(string name) {  this.Name = name; }
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth);

        
    }
}
