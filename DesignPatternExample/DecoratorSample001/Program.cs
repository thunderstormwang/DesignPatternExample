using System;

namespace DecoratorSample001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 可層層堆疊
            Component c = new ConcreteComponent();
            Component da = new ConcreteDecoratorA(c);
            Component db = new ConcreteDecoratorB(da);
            db.Operation();

            Console.ReadLine();
        }
    }
}