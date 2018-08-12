using System;

namespace DecoratorSample001
{
    /// <summary>
    /// 實作的 Component
    /// </summary>
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent operation");
        }
    }
}