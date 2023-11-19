namespace Berger.Extensions.Abstractions
{
    public interface IMessage<T> where T : Enum
    {
        T MessageType { get; }
    }
}