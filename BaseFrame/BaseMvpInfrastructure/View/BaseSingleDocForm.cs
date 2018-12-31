using BaseFrame.MultiDocView;
using BaseFrame.SingleDocView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseFrame.View.SingleDocView
{
    /// <summary>
    /// 单文档窗体基类。
    /// </summary>
    public class BaseSingleDocForm : BaseForm, ISingleDocView
    {
        #region Fields
        #endregion

        #region Constructor
        /// <summary>
        /// 创建多文档窗体。
        /// </summary>
        public BaseSingleDocForm()
        {
        }
        #endregion

        #region Properties
        /// <summary>
        /// 代表当前App的主窗体，一般只用于设置弹出框的归属。
        /// The main window as IWin32Window.
        /// </summary>
        public virtual IWin32Window MainWin32Window
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        /// 提供同步或异步执行委托的方法：一般只用于操作界面元素。
        /// </summary>
        public virtual ISynchronizeInvoke SynchronizingObject
        {
            get
            {
                return this;
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// 显示界面
        /// </summary>
        public override void ShowView()
        {
            this.Show();
        }

        /// <summary>
        /// 关闭界面
        /// </summary>
        public override void CloseView()
        {
            this.Close();
        }
        #endregion

        #region Private Methods

        #endregion
    }
}
