namespace StateSample001
{
    /// <summary>
    /// 使用 Abstract Class 作為 State 的抽象
    /// </summary>
    public abstract class AbstractState
    {
        /// <summary>
        /// 傳入 State Context
        /// </summary>
        /// <param name="context"></param>
        public abstract void Handle(StateContext context);
    }
}