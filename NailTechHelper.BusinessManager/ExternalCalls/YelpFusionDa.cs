using NailTechhelper.BusinessManager;
using NailTechHelper.BusinessManager.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NailTechHelper.BusinessManager.ExternalCalls
{
    public class YelpFusionDa
    {
        private string _domain = "https://api.yelp.com/v3/businesses";

        private string _searchEndpoint = "/search";

        static HttpClient client = new HttpClient();

        private string ApiKey = "hOrZWx8WP3VFJo2I2MUIr0hFI8zgS_h1ib1dQakz_SvpNrmlx4AWiYJhe3tTh43NAMG9P16_9gxzS88z8hryzP2fprh_fD17LfLIMhOrf33UPqHyllkh9urGjJhhXXYx";

        public async Task<BeautySalonBusinessCollection> GetBusinessesInfoFromYelpAsync(string searchTerm, string location, int limit)
        {
            var url = _domain + _searchEndpoint;


            var searchQuery = $@"?term={searchTerm}&location={location}&limit={limit}";

            var uri = url + searchQuery;

            client.DefaultRequestHeaders.Authorization =
                     new AuthenticationHeaderValue("Bearer", ApiKey);

            HttpResponseMessage response = await client.SendAsync(
               new HttpRequestMessage(HttpMethod.Get, uri));

            response.EnsureSuccessStatusCode();

            var resultContent = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<BeautySalonBusinessCollection>(resultContent);
            var json = JsonConvert.SerializeObject(new BeautySalonBusinessCollection { 
            BeautySalonBusinesses = new System.Collections.Generic.List<BeautySalonBusiness> { new BeautySalonBusiness { } },
            Region = new Region { Coordinate = new Coordinate { } }
            });

            return result;
        }
    }
}
