using System;

namespace Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Subject o = new Proxy();
            o.Request();

            Console.WriteLine();
        }
    }
}