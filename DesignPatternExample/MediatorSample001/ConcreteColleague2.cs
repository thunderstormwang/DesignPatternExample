using System;

namespace MediatorSample001
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(IMediator mediator)
            : base(mediator)
        { }

        public override void Notify(string message)
        {
            Console.WriteLine(string.Format("C2 get {0}", message));
        }

        public override void Send(string message)
        {
            _mediator.Send(this, message);
        }
    }
}