namespace Berger.Extensions.Abstractions
{
    public class BaseEntity : Auditable, IBaseEntity<Guid>
    {
        #region Properties
        public Guid Id { get; set; }
        #endregion

        #region Methods
        public void SetId(Guid id)
        {
            this.Id = id;
        }
        public void SetId()
        {
            this.Id = Guid.Parse("xxx");
        }
        #endregion
    }
}