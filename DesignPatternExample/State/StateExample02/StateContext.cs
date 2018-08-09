namespace State.StateExample02
{
    public class StateContext
    {
        public StateContext()
        {
            Current = new State1();
        }

        private IState Current { get; set; }

        public void Request()
        {
            if (Current != null)
            {
                Current = Current.Handle();
            }
        }
    }
}