using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
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
        Thread thread;

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
                thread = new Thread(this.stud);
                thread.Start();
            }
            catch (Exception ex)
            {
                systemLog.WriteEntry(ex.Message);
            }

            if (!Directory.Exists("C:\\xmlFileWatcherCSharp"))
            {
                Directory.CreateDirectory("C:\\xmlFileWatcherCSharp");
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
            News news;
            String author;
            systemLog.WriteEntry("A file has been modified or added - " + e.Name);
            try
            {
                XDocument doc = XDocument.Load(e.FullPath);
                IEnumerable<XElement> iterator = doc.Descendants("News");
                foreach (XElement elem in iterator)
                {
                    news = new News();
                    news.Title = elem.Element("Title").Value;
                    news.SubTitle = elem.Element("SubTitle").Value;
                    news.Body = elem.Element("Body").Value;
                    author = elem.Element("Author").Value;
                    proxy.sendNewsA(news,"toto");
                }
            }
            catch (Exception ex)
            {
                systemLog.WriteEntry(ex.Message);
            }
            
        }
    }
}
