using System;
using Newtonsoft.Json;

namespace BotMonitorsAPI.Classes
{
    public partial class MonitorsResponse
    {
        [JsonProperty("stat")]
        public string Stat { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("monitors")]
        public Monitor[] Monitors { get; set; }
    }

    public partial class Monitor
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("friendly_name")]
        public string FriendlyName { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("sub_type")]
        public string SubType { get; set; }

        [JsonProperty("keyword_type")]
        public string KeywordType { get; set; }

        [JsonProperty("keyword_case_type")]
        public string KeywordCaseType { get; set; }

        [JsonProperty("keyword_value")]
        public string KeywordValue { get; set; }

        [JsonProperty("http_username")]
        public string HttpUsername { get; set; }

        [JsonProperty("http_password")]
        public string HttpPassword { get; set; }

        [JsonProperty("port")]
        public string Port { get; set; }

        [JsonProperty("interval")]
        public long Interval { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("create_datetime")]
        public long CreateDatetime { get; set; }

        [JsonProperty("monitor_group")]
        public long MonitorGroup { get; set; }

        [JsonProperty("is_group_main")]
        public long IsGroupMain { get; set; }

        [JsonProperty("logs")]
        public Log[] Logs { get; set; }
    }

    public partial class Log
    {
        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("datetime")]
        public long Datetime { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }
    }

    public partial class Pagination
    {
        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }
}
