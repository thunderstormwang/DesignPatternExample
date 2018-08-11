namespace Command
{
    public abstract class Command
    {
        protected Receiver Receiver { get; set; }

        protected Command(Receiver receiver)
        {
            Receiver = receiver;
        }

        public abstract void execute();
    }

    public class CommandA : Command
    {
        public CommandA(Receiver receiver) : base(receiver)
        { }

        public override void execute()
        {
            Receiver.DoA();
        }
    }

    public class CommandB : Command
    {
        public CommandB(Receiver receiver) : base(receiver)
        { }

        public override void execute()
        {
            Receiver.DoB();
        }
    }

    public class CommandC : Command
    {
        public CommandC(Receiver receiver) : base(receiver)
        { }

        public override void execute()
        {
            Receiver.DoC();
        }
    }
}