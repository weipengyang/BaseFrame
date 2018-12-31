using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Utility.Files
{
    /// <summary>
    /// 打开文件接口参数对象。
    /// </summary>
    public class FileOpeningInfo
    {
        /// <summary>
        /// 初始路径。
        /// </summary>
        public string InitialPath { get; set; }

        /// <summary>
        /// 文件过滤信息。
        /// </summary>
        public string FileFilter { get; set; }

        /// <summary>
        /// 打开文件相关描述。
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 是否支持文件的多选。
        /// </summary>
        public bool CanMultiSelect { get; set; }
    }
}
