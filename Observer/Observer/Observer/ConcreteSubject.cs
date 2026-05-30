using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class ConcreteSubject : Subject
    {
        private string _name = "";

        public void SetName(string name) { 
            
            this._name = name;

            this.Notify();
        }
    }
}
