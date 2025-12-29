namespace Berger.Extensions.Abstractions
{
    public interface IAddressed
    {
        #region Properties
        List<IAddress> Addresses { get; set; }
        #endregion
    }
}