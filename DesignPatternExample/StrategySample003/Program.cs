using System;

namespace StrategySample003
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StrategyContext context = new StrategyContext();
            Console.WriteLine(context.ExecuteStrategy("1+6"));
            Console.WriteLine(context.ExecuteStrategy("7-5"));
            Console.WriteLine(context.ExecuteStrategy("3*6"));
            Console.WriteLine(context.ExecuteStrategy("6/2"));
        }
    }
}