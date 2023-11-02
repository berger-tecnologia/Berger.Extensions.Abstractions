namespace Berger.Extensions.Abstractions
{
    public interface ISlug : IName
    {
        #region Properties
        public string Slug { get; }
        #endregion

        #region Methods
        public void SetSlug(string slug);
        #endregion
    }
}