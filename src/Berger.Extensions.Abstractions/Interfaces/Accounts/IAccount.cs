namespace Berger.Extensions.Abstractions
{
    public interface IAccount
    {
        public void Logoff();
        public string Signin(string user, string password);
    }
}