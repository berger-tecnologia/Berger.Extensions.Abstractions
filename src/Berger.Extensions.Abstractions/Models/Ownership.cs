namespace Berger.Extensions.Abstractions
{
    public class Ownership : Auditable
    {
        public Guid? UserID { get; set; }
        public Guid? OwnerID { get; set; }
        public Guid? SenderID { get; set; }
        public Guid? ReceiverID { get; set; }
    }
}