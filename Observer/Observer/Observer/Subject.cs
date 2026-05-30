using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal abstract class Subject
    {
        private readonly List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer) {
        
            if(observer != null) _observers.Add(observer);
        }

        public void Detach(Observer observer) { 
            if(observer != null) _observers.Remove(observer);
        }

        public void Notify() {
            foreach (Observer observer in _observers) { 
                observer?.Update(this);
            }
        }
    }
}
