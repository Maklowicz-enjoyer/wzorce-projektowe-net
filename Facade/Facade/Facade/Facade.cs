using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Facade
    {
        Subsystem1 subsystem1 = new Subsystem1();
        Subsystem2 subsystem2 = new Subsystem2();
        Subsystem3 subsystem3 = new Subsystem3();
        Subsystem4 subsystem4 = new Subsystem4();

        public void CallAll()
        {
            subsystem1.S1F1();
            subsystem1.S1F2();
            subsystem1.S1F3();

            subsystem2.S2F1();
            subsystem2.S2F2();
            subsystem2.S2F3();

            subsystem3.S3F1();
            subsystem3.S3F2();
            subsystem3.S3F3();

            subsystem4.S4F1();
            subsystem4.S4F2();
            subsystem4.S4F3();
        }

        public void CallF1()
        {
            subsystem1.S1F1();
            subsystem2.S2F1();
            subsystem3.S3F1();
            subsystem4.S4F1();
        }
    }
}
