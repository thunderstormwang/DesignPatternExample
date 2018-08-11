using ObserverSampleLibrary003;
using System;

namespace ObserverSample003
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteSubject s = new ConcreteSubject();
            s.AddObserver(new ConcreteObserver() { Name = "A" });
            s.AddObserver(new ConcreteObserver() { Name = "B" });
            s.AddObserver(new ConcreteObserver() { Name = "C" });

            s.SubjectState = "Where have all the flowers gone ?";

            Console.ReadLine();
        }
    }
}