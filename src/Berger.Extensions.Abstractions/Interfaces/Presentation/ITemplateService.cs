namespace Berger.Extensions.Abstractions
{
    public interface ITemplateService
    {
        string Process(string template, List<KeyValuePair<string, string>> Data);
    }
}