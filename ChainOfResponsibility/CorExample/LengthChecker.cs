namespace ChainOfResponsibility.CorExample
{
    /// <summary>
    /// 長度檢查
    /// </summary>
    internal class LengthChecker : FormatChecker
    {
        public LengthChecker(FormatChecker successor) : base(successor)
        { }

        protected override bool InternalCheck(string source)
        {
            return source.Length == 29;
        }
    }
}