namespace Berger.Extensions.Abstractions
{
    public interface IContainer
    {
        string Url { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        bool Visibility { get; set; }
    }
}