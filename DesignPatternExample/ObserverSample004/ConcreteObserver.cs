using ObserverSampleLibrary004;
using System;

namespace ObserverSample004
{
    public class ConcreteObserver
    {
        public string Name
        {
            get;
            set;
        }

        public void Update(ConcreteSubject subject)
        {
            Console.WriteLine(string.Format("{0} Update Subject State : {1}", Name, subject.SubjectState));
        }
    }
}