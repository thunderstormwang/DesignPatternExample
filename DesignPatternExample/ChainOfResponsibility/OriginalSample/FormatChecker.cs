using System;

namespace ChainOfResponsibility.OriginalSample
{
    public class FormatChecker
    {
        public CheckResult Check(string source)
        {
            // 巢狀 if, 不易讀且難維護

            var result = new CheckResult() { Source = source };

            if (source.Length == 29)
            {
                if (source.Substring(0, 3) == "965")
                {
                    DateTime firstDate;
                    if (DateTime.TryParseExact(source.Substring(13, 8), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture,
                           System.Globalization.DateTimeStyles.None, out firstDate))
                    {
                        DateTime secondDate;
                        if (DateTime.TryParseExact(source.Substring(21, 8), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture,
                           System.Globalization.DateTimeStyles.None, out secondDate))
                        {
                            result.Result = true;
                        }
                    }
                }
            }

            return result;
        }
    }
}