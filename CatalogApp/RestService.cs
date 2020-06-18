using System;
using System.Text;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using Xamarin.Essentials;

namespace CatalogApp
{
    public class RestService
    {
        HttpClient _client;

        public RestService()
        {
            _client = new HttpClient();

            string authInfo = "ck_2682b35c4d9a8b6b6effac126ac552e0bfb315a0" + ":" + "cs_cab8c9a729dfb49c50ce801a9ea41b577c00ad71";
            var byteArray = Encoding.ASCII.GetBytes(authInfo);
            _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        }

        public async Task<List<CatalogData>> GetJson(string uri)
        {
            var catalogData = new List<CatalogData>();

            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                Console.WriteLine(response);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(content);

                    Preferences.Set("data", content);

                    catalogData = JsonConvert.DeserializeObject<List<CatalogData>>(content);

                    Console.WriteLine(catalogData);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }

            return catalogData;
        }
    }
}
