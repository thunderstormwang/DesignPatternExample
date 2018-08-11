using ObserverSampleLibrary006;
using System;

namespace ObserverSample006
{
    public class ConcreteObserver
    {
        public string Name { get; set; }

        public void Update(object subject, EventArgs args)
        {
            var s = (ConcreteSubject)subject;
            Console.WriteLine(string.Format("{0} Update Subject State : {1}",
                Name,
                s.SubjectState));
        }
    }
}