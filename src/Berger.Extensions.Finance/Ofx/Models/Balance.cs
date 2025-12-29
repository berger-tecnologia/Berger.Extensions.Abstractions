using System.Xml;
using System.Globalization;
using Berger.Extensions.Abstractions;
using Berger.Extensions.Finance.Ofx.Constants;

namespace Berger.Extensions.Finance.Ofx
{
    public class Balance : BaseEntity
    {
        public Balance()
        {
            this.SetId();
        }
        public decimal LedgerBalance { get; set; }
        public DateTime LedgerBalanceDate { get; set; }
        public decimal AvaliableBalance { get; set; }
        public DateTime AvaliableBalanceDate { get; set; }
        public Balance(XmlNode ledgerNode, XmlNode avaliableNode)
        {
            this.SetId();

            var tempLedgerBalance = ledgerNode.GetValue(BalancePath.BalanceAmount);

            if (!String.IsNullOrEmpty(tempLedgerBalance))
            {
                LedgerBalance = Convert.ToDecimal(tempLedgerBalance, CultureInfo.InvariantCulture);
            }
            else
            {
                throw new OFXParseException("Ledger balance has not been set");
            }

            if (avaliableNode == null)
            {
                AvaliableBalance = 0;

                AvaliableBalanceDate = new DateTime();
            }
            else
            {
                var tempAvaliableBalance = avaliableNode.GetValue(BalancePath.BalanceAmount);

                if (!String.IsNullOrEmpty(tempAvaliableBalance))
                {
                    AvaliableBalance = Convert.ToDecimal(tempAvaliableBalance, CultureInfo.InvariantCulture);
                }
                else
                {
                    throw new OFXParseException("Avaliable balance has not been set");
                }
                AvaliableBalanceDate = avaliableNode.GetValue(BalancePath.DateAsOf).ToDate();
            }

            LedgerBalanceDate = ledgerNode.GetValue(BalancePath.DateAsOf).ToDate();
        }
    }
}