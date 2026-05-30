using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFacade.Dzienniki
{
    public class Aktywnosci : List<DateTime>
    {
        public bool Klasyfikacja() {
            
            try {
                return this.Count > 0;
            }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }

            return false;
        }

        public void Informacje() {
            try
            {
                Console.WriteLine("Dziennik aktywności");

                this.ForEach(elem => Console.Write("{0} | ",elem.ToShortDateString()));

                /*
                    foreach (var elem in this)
                    {
                        Console.WriteLine("{0}|", elem.ToShortDateString();
                    }
                */
            }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }
        }
    }
}
