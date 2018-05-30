using LuisDelValle.WinningSolution.Abstractions;
using LuisDelValle.WinningSolution.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LuisDelValle.WinningSolution.WebApp.Services
{
    public class RestClient : IRestClient<IEnumerable<Item>>
    {
        public string Host { get; set; }
        public string Path { get; set; }

        private static HttpClient Client = new HttpClient();

        public async Task<IEnumerable<Item>> GetResponseAsync()
        {
            var stringItems = await Client.GetStringAsync(Host + Path);

            if (stringItems != null)
            {
                var items = JsonConvert.DeserializeObject<IEnumerable<Item>>(stringItems);

                if (items != null)
                {
                    return items;
                }
            }

            return null;
        }
    }
}
