using System;

namespace IteratorSample001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyIterator myIterator = new MyIterator();

            foreach (double item in myIterator)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}