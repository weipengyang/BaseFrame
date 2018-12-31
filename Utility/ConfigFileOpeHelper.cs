using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaseFrame.Utility.ConfigHelper;

namespace BaseFrame.Utility
{
    public class ConfigFileOpeHelper
    {
        /// <summary>
        /// 加载有系统配置项的实例。
        /// </summary>
        private static ConfigFileOpeHelper instance = null;

        /// <summary>
        /// 获取当前系统配置实例。
        /// </summary>
        public static ConfigFileOpeHelper Current
        {
            get
            {
                if (ConfigFileOpeHelper.instance == null)
                {
                    ConfigFileOpeHelper.instance = new ConfigFileOpeHelper();
                }
                return ConfigFileOpeHelper.instance;
            }
        }

        private ConfigFileOpeHelper()
        {
        }

        /// <summary>
        /// 指定的键的配置项，是否存在。
        /// </summary>
        /// <param name="key">配置项对应的键名。</param>
        /// <returns></returns>
        private bool IsConfigExists(string key)
        {
            return AppConfigManager.Current.IsConfigExists(key);
        }


        /// <summary>
        /// 事件文件名称
        /// </summary>
        public string EventFileName
        {
            get
            {
                return AppConfigManager.Current.GetString(
                    "key",
                    "value");
            }
        }
    }
}
