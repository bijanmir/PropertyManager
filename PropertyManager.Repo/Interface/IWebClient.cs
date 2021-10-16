using System.Threading.Tasks;

namespace PropertyManager.Repo.Interface
{
    public interface IWebClient
    {
        public Task<T> InvokeGetAsync<T>(string uri);
        public Task<T> InvokePostAsync<T>(string uri, T obj);
        public Task InvokePutAsync<T>(string uri, T obj);
        public Task InvokeDeleteAsync(string uri);
    }
}