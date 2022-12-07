using System;
using System.Diagnostics;
using System.Text;
using Microsoft.Azure.ServiceBus;
using Newtonsoft.Json;
using TAPLibrary.Utilities;

namespace TAPLibrary.Logging
{
    public class AstuteLogging : BaseAstuteLogging
    {
        protected string _client = string.Empty;
        protected string _callingIp = string.Empty;
        protected string _eventId = string.Empty;
        protected string _originalMessage = string.Empty;

        public AstuteLogging(bool isProd, string callingApp)
        {
            SetServiceBusConnection(isProd ? Azure.Connections.SERVICE_BUS : Azure.Connections.SERVICE_BUS_QA);

            SetServiceBusTopic(isProd ? Azure.LoggingTopics.PROD : Azure.LoggingTopics.QA);

            if (isProd)
                _topicClient = new TopicClient(Azure.Connections.SERVICE_BUS, Azure.LoggingTopics.PROD);
            else
                _topicClient = new TopicClient(Azure.Connections.SERVICE_BUS_QA, Azure.LoggingTopics.QA);

            _callingApp = callingApp;
        }

        public void NewEvent()
        {
            _eventId = Guid.NewGuid().ToString();
        }

        public string EventId
        {
            get { return _eventId; }
            set { _eventId = value; }
        }
        public string OriginalMessage
        {
            get { return _originalMessage; }
            set { _originalMessage = value; }
        }
        public string Client
        {
            get { return _client; }
            set { _client = value; }
        }
        public string CallingIP
        {
            get { return _callingIp; }
            set { _callingIp = value; }
        }

        #region Debug
        public void Debug(Exception ex, string text, LogDetail detail = null)
        {
            //            AstuteLoggingModel log = CreateLog( ReflectionUtil.GetCallerFrame( "Debug" ) );
            AstuteLoggingModel log = CreateLog();

            if (!string.IsNullOrEmpty(_eventId))
                log.EventId = _eventId;

            if (!string.IsNullOrEmpty(text))
            {
                log.Message = text;
            }

            if (ex != null)
            {
                log.Exception = ex.ToString();
            }

            if (detail != null)
            {
                log.Detail = detail;
            }

            log.ProcessName = _callingApp;
            log.LoggingType = "DEBUG";
            log.CallingClient = _client;
            log.ClientIP = _callingIp;

            var encMessage = new Message(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(log)));
            _topicClient.SendAsync(encMessage);
        }
        
        public void Debug(Exception ex)
        {
            Debug(ex, null);
        }
        public void Debug(string text)
        {
            Debug(null, text);
        }
        public void Debug(Exception ex, LogDetail detail)
        {            
            Debug(ex, null, detail);
        }
        public void Debug(LogDetail detail)
        {
            Debug(null, null, detail);
        }
        #endregion

        #region Warning
        public void Warning(Exception ex, string text, LogDetail detail = null)
        {
            //AstuteLoggingModel log = CreateLog(ReflectionUtil.GetCallerFrame("Warning"));
            AstuteLoggingModel log = CreateLog();

            if (!string.IsNullOrEmpty(_eventId))
                log.EventId = _eventId;

            if (!string.IsNullOrEmpty(text))
            {
                log.Message = text;
            }

            if (ex != null)
            {
                log.Exception = ex.ToString();
            }
            if (detail != null)
            {
                log.Detail = detail;
            }

            log.ProcessName = _callingApp;
            log.LoggingType = "WARNING";
            log.CallingClient = _client;
            log.ClientIP = _callingIp;

            var encMessage = new Message(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(log)));
            _topicClient.SendAsync(encMessage);
        }

        public void Warning(Exception ex)
        {
            Warning(ex, null);
        }
        public void Warning(string text)
        {
            Warning(null, text);
        }
        public void Warning(Exception ex, LogDetail detail)
        {
            Warning(ex, null, detail);
        }
        public void Warning(LogDetail detail)
        {
            Warning(null, null, detail);
        }
        #endregion

        #region Info
        public void Info(Exception ex, string text, LogDetail detail = null)
        {
            //AstuteLoggingModel log = CreateLog( ReflectionUtil.GetCallerFrame( "Info" ) );
            AstuteLoggingModel log = CreateLog();

            if (!string.IsNullOrEmpty(_eventId))
                log.EventId = _eventId;

            if (!string.IsNullOrEmpty(text))
            {
                log.Message = text;
            }

            if (ex != null)
            {
                log.Exception = ex.ToString();
            }

            if (detail != null)
            {
                log.Detail = detail;
            }

            log.ProcessName = _callingApp;
            log.CallingClient = _client;
            log.LoggingType = "INFO";
            log.ClientIP = _callingIp;

            var encMessage = new Message(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(log)));
            _topicClient.SendAsync(encMessage);
        }
        
        public void Info(Exception ex)
        {
            Info(ex, null);
        }

        public void Info(string text)
        {
            Info(null, text);
        }

        public void Info(Exception ex, LogDetail detail)
        {
            Info(ex, null, detail);
        }
        public void Info(LogDetail detail)
        {
            Info(null, null, detail);
        }
        #endregion

        #region Fatal
        public void Fatal(Exception ex, string text, LogDetail detail = null)
        {
            AstuteLoggingModel log = CreateLog( ReflectionUtil.GetCallerFrame( "Fatal" ) );

            if (!string.IsNullOrEmpty(_eventId))
                log.EventId = _eventId;

            if ( !string.IsNullOrEmpty(text))
            {
                log.Message = text;
            }

            if (ex != null)
            {
                log.Exception = ex.ToString();
            }

            if (detail != null)
            {
                log.Detail = detail;
            }

            log.ProcessName = _callingApp;
            log.CallingClient = _client;
            log.LoggingType = "FATAL";
            log.ClientIP = _callingIp;

            var encMessage = new Message(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(log)));
            _topicClient.SendAsync(encMessage);
        }
        
        public void Fatal(Exception ex)
        {
            Fatal(ex, "");
        }
        
        public void Fatal(string text)
        {
            Fatal(null, text);
        }
        public void Fatal(Exception ex, LogDetail detail)
        {
            Fatal(ex, null, detail);
        }
        public void Fatal(LogDetail detail)
        {
            Fatal(null, null, detail);
        }
        #endregion

        #region Error
        public void Error(Exception ex, string text, LogDetail detail = null)
        {
            AstuteLoggingModel log = CreateLog( ReflectionUtil.GetCallerFrame( "Error" ) );

            if (!string.IsNullOrEmpty(_eventId))
                log.EventId = _eventId;

            if (!string.IsNullOrEmpty(text))
            {
                log.Message = text;
            }

            if (ex != null)
            {
                log.Exception = ex.ToString();
            }

            if (detail != null)
            {
                log.Detail = detail;
            }

            log.ProcessName = _callingApp;
            log.CallingClient = _client;
            log.LoggingType = "ERROR";
            log.ClientIP = _callingIp;

            var encMessage = new Message(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(log)));
            _topicClient.SendAsync(encMessage);
        }
        
        public void Error(Exception ex)
        {
            Error(ex, "");
        }
        
        public void Error(string text)
        {
            Error(null, text);
        }
        public void Error(Exception ex, LogDetail detail)
        {
            Error(ex, null, detail);
        }
        public void Error(LogDetail detail)
        {
            Error(null, null, detail);
        }
        #endregion

        #region Verbose
        public void Verbose(Exception ex, string text, LogDetail detail = null)
        {
            //AstuteLoggingModel log = CreateLog( ReflectionUtil.GetCallerFrame( "Verbose" ) );
            AstuteLoggingModel log = CreateLog();

            if (!string.IsNullOrEmpty(_eventId))
                log.EventId = _eventId;

            if ( !string.IsNullOrEmpty(text))
            {
                log.Message = text;
            }

            if (ex != null)
            {
                log.Exception = ex.ToString();
            }

            if (detail != null)
            {
                log.Detail = detail;
            }

            log.ProcessName = _callingApp;
            log.CallingClient = _client;
            log.LoggingType = "VERBOSE";
            log.ClientIP = _callingIp;

            var encMessage = new Message(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(log)));
            _topicClient.SendAsync(encMessage);

        }
        
        public void Verbose(Exception ex)
        {
            Verbose(ex, null);
        }
        
        public void Verbose(string text)
        {
            Verbose(null, text);
        }
        public void Verbose(Exception ex, LogDetail detail)
        {
            Verbose(ex, null, detail);
        }
        public void Verbose(LogDetail detail)
        {
            Verbose(null, null, detail);
        }
        #endregion

        protected AstuteLoggingModel CreateLog(StackFrame item)
        {
            var obj = new AstuteLoggingModel
            {
                CallingProcudure = item.GetMethod().Name,
            };
            obj.CallingNamespace = item.GetMethod().ReflectedType != null ? item.GetMethod().ReflectedType.Namespace : item.GetMethod().Name;
            return obj;
        }
        protected AstuteLoggingModel CreateLog()  // No Reflection
        {
            return new AstuteLoggingModel();
//            var obj = new AstuteLoggingModel
//            {
//                CallingProcudure = item.GetMethod().Name,
//            };
//            obj.CallingNamespace = item.GetMethod().ReflectedType != null ? item.GetMethod().ReflectedType.Namespace : item.GetMethod().Name;
            //return obj;
        }

    }
}
