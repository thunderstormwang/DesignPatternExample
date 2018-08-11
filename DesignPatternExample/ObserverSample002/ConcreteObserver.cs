using ObserverSampleLibrary002;
using System;

namespace ObserverSample002
{
    /// <summary>
    /// 實作觀察者
    /// </summary>
    public class ConcreteObserver : IObserver
    {
        private ConcreteSubject _subject;

        public string Name
        {
            get;
            set;
        }

        public ConcreteObserver(ConcreteSubject subject)
        {
            _subject = subject;
            _subject.AddObserver(this);
        }

        public void Update()
        {
            Console.WriteLine(string.Format("{0} Update Subject State : {1}", Name, _subject.SubjectState));
        }
    }
}