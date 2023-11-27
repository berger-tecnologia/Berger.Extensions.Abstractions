namespace Berger.Extensions.Abstractions
{
    public interface ISession
    {
        void Logoff();
        Guid GetSid();
        string GetIp();
        string GetName();
        Guid GetGroupSid();
        string GetEmail();
        List<string> GetRole();
    }
}