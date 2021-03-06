namespace BotMonitorsAPI.Classes
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using BotMonitorsAPI.Configures;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class NewMonitorResponse
    {
        /// <summary>
        /// Exists only for JSON responses to show if any records are returned or not.
        /// ok or fail
        /// </summary>
        [JsonProperty("stat")]
        public string Stat { get; set; }

        [JsonProperty("monitor")]
        public NewMonitor Monitor { get; set; }
    }

    public partial class NewMonitor
    {
        /// <summary>
        /// The ID of the monitor (can be used for monitor-specific requests).
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
        /// <summary>
        /// The status of the monitor. 
        /// When used with the editMonitor method 0 (to pause) 
        /// or 1 (to start) can be sent.
        /// </summary>
        [JsonProperty("status")]
        public MonitorStatus Status { get; set; }
    }
}
