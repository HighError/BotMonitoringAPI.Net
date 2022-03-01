namespace BotMonitorsAPI.Classes
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class RemoveMonitorResponse
    {
        /// <summary>
        /// Exists only for JSON responses to show if any records are returned or not.
        /// ok or fail
        /// </summary>
        [JsonProperty("stat")]
        public string Stat { get; set; }

        [JsonProperty("monitor")]
        public RemoveMonitor Monitor { get; set; }
    }

    public partial class RemoveMonitor
    {
        /// <summary>
        /// The ID of the monitor (can be used for monitor-specific requests).
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
