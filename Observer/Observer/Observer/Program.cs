namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Observer observer = new ConcreteObserver("Obserwator 1");
            Observer observer2 = new ConcreteObserver("Obserwator 2");
            Observer observer3 = new ConcreteObserver("Obserwator 3");

            ConcreteSubject subject = new ConcreteSubject();
            ConcreteSubject subject2 = new ConcreteSubject();

            subject.Attach(observer);
            subject.Attach(observer2);
            subject.Attach(observer3);

            subject2.Attach(observer);


            string? text = "";
            while (text != "exit")
            {
                text = Console.ReadLine();

                if (text != null)
                {
                    subject.SetName(text);
                    subject2.SetName(text);
                }
            }
        }
    }
}
