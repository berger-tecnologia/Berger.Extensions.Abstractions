namespace Berger.Extensions.Abstractions
{
    public interface IMessage<T> : IBaseEntity<Guid> where T : Enum
    {
        T MessageType { get; }
        string Message { get; set; }
    }
}