using System;

namespace SingletonSample002_RegistryOfSingleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var o1 = SingletonRegistry.GetInstance<Class1>();
            var o2 = SingletonRegistry.GetInstance<Class1>();

            Console.WriteLine(object.ReferenceEquals(o1, o2));

            Console.ReadLine();
        }
    }
}