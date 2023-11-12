namespace Berger.Extensions.Abstractions
{
    public interface IMedia
    {
        #region Properties
        string Url { get; set; }
        string Alt { get; set; }
        bool Featured { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}