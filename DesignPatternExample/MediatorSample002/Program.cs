using System;

namespace MediatorSample002
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();

            var c1 = new ConcreteColleague1();
            var c2 = new ConcreteColleague2();
            mediator.AddColleague(c1);
            mediator.AddColleague(c2);

            c1.Send("XYZ");
            c2.Send("12345");

            Console.ReadLine();
        }
    }
}