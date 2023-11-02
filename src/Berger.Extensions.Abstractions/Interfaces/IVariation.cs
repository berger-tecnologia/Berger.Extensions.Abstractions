namespace Berger.Extensions.Abstractions
{
    public interface IVariation
    {
        string Key { get; }
        string Path { get; }
        string? Value { get; set; }
    }
}