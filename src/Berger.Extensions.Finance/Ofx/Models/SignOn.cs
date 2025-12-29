using System;
using System.Xml;
using Berger.Extensions.Abstractions;
using Berger.Extensions.Finance.Ofx.Constants;

namespace Berger.Extensions.Finance.Ofx
{
    public class SignOn : BaseEntity
    {
        public SignOn()
        {
            this.SetId();
        }
        public string StatusSeverity { get; set; }
        public DateTime DTServer { get; set; }
        public int StatusCode { get; set; }
        public string Language { get; set; }
        public string IntuBid { get; set; }
        public SignOn(XmlNode node)
        {
            this.SetId();

            StatusCode = Convert.ToInt32(node.GetValue(StatusPath.Code));
            StatusSeverity = node.GetValue(StatusPath.Severity);
            DTServer = node.GetValue(StatusPath.DtServer).ToDate();
            Language = node.GetValue(StatusPath.Language);
            IntuBid = node.GetValue(BankPath.IntuBid);
        }
    }
}