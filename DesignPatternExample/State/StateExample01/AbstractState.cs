using System;

namespace State.StateExample01
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