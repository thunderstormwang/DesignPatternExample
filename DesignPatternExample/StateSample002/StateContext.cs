namespace StateSample002
{
    public class StateContext
    {
        private IState Current { get; set; }

        public StateContext()
        {
            Current = new State1();
        }

        public void Request()
        {
            if (Current != null)
            {
                Current = Current.Handle();
            }
        }
    }
}