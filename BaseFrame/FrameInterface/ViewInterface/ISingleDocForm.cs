using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.SingleDocView
{
    /// <summary>
    /// 单文档窗体接口。
    /// </summary>
    public interface ISingleDocForm : ISingleDocView
    {
        /// <summary>
        /// 清空日志消息。
        /// </summary>
        void ClearLogMsg();

        /// <summary>
        /// 获取日志消息。
        /// </summary>
        /// <returns></returns>
        string GetLogMsg();
    }
}
