using System;

namespace PrototypeSample007_Extension
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            Class1 o1 = new Class1();
            o1.X = 888;
            Class1 o2 = o1.Clone();
            Console.WriteLine("ReferenceEquals(o1.X, o2.X) = " + object.ReferenceEquals(o1.X, o2.X));

            Console.ReadLine();
        }
    }
}