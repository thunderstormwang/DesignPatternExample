using System;

namespace ProtytypeSample002
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyRectangle o1 = new MyRectangle();
            o1.Height = 5;
            o1.Width = 8;

            var o2 = (MyRectangle)o1.Clone();
            Console.WriteLine(o2.Width.ToString());
            Console.ReadLine();
        }
    }
}