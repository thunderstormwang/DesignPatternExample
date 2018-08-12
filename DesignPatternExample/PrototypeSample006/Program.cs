using System;

namespace ProtytypeSample006
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var factory = new Factory1();
            var pa = factory.CreateProductA();
            var pb = factory.CreateProductB();
            Console.WriteLine(pa.GetType().Name);
            Console.WriteLine(pb.GetType().Name);

            Console.ReadLine();
        }
    }
}