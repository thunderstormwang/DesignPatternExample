﻿namespace Momento
{
    public class Memento
    {
        public string State
        {
            get;
            private set;
        }

        public Memento(string state)
        {
            State = state;
        }
    }
}