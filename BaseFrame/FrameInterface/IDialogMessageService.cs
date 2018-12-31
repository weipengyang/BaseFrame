using BaseFrame.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseFrame.Interface
{
    /// <summary>
    /// Message service that sets an owner for dialog boxes.
    /// </summary>
    public interface IDialogMessageService : IMessageService
    {
        /// <summary>
        /// 弹出框的归属窗体。
        /// </summary>
        IWin32Window DialogOwner { get; }

        /// <summary>
        /// 提供同步或异步执行委托的方法：一般只用于操作界面元素。
        /// </summary>
        ISynchronizeInvoke DialogSynchronizeInvoke { get; }

        /// <summary>
        /// 初始化对话框服务。
        /// </summary>
        /// <param name="dialogOwner"></param>
        /// <param name="dialogSynchronizeInvoker"></param>
        void InitDialogMessageService(IWin32Window dialogOwner, ISynchronizeInvoke dialogSynchronizeInvoker);
    }
}
