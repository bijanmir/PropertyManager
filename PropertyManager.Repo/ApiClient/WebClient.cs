using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using PropertyManager.Repo.Interface;

namespace PropertyManager.Repo.ApiClient
{
    public class WebClient : IWebClient
    {

        private readonly string _baseUrl;
        private readonly HttpClient _httpClient;

        public WebClient(string baseUrl, HttpClient httpClient)
        {
            _baseUrl = baseUrl;
            _httpClient = httpClient;
            
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        
        public async Task<T> InvokeGetAsync<T>(string uri)
        {
            return await _httpClient.GetFromJsonAsync<T>(GetUrl(uri));
        }

        public async Task<T> InvokePostAsync<T>(string uri, T obj)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(GetUrl(uri), obj);
            await HandleError(response);
            
            return await response.Content.ReadFromJsonAsync<T>();
        }

        public async Task InvokePutAsync<T>(string uri, T obj)
        {
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync(GetUrl(uri), obj);
            await HandleError(response);
        }

        public async Task InvokeDeleteAsync(string uri)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync(GetUrl(uri));
            await HandleError(response);
        }

        private string GetUrl(string uri)
        {
            return $"{_baseUrl}/{uri}";
        }

        private static async Task HandleError(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                string error = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException(error);
            }
        }
    }
}