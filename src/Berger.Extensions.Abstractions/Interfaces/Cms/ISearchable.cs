namespace Berger.Extensions.Abstractions
{
    public interface ISearchable : IBaseEntity<Guid>
    {
        string Name { get; set; }
    }
}