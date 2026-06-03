using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    internal class CEO : Employee
    {
        public CEO() { OrderMaxValue = 3000; }
        public override void AcceptOrder(OrderRequest request)
        {
            if (request.Value <= OrderMaxValue)
            {
                Console.WriteLine("zamówieniem zajmuje się CEO");
            }
            else if (this.Supervisor != null)
            {
                this.Supervisor.AcceptOrder(request);
            }
            else
            {
                Console.WriteLine("brak przełorzonego dla którego można przekazać zadanie");
            }
        }
    }
}
