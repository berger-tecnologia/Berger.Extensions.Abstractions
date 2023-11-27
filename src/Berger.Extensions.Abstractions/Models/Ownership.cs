namespace Berger.Extensions.Abstractions
{
    public class Ownership : Auditable
    {
        public Guid UserId { get; set; }
        public Guid? OwnerId { get; set; }
        public Guid? SenderId { get; set; }
        public Guid? DriverId { get; set; }
        public Guid? ReceiverId { get; set; }
    }
}