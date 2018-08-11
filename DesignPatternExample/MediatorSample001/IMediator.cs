namespace MediatorSample001
{
    public interface IMediator
    {
        void Send(Colleague colleague, string message);
    }
}