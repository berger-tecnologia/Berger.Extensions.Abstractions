namespace Berger.Extensions.Abstractions
{
    public interface IParent<T>
    {
        public T Parent { get; }
        public Guid? ParentId { get; }
    }
}