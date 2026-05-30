using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFacade.Dzienniki
{
    public class Oceny: List<Ocena>
    {
        public bool Klasyfikacja()
        {
            try 
            {
                var wartosc = !this.Exists(elem => elem == Ocena.NIEDOSTATECZNA);
                return wartosc;
            }
            catch (Exception ex) {Console.Error.WriteLine(ex.Message); }

            return false;
        }
    
        public void Informacje()
        {
            try
            {
                Console.WriteLine("Dziennik ocen");

                this.ForEach(elem => Console.Write("{0} | ", elem.ToString())); ;
            }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }
        }
    }

    public enum Ocena { 
        NIEDOSTATECZNA = 0,
        DOSTATECZNA = 1,
        DOSTATECZNA_PLUS = 2,
        DOBRA = 3,
        DOBRA_PLUS = 4,
        BARDZO_DOBRA = 5
    }
}
