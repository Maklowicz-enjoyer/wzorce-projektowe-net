using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var order1 = new OrderRequest { Value = 2200};
            var e1 = new CEO();
            var e2 = new PM { Supervisor = e1};
            var e3 = new Programista { Supervisor = e2};

            e3.AcceptOrder(order1);


        }
    }
}
