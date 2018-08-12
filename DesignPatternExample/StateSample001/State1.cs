using System;

namespace StateSample001
{
    // 父類別和子類別皆沒有儲存狀態, 型別本身就是狀態

    public class State1 : AbstractState
    {
        // 子類別須實作出特定狀態的具體行為內容
        public override void Handle(StateContext context)
        {
            Console.WriteLine("1");
            context.Current = new State2();
        }
    }
}