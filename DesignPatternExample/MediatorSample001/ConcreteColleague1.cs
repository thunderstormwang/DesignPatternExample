using System;

namespace MediatorSample001
{
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(IMediator mediator)
            : base(mediator)
        { }

        public override void Notify(string message)
        {
            Console.WriteLine(string.Format("C1 get {0}", message));
        }

        public override void Send(string message)
        {
            _mediator.Send(this, message);
        }
    }
}