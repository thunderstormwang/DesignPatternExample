namespace DecoratorSample001
{
    /// <summary>
    /// Decorator (裝飾者) 的介面
    /// </summary>
    public abstract class Decorator : Component
    {
        // 包含 Component 實體
        protected Component _component;

        protected Decorator(Component component)
        {
            _component = component;
        }
    }
}