using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFacade
{
    public class Student
    {
        public string Imie { get; private set; }

        public string Nazwisko { get; private set; }

        public Dziennik DziennikStudenta { get; private set; }

        public Student(string imie, string nazwisko)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;

            this.DziennikStudenta = new Dziennik();
        }
    }
}
