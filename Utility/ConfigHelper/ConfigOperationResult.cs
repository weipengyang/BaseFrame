using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Utility.ConfigHelper
{
    /// <summary>
    /// 配置项的操作结果。
    /// </summary>
    public enum ConfigOperationResult
    {
        /// <summary>
        /// 成功。
        /// </summary>
        Success,
        //NotNeedUpdate,
        /// <summary>
        /// 失败。
        /// </summary>
        Failed,
        /// <summary>
        /// 未找到配置项。
        /// </summary>
        NotFoundConfig
    }
}
