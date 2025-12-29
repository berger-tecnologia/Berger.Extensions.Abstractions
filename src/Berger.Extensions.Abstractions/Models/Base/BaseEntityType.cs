namespace Berger.Extensions.Abstractions
{
    public class BaseEntityType : BaseEntity, IBaseEntityType
    {
        #region Properties
        public Guid EntityTypeId { get; set; }
        #endregion

        #region Methods
        public void SetEntityTypeId(Guid id)
        {
            this.EntityTypeId = id;
        }
        #endregion
    }
}