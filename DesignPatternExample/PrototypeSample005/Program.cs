using System;

namespace ProtytypeSample005
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var o = ProductsContext.Manager.GetPrototype("ProductA1");

            Console.WriteLine(o.GetType().Name);
            Console.ReadLine();
        }
    }
}