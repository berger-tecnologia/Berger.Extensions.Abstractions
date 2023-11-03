namespace Berger.Extensions.Abstractions
{
    public interface INotificationMessage : IEntity<Guid>
    {
        string Name { get; set; }
        string Title { get; set; }
        string Property { get; set; }
        string Value { get; set; }
        string Message { get; set; }
        string Code { get; set; }
        int Status { get; set; }
        DateTime Created { get; set; }
        DateTime? Updated { get; set; }
        bool Deleted { get; set; }
    }
}