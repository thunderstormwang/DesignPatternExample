using System;

namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcteteBuilder1 builder = new ConcteteBuilder1();
            Director director = new Director(builder);

            var result = builder.GetResult();

            Console.ReadLine();
        }
    }
}