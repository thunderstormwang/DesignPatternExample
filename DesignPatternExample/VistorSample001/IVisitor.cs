namespace VistorSample001
{
    public interface IVisitor
    {
        void Visit(ElementA element);

        void Visit(ElementB element);
    }
}