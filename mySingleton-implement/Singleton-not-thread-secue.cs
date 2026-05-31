using System;
using System.Collections.Generic;
using System.Text;

namespace mySingleton_implement
{
    public class Singleton_not_thread_secue
    {
        private static Singleton_not_thread_secue instance;

        private Singleton_not_thread_secue() { } // Private constructor to prevent instantiation

        public static Singleton_not_thread_secue GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton_not_thread_secue(); //tworzy tylko raz
            }
            return instance;
        }
        public void Log(string message)
        {
            Console.WriteLine($"[Not-Safe] {message}");
        }
    }
}
