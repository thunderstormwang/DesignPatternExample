namespace StrategySample002
{
    public class StrategyContext
    {
        public void ExecuteStrategy(string args)
        {
            var strategy = StrategyFactory.CreateStrategy(args);
            if (strategy != null)
            {
                strategy.AlgorithmMethod();
            }
        }
    }
}