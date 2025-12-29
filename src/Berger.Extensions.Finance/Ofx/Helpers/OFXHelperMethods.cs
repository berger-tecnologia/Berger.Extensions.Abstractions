using System;
using System.Xml;

namespace Berger.Extensions.Finance.Ofx
{
   public static class OFXHelperMethods
   {
      public static BankAccountType GetBankAccountType(this string bankAccountType)
      {
          try
          {
              return (BankAccountType)Enum.Parse(typeof(BankAccountType), bankAccountType, true);
          }
          catch (Exception)
          {

              return BankAccountType.NA;
          }  
      }

      public static DateTime ToDate(this string date)
      {
         try
         {
            if (date.Length < 8)
            {
               return new DateTime();
            }

            var dd = Int32.Parse(date.Substring(6, 2));
            var mm = Int32.Parse(date.Substring(4, 2));
            var yyyy = Int32.Parse(date.Substring(0, 4));

            return new DateTime(yyyy, mm, dd);
         }
         catch
         {
            throw new OFXParseException("Unable to parse date");
         }
      }
      public static string GetValue(this XmlNode node, string xpath)
      {
         var tempNode = node.SelectSingleNode(xpath);

         if (tempNode != null && tempNode.FirstChild != null)
         {
             return tempNode.FirstChild.Value;
         }

         return String.Empty;
      }
   }
}