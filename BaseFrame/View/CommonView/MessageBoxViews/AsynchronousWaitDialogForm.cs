using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseFrame.View.MessageBoxViews
{
    /// <summary>
    /// 异步等待消息提示框。
    /// </summary>
    public partial class AsynchronousWaitDialogForm : Form
    {
        /// <summary>
        /// 创建异步等待消息提示框。
        /// </summary>
        public AsynchronousWaitDialogForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 取消 按钮是否可见。
        /// </summary>
        /// <param name="allowCancel"></param>
        public void SetAllowCancel(bool allowCancel)
        {
            cancelButton.Text = ConstStringResources.GlobalCancelButtonText;

            if (allowCancel)
            {
                cancelButton.Visible = true;
                progressBar.Width = cancelButton.Left - 8 - progressBar.Left;
            }
            else
            {
                cancelButton.Visible = false;
                progressBar.Width = cancelButton.Right - progressBar.Left;
            }
        }
    }
}
