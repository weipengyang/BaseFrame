using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Utility.MessageService
{
    /// <summary>
    /// 前任务的进度通知接口。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IProgress<in T>
    {
        /// <summary>
        /// 通知当前任务的进度已更新。
        /// Reports a progress update.
        /// </summary>
        /// <param name="value"></param>
        void Report(T value);
    }
}
