using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFacade
{
    public class Dziennik
    {
        private readonly Dzienniki.Aktywnosci _aktywnosci = new Dzienniki.Aktywnosci();
        private readonly Dzienniki.Obecnosci _obecnosci = new Dzienniki.Obecnosci();
        private readonly Dzienniki.Oceny _oceny = new Dzienniki.Oceny();

        public bool Klasyfikacja()
        {
            try 
            {
                _aktywnosci.Informacje();
                _obecnosci.Informacje();
                _oceny.Informacje();

                return 
                    _aktywnosci.Klasyfikacja() &&
                    _obecnosci.Klasyfikacja() &&
                    _oceny.Klasyfikacja();
            }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }

            return false;
        }

        public void DodajOcene(Dzienniki.Ocena ocena)
        {
            _oceny.Add(ocena);
        }

        public void DodajObecnosc(bool obecnosc)
        {
            _obecnosci.Add(obecnosc);
        }

        public void DodajAktywnosc(DateTime aktywnosc)
        {
            _aktywnosci.Add(aktywnosc);
        }
    }
}
