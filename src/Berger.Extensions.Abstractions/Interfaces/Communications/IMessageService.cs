namespace Berger.Extensions.Abstractions
{
    public interface IMessageService<T> where T : Enum
    {
        void Send(IMessage<T> message);
    }
}