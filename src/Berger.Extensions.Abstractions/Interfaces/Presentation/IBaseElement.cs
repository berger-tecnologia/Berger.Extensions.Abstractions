namespace Berger.Extensions.Abstractions
{
    public interface IBaseElement<T> where T : Enum
    {
        #region Properties
        T ElementType { get; set; }
        string Href { get; set; }
        string Class { get; set; }
        string Style { get; set; }
        string Target { get; set; }
        #endregion

        #region Methods
        void SetType(T type);
        void SetHref(string link);
        void SetClass(string classValue);
        #endregion
    }
}