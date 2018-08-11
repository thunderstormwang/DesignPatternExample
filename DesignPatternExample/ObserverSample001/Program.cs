using System;

namespace ObserverSample001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteSubject s = new ConcreteSubject();
            ConcreteObserver o1 = new ConcreteObserver(s) { Name = "A" };
            ConcreteObserver o2 = new ConcreteObserver(s) { Name = "B" };

            s.SubjectState = "This is a dog";

            Console.ReadLine();
        }
    }
}