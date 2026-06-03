using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Adapter : Target
    {
        private readonly Adaptee adaptee = new Adaptee();

        public override void Print()
        {
            adaptee.AdapteePrint();
        }
    }
}
