using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Adam", "Małysz");
           
            var oceny1 = new List<Dzienniki.Ocena> { 
                Dzienniki.Ocena.DOBRA,
                Dzienniki.Ocena.DOBRA,
                Dzienniki.Ocena.DOBRA,
                Dzienniki.Ocena.DOBRA,
                Dzienniki.Ocena.DOBRA,
            };

            oceny1.ForEach(ocena => student1.DziennikStudenta.DodajOcene(ocena));

            var student2 = new Student("Robert", "Kubica");

            var oceny2 = new List<Dzienniki.Ocena> {
                Dzienniki.Ocena.DOBRA,
                Dzienniki.Ocena.BARDZO_DOBRA,
                Dzienniki.Ocena.DOSTATECZNA,
                Dzienniki.Ocena.DOSTATECZNA_PLUS,
            };

            oceny2.ForEach(ocena => student2.DziennikStudenta.DodajOcene(ocena));

            var lista = new ListaStudentow() { student1, student2 };

            lista.ForEach(
                student => 
                    Console.WriteLine("Klasyfikacja dla {0} {1}: {2}", 
                    student.Imie,
                    student.Nazwisko,
                    student.DziennikStudenta.Klasyfikacja()));

            Console.ReadKey();
        }
    }
}
