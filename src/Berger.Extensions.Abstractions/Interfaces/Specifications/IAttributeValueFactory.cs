namespace Berger.Extensions.Abstractions
{
    public interface IAttributeValueFactory
    {
        IAttributeValue Create(Guid id, string name, string description);
    }
}