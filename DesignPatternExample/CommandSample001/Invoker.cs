namespace CommandSample001
{
    public class Invoker
    {
        private Command _command;

        public void SetCommnad(Command command)
        {
            _command = command;
        }

        public void Action()
        {
            _command.execute();
        }
    }
}