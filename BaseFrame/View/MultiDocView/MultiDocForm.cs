using System;
using System.Windows.Forms;
using BaseFrame.Interface;
using BaseFrame.Presenter;
using BaseFrame.Utility;
using BaseFrame.Interface.ViewInterface;
using System.ComponentModel;
using DevComponents.DotNetBar;
using System.Drawing;
using BaseFrame.FrameInterface.ViewInterface;
using BaseFrame.FrameInterface.PresenterInterface;

namespace BaseFrame.MultiDocView
{
    /// <summary>
    /// 多文档窗体。
    /// </summary>
    public partial class MultiDocForm : BaseMultiDocForm, IMultiDocForm, IMainView
    {
        #region Fields
        private IMultiDocFormPresenter presenter;

        private IMultiDocSubForm _multiDocSubForm;
        #endregion

        #region Constructor
        /// <summary>
        /// 创建多文档窗体。
        /// </summary>
        public MultiDocForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        /////// <summary>
        /////// 代表当前App的主窗体，一般只用于设置弹出框的归属。
        /////// The main window as IWin32Window.
        /////// </summary>
        ////public IWin32Window MainWin32Window
        ////{
        ////    get
        ////    {
        ////        return this;
        ////    }
        ////}

        /////// <summary>
        /////// 提供同步或异步执行委托的方法：一般只用于操作界面元素。
        /////// </summary>
        ////public ISynchronizeInvoke SynchronizingObject
        ////{
        ////    get
        ////    {
        ////        return this;
        ////    }
        ////}
        #endregion

        #region Public Methods

        #endregion

        #region Protected Methods
        /// <summary>
        /// 初始化Presenter数据：在此方法中解决循环依赖问题，默认绑定页面关联的Presenter接口实现。
        /// </summary>
        protected override void InternalInitData()
        {
            this.presenter = ServiceContainer.GetInstance<IMultiDocFormPresenter>();
            this.ApplyPresenter(this.presenter);
        }
        #endregion

        #region Private Methods

        #endregion

        #region CommandHandler

        #endregion

        #region EventHandler
        private void rbnitmManageMsgBox_Click(object sender, EventArgs e)
        {
            this.ChangeView(ServiceContainer.GetInstance<IMsgBoxExampleView>());
        }

        private void rbnitmThreadMsgBox_Click(object sender, EventArgs e)
        {
            this.ChangeView(ServiceContainer.GetInstance<IThreadMsgBoxExampleView>());
        }
        #endregion
    }
}
