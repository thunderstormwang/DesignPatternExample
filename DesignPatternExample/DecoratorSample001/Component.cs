namespace DecoratorSample001
{
    /// <summary>
    /// 可被 Decorator 動態增加職責的介面
    /// </summary>
    public abstract class Component
    {
        public abstract void Operation();
    }
}