namespace Berger.Extensions.Abstractions
{
    public class BaseEntityWrapper : IBaseEntity
    {
        #region Interfaces
        private readonly IBaseEntity BaseEntity;
        #endregion

        #region Properties
        public Guid ID
        {
            get => BaseEntity.ID;
            set => BaseEntity.ID = value;
        }
        public bool Deleted
        {
            get => BaseEntity.Deleted;
            set => BaseEntity.Deleted = value;
        }
        public DateTime? DeletedOn
        {
            get => BaseEntity.DeletedOn;
            set => BaseEntity.DeletedOn = value;
        }
        public DateTime? ModifiedOn
        {
            get => BaseEntity.ModifiedOn;
            set => BaseEntity.ModifiedOn = value;
        }
        public DateTime CreatedOn
        {
            get => BaseEntity.CreatedOn;
            set => BaseEntity.CreatedOn = value;
        }
        #endregion

        #region Methods
        public void Delete()
        {
            BaseEntity.Delete();
        }
        #endregion
    }
}