namespace Berger.Extensions.Abstractions
{
    public interface IEmailService<T> where T : Enum
    {
        void Send(IMessage<T> message, ISmtpConfiguration smtp, string alias = "");
    }
}