namespace Berger.Extensions.Abstractions
{
    public interface ISlug
    {
        #region Properties
        public string Name { get; set; }
        public string Slug { get; set; }
        #endregion
    }
}