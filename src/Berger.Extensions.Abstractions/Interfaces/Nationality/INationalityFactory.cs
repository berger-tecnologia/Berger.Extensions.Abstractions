namespace Berger.Extensions.Abstractions
{
    public interface INationalityFactory
    {
        INationality Create(string name);
    }
}