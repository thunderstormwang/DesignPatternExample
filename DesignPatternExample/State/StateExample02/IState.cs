using System;

namespace State.StateExample02
{
    /// <summary>
    /// 使用 Interface 作為 State 的抽象
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// 這是一種變形，將下一個 State 物件傳回
        /// </summary>
        /// <returns></returns>
        IState Handle();
    }

    public class State1 : IState
    {
        public IState Handle()
        {
            Console.WriteLine("5");
            return new State2();
        }
    }

    public class State2 : IState
    {
        public IState Handle()
        {
            Console.WriteLine("6");
            return new State1();
        }
    }
}