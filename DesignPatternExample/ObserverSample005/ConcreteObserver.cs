﻿using ObserverSampleLibrary005;
using System;

namespace ObserverSample005
{
    public class ConcreteObserver
    {
        public string Name { get; set; }

        public void Update(object subject)
        {
            var s = (ConcreteSubject)subject;
            Console.WriteLine(string.Format("{0} Update Subject State : {1}",
                Name,
                s.SubjectState));
        }
    }
}