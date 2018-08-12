namespace StrategySample002
{
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