namespace Berger.Extensions.Abstractions
{
    public interface IEntity<T>
    {
        T ID { get; set;  }
    }
}