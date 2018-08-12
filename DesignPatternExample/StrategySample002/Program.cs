using System;

namespace StrategySample002
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 與 simple factory 很像, 但 strategy 只需知道執行結果就好,
            // simple factory 會需要知道物件實體
            StrategyContext context = new StrategyContext();
            context.ExecuteStrategy("Strategy2");

            Console.ReadLine();
        }
    }
}