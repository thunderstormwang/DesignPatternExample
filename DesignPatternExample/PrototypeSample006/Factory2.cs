namespace ProtytypeSample006
{
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