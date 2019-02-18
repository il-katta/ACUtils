using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security;

namespace ACUtils
{
    /// <summary>
    /// Logging operations
    /// </summary>
    public class Logger : ILogger
    {
        // Note: The actual limit is higher than this, but different Microsoft operating systems actually have
        //       different limits. So just use 30,000 to be safe.
        private const int MaxEventLogEntryLength = 30000;
        private bool debugLoggingEnabled = false;
        /// <summary>
        /// Gets or sets the source/caller. When logging, this logger class will attempt to get the
        /// name of the executing/entry assembly and use that as the source when writing to a log.
        /// In some cases, this class can't get the name of the executing assembly. This only seems
        /// to happen though when the caller is in a separate domain created by its caller. So,
        /// unless you're in that situation, there is no reason to set this. However, if there is
        /// any reason that the source isn't being correctly logged, just set it here when your
        /// process starts.
        /// </summary>
        public static string Source { get; set; }


        public Logger(bool debug = false)
        {
            this.debugLoggingEnabled = debug;
        }

        /// <summary>
        /// Logs the message, but only if debug logging is true.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="debugLoggingEnabled">if set to <c>true</c> [debug logging enabled].</param>
        /// <param name="source">The name of the app/process calling the logging method. If not provided,
        /// an attempt will be made to get the name of the calling process.</param>
        public void Debug(string message, string source = "", int eventID = 0)
        {
            if (debugLoggingEnabled == false) { return; }

            Log(message, EventLogEntryType.Information, source, eventID);
        }

        /// <summary>
        /// Logs the information.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="source">The name of the app/process calling the logging method. If not provided,
        /// an attempt will be made to get the name of the calling process.</param>
        public void Information(string message, string source = "", int eventID = 0)
        {
            Log(message, EventLogEntryType.Information, source, eventID);
        }

        /// <summary>
        /// Logs the warning.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="source">The name of the app/process calling the logging method. If not provided,
        /// an attempt will be made to get the name of the calling process.</param>
        public void Warning(string message, string source = "", int eventID = 0)
        {
            Log(message, EventLogEntryType.Warning, source, eventID);
        }

        /// <summary>
        /// Logs the exception.
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <param name="source">The name of the app/process calling the logging method. If not provided,
        /// an attempt will be made to get the name of the calling process.</param>
        public void LogException(Exception ex, string source = "")
        {
            if (ex == null) { throw new ArgumentNullException("ex"); }

            Error(ex.ToString());
        }

        public void Error(string message, string source = "", int eventID = 0)
        {
            Log(message, EventLogEntryType.Error, source, eventID);
        }

        /*
        /// <summary>
        /// Recursively gets the properties and values of an object and dumps that to the log.
        /// </summary>
        /// <param name="theObject">The object to log</param>
        [SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Xanico.Core.Logger.Log(System.String,System.Diagnostics.EventLogEntryType,System.String)")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "object")]
        public static void LogObjectDump(object theObject, string objectName, string source = "")
        {
            const int objectDepth = 5;
            string objectDump = ObjectDumper.GetObjectDump(theObject, objectDepth);

            string prefix = string.Format(CultureInfo.CurrentCulture,
                                          "{0} object dump:{1}",
                                          objectName,
                                          Environment.NewLine);

            Log(prefix + objectDump, EventLogEntryType.Warning, source);
        }
        */
        /// <summary>
        /// Scrive il log nel registro eventi di Windows e in output
        /// </summary>
        /// <param name="message"></param>
        /// <param name="entryType"></param>
        /// <param name="source"></param>
        private void Log(string message, EventLogEntryType entryType, string source, int eventID = 0)
        {
            // Note: I got an error that the security log was inaccessible. To get around it, I ran the app as administrator
            //       just once, then I could run it from within VS.

            if (string.IsNullOrWhiteSpace(source))
            {
                source = GetSource();
            }

            string possiblyTruncatedMessage = EnsureLogMessageLimit(message);
            try
            {
                EventLog.WriteEntry(source, possiblyTruncatedMessage, entryType);
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Logger - DEBUG - {0}", ex.ToString()));
            }
            finally
            {
                // If we're running a console app, also write the message to the console window.
                //if (Environment.UserInteractive)
                //{
                Console.WriteLine(message);
                //}
            }
        }

        private static string GetSource()
        {
            // If the caller has explicitly set a source value, just use it.
            if (!string.IsNullOrWhiteSpace(Source)) { return Source; }

            try
            {
                Assembly assembly = Assembly.GetEntryAssembly();

                // GetEntryAssembly() can return null when called in the context of a unit test project.
                // That can also happen when called from an app hosted in IIS, or even a windows service.

                if (assembly == null)
                {
                    assembly = Assembly.GetExecutingAssembly();
                }


                if (assembly == null)
                {
                    // From http://stackoverflow.com/a/14165787/279516:
                    assembly = new StackTrace().GetFrames().Last().GetMethod().Module.Assembly;
                }

                if (assembly == null) { return "Unknown"; }

                return assembly.GetName().Name;
            }
            catch
            {
                return "Unknown";
            }
        }

        // Ensures that the log message entry text length does not exceed the event log viewer maximum length of 32766 characters.
        private static string EnsureLogMessageLimit(string logMessage)
        {
            if (logMessage.Length > MaxEventLogEntryLength)
            {
                string truncateWarningText = string.Format(CultureInfo.CurrentCulture, "... | Log Message Truncated [ Limit: {0} ]", MaxEventLogEntryLength);

                // Set the message to the max minus enough room to add the truncate warning.
                logMessage = logMessage.Substring(0, MaxEventLogEntryLength - truncateWarningText.Length);

                logMessage = string.Format(CultureInfo.CurrentCulture, "{0}{1}", logMessage, truncateWarningText);
            }

            return logMessage;
        }

        public static string CreateEventSource(string currentAppName)
        {
            string eventSource = currentAppName;
            bool sourceExists;
            try
            {
                // searching the source throws a security exception ONLY if not exists!
                sourceExists = EventLog.SourceExists(eventSource);
                if (!sourceExists)
                {   // no exception until yet means the user as admin privilege
                    EventLog.CreateEventSource(eventSource, "Application");
                }
            }
            catch (SecurityException)
            {
                eventSource = "Application";
            }

            return eventSource;
        }

        public static string CreateEventSource()
        {
            return CreateEventSource(GetSource());
        }


        private static IEnumerable<EventLogEntry> dumpLogs()
        {
            foreach (EventLog logs in EventLog.GetEventLogs())
            {
                if (logs.Log == "Application")
                {
                    string source = GetSource();

                    foreach (EventLogEntry e in logs.Entries)
                    {
                        if (e.Source == source)
                        {
                            yield return e;
                        }
                    }
                }
            }
        }

        public static void DumpLogs()
        {
            foreach (EventLogEntry e in (from e in dumpLogs() orderby e.TimeWritten descending select e))
            {
                Console.WriteLine(string.Format("{0} - {1}", e.TimeGenerated.ToString(), e.Message));
            }
        }

        public static void DumpLogs(TimeSpan timeAgo)
        {
            foreach (EventLogEntry e in (from e in dumpLogs() where (DateTime.Now - e.TimeGenerated) < timeAgo orderby e.TimeWritten descending select e))
            {
                Console.WriteLine(string.Format("{0} - {1} - {2}", e.TimeGenerated.ToString(), e.EntryType, e.Message));
            }
        }

        #region ILogger
        public void Debug(string message)
        {
            this.Debug(message, "", 0);
        }

        public void Information(string message)
        {
            this.Information(message, "", 0);
        }

        public void Warning(string message)
        {
            this.Warning(message, "", 0);
        }

        public void Error(string message)
        {
            this.Error(message, "", 0);
        }

        public void Exception(Exception exception)
        {
            this.LogException(exception);
        }

        void ILogger.Debug(string message)
        {
            throw new NotImplementedException();
        }

        void ILogger.Debug(string messageTemplate, params object[] propertyValues)
        {
            throw new NotImplementedException();
        }

        void ILogger.Information(string message)
        {
            throw new NotImplementedException();
        }

        void ILogger.Information(string messageTemplate, params object[] propertyValues)
        {
            throw new NotImplementedException();
        }

        void ILogger.Warning(string message)
        {
            throw new NotImplementedException();
        }

        void ILogger.Warning(string messageTemplate, params object[] propertyValues)
        {
            throw new NotImplementedException();
        }

        void ILogger.Error(string message)
        {
            throw new NotImplementedException();
        }

        void ILogger.Error(string messageTemplate, params object[] propertyValues)
        {
            throw new NotImplementedException();
        }

        void ILogger.Exception(Exception exception)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
