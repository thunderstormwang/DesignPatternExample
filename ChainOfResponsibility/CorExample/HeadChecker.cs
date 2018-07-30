namespace ChainOfResponsibility.CorExample
{
    /// <summary>
    /// 開頭檢查
    /// </summary>
    internal class HeadChecker : FormatChecker
    {
        public HeadChecker(FormatChecker successor) : base(successor)
        { }

        protected override bool InternalCheck(string source)
        {
            string head = source.Substring(0, 3);
            return head == "965";
        }
    }
}