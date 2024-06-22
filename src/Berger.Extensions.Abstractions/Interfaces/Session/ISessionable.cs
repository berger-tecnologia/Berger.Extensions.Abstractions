namespace Berger.Extensions.Abstractions
{
    public interface ISessionable
    {
        #region Properties
        public Guid? SessionId { get; }
        #endregion

        #region Methods
        public void SetSessionId(Guid Id);
        #endregion
    }
}