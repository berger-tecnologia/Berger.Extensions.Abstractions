namespace Berger.Extensions.Abstractions
{
    public interface IMessage<T> where T : Enum
    {
        T MessageType { get; }
        string Body { get; set; }
        string Subject { get; set; }
        string Recipient { get; set; }
    }
}