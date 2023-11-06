namespace Berger.Extensions.Abstractions
{
    public class BaseEntity : Auditable, IBaseEntity<Guid>
    {
        #region Properties
        public Guid ID { get; set; }
        #endregion

        #region Methods
        public void SetId(Guid id)
        {
            this.ID = id;
        }
        #endregion
    }
}