namespace Berger.Extensions.Abstractions
{
    public class Auditable : IAuditable
    {
        #region Properties
        public bool Deleted { get; set; } = false;
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        #endregion

        #region Methods
        public void Delete()
        {
            this.Deleted = true;

            DeletedOn = DateTime.UtcNow;
        }

        public void Update()
        {
            this.UpdatedOn = DateTime.UtcNow;
        }
        #endregion
    }
}