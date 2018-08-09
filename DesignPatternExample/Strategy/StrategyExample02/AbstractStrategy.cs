using System;

namespace Strategy.StrategyExample02
{
    public abstract class AbstractStrategy
    {
        public abstract void AlgorithmMethod();
    }

    internal class Strategy1 : AbstractStrategy
    {
        public override void AlgorithmMethod()
        {
            Console.WriteLine("Strategy 1");
        }
    }

    internal class Strategy2 : AbstractStrategy
    {
        public override void AlgorithmMethod()
        {
            Console.WriteLine("Strategy 2");
        }
    }
}