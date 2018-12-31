using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseFrame.Interface.ViewInterface
{
    /// <summary>
    /// 主窗体接口：代表当前App的主窗体。
    /// </summary>
    public interface IMainView : IView
    {
        /// <summary>
        /// 代表当前App的主窗体，一般只用于设置弹出框的归属。
        /// The main window as IWin32Window.
        /// </summary>
        IWin32Window MainWin32Window { get; }

        /// <summary>
        /// 提供同步或异步执行委托的方法：一般只用于操作界面元素。
        /// </summary>
        ISynchronizeInvoke SynchronizingObject { get; }
    }
}
