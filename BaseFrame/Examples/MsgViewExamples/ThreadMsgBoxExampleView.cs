using BaseFrame.FrameInterface.PresenterInterface;
using BaseFrame.FrameInterface.ViewInterface;
using BaseFrame.MultiDocView;
using BaseFrame.View.MessageBoxViews;
using BaseFrame.Utility;
using BaseFrame.Utility.MessageService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseFrame.Interface;

namespace BaseFrame.Examples.MsgViewExamples
{
    /*
    <!--ThreadMsgBoxExampleView 界面关联的 IThreadMsgBoxExampleView 接口配置-->
    <component instance-scope="singleinstance"
      type="BaseFrame.Examples.MsgViewExamples.ThreadMsgBoxExampleView, BaseFrame"
      service="BaseFrame.FrameInterface.ViewInterface.IThreadMsgBoxExampleView, BaseFrame">
    </component>
    */

    /// <summary>
    /// MVP模式中的View页面：用于UI显示。
    /// </summary>
    /// <remarks>
    /// type="BaseFrame.Examples.MsgViewExamples.ThreadMsgBoxExampleView, BaseFrame"
    /// </remarks>
    public partial class ThreadMsgBoxExampleView : MultiDocSubForm, IThreadMsgBoxExampleView
    {
        #region Fields
        private IThreadMsgBoxExamplePresenter threadMsgBoxPresenter;
        #endregion

        #region Constructor
        /// <summary>
        /// MVP模式中的View页面：用于UI显示。
        /// </summary>
        public ThreadMsgBoxExampleView()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties

        #endregion

        #region Public Methods

        #endregion

        #region Protected Methods
        /// <summary>
        /// 初始化Presenter数据：在此方法中解决循环依赖问题，默认绑定页面关联的Presenter接口实现。
        /// </summary>
        protected override void InternalInitData()
        {
            this.threadMsgBoxPresenter = ServiceContainer.GetInstance<IThreadMsgBoxExamplePresenter>();
            this.ApplyPresenter(this.threadMsgBoxPresenter);
        }
        #endregion

        #region Private Methods

        #endregion

        #region CommandHandler

        #endregion

        #region EventHandler

        #endregion

        private void btnStartThread_Click(object sender, EventArgs e)
        {
            this.threadMsgBoxPresenter.StartTaskByThread();
        }

        private void btnStartLongTimeAction_Click(object sender, EventArgs e)
        {
            this.threadMsgBoxPresenter.StartTask();
        }
    }
}
