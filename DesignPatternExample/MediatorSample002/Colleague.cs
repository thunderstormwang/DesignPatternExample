using System;

namespace MediatorSample002
{
    public abstract class Colleague
    {
        public event EventHandler<string> MessageSended;

        public void Send(string message)
        {
            MessageSended?.Invoke(this, message);
        }

        public abstract void Notify(string message);
    }
}