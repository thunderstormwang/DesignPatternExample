using System;

namespace DecoratorSample001
{
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