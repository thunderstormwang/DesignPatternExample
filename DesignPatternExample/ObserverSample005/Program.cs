using ObserverSampleLibrary005;
using System;

namespace ObserverSample005
{
    /// <summary>
    /// 委派，參數使用 object
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteSubject s = new ConcreteSubject();
            s.Notify += new ConcreteObserver() { Name = "A" }.Update;
            s.Notify += new ConcreteObserver() { Name = "B" }.Update;
            s.Notify += new ConcreteObserver() { Name = "C" }.Update;
            s.SubjectState = "All I have to do is dream.";

            Console.ReadLine();
        }
    }
}