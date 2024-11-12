namespace Berger.Extensions.Abstractions
{
    public interface IContext
    {
        Guid ApplicationId { get; }
        void SetApplication(Guid applicationId);
    }
    public interface IEntityContext
    {
        Guid EntityTypeId { get; }
        Guid? EntityID { get; }
        void SetEntityType(Guid entityTypeId, Guid? entityID);
    }
}