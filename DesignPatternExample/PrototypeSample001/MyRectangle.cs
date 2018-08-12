namespace ProtytypeSample001
{
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