namespace Berger.Extensions.Abstractions
{
    public interface IElementType<T>
    {
        T AssetType { get; set; }
    }
}