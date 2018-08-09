using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var checker = new OriginalSample.FormatChecker();
            //var checker = new CorExample.FormatChecker();
            List<CheckResult> results = new List<CheckResult>();
            foreach (var item in FakeDataSource.Data)
            {
                results.Add(checker.Check(item));
            }

            foreach (var item in results)
            {
                Console.WriteLine($"Source : {item.Source} , Result is {item.Result}");
            }
            Console.ReadLine();

        }
    }
}
