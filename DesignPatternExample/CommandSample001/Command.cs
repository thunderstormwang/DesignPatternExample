namespace CommandSample001
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
}