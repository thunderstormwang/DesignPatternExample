namespace Bridge
{
    public abstract class Abstraction
    {
        protected IImplementor _implementor;

        protected Abstraction(IImplementor implementor)
        {
            _implementor = implementor;
        }

        public abstract void Operation();
    }

    public class RefindAbstraction : Abstraction
    {
        public RefindAbstraction(IImplementor implementor)
            : base(implementor)
        { }

        public override void Operation()
        {
            if (_implementor != null)
            {
                _implementor.OperationImp();
            }
        }
    }
}