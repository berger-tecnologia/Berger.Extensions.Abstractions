namespace Berger.Extensions.Abstractions
{
    public interface ICancelled
    {
        public bool Cancelled { get; }
        public DateTime? CancelledOn { get; }
    }
}