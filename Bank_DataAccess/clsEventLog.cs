using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_DataAccess
{
    public class clsEventLog
    {
        private static string _SourceName = "Bank";

        public static void LogExseptionsToLogerViewr(string Message, EventLogEntryType type)
        {
            if (!EventLog.SourceExists(_SourceName))
            {
                EventLog.CreateEventSource(_SourceName, "Application");
            }


            EventLog.WriteEntry(_SourceName, Message, type);
        }
    }
}
