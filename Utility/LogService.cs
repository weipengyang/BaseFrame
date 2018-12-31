using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using log4net;
using log4net.Config;

namespace BaseFrame.Utility
{
    public class LogService
    {
        static LogService()
        {
            //string dbPath = AppDomain.CurrentDomain.BaseDirectory;
            //int end = dbPath.LastIndexOf('\\');
            //dbPath = dbPath.Substring(0, end) + "\\" + "FTDF.db";

            string assemPath = Assembly.GetExecutingAssembly().CodeBase;
            assemPath = assemPath.Substring(8);
            int index = assemPath.LastIndexOf("/");

            string dbPath = assemPath.Substring(0, index) + "/";


            XmlConfigurator.ConfigureAndWatch(new FileInfo(dbPath + "Log4NetConfig.xml"));
        }

        /// <summary>
        /// 根据logger名称获取log
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ILog GetLoggerByName(string name)
        {
            return LogManager.GetLogger(name);
        }
    }
}
