namespace CommandSample001
{
    public class CommandA : Command
    {
        public CommandA(Receiver receiver) : base(receiver)
        { }

        public override void execute()
        {
            Receiver.DoA();
        }
    }
}