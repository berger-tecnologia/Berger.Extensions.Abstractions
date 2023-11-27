namespace Berger.Extensions.Abstractions
{
    public class Auditable : IAuditable
    {
        #region Properties
        public bool Deleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
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