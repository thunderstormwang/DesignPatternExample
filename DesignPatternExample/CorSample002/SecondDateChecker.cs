using System;

namespace CorSample002
{
    /// <summary>
    /// 第二個日期檢查
    /// </summary>
    internal class SecondDateChecker : FormatChecker
    {
        public SecondDateChecker(FormatChecker successor) : base(successor)
        { }

        protected override bool InternalCheck(string source)
        {
            var dateString = source.Substring(21, 8);
            DateTime date;
            return DateTime.TryParseExact(dateString, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture,
                            System.Globalization.DateTimeStyles.None, out date);
        }
    }
}