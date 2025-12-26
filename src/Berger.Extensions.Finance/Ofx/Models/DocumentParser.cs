using System.Xml;
using System.Text;

namespace Berger.Extensions.Finance.Ofx
{
    public class DocumentParser
   {
      public Document Import(FileStream stream)
      {
         using (var reader = new StreamReader(stream, Encoding.Default))
         {
            return Import(reader.ReadToEnd());
         }
      }
      public Document Import(string ofx)
      {
         return ParseDocument(ofx);
      }
      private Document ParseDocument(string ofxString)
      {
         if (!IsXmlVersion(ofxString))
         {
            //ofxString = SGMLToXML(ofxString);
         }

         return Parse(ofxString);
      }

      private Document Parse(string ofxString)
      {
         var ofx = new Document {AccType = GetAccountType(ofxString)};

         var doc = new XmlDocument();

         doc.Load(new StringReader(ofxString));

         var currencyNode = doc.SelectSingleNode(GetXPath(ofx.AccType, OFXSection.CURRENCY));

         if (currencyNode != null)
         {
            ofx.Currency = currencyNode.FirstChild.Value;
         }
         else
         {
            throw new OFXParseException("Currency not found");
         }

         var signOnNode = doc.SelectSingleNode(Dados.SignOn);

         if (signOnNode != null)
         {
            ofx.SignOn = new SignOn(signOnNode);
         }
         else
         {
            throw new OFXParseException("Sign On information not found");
         }

         var accountNode = doc.SelectSingleNode(GetXPath(ofx.AccType, OFXSection.ACCOUNTINFO));

         if (accountNode != null)
         {
            ofx.Account = new Account(accountNode, ofx.AccType);
         }
         else
         {
            throw new OFXParseException("Account information not found");
         }

         ImportTransations(ofx, doc);

         var ledgerNode = doc.SelectSingleNode(GetXPath(ofx.AccType, OFXSection.BALANCE) + "/LEDGERBAL");
         var avaliableNode = doc.SelectSingleNode(GetXPath(ofx.AccType, OFXSection.BALANCE) + "/AVAILBAL");

         if (ledgerNode != null) // && avaliableNode != null
         {
            ofx.Balance = new Balance(ledgerNode, avaliableNode);
         }
         else
         {
            throw new OFXParseException("Balance information not found");
         }

         return ofx;
      }

      private string GetXPath(AccountType type, OFXSection section)
      {
         string xpath, accountInfo;

         switch (type)
         {
            case AccountType.BANK:
               xpath = Dados.BankAccount;
               accountInfo = "/BANKACCTFROM";
               break;
            case AccountType.CC:
               xpath = Dados.CCAccount;
               accountInfo = "/CCACCTFROM";
               break;
            default:
               throw new OFXException("Account Type not supported. Account type " + type);
         }

         switch (section)
         {
            case OFXSection.ACCOUNTINFO:
               return xpath + accountInfo;
            case OFXSection.BALANCE:
               return xpath;
            case OFXSection.TRANSACTIONS:
               return xpath + "/BANKTRANLIST";
            case OFXSection.SIGNON:
               return Dados.SignOn;
            case OFXSection.CURRENCY:
               return xpath + "/CURDEF";
            default:
               throw new OFXException("Unknown section found when retrieving XPath. Section " + section);
         }
      }

      private void ImportTransations(Document Document, XmlDocument doc)
      {
         var xpath = GetXPath(Document.AccType, OFXSection.TRANSACTIONS);

         Document.StatementStart = doc.GetValue(xpath + "//DTSTART").ToDate();
         Document.StatementEnd = doc.GetValue(xpath + "//DTEND").ToDate();

         var transactionNodes = doc.SelectNodes(xpath + "//STMTTRN");

         Document.Transactions = new List<Transaction>();

         foreach (XmlNode node in transactionNodes)
            Document.Transactions.Add(new Transaction(node, Document.Currency));
      }
      private AccountType GetAccountType(string file)
      {
         if (file.IndexOf("<CREDITCARDMSGSRSV1>") != -1)
            return AccountType.CC;

         if (file.IndexOf("<BANKMSGSRSV1>") != -1)
            return AccountType.BANK;

         throw new OFXException("Unsupported Account Type");
      }

      private bool IsXmlVersion(string file)
      {
         return (file.IndexOf("OFXHEADER:100") == -1);
      }

      private string ParseHeader(string file)
      {
         var header = file.Substring(0, file.IndexOf('<'))
            .Split(new[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);

         CheckHeader(header);

         //Remove header
         return file.Substring(file.IndexOf('<')).Trim();
      }
      private void CheckHeader(string[] header)
      {
		if (header[0] == "OFXHEADER:100DATA:OFXSGMLVERSION:102SECURITY:NONEENCODING:USASCIICHARSET:1252COMPRESSION:NONEOLDFILEUID:NONENEWFILEUID:NONE")//non delimited header
			return;
         if (header[0] != "OFXHEADER:100")
            throw new OFXParseException("Incorrect header format");

         if (header[1] != "DATA:OFXSGML")
            throw new OFXParseException("Data type unsupported: " + header[1] + ". OFXSGML required");

         if (header[2] != "VERSION:102")
            throw new OFXParseException("OFX version unsupported. " + header[2]);

         if (header[3] != "SECURITY:NONE")
            throw new OFXParseException("OFX security unsupported");

         if (header[4] != "ENCODING:USASCII")
            throw new OFXParseException("ASCII Format unsupported:" + header[4]);

         if (header[5] != "CHARSET:1252")
            throw new OFXParseException("Charecter set unsupported:" + header[5]);

         if (header[6] != "COMPRESSION:NONE")
            throw new OFXParseException("Compression unsupported");

         if (header[7] != "OLDFILEUID:NONE")
            throw new OFXParseException("OLDFILEUID incorrect");
      }

      #region Nested type: OFXSection
      private enum OFXSection
      {
         SIGNON,
         ACCOUNTINFO,
         TRANSACTIONS,
         BALANCE,
         CURRENCY
      }

      #endregion
   }
}