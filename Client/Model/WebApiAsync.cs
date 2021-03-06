﻿using System.Net.Http.Headers;

namespace Client.Model
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;

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


            //det er vores handler, til at sende og modtage request fra serveren. Det er hvad vores databseAPi bygget ud fra.
            //disse metoder skal sikrer at alle de funktioner vi køre i mod vores databaseapi at de er korrekt opsat.
            
        #endregion
        public async Task Create(int key, T obj)
            {
            // Json . NET er et tredjepartsbibliotek, der hjælper med konvertering mellem JSON- tekst og. NET- objekt bruger JsonSerializer.
            // JsonSerializer konverterer. NET objekter i deres JSON- ækvivalente tekst og
            // tilbage igen ved at kortlægge. NET- objekt-ejendomsnavne til JSON- ejendomsnavne. 
            string UrlNew = _url + "/" + key;
                string Serialized = JsonConvert.SerializeObject(obj);
                StringContent SC = new StringContent(Serialized, Encoding.UTF8, "application/json");
                HttpResponseMessage Response = _httpClient.PostAsync(_url, SC).Result;

                Response.EnsureSuccessStatusCode();

                HttpResponseMessage response = await _httpClient.PostAsJsonAsync(
                    UrlNew, SC);
                response.EnsureSuccessStatusCode();

            }


            



            public async Task Delete(int key)
            {
                string UrlNew = _url + "/" + key;

                HttpResponseMessage Response = _httpClient.DeleteAsync(UrlNew).Result;
                Response.EnsureSuccessStatusCode();

            }

            public async Task<List<T>> Load()
            {
                string UrlNew = _serverURL + "/"+ _apiPrefix + "/" + _apiID;
                List<T> product = null;
                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = _httpClient.GetAsync(UrlNew).Result;
                if (response.IsSuccessStatusCode)
                {
                    product = await response.Content.ReadAsAsync<List<T>>();
                    return product;
            }

                return null;

            }

            public async Task<T> Read(int key)
            {
            string UrlNew = _serverURL +"/"+ _apiPrefix + "/" + _apiID +"/" + key;
            T product = null;
                HttpResponseMessage response = _httpClient.GetAsync(UrlNew).Result;
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
