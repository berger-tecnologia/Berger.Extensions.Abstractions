namespace Berger.Extensions.Abstractions
{
    public interface INationality
    {
        #region Properties
        string Name { get; set; }
        #endregion

        #region Methods
        string GetNationality();
        #endregion
    }
}