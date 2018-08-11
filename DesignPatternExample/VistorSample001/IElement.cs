namespace VistorSample001
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

    public class ElementA : IElement
    {
        public int X { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class ElementB : IElement
    {
        public int Y { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}