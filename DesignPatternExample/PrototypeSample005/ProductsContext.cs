namespace ProtytypeSample005
{
    /// <summary>
    /// 使用 ProrotypeManager 的上下文介面
    /// </summary>
    public class ProductsContext
    {
        private static PrototypeManager _manager;

        public static PrototypeManager Manager
        {
            get
            {
                if (_manager == null)
                {
                    CreateManager();
                }
                return _manager;
            }
        }

        private static void CreateManager()
        {
            _manager = new PrototypeManager();
            _manager.AddPrototype("ProductA1", new ProductA1());
            _manager.AddPrototype("ProductA2", new ProductA2());
            _manager.AddPrototype("ProductB1", new ProductB1());
            _manager.AddPrototype("ProductB2", new ProductB2());
        }
    }
}