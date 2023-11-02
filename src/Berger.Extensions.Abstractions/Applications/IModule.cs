namespace Berger.Extensions.Abstractions
{
    public interface IModule
    {
        string Name { get; set; }
        public void SetName(string name);
    }
}