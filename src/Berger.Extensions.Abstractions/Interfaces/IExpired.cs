namespace Berger.Extensions.Abstractions
{
    public interface IExpired
    {
        bool Expired { get; }
        DateTime? StartsOn { get; }
        DateTime? ExpiresOn { get; }
    }
}