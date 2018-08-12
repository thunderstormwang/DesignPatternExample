using System;

namespace StrategySample001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 這會讓 Client 端程式知道實作內容"Strategy1"
            StrategyContext context = new StrategyContext(new Strategy1());
            context.ExecuteStrategy();

            Console.ReadLine();
        }
    }
}