using System;

namespace StrategySample002
{
    internal class Strategy1 : AbstractStrategy
    {
        public override void AlgorithmMethod()
        {
            Console.WriteLine("Strategy 1");
        }
    }
}