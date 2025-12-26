namespace Berger.Extensions.Finance.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parser = new OFXDocumentParser();

            var file = @"NU_3774151682_01OUT2024_22DEZ2024.ofx";

            var ofx = parser.Import(new FileStream(file, FileMode.Open));
        }
    }
}