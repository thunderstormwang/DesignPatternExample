using ObserverSampleLibrary004;
using System;

namespace ObserverSample004
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteSubject s = new ConcreteSubject();
            s.Notify += new ConcreteObserver() { Name = "A" }.Update;
            s.Notify += new ConcreteObserver() { Name = "B" }.Update;
            s.Notify += new ConcreteObserver() { Name = "C" }.Update;
            s.SubjectState = "How old are you ?";

            Console.ReadLine();
        }
    }
}