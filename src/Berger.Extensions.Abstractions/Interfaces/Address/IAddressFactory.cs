namespace Berger.Extensions.Abstractions
{
    public interface IAddressFactory
    {
        IAddress Create(Guid id, string street, string number, string postcode);
    }
}