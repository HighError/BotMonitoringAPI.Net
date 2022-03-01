using BotMonitorsAPI.Classes;
using RestSharp;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace BotMonitorsAPI
{
    public class BotMonitors
    {
        public static readonly string API_KEY = Environment.GetEnvironmentVariable("API-MONITOR");

        private static readonly string baseUrl = "https://api.uptimerobot.com/v2";
        private static readonly RestClient client = new RestClient(baseUrl);

        public static async Task<AccountResponse> GetAccountDetails()
        {
            var request = new RestRequest("getAccountDetails")
                .AddHeader("content-type", "application/x-www-form-urlencoded")
                .AddHeader("cache-control", "no-cache")
                .AddParameter("api_key", API_KEY)
                .AddParameter("format", "json");

            var response = await client.PostAsync(request);
            var content = JsonSerializer.Deserialize<AccountResponse>(response.Content);

            return content;
        }

        public static async Task<MonitorsResponse> GetMonitors()
        {
            var request = new RestRequest("getMonitors")
                .AddHeader("content-type", "application/x-www-form-urlencoded")
                .AddHeader("cache-control", "no-cache")
                .AddParameter("api_key", API_KEY)
                .AddParameter("format", "json");

            var response = await client.PostAsync(request);
            var content = JsonSerializer.Deserialize<MonitorsResponse>(response.Content);

            return content;
        }
    }
}
