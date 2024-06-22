namespace Berger.Extensions.Abstractions
{
    public interface IMessage<T> where T : Enum
    {
        T MessageFormat { get; }
        string Body { get; }
        string Subject { get; }
        string Recipient { get; }
        Guid? PhoneId { get; set; }
        Guid ApplicationId { get; set; }
        Guid? CultureId { get; set; }
        Guid InteractionId { get; set; }
        string TemplateUrl { get; set; }
        List<KeyValuePair<string, string>> Data { get; set; }
        string Content { get; set; }
        bool Simulation { get; set; }
    }
}