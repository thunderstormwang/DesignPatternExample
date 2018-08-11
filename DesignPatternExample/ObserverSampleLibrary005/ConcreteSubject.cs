namespace ObserverSampleLibrary005
{
    public delegate void NotifyHandler(object subject);

    public class ConcreteSubject
    {
        private string _subjectState;

        public NotifyHandler Notify { get; set; }

        public string SubjectState
        {
            get { return _subjectState; }
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