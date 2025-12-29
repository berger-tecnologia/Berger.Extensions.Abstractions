using System.ComponentModel;

namespace Berger.Extensions.Finance.Ofx
{
    public enum AccountType
    {
        [Description("Bank Account")]
        BANK,

        [Description("Credit Card")]
        CC,

        [Description("Accounts Payable")]
        AP,

        [Description("Accounts Receivable")]
        AR,
        NA,
    }
}