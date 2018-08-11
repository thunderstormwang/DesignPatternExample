using System;

namespace MediatorSample002
{
    public class ConcreteColleague2 : Colleague
    {`
        public override void Notify(string message)
        {
            Console.WriteLine(string.Format("C2 get {0}", message));
        }
    }
}