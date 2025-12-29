namespace Berger.Extensions.Abstractions
{
    public interface ISeen
    {
        bool Seen { get; }
        DateTime? SeenOn { get; }
    }
}