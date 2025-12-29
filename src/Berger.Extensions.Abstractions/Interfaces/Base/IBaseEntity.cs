namespace Berger.Extensions.Abstractions
{
    public interface IBaseEntity<T> : IAuditable
    {
        #region Properties
        T Id { get; set; }
        #endregion

        #region Methods
        void SetId(T Id);
        #endregion
    }
}