namespace ProtytypeSample006
{
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
}