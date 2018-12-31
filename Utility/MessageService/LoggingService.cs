using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Utility
{
    /// <summary>
    /// LogService的简单包装，默认内部创建一个 "PublicUtilsLogger" 的日志对象。可通过InitLogger来重新设置日志对象。
    /// Class for easy logging.
    /// </summary>
    public static class LoggingService
    {
        private static ILog flowLog = LogService.GetLoggerByName("PublicUtilsLogger");

        /// <summary>
        /// 按Logger名称初始化日志服务。
        /// </summary>
        /// <param name="loggerName"></param>
        public static void InitLoggingService(string loggerName)
        {
            flowLog = LogService.GetLoggerByName(loggerName);
        }

        public static void Debug(object message)
        {
            flowLog.Debug(message);
        }

        public static void Debug(object message, Exception exception)
        {
            flowLog.Debug(message, exception);
        }

        public static void DebugFormatted(string format, params object[] args)
        {
            flowLog.DebugFormat(format, args);
        }

        public static void Info(object message)
        {
            flowLog.Info(message);
        }

        public static void InfoFormatted(string format, params object[] args)
        {
            flowLog.InfoFormat(format, args);
        }

        public static void Warn(object message)
        {
            flowLog.Warn(message);
        }

        public static void Warn(object message, Exception exception)
        {
            flowLog.Warn(message, exception);
        }

        public static void WarnFormatted(string format, params object[] args)
        {
            flowLog.WarnFormat(format, args);
        }

        public static void Error(object message)
        {
            flowLog.Error(message);
        }

        public static void Error(object message, Exception exception)
        {
            flowLog.Error(message, exception);
        }

        public static void ErrorFormatted(string format, params object[] args)
        {
            flowLog.ErrorFormat(format, args);
        }

        public static void Fatal(object message)
        {
            flowLog.Fatal(message);
        }

        public static void Fatal(object message, Exception exception)
        {
            flowLog.Fatal(message, exception);
        }

        public static void FatalFormatted(string format, params object[] args)
        {
            flowLog.FatalFormat(format, args);
        }

        public static bool IsDebugEnabled
        {
            get
            {
                return true;
            }
        }

        public static bool IsInfoEnabled
        {
            get
            {
                return true;
            }
        }

        public static bool IsWarnEnabled
        {
            get
            {
                return true;
            }
        }

        public static bool IsErrorEnabled
        {
            get
            {
                return true;
            }
        }

        public static bool IsFatalEnabled
        {
            get
            {
                return true;
            }
        }
    }
}
