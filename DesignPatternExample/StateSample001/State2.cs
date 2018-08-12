using System;

namespace StateSample001
{
    public class State2 : AbstractState
    {
        // 子類別須實作出特定狀態的具體行為內容
        public override void Handle(StateContext context)
        {
            Console.WriteLine("2");
            context.Current = new State1();
        }
    }
}