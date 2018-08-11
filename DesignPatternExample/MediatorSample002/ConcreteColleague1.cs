using System;

namespace MediatorSample002
{
    public class ConcreteColleague1 : Colleague
    {
        public override void Notify(string message)
        {
            Console.WriteLine(string.Format("C1 get {0}", message));
        }
    }
}