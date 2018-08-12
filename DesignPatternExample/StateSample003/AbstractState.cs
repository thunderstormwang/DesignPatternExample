using System;

namespace StateSample003
{
    /// <summary>
    ///
    /// </summary>
    public abstract class AbstractState
    {
        public abstract void Handle(StateContext context);
    }

    public class State1 : AbstractState
    {
        public override void Handle(StateContext context)
        {
            Console.WriteLine("8");
            context.Current = context.GetInstance<State2>();
        }
    }

    public class State2 : AbstractState
    {
        public override void Handle(StateContext context)
        {
            Console.WriteLine("9");
            context.Current = context.GetInstance<State1>();
        }
    }
}