using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Model
{
    /// <summary>
    /// 关闭事件参数。
    /// </summary>
    public class ClosingEventArgs : EventArgs
    {
        /// <summary>
        /// 初始化 ClosingEventArgs 类的新实例，其 ClosingEventArgs.Cancel属性设置为 false。
        /// </summary>
        public ClosingEventArgs()
            : this(false)
        {
        }

        /// <summary>
        /// 初始化 ClosingEventArgs 类的新实例，其 ClosingEventArgs.Cancel属性设置为给定值。
        /// </summary>
        /// <param name="cancel">要取消事件时为 true；否则为 false。</param>
        public ClosingEventArgs(bool cancel)
            : this(cancel, false)
        {
        }

        /// <summary>
        /// 初始化 ClosingEventArgs 类的新实例，其 ClosingEventArgs.Cancel属性设置为给定值。
        /// </summary>
        /// <param name="cancel">要取消事件时为 true；否则为 false。</param>
        /// <param name="forceClose">是否强制</param>
        public ClosingEventArgs(bool cancel, bool forceClose)
        {
            this.Cancel = cancel;
            this.ForceClose = forceClose;
        }

        /// <summary>
        /// 获取或设置指示是否应取消事件的值。
        /// 返回结果:
        ///     如果应取消事件，则为 true；否则为 false。
        /// </summary>
        public bool Cancel { get; set; }

        /// <summary>
        /// 强制关闭：不需要询问文件保存，直接关闭页面。
        /// </summary>
        public bool ForceClose { get; private set; }
    }
}
