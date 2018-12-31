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
    //<!--MsgBoxExampleView 界面关联的 IMsgBoxExampleView 接口配置-->
    //<component instance-scope="singleinstance"
    //  type="BaseFrame.Examples.MsgViewExamples.MsgBoxExampleView, BaseFrame"
    //  service="BaseFrame.FrameInterface.ViewInterface.IMsgBoxExampleView, BaseFrame">
    //</component>

    /// <summary>
    /// MVP模式中的View页面：用于UI显示。
    /// </summary>
    /// <remarks>
    /// type="BaseFrame.Examples.MsgViewExamples.MsgBoxExampleView, BaseFrame"
    /// </remarks>
    public partial class MsgBoxExampleView : MultiDocSubForm, IMsgBoxExampleView
    {
        #region Fields
        private IMsgBoxExamplePresenter msgBoxExamplePresenter;
        #endregion

        #region Constructor
        /// <summary>
        /// MVP模式中的View页面：用于UI显示。
        /// </summary>
        public MsgBoxExampleView()
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
            this.msgBoxExamplePresenter = ServiceContainer.GetInstance<IMsgBoxExamplePresenter>();
            this.ApplyPresenter(this.msgBoxExamplePresenter);
        }
        #endregion

        #region Private Methods

        #endregion

        #region CommandHandler

        #endregion

        #region EventHandler
        private void btnShowError_Click(object sender, EventArgs e)
        {
            this.msgBoxExamplePresenter.HandleTaskShowError();
        }

        private void btnShowWarning_Click(object sender, EventArgs e)
        {
            this.msgBoxExamplePresenter.HandleTaskShowWarning();
        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            this.msgBoxExamplePresenter.HandleTaskShowMessage();
        }

        private void btnAskQuestion_Click(object sender, EventArgs e)
        {
            this.msgBoxExamplePresenter.HandleTaskAskQuestion();
        }

        private void btnShowCustomDialog_Click(object sender, EventArgs e)
        {
            this.msgBoxExamplePresenter.HandleTaskShowCustomDialog();
        }

        private void btnInputMsgBox_Click(object sender, EventArgs e)
        {
            this.msgBoxExamplePresenter.HandleTaskShowInputBox();
        }
        #endregion


    }
}
