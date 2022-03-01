using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotMonitorsAPI.Configures
{
    
    public enum MonitorType
    {
        HTTP = 1,
        Keyword = 2,
        Ping = 3,
        Port = 4,
        Heartbeat = 5
    }
    public enum MonitorSubType
    {
        HTTP = 1,
        HTTPS = 2,
        FTP = 3,
        SMTP = 4,
        POP3 = 5,
        IMAP = 6,
        Custom = 99
    }
}
