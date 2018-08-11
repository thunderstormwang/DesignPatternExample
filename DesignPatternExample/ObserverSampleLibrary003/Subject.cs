using System.Collections.Generic;

namespace ObserverSampleLibrary003
{
    public abstract class Subject
    {
        protected List<IObserver> _observers;

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
                if (observer != null)
                {
                    observer.Update(this);
                }
            }
        }
    }
}