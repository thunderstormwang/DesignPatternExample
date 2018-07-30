namespace ChainOfResponsibility.CorExample
{
    public abstract class FormatChecker
    {
        protected FormatChecker _successor;
        protected abstract bool InternalCheck(string source);
        public CheckResult Check(string source)
        {
            // 檢查結果為 true, 若沒有後繼者,表示檢查結束, 若有後繼者則繼續往下處理
            // 檢查結果為 false, 則跳出, 不再處理
            if (InternalCheck(source))
            {
                if (_successor != null)
                {
                    return _successor.Check(source);
                }
                else
                {
                    return new CheckResult() { Source = source, Result = true };
                }
            }
            else
            {
                return new CheckResult() { Source = source, Result = false };
            }
        }

        protected FormatChecker(FormatChecker successor)
        {
            _successor = successor;
        }
    }
}