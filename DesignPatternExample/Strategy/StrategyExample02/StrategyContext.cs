namespace Strategy.StrategyExample02
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

    public class StrategyFactory
    {
        public static AbstractStrategy CreateStrategy(string args)
        {
            switch (args)
            {
                case "Strategy1":
                    return new Strategy1();

                case "Strategy2":
                    return new Strategy2();

                default:
                    return null;
            }
        }
    }
}