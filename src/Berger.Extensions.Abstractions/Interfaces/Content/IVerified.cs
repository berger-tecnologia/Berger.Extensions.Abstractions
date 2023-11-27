namespace Berger.Extensions.Abstractions
{
    public interface IVerified
    {
        public bool Verified { get; }
        public DateTime? VerifiedOn { get; }
    }
}