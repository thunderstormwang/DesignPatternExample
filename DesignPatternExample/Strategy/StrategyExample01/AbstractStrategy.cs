using System;

namespace Strategy.StrategyExample01
{
    public abstract class AbstractStrategy
    {
        public abstract void AlgorithmMethod();
    }

    public class Strategy1 : AbstractStrategy
    {
        public override void AlgorithmMethod()
        {
            Console.WriteLine("Strategy 1");
        }
    }

    public class Strategy2 : AbstractStrategy
    {
        public override void AlgorithmMethod()
        {
            Console.WriteLine("Strategy 2");
        }
    }
}