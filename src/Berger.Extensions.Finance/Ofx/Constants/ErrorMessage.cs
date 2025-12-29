namespace Berger.Extensions.Finance.Constants
{
    internal static class ErrorMessage
    {
        internal const string UnsupportedAccountType = "Unsupported Account Type";
        internal const string IncorrectHeaderFormat = "Incorrect header format";

        internal const string DataTypeUnsupported = "Data type unsupported: {0}. OFXSGML required";
        internal const string VersionUnsupported = "OFX version unsupported. {0}";
        internal const string SecurityUnsupported = "OFX security unsupported";
        internal const string EncodingUnsupported = "ASCII Format unsupported: {0}";
        internal const string CharsetUnsupported = "Character set unsupported: {0}";
        internal const string CompressionUnsupported = "Compression unsupported";
        internal const string OldFileUidIncorrect = "OLDFILEUID incorrect";
    }
}
