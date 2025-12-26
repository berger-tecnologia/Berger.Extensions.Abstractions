using System;
using System.Xml;
using Berger.Extensions.Abstractions;

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

            StatusCode = Convert.ToInt32(node.GetValue("//CODE"));
            StatusSeverity = node.GetValue("//SEVERITY");
            DTServer = node.GetValue("//DTSERVER").ToDate();
            Language = node.GetValue("//LANGUAGE");
            IntuBid = node.GetValue("//INTU.BID");
        }
    }
}