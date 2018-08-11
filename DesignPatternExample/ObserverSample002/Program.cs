using ObserverSampleLibrary002;
using System;

namespace ObserverSample002
{
    public class Program
    {
        // 跟 (001) 差別分成2個專案

        public static void Main(string[] args)
        {
            ConcreteSubject s = new ConcreteSubject();
            ConcreteObserver o1 = new ConcreteObserver(s) { Name = "A" };
            ConcreteObserver o2 = new ConcreteObserver(s) { Name = "B" };

            s.SubjectState = "Rain drop falling on my head";

            Console.ReadLine();
        }
    }
}