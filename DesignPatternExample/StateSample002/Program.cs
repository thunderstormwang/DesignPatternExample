using System;

namespace StateSample002
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StateContext context = new StateContext();
            for (int i = 0; i < 10; i++)
            {
                context.Request();
            }
            Console.ReadLine();
        }
    }
}