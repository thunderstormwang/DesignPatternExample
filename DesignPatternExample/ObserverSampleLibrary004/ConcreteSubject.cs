namespace ObserverSampleLibrary004
{
    public delegate void NotifyHandler(ConcreteSubject subject);

    public class ConcreteSubject
    {
        private string _subjectState;
        public NotifyHandler Notify;

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
                Notify(this);
            }
        }
    }
}