using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotMonitorsAPI.Classes
{
    public class AccountResponse
    {
        public string stat { get; set; }
        public Account account { get; set; }
    }

    public class Account
    {
        public string email { get; set; }
        public int monitor_limit { get; set; }
        public int monitor_interval { get; set; }
        public int up_monitors { get; set; }
        public int down_monitors { get; set; }
        public int paused_monitors { get; set; }
    }
}
