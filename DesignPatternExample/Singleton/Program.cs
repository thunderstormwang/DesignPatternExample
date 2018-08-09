using System;

namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                SingletonClass.SingletonObject.Show();
            }
            Console.ReadLine();
        }
    }
}
