namespace Berger.Extensions.Abstractions
{
    public interface IBaseEntity<T> : IAuditable
    {
        #region Properties
        T ID { get; set; }
        #endregion

        #region Methods
        void SetId(T id);
        #endregion
    }
}