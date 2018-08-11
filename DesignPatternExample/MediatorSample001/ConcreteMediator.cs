namespace MediatorSample001
{
    public class ConcreteMediator : IMediator
    {
        public ConcreteColleague1 Colleague1
        {
            private get;
            set;
        }

        public ConcreteColleague2 Colleague2
        {
            private get;
            set;
        }

        public void Send(Colleague colleague, string message)
        {
            if (colleague == Colleague1)
            {
                Colleague2.Notify(message);
            }
            else
            {
                Colleague1.Notify(message);
            }
        }
    }
}