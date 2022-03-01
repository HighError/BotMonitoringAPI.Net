using Newtonsoft.Json;

namespace BotMonitorsAPI.Classes
{
    public partial class AccountResponse
    {
        [JsonProperty("stat")]
        public string Stat { get; set; }

        [JsonProperty("account")]
        public Account Account { get; set; }
    }

    public partial class Account
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("monitor_limit")]
        public long MonitorLimit { get; set; }

        [JsonProperty("monitor_interval")]
        public long MonitorInterval { get; set; }

        [JsonProperty("up_monitors")]
        public long UpMonitors { get; set; }

        [JsonProperty("down_monitors")]
        public long DownMonitors { get; set; }

        [JsonProperty("paused_monitors")]
        public long PausedMonitors { get; set; }
    }
}
