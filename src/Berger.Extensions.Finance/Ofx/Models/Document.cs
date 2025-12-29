using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Finance.Ofx
{
    public class Document : BaseEntity
    {
        public Document()
        {
            this.SetId();
        }
        public DateTime StatementStart { get; set; }
        public DateTime StatementEnd { get; set; }
        public AccountType AccType { get; set; }
        public string Currency { get; set; }
        public SignOn SignOn { get; set; }
        public Guid AccountId { get; set; }
        public Account Account { get; set; }
        public Guid BalanceId { get; set; }
        public Balance Balance { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}