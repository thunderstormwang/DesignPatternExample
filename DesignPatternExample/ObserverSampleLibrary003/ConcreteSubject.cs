namespace ObserverSampleLibrary003
{
    public class ConcreteSubject : Subject
    {
        private string _subjectState;

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
                    Notify();
                }
            }
        }
    }
}