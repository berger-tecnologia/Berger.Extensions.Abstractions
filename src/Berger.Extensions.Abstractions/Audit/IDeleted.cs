namespace Berger.Extensions.Abstractions
{
    public interface IDeleted
    {
        bool Deleted { get; set; }
        DateTime? DeletedOn { get; set; }
    }
}