using Newtonsoft.Json;

namespace BotMonitorsAPI.Classes
{
    public partial class AccountResponse
    {
        /// <summary>
        /// Exists only for JSON responses to show if any records are returned or not.
        /// ok or fail
        /// </summary>
        [JsonProperty("stat")]
        public string Stat { get; set; }

        [JsonProperty("account")]
        public Account Account { get; set; }
    }

    public partial class Account
    {
        /// <summary>
        /// The account e-mail.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
        /// <summary>
        /// The max number of monitors that can be created for the account
        /// </summary>
        [JsonProperty("monitor_limit")]
        public long MonitorLimit { get; set; }
        /// <summary>
        /// The min monitoring interval (in seconds) supported by the account
        /// </summary>
        [JsonProperty("monitor_interval")]
        public long MonitorInterval { get; set; }
        /// <summary>
        /// The number of "up" monitors
        /// </summary>
        [JsonProperty("up_monitors")]
        public long UpMonitors { get; set; }
        /// <summary>
        /// The number of "down" monitors
        /// </summary>
        [JsonProperty("down_monitors")]
        public long DownMonitors { get; set; }
        /// <summary>
        /// The number of "paused" monitors
        /// </summary>
        [JsonProperty("paused_monitors")]
        public long PausedMonitors { get; set; }
    }
}
