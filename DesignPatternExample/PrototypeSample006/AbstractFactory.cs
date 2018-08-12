namespace ProtytypeSample006
{
    public abstract class AbstractFactory
    {
        protected PrototypeManager _manager;

        protected AbstractFactory()
        {
            _manager = new PrototypeManager();
            _manager.AddPrototype("ProductA1", new ProductA1());
            _manager.AddPrototype("ProductA2", new ProductA2());
            _manager.AddPrototype("ProductB1", new ProductB1());
            _manager.AddPrototype("ProductB2", new ProductA2());
        }

        public abstract AbstractProductA CreateProductA();

        public abstract AbstractProductB CreateProductB();
    }
}