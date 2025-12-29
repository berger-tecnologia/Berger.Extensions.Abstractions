namespace Berger.Extensions.Finance.Constants
{
    internal static class Header
    {
        internal const string NonDelimitedHeader =
            "OFXHEADER:100DATA:OFXSGMLVERSION:102SECURITY:NONEENCODING:USASCIICHARSET:1252COMPRESSION:NONEOLDFILEUID:NONENEWFILEUID:NONE";

        internal const string HeaderPrefix = "OFXHEADER:100";

        internal const string DataType = "DATA:OFXSGML";
        internal const string Version = "VERSION:102";
        internal const string Security = "SECURITY:NONE";
        internal const string Encoding = "ENCODING:USASCII";
        internal const string Charset = "CHARSET:1252";
        internal const string Compression = "COMPRESSION:NONE";
        internal const string OldFileUid = "OLDFILEUID:NONE";
    }
}