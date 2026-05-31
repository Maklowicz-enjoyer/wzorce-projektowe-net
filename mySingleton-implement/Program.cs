using System;
using System.Security.Cryptography;
namespace mySingleton_implement
{
    class Program
    {
        static void Main(string[] args)
        {
            
             Singleton_not_thread_secue.GetInstance().Log("WERSJA NIEBIEZPIECZNA");
             SingletonThreadLock.GetInstance().Log("wersja z lockiem");
            SingletonLazy.Instance.Log("wersja leniwa");
            staticReadonly_Singleton.GetInstance().Log("Wersja najprostrza thread secure");
            Console.ReadKey();
        }
    }
}