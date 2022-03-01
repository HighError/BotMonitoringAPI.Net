using System;
using BotMonitorsAPI.Configures;
using Newtonsoft.Json;

namespace BotMonitorsAPI.Classes
{
    public partial class MonitorsResponse
    {
        /// <summary>
         /// Exists only for JSON responses to show if any records are returned or not.
         /// ok or fail
         /// </summary>
        [JsonProperty("stat")]
        public string Stat { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("monitors")]
        public Monitor[] Monitors { get; set; }
    }

    public partial class Monitor
    {
        /// <summary>
        /// The ID of the monitor (can be used for monitor-specific requests).
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
        /// <summary>
        /// The friendly name of the monitor.
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; set; }
        /// <summary>
        /// The URL/IP of the monitor.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; set; }
        /// <summary>
        /// The type of the monitor
        /// </summary>
        [JsonProperty("type")]
        public MonitorType Type { get; set; }
        /// <summary>
        /// Used only for "Port monitoring (type = 4)" 
        /// and shows which pre-defined port/service is monitored 
        /// or if a custom port is monitored.
        /// </summary>
        [JsonProperty("sub_type")]
        public MonitorSubType SubType { get; set; }
        /// <summary>
        /// used only for "Keyword monitoring (type = 2)" 
        /// and shows "if the monitor will be flagged as 
        /// down when the keyword exists or not exists".
        /// </summary>
        [JsonProperty("keyword_type")]
        public string KeywordType { get; set; }
        /// <summary>
        /// used only for "Keyword monitoring (type = 2)" 
        /// if set the keyword value will be checked as case sensitive 
        /// or case insensitive according the selection. 
        /// (case sensitive by default)
        /// </summary>
        [JsonProperty("keyword_case_type")]
        public string KeywordCaseType { get; set; }
        /// <summary>
        /// The value of the keyword.
        /// </summary>
        [JsonProperty("keyword_value")]
        public string KeywordValue { get; set; }
        /// <summary>
        /// Used for password-protected web pages. Available for HTTP and keyword monitoring.
        /// </summary>
        [JsonProperty("http_username")]
        public string HttpUsername { get; set; }
        /// <summary>
        /// Used for password-protected web pages. Available for HTTP and keyword monitoring
        /// </summary>
        [JsonProperty("http_password")]
        public string HttpPassword { get; set; }
        /// <summary>
        /// used only for "Port monitoring (type = 4)" 
        /// and shows the port monitored.
        /// </summary>
        [JsonProperty("port")]
        public string Port { get; set; }
        /// <summary>
        /// The interval for the monitoring check (300 seconds by default).
        /// </summary>
        [JsonProperty("interval")]
        public long Interval { get; set; }
        /// <summary>
        /// The status of the monitor. 
        /// When used with the editMonitor method 0 (to pause) 
        /// or 1 (to start) can be sent.
        /// </summary>
        [JsonProperty("status")]
        public MonitorStatus Status { get; set; }

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
        /// <summary>
        /// The value of the keyword.
        /// </summary>
        [JsonProperty("type")]
        public long Type { get; set; }
        /// <summary>
        /// The date and time of the log (inherits the user's timezone setting).
        /// </summary>
        [JsonProperty("datetime")]
        public long Datetime { get; set; }
        /// <summary>
        /// The duration of the downtime in seconds.
        /// </summary>
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
