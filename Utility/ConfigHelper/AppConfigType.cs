using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Utility.ConfigHelper
{
    public enum AppConfigType
    {
        /// <summary>
        /// 存在于用户自定义配置文件
        /// </summary>
        InUserConfigs = 1,

        /// <summary>
        /// 存在于系统配置文件
        /// </summary>
        InAppConfigs = 2,

        /// <summary>
        /// 存在于系统注册表
        /// </summary>
        InRegistryConfig = 4,
    }
}
