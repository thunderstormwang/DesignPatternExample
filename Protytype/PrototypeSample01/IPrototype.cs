namespace Protytype.PrototypeSample01
{
    // 自定義介面

    public interface IPrototype
    {
        IPrototype Clone();
    }

    public class MyRectangle : IPrototype
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public IPrototype Clone()
        {
            MyRectangle o = new MyRectangle();
            o.Width = this.Width;
            o.Height = this.Height;
            return o;
        }
    }
}
