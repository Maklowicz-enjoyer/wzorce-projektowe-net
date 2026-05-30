using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class ConcreteObserver : Observer
    {
        public string? Name {  get; set; }   

        public override void Update(Subject subject)
        {
            Console.WriteLine("Nastąpiła zmiana stanu w obiekcie obserwowanym");
            Console.WriteLine($"Obserwaror {Name} zaobserwował zmianę w {subject.GetHashCode()}");
        }

        public ConcreteObserver(string? name)
        {
            Name = name;
        }
    }
}
