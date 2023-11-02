namespace Berger.Extensions.Abstractions
{
    public interface ITenant
    {
        #region Properties
        Guid TenantID { get; set; }
        #endregion

        #region Methods
        void SetTenant(Guid id) => TenantID = id;
        #endregion
    }
}