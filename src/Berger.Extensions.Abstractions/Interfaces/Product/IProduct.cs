namespace Berger.Extensions.Abstractions
{
    public interface IProduct
    {
        #region Properties
        bool Highlighted { get; set; }
        #endregion

        #region Methods
        void SetMedia(Guid id, string url, bool featured = false);
        void SetCategory(Guid categoryId, string name);
        //void SetReview(Guid productId, int score);
        void Highlight();
        #endregion
    }
}