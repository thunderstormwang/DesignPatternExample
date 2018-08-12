using System;

namespace BridgeSample001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RefindAbstraction o = new RefindAbstraction(new ImplementorA());
            o.Operation();

            Console.ReadLine();
        }
    }
}