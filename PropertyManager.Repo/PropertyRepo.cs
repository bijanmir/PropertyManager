using System.Collections.Generic;
using System.Threading.Tasks;
using PropertyManager.DataModel.Model;
using PropertyManager.Repo.ApiClient;

namespace PropertyManager.Repo
{
    public class PropertyRepo
    {
        private readonly IWebClient _webClient;

        public PropertyRepo(IWebClient webClient)
        {
            _webClient = webClient;
        }

        public async Task<IEnumerable<Property>> GetAsync()
        {
            return await _webClient.InvokeGetAsync<IEnumerable<Property>>("api/prop");
        }

        public async Task<Property> GetByIdAsync(int id)
        {
            return await _webClient.InvokeGetAsync<Property>($"api/prop/{id}");
        }

        public async Task<int> CreateAsync(Property prop)
        {
            prop = await _webClient.InvokePostAsync("api/prop", prop);
            return prop.PropId;
        }

        public async Task UpdateAsync(Property prop)
        {
            await _webClient.InvokePutAsync($"api/prop/{prop.PropId}", prop);
        }

        public async Task DeleteAsync(int id)
        {
            await _webClient.InvokeDeleteAsync($"api/prop/{id}");
        }
    }
}