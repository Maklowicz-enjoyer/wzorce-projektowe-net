using System;
using System.Collections.Generic;
using System.Text;

namespace my_adapter_implement
{
    internal class Adapter : ITarget
    {
        private readonly Adaptee adaptee = new Adaptee();
    
    public void Print()
        {
            adaptee.AdapteePrint();
        }
    }
}
