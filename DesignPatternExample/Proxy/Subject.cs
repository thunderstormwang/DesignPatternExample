using System;

namespace Proxy
{
    public abstract class Subject
    {
        public abstract void Request();
    }

    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("RealSubject request");
        }
    }

    public class Proxy : Subject
    {
        private Subject _realSubject;

        public Proxy()
        {
            _realSubject = new RealSubject();
        }

        public override void Request()
        {
            BeforeAction();
            _realSubject.Request();
            AfterAction();
        }

        private void BeforeAction()
        {
            Console.WriteLine("Proxy before request");
        }

        private void AfterAction()
        {
            Console.WriteLine("Proxy after request");
        }
    }
}