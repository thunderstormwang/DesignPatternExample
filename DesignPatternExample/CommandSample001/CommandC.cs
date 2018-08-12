namespace CommandSample001
{
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