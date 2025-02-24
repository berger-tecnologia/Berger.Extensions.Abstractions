namespace Berger.Extensions.Abstractions
{
    public interface IBaseEntityType : IBaseEntity<Guid>
    {
        #region Properties
        public Guid EntityTypeId { get; }
        #endregion

        #region Methods
        public void SetEntityTypeId(Guid id);
        #endregion
    }
}