namespace WindowsService
{
    partial class NewsWindowsService
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.systemLog = new System.Diagnostics.EventLog();
            this.xmlFileWatcher = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.systemLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xmlFileWatcher)).BeginInit();
            // 
            // systemLog
            // 
            this.systemLog.EntryWritten += new System.Diagnostics.EntryWrittenEventHandler(this.eventLog1_EntryWritten);
            // 
            // xmlFileWatcher
            // 
            this.xmlFileWatcher.EnableRaisingEvents = true;
            this.xmlFileWatcher.Path = "C:\\xmlFileWatcherCSharp";
            this.xmlFileWatcher.Changed += new System.IO.FileSystemEventHandler(this.xmlFileWatcher_Changed);
            // 
            // NewsWindowsService
            // 
            this.ServiceName = "Service1";
            ((System.ComponentModel.ISupportInitialize)(this.systemLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xmlFileWatcher)).EndInit();

        }

        #endregion

        private System.Diagnostics.EventLog systemLog;
        private System.IO.FileSystemWatcher xmlFileWatcher;
    }
}
