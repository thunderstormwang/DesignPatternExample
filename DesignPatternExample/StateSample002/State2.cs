using System;

namespace StateSample002
{
    public class State2 : IState
    {
        public IState Handle()
        {
            Console.WriteLine("6");
            return new State1();
        }
    }
}