using System.Collections.Generic;

namespace ObserverSample001
{
    /// <summary>
    ///  被觀察者(通知者)的抽象
    /// </summary>
    public abstract class Subject
    {
        private List<IObserver> _observers;

        public Subject()
        {
            _observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        protected void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}