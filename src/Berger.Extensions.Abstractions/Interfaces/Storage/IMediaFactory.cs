namespace Berger.Extensions.Abstractions
{
    public interface IMediaFactory
    {
        IMedia Create(Guid id, string url, bool featured = false);
    }
}