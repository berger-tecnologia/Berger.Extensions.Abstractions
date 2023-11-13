namespace Berger.Extensions.Abstractions
{
    public class BaseEntity : Ownership, IBaseEntity<Guid>
    {
        #region Properties
        public Guid Id { get; set; }
        #endregion

        #region Methods
        public void SetId(Guid id)
        {
            this.Id = id;
        }
        #endregion
    }
}