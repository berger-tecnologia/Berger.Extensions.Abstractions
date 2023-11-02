namespace Berger.Extensions.Abstractions
{
    public interface IAsset
    {
        public Guid ContainerID { get; set; }
        string Name { get; set; }
        public void SetName(string name);
    }
}