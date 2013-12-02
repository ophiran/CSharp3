using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using WindowsService.ServiceRef;

namespace WindowsService
{
    public partial class NewsWindowsService : ServiceBase
    {
        NewsWCFClient proxy;

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
            try
            {
                systemLog.WriteEntry("-Service Start-");
                proxy = new NewsWCFClient();
                Thread thread = new Thread(this.stud);
            }
            catch (Exception ex)
            {
                systemLog.WriteEntry(ex.Message);
            }
            
        }

        protected override void OnStop()
        {
            systemLog.WriteEntry("-Service Stop-");
        }

        private void eventLog1_EntryWritten(object sender, EntryWrittenEventArgs e)
        {
            
        }

        private void stud()
        {

        }

        private void xmlFileWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            systemLog.WriteEntry("A file has been modified or added - " + e.Name);
            try
            {
                String test = "";
                test += proxy.connectUser("", "");
                systemLog.WriteEntry(test);
            }
            catch (Exception ex)
            {
                systemLog.WriteEntry(ex.StackTrace);
            }
            XDocument doc = XDocument.Load(e.FullPath);
            IEnumerable<XElement> iterator = doc.Descendants();
            foreach (XElement elem in iterator)
            {
                systemLog.WriteEntry(elem.Name.LocalName);
            }
        }
    }
}
