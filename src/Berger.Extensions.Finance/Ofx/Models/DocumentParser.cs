using System.Xml;
using System.Text;
using Berger.Extensions.Finance.Constants;
using Berger.Extensions.Finance.Ofx.Constants;

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
            var ofx = new Document { AccType = GetAccountType(ofxString) };

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

            var ledgerNode = doc.SelectSingleNode(GetXPath(ofx.AccType, OFXSection.BALANCE) + DocumentPath.LedgerBalance);
            var avaliableNode = doc.SelectSingleNode(GetXPath(ofx.AccType, OFXSection.BALANCE) + DocumentPath.AvailableBalance);

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
                    accountInfo = DocumentPath.BankAccountFrom;
                    break;
                case AccountType.CC:
                    xpath = Dados.CCAccount;
                    accountInfo = DocumentPath.AccountFrom;
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
                    return xpath + DocumentPath.BankTransactionList;
                case OFXSection.SIGNON:
                    return Dados.SignOn;
                case OFXSection.CURRENCY:
                    return xpath + DocumentPath.CurrencyDefinition;
                default:
                    throw new OFXException("Unknown section found when retrieving XPath. Section " + section);
            }
        }

        private void ImportTransations(Document Document, XmlDocument doc)
        {
            var xpath = GetXPath(Document.AccType, OFXSection.TRANSACTIONS);

            Document.StatementStart = doc.GetValue(xpath + BalancePath.DateStart).ToDate();
            Document.StatementEnd = doc.GetValue(xpath + BalancePath.DateEnd).ToDate();

            var transactionNodes = doc.SelectNodes(xpath + TransactionPath.StatementTransaction);

            Document.Transactions = new List<Transaction>();

            foreach (XmlNode node in transactionNodes)
                Document.Transactions.Add(new Transaction(node, Document.Currency));
        }
        private AccountType GetAccountType(string file)
        {
            if (file.IndexOf(Tag.CreditCardMessage) != -1)
                return AccountType.CC;

            if (file.IndexOf(Tag.BankMessage) != -1)
                return AccountType.BANK;

            throw new OFXException(ErrorMessage.UnsupportedAccountType);
        }

        private bool IsXmlVersion(string file)
        {
            return (file.IndexOf(Header.HeaderPrefix) == -1);
        }

        private string ParseHeader(string file)
        {
            var header = file.Substring(0, file.IndexOf('<'))
               .Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            CheckHeader(header);

            //Remove header
            return file.Substring(file.IndexOf('<')).Trim();
        }
        private void CheckHeader(string[] header)
        {
            if (header[0] == Header.NonDelimitedHeader)
                return;

            if (header[0] != Header.HeaderPrefix)
                throw new OFXParseException(ErrorMessage.IncorrectHeaderFormat);

            if (header[1] != Header.DataType)
                throw new OFXParseException("Data type unsupported: " + header[1] + ". OFXSGML required");

            if (header[2] != Header.Version)
                throw new OFXParseException("OFX version unsupported. " + header[2]);

            if (header[3] != Header.Security)
                throw new OFXParseException(ErrorMessage.SecurityUnsupported);

            if (header[4] != Header.Encoding)
                throw new OFXParseException("ASCII Format unsupported:" + header[4]);

            if (header[5] != Header.Charset)
                throw new OFXParseException("Character set unsupported:" + header[5]);

            if (header[6] != Header.Compression)
                throw new OFXParseException(ErrorMessage.CompressionUnsupported);

            if (header[7] != Header.OldFileUid)
                throw new OFXParseException(ErrorMessage.OldFileUidIncorrect);
        }
    }
}