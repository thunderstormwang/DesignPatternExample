using System;

namespace ProxySample001
{
    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("RealSubject request");
        }
    }
}