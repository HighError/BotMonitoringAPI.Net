namespace BotMonitorsAPI.Classes
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class NewMonitorResponse
    {
        [JsonProperty("stat")]
        public string Stat { get; set; }

        [JsonProperty("monitor")]
        public NewMonitor Monitor { get; set; }
    }

    public partial class NewMonitor
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }
    }
}
