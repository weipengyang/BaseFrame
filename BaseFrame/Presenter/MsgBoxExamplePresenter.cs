using BaseFrame.FrameInterface.PresenterInterface;
using BaseFrame.FrameInterface.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaseFrame.Interface;
using BaseFrame.Utility;
using BaseFrame.View.MessageBoxViews;

namespace BaseFrame.Presenter
{
    //<!--MsgBoxExamplePresenter View 界面关联的 IMsgBoxExamplePresenter 接口配置-->
    //<component instance-scope="singleinstance"
    //  type="BaseFrame.Presenter.MsgBoxExamplePresenter, BaseFrame"
    //  service="BaseFrame.FrameInterface.PresenterInterface.IMsgBoxExamplePresenter, BaseFrame">
    //</component>

    /// <summary>
    /// MVP模式中View页面对应的Presenter：用于后台逻辑处理。
    /// </summary>
    /// <remarks>
    /// type="BaseFrame.Presenter.MsgBoxExamplePresenter, BaseFrame"
    /// </remarks>
    public class MsgBoxExamplePresenter : BasePresenter, IMsgBoxExamplePresenter
    {
        #region Fields
        private IMsgBoxExampleView msgBoxExampleView;

        string msgShort = "人生何其短，切莫入错行。";

        string caption = "Title-ShowMessageViewExampleForm";

        string fmtMsg = "DateTime:{0:yyyy-MM-dd HH:mm:ss.fff};int:{1};string:{2}.";

        string msg = "人生何其短，切莫入错行。----创意无处不在—Life's Too Short for the Wrong Job 这是Scholz & Friends 广告公司为德国的一个招聘网站Jobsintown.de做的一个系列广告 “Life's Too Short for the Wrong Job”，非常有创意。";
        #endregion

        #region Constructor
        /// <summary>
        /// MVP模式中View页面对应的Presenter：用于后台逻辑处理。
        /// </summary>
        public MsgBoxExamplePresenter()
        {
        }
        #endregion

        #region Properties

        #endregion

        #region Public Methods
        public void HandleTaskShowError()
        {
            ServiceContainer.MessageService.ShowError(msg);
        }

        public void HandleTaskShowWarning()
        {
            ServiceContainer.MessageService.ShowWarning(msg);
        }

        public void HandleTaskShowMessage()
        {
            ServiceContainer.MessageService.ShowMessage(msg);
        }

        public void HandleTaskAskQuestion()
        {
            bool questResult = ServiceContainer.MessageService.AskQuestion(msg, "AskQuestion");

            LogMsg(questResult.ToString());
            ServiceContainer.MessageService.ShowMessageFormatted("AskQuestion选择结果：{0}", "AskQuestion选择结果", questResult);
        }

        public void HandleTaskShowInputBox()
        {
            string msg = ServiceContainer.MessageService.ShowInputBox("ShowInputBox", "请输入名称：", "default");
            LogMsg(msg);
            ServiceContainer.MessageService.ShowMessageFormatted("ShowInputBox 输入结果:{0}{1}", "ShowInputBox 输入结果", Environment.NewLine, msg);
        }

        public void HandleTaskShowCustomDialog()
        {
            int result = ServiceContainer.MessageService.ShowCustomDialog("ShowCustomDialog 长消息", msg,
                                                                        0, 3,
                                                                        ConstStringResources.GlobalOKButtonText,
                                                                        ConstStringResources.GlobalYesToAll,
                                                                        ConstStringResources.GlobalCloseButtonText,
                                                                        ConstStringResources.GlobalCancelButtonText);
            LogMsg(result.ToString());
            ServiceContainer.MessageService.ShowMessageFormatted("ShowCustomDialog 长消息 选择的按钮下标：{0}", "ShowCustomDialog 长消息 选择的按钮下标", result);

            result = ServiceContainer.MessageService.ShowCustomDialog("ShowCustomDialog 短消息", msgShort,
                                                                        0, 2,
                                                                        ConstStringResources.GlobalOKButtonText,
                                                                        //ConstStringResources.GlobalYesToAll,
                                                                        ConstStringResources.GlobalCloseButtonText,
                                                                        ConstStringResources.GlobalCancelButtonText);
            LogMsg(result.ToString());
            ServiceContainer.MessageService.ShowMessageFormatted("ShowCustomDialog 短消息 选择的按钮下标：{0}", "ShowCustomDialog 短消息 选择的按钮下标", result);
        }
        #endregion

        #region Protected Methods
        /// <summary>
        /// 初始化Presenter数据：在此方法中解决循环依赖问题。
        /// </summary>
        protected override void InternalInitData()
        {
            this.msgBoxExampleView = ServiceContainer.GetInstance<IMsgBoxExampleView>();
            this.AttachView(this.msgBoxExampleView);
        }
        #endregion

        #region Private Methods
        void LogMsg(string msg)
        {
            System.Diagnostics.Trace.Write("LogMsg:");
            System.Diagnostics.Trace.WriteLine(msg);
        }
        #endregion

        #region CommandHandler

        #endregion

        #region EventHandler

        #endregion
    }
}
