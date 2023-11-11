namespace Berger.Extensions.Abstractions
{
    public interface IDeleted
    {
        #region Properties
        bool Deleted { get; set; }
        DateTime? DeletedOn { get; set; }
        #endregion

        #region Methods
        void Delete();
        #endregion
    }
}