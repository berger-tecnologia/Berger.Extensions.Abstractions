namespace Berger.Extensions.Abstractions
{
    public interface IUserOwned : IBaseEntity<Guid>
    {
        #region Properties
        public Guid UserId { get; set; }
        #endregion
    }
}