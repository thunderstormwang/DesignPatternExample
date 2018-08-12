namespace CommandSample001
{
    public class CommandB : Command
    {
        public CommandB(Receiver receiver) : base(receiver)
        { }

        public override void execute()
        {
            Receiver.DoB();
        }
    }
}