namespace Berger.Extensions.Abstractions
{
    public interface IMetadata
    {
        string Key { get; set; }
        Dictionary<string, string> Values { get; set; }
    }
}