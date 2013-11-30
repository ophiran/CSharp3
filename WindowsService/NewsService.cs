using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService
{
    public partial class NewsWindowsService : ServiceBase
    {
        public NewsWindowsService()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("SystemLog"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "SystemLog", "LogEntry");
            }
            systemLog.Source = "SystemLog";
            systemLog.Log = "LogEntry";
        }

        protected override void OnStart(string[] args)
        {
            systemLog.WriteEntry("-Service Start-");
        }

        protected override void OnStop()
        {
            systemLog.WriteEntry("-Service Stop-");
        }

        private void eventLog1_EntryWritten(object sender, EntryWrittenEventArgs e)
        {

        }

        private void xmlFileWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            systemLog.WriteEntry("A file has been modified or added - " + e.Name);
        }
    }
}
