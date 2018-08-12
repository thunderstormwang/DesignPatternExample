using System;
using System.Collections.Generic;

namespace TemplateSample002_Delegate
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
            var result = list.DoWhere((x) => x > 4);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}