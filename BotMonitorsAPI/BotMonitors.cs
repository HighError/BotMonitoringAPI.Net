using BotMonitorsAPI.Classes;
using BotMonitorsAPI.Configures;
using Newtonsoft.Json;
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
        private static readonly RestClient client = new(baseUrl);

        private static T DeserializeJson<T>(string json) => JsonConvert.DeserializeObject<T>(json);

        /// <summary>
        /// Account details (max number of monitors that can be added and number 
        /// of up/down/paused monitors) can be grabbed using this method. 
        /// </summary>
        /// <returns>Object BotMonitors.Classes.AccountResponse</returns>
        public static async Task<AccountResponse> GetAccountDetails()
        {
            var request = new RestRequest("getAccountDetails")
                .AddHeader("content-type", "application/x-www-form-urlencoded")
                .AddHeader("cache-control", "no-cache")
                .AddParameter("api_key", API_KEY)
                .AddParameter("format", "json");

            var response = await client.PostAsync(request);

            return DeserializeJson<AccountResponse>(response.Content);
        }

        /// <summary>
        /// his is a Swiss-Army knife type of a method for getting any information on monitors.
        /// 
        /// By default, it lists all the monitors in a user's account, their friendly names, 
        /// types (http, keyword, port, etc.), statuses (up, down, etc.) and uptime ratios.
        /// 
        /// There are optional parameters which lets the getMonitors method to output 
        /// information on any given monitors rather than all of them.
        /// 
        /// And also, parameters exist for getting the notification logs(alerts) 
        /// for each monitor and even which alert contacts were alerted on each notification.
        /// </summary>
        /// <returns>Object BotMonitors.Classes.MonitorsResponse</returns>
        public static async Task<MonitorsResponse> GetMonitors()
        {
            var request = new RestRequest("getMonitors")
                .AddHeader("content-type", "application/x-www-form-urlencoded")
                .AddHeader("cache-control", "no-cache")
                .AddParameter("api_key", API_KEY)
                .AddParameter("format", "json");

            var response = await client.PostAsync(request);

            return DeserializeJson<MonitorsResponse>(response.Content);
        }
        /// <summary>
        /// New monitors of any type can be created using this method.
        /// </summary>
        /// <param name="configure">Object BotMonitors.Configure.NewMonitorConfigure</param>
        /// <returns>Object BotMonitors.Classes.NewMonitorResponse</returns>
        public static async Task<NewMonitorResponse> NewMonitor(NewMonitorConfigure configure)
        {
            if (configure.Type == MonitorType.Ping && configure.SubType == null)
            {
                return null;
            }

            var request = new RestRequest("newMonitor")
                .AddHeader("content-type", "application/x-www-form-urlencoded")
                .AddHeader("cache-control", "no-cache")
                .AddParameter("api_key", API_KEY)
                .AddParameter("format", "json")
                .AddParameter("friendly_name", configure.FriendlyName)
                .AddParameter("ulr", configure.Url)
                .AddParameter("type", configure.Type);

            var response = await client.PostAsync(request);

            return DeserializeJson<NewMonitorResponse>(response.Content);
        }
        /// <summary>
        /// Monitors can be deleted using this method.
        /// </summary>
        /// <param name="id">The ID of the monitor to be deleted</param>
        /// <returns>Object BotMonitors.Classes.RemoveMonitorResponse</returns>
        public static async Task<RemoveMonitorResponse> RemoveMonitor(string id)
        {
            var request = new RestRequest("editMonitor")
                .AddHeader("content-type", "application/x-www-form-urlencoded")
                .AddHeader("cache-control", "no-cache")
                .AddParameter("api_key", API_KEY)
                .AddParameter("format", "json")
                .AddParameter("id", id);

            var response = await client.PostAsync(request);

            return DeserializeJson<RemoveMonitorResponse>(response.Content);
        }
    }
}
