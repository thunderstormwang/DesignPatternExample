using System;

namespace ObserverSampleLibrary006
{
    public class ConcreteSubject
    {
        private string _subjectState;

        public event EventHandler Notify;

        public string SubjectState
        {
            get
            {
                return _subjectState;
            }
            set
            {
                if (value != _subjectState)
                {
                    _subjectState = value;
                    OnNotify();
                }
            }
        }

        private void OnNotify()
        {
            if (Notify != null)
            {
                Notify(this, EventArgs.Empty);
            }
        }
    }
}