using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    internal abstract class Employee
    {
        public decimal OrderMaxValue { get; set; }
        public Employee? Supervisor { get; set; }
        public abstract void AcceptOrder(OrderRequest request);

    }
}
