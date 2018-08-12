using System;
using System.Collections.Generic;

namespace TemplateSmple001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            PredicateInt o = new PredicateInt(list);
            var result = o.DoWhere();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}