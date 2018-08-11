using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy.StrategyExample03
{
    public class StrategyContext
    {
        private Dictionary<string, Func<decimal, decimal, decimal>> Strategies
        { get; set; }

        public StrategyContext()
        {
            Strategies = new Dictionary<string, Func<decimal, decimal, decimal>>();
            Strategies.Add("+", (x, y) => x + y);
            Strategies.Add("-", (x, y) => x - y);
            Strategies.Add("*", (x, y) => x * y);
            Strategies.Add("/", (x, y) => x / y);
        }

        public decimal ExecuteStrategy(string args)
        {
            args = args.Trim();
            var strategy = Strategies.FirstOrDefault((x) => args.Contains(x.Key));
            if (strategy.Key != null)
            {
                decimal x;
                decimal y;
                decimal result = 0;
                var numbers = args.Split(new string[] { strategy.Key }, StringSplitOptions.None);
                decimal.TryParse(numbers[0], out x);
                decimal.TryParse(numbers[1], out y);
                result = strategy.Value.Invoke(x, y);
                return result;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}