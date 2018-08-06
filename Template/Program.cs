using System;
using System.Collections.Generic;
using Template.DelegateSample;

namespace Template
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TemplateSample();

            DelegateSample();
        }

        private static void TemplateSample()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            TemplateSample.PredicateInt o = new TemplateSample.PredicateInt(list);
            var result = o.DoWhere();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        private static void DelegateSample()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            var result = list.DoWhere((x) => x > 4);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}