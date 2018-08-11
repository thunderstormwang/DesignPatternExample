using System;

namespace MediatorSample001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();

            var c1 = new ConcreteColleague1(mediator);
            var c2 = new ConcreteColleague2(mediator);
            mediator.Colleague1 = c1;
            mediator.Colleague2 = c2;

            c1.Send("XYZ");
            c2.Send("12345");

            Console.ReadLine();
        }
    }
}