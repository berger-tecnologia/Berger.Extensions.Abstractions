namespace Berger.Extensions.Abstractions
{
    public interface IApplication
    {
        string Code { get; set; }
        string Name { get; set; }
        string Icon { get; set; }
        string Description { get; set; }
    }
}