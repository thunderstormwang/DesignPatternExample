using System;

namespace DecoratorSample001
{
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
}