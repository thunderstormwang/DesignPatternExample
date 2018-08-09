namespace Protytype.PrototypeSample06
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

    /// <summary>
    /// 工廠一，產生同一族的產品 A 與 產品 B
    /// </summary>
    public class Factory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return (AbstractProductA)_manager.GetPrototype("ProductA1");
        }

        public override AbstractProductB CreateProductB()
        {
            return (AbstractProductB)_manager.GetPrototype("ProductB1");
        }
    }

    /// <summary>
    /// 工廠二，產生同一族的產品 A 與 產品 B
    /// </summary>
    public class Factory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return (AbstractProductA)_manager.GetPrototype("ProductA2");
        }

        public override AbstractProductB CreateProductB()
        {
            return (AbstractProductB)_manager.GetPrototype("ProductB2");
        }
    }
}
