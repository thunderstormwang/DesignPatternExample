namespace StrategySample001
{
    public class StrategyContext
    {
        private AbstractStrategy _strategy;

        public StrategyContext(AbstractStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            _strategy.AlgorithmMethod();
        }
    }
}