using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Utility.Files
{
    /// <summary>
    /// 保存文件时的接口参数。
    /// </summary>
    public class FileCreationInfo
    {
        /// <summary>
        /// 带点前缀(".")的文件扩展名。
        /// </summary>
        public string ExtensionNameWithDot { get; set; }

        /// <summary>
        /// 不带点前缀(".")的文件扩展名。
        /// </summary>
        public string ExtensionNameWithoutDot { get; set; }

        /// <summary>
        /// 默认文件保存的名称。
        /// </summary>
        public string DefualtFileName { get; set; }

        /// <summary>
        /// 初始路径。
        /// </summary>
        public string InitialPath { get; set; }

        /// <summary>
        /// 文件过滤信息。
        /// </summary>
        public string FileFilter { get; set; }

        /// <summary>
        /// 对话框相关的描述。
        /// </summary>
        public string Description { get; set; }
    }
}
