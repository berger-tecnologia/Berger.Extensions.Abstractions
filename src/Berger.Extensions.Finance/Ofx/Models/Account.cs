using System.Xml;
using Berger.Extensions.Abstractions;
using Berger.Extensions.Finance.Ofx.Constants;

namespace Berger.Extensions.Finance.Ofx
{
    public class Account : BaseEntity
    {
        public Account()
        {
            this.SetId();
        }
        public string AccountIdentificador { get; set; }
        public string AccountKey { get; set; }
        public AccountType AccountType { get; set; }

        #region Bank Only

        private BankAccountType _BankAccountType = BankAccountType.NA;

        public string BankID { get; set; }

        public string BranchID { get; set; }


        public BankAccountType BankAccountType
        {
            get
            {
                if (AccountType == AccountType.BANK)
                    return _BankAccountType;

                return BankAccountType.NA;
            }
            set
            {
                _BankAccountType = AccountType == AccountType.BANK ? value : BankAccountType.NA;
            }
        }

        #endregion

        public Account(XmlNode node, AccountType type)
        {
            this.SetId();

            AccountType = type;

            AccountIdentificador = node.GetValue(AccountPath.AccountId);
            AccountKey = node.GetValue(AccountPath.AccountKey);

            switch (AccountType)
            {
                case AccountType.BANK:
                    InitializeBank(node);
                    break;
                case AccountType.AP:
                    InitializeAP(node);
                    break;
                case AccountType.AR:
                    InitializeAR(node);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Initializes information specific to bank
        /// </summary>
        private void InitializeBank(XmlNode node)
        {
            BankID = node.GetValue(BankPath.BankId);
            BranchID = node.GetValue(BankPath.BranchId);

            //Get Bank Account Type from XML
            string bankAccountType = node.GetValue(AccountPath.AccountType);

            //Check that it has been set
            if (String.IsNullOrEmpty(bankAccountType))
                throw new OFXParseException("Bank Account type unknown");

            //Set bank account enum
            _BankAccountType = bankAccountType.GetBankAccountType();
        }

        #region Account types not supported

        private void InitializeAP(XmlNode node)
        {
            throw new OFXParseException("AP Account type not supported");
        }
        private void InitializeAR(XmlNode node)
        {
            throw new OFXParseException("AR Account type not supported");
        }
        #endregion
    }
}