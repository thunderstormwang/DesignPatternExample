using System;

namespace ProtytypeSample004
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyClass2 o1 = new MyClass2();
            o1.Data.X = 888;
            var o2 = (MyClass2)o1.Clone();
            Console.WriteLine("ReferenceEquals(o1.Data, o2.Data) = " + object.ReferenceEquals(o1.Data, o2.Data));

            Console.ReadLine();
        }
    }
}