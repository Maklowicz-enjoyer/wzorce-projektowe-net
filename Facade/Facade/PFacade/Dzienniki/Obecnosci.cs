using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFacade.Dzienniki
{
    public class Obecnosci : List<bool>
    {
        public bool Klasyfikacja()
        {
            try 
            {
                var nieobecnosci = this.Count(elem => elem == false);
                var w = this.Count;
                var wartosc = (double)nieobecnosci / w;
                return wartosc < 0.2;
            } 
            
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }

            return false;
        }

        public void Informacje()
        {
            try
            {
                Console.WriteLine("Dziennik obecności");

                this.ForEach(elem => Console.Write("{0} | ", elem ? "Obecny" : "Nieobecny"));

            }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }
        }
    }
}
