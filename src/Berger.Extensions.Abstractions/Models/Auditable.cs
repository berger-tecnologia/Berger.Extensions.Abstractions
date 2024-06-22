namespace Berger.Extensions.Abstractions
{
    public class Auditable : IAuditable
    {
        #region Properties
        public Guid? ModifiedBy { get; set; }
        public bool Deleted { get; set; } = false;
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        #endregion

        #region Methods
        public void Delete()
        {
            this.Deleted = true;
        }
        public void SetModified()
        {
            this.ModifiedOn = DateTime.UtcNow;
        }
        public void SetDeleted()
        {
            this.ModifiedOn = DateTime.UtcNow;
        }
        #endregion
    }
}