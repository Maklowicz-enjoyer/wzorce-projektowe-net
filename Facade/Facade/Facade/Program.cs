using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute2F();

            Console.ReadKey();
        }

        static void Execute1()
        {
            var s1 = new Subsystem1();
            var s2 = new Subsystem2();
            var s3 = new Subsystem3();
            var s4 = new Subsystem4();

            s1.S1F1();
            s2.S2F1();
            s3.S3F1();
            s4.S4F1();

            s1.S1F1();
            s1.S1F2();
            s1.S1F3();

            s2.S2F1();
            s2.S2F2();
            s2.S2F3();

            s3.S3F1();
            s3.S3F2();
            s3.S3F3();

            s4.S4F1();
            s4.S4F2();
            s4.S4F3();
        }

        static void Execute2()
        {
            var s1 = new Subsystem1();
            var s2 = new Subsystem2();
            var s3 = new Subsystem3();
            var s4 = new Subsystem4();

            s1.S1F1();
            s1.S1F2();
            s1.S1F3();

            s2.S2F1();
            s2.S2F2();
            s2.S2F3();

            s3.S3F1();
            s3.S3F2();
            s3.S3F3();

            s4.S4F1();
            s4.S4F2();
            s4.S4F3();
        }

        static void Execute1F() {

            var facade = new Facade();

            facade.CallF1();
            facade.CallAll();
        }

        static void Execute2F()
        {
            new Facade().CallAll();
        }
    }
}
