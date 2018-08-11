using System;

namespace Strategy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StrategyExample01();

            StrategyExample02();

            StrategyExample03();
        }

        private static void StrategyExample01()
        {
            // 這會讓 Client 端程式知道實作內容"Strategy1"
            StrategyExample01.StrategyContext context = new StrategyExample01.StrategyContext(new StrategyExample01.Strategy1());
            context.ExecuteStrategy();

            Console.ReadLine();
        }

        private static void StrategyExample02()
        {
            // 與 simple factory 很像, 但 strategy 只需知道執行結果就好,
            // simple factory 會需要知道物件實體
            StrategyExample02.StrategyContext context = new StrategyExample02.StrategyContext();
            context.ExecuteStrategy("Strategy2");

            Console.ReadLine();
        }

        private static void StrategyExample03()
        {
            StrategyExample03.StrategyContext context = new StrategyExample03.StrategyContext();
            Console.WriteLine(context.ExecuteStrategy("1+6"));
            Console.WriteLine(context.ExecuteStrategy("7-5"));
            Console.WriteLine(context.ExecuteStrategy("3*6"));
            Console.WriteLine(context.ExecuteStrategy("6/2"));
        }
    }
}