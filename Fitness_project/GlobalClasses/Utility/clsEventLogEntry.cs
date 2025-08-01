using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_project.GlobalClasses.Utility
{
    public class clsEventLogEntry
    {
        public enum enEventLogEntry { enInformation = 1, enWarnning = 2, enError = 3 }
        public enEventLogEntry _EventLog = enEventLogEntry.enInformation;
        public static void SaveEventToEventLogEntry(string Description, enEventLogEntry eventLogEntry = enEventLogEntry.enError)
        {
            string AppName = "Fitness_project";
            if (!EventLog.SourceExists(AppName))
            {
                EventLog.CreateEventSource(AppName, "Application");
            }
            switch (eventLogEntry)
            {
                case enEventLogEntry.enInformation:
                    EventLog.WriteEntry(AppName, Description, EventLogEntryType.Information);
                    break;
                case enEventLogEntry.enWarnning:
                    EventLog.WriteEntry(AppName, Description, EventLogEntryType.Warning);
                    break;
                default:
                    EventLog.WriteEntry(AppName, Description, EventLogEntryType.Error);
                    break;
            }

        }
    }
}
