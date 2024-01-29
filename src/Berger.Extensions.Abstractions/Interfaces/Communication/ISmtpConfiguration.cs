namespace Berger.Extensions.Abstractions
{
    public interface ISmtpConfiguration
    {
        string Host { get; }
        int Port { get; }
        bool EnableSsl { get; }
        string User { get; }
        string Password { get; }
    }
}