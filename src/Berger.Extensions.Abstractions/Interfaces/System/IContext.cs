namespace Berger.Extensions.Abstractions
{
    public interface IContext
    {
        Guid ApplicationId { get; }
        void SetApplication(Guid applicationId);
    }
}