namespace Berger.Extensions.Abstractions
{
    public interface IFileFactory
    {
        IFile Create(Guid id, string url, bool featured = false);
    }
}