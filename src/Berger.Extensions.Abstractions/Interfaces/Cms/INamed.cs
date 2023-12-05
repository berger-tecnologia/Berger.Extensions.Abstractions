namespace Berger.Extensions.Abstractions
{
    public interface INamed : IBaseEntity<Guid>
    {
        string Name { get; set; }
    }
}