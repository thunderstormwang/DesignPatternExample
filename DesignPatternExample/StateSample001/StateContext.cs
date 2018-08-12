namespace StateSample001
{
    public class StateContext
    {
        // 實際持有狀態
        internal AbstractState Current { get; set; }

        public StateContext()
        {
            Current = new State1();
        }

        public void Request()
        {
            if (Current != null)
            {
                Current.Handle(this);
            }
        }
    }
}