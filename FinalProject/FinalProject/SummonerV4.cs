using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FinalProject
{
    public class SummonerV4
    {
        private static readonly Uri ApiBaseAddress;
        private RiotApi Api { get; }

        public SummonerV4(RiotApi api)
        {
            Api = api;
        }

        public Summoner GetSummonerByName(string summonerName)
        {
            var uriBuilder = new UriBuilder($"{ApiBaseAddress}/by-name/{summonerName}");
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["api_key"] = Api.ApiKey;
            uriBuilder.Query = query.ToString();
            string requestUri = uriBuilder.ToString();

            var response = Api.Client.GetAsync(requestUri).Result;

            if (response.IsSuccessStatusCode == false)
            {
                throw new Exception($"Request failed. Response: {response.StatusCode}");
            }

            string jsonResponse = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<Summoner>(jsonResponse);

        }

        public async Task<Summoner> GetSummonerByNameAsync(string summonerName)
    }
}
