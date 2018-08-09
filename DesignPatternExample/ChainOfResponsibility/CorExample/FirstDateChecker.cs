using System;

namespace ChainOfResponsibility.CorExample
{
    /// <summary>
    /// 第一個日期檢查
    /// </summary>
    internal class FirstDateChecker : FormatChecker
    {
        public FirstDateChecker(FormatChecker successor) : base(successor)
        { }

        protected override bool InternalCheck(string source)
        {
            var dateString = source.Substring(13, 8);
            DateTime date;
            return DateTime.TryParseExact(dateString, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture,
                           System.Globalization.DateTimeStyles.None, out date);
        }
    }
}