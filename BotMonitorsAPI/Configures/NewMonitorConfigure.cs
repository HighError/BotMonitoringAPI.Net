using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotMonitorsAPI.Configures
{
    public class NewMonitorConfigure
    {
        /// <summary>
        /// Required.
        /// 
        /// The friendly name of the monitor.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// Required.
        /// 
        /// The URL/IP of the monitor.
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Required.
        /// 
        /// The type of the monitor.
        /// </summary>
        public MonitorType Type { get; set; }
        /// <summary>
        /// Optional (Required for port monitoring)
        /// 
        /// Used only for "Port monitoring (type = 4)" 
        /// and shows which pre-defined port/service is monitored 
        /// or if a custom port is monitored.
        /// </summary>
        public MonitorSubType? SubType { get; set; }
        /// <summary>
        /// Optional (Required for port monitoring)
        /// 
        /// Used only for "Port monitoring (type = 4)" and shows the port monitored.
        /// </summary>
        public int? Port { get; set; }

        public NewMonitorConfigure(string friendlyName, string url, MonitorType type)
        {
            FriendlyName = friendlyName;
            Url = url;
            Type = type;
        }
    }
}
