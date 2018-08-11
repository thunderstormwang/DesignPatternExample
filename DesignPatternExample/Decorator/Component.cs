using System;

namespace Decorator
{
    /// <summary>
    /// 可被 Decorator 動態增加職責的介面
    /// </summary>
    public abstract class Component
    {
        public abstract void Operation();
    }

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

    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component)
        { }

        public override void Operation()
        {
            _component.Operation();
            AddedBehavior();
        }

        private void AddedBehavior()
        {
            Console.WriteLine("ConcreteDecoratorA AddBehavior");
        }
    }

    /// <summary>
    /// 裝飾者實作 B
    /// </summary>
    public class ConcreteDecoratorB : Decorator
    {
        public string AddedState
        {
            get;
            set;
        }

        public ConcreteDecoratorB(Component component) : base(component)
        {
            AddedState = "ConcreteDecoratorB State";
        }

        public override void Operation()
        {
            _component.Operation();
            Console.WriteLine(AddedState);
        }
    }
}