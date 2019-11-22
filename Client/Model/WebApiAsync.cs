namespace Client.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    using Client.Model;

    using Newtonsoft.Json;

    public class WebAPIAsync<T> : IWebAPIAsync<T> where T : class
        {


            #region Instance fields
            private string _serverURL;
            private string _apiPrefix;
            private string _apiID;
            private HttpClientHandler _httpClientHandler;
            private HttpClient _httpClient;
            private string _url;
            #endregion

            #region Constructor
            public WebAPIAsync(string serverURL, string apiPrefix, string apiID)
            {
                _serverURL = serverURL;
                _apiID = apiID;
                _apiPrefix = apiPrefix;
                _httpClientHandler = new HttpClientHandler();
                _httpClientHandler.UseDefaultCredentials = true;
                _httpClient = new HttpClient(_httpClientHandler);
                _httpClient.BaseAddress = new Uri(_serverURL);
                _url = serverURL + "/" + _apiPrefix + "/" + apiID;
            }


            public async Task Create(int key, T obj)
            {
                string UrlNew = _url + "/" + key;
                string Serialized = JsonConvert.SerializeObject(obj);
                StringContent SC = new StringContent(Serialized, Encoding.UTF8, "application/json");
                HttpResponseMessage Response = _httpClient.PostAsync(_url, SC).Result;

                Response.EnsureSuccessStatusCode();

                HttpResponseMessage response = await _httpClient.PostAsJsonAsync(
                    UrlNew, SC);
                response.EnsureSuccessStatusCode();

            }


            #endregion



            public async Task Delete(int key)
            {
                string UrlNew = _url + "/" + key;

                HttpResponseMessage Response = _httpClient.DeleteAsync(UrlNew).Result;
                Response.EnsureSuccessStatusCode();

            }

            public async Task<List<T>> Load()
            {
                List<T> product = null;
                HttpResponseMessage response = await _httpClient.GetAsync(_url);
                if (response.IsSuccessStatusCode)
                {
                    product = await response.Content.ReadAsAsync<List<T>>();
                    return product;
            }

                return null;

            }

            public async Task<T> Read(int key)
            {
                string UrlNew = _url + "/" + key;
                T product = null;
                HttpResponseMessage response = await _httpClient.GetAsync(UrlNew);
                if (response.IsSuccessStatusCode)
                {
                    product = await response.Content.ReadAsAsync<T>();
                }
                return product;
            }

            public async Task Update(int key, T obj)
            {

                string UrlNew = _url + "/" + key;
                T product = null;
                HttpResponseMessage response = await _httpClient.PutAsJsonAsync(
                    UrlNew, obj);
                response.EnsureSuccessStatusCode();

                // Deserialize the updated product from the response body.
                product = await response.Content.ReadAsAsync<T>();

            }

        }
    

}
