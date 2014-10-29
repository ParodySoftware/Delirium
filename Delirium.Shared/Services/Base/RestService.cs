using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Delirium.Shared.Services.Base
{
    public abstract class RestService
    {
        public RestService(string baseAddress)
        {
            this.BaseAddress = baseAddress;         
        }

        private string BaseAddress { get; set; }

        protected async Task<T> GetAsAsync<T>(string requetUri)
        {
            T ret = default(T);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.BaseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(requetUri);

                if (response.IsSuccessStatusCode)
                {
                    ret = await response.Content.ReadAsAsync<T>();
                }
            }

            return ret;
        }
    }
}
