using Iterator.IteratorSample01;
using Iterator.IteratorSample02;
using Iterator.IteratorSample03;
using System;

namespace Iterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyIterator01 myIterator01 = new MyIterator01();

            foreach (double item in myIterator01)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            MyIterator02 myIterator02 = new MyIterator02();

            foreach (double item in myIterator02)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            MyIterator03 myIterator03 = new MyIterator03();

            foreach (double item in myIterator03)
            {
                Console.Write(item + " ");
            }
        }
    }
}