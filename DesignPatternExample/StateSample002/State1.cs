using System;

namespace StateSample002
{
    public class State1 : IState
    {
        public IState Handle()
        {
            Console.WriteLine("5");
            return new State2();
        }
    }
}