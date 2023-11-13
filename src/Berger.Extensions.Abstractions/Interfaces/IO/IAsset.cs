namespace Berger.Extensions.Abstractions
{
    public interface IAsset<T> where T : IFileExtension
    {
        #region Properties
        Guid ContainerID { get; set; }
        IContainer Container { get; set; }
        T FileExtension { get; set; }
        string AttributeId { get; set; }
        string Name { get; set; }
        string Path { get; set; }
        #endregion

        #region Methods
        public void SetName(string name);
        #endregion
    }
}