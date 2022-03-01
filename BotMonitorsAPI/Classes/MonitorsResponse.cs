using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotMonitorsAPI.Classes
{
    public class MonitorsResponse
    {
        public string stat { get; set; }
        public Pagination pagination { get; set; }
        public List<Monitor> monitors { get; set; }
    }

    public class Monitor
    {
        public int id { get; set; }
        public string friendly_name { get; set; }
        public string url { get; set; }
        public int type { get; set; }
        public string sub_type { get; set; }
        public string keyword_type { get; set; }
        public int? keyword_case_type { get; set; }
        public string keyword_value { get; set; }
        public string http_username { get; set; }
        public string http_password { get; set; }
        public string port { get; set; }
        public int interval { get; set; }
        public int status { get; set; }
        public int create_datetime { get; set; }
        public int monitor_group { get; set; }
        public int is_group_main { get; set; }
        public List<Log> logs { get; set; }
    }

    public class Pagination
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
    }

    public class Log
    {
        public int type { get; set; }
        public int datetime { get; set; }
        public int duration { get; set; }
    }

}
