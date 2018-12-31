using System;
using System.Windows.Forms;
using BaseFrame.BaseMvpInfrastructure.Model;
using BaseFrame.Interface;
using BaseFrame.MultiDocView;
using BaseFrame.Presenter;
using BaseFrame.SingleDocView;
using BaseFrame.Utility;
using BaseFrame.Interface.ViewInterface;
using System.ComponentModel;

namespace BaseFrame.View.SingleDocView
{
    /// <summary>
    /// 单文档类窗体
    /// </summary>
    public partial class SingleDocForm : BaseSingleDocForm, ISingleDocForm, IMainView
    {
        #region Field
        /// <summary>
        /// 业务presenter
        /// </summary>
        private ISingleDocFormPresenter presenter = null; 
        #endregion

        #region Properties
        #endregion

        #region Constructor
        /// <summary>
        /// 构造函数
        /// </summary>
        public SingleDocForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// 清空日志消息。
        /// </summary>
        public void ClearLogMsg()
        {
            txtShowInfo.Clear();
        }

        /// <summary>
        /// 获取日志消息。
        /// </summary>
        /// <returns></returns>
        public string GetLogMsg()
        {
            return this.txtShowInfo.Text;
        }

        /// <summary>
        /// 刷新界面
        /// </summary>
        /// <param name="dataObj">要刷新的数据</param>
        public override void RefreshView(object dataObj)
        {
            try
            {
                string logInfo = (string)dataObj;
                txtShowInfo.AppendText(logInfo);
            }
            catch (Exception ex)
            {
                Constants.log.Error("[SingleDocForm][RefreshView] 刷新界面异常，异常信息,", ex);
            }
        }

        /// <summary>
        /// 显示页面内容，如果textbox是在主线程上，则直接赋值，否则需要invoke显示
        /// </summary>
        /// <param name="info">要显示的信息</param>
        public void ShowMsgInfo(string info)
        {
            if (this.txtShowInfo.InvokeRequired)
            {
                this.Invoke(new Action<string>(ShowInfo), info);
                return;
            }
            ShowInfo(info);
        }
        #endregion

        #region Protected Methods
        /// <summary>
        /// 初始化Presenter数据：在此方法中解决循环依赖问题，默认绑定页面关联的Presenter接口实现。
        /// </summary>
        protected override void InternalInitData()
        {
            this.presenter = ServiceContainer.GetInstance<ISingleDocFormPresenter>();
            this.ApplyPresenter(this.presenter);
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// 在textbox框上显示信息，当textbox框上的内容超过1000行时，
        /// 则清除textbox框上的内容，否则在textbox框上追加
        /// </summary>
        /// <param name="info">要显示的信息</param>
        private void ShowInfo(string info)
        {
            int lineCount = txtShowInfo.Lines.Length;
            if (lineCount > 1000)
            {
                txtShowInfo.Text = "";
            }
            if (string.IsNullOrEmpty(info))
            {
                txtShowInfo.Text = "";
                return;
            }
            txtShowInfo.AppendText(info);
        } 
        #endregion

        #region EventHandlers
        /// <summary>
        /// 开始接收日志按钮事件
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            presenter.StartReceiveLog();
        }

        /// <summary>
        /// 结束接收日志按钮事件
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            presenter.StopReceiveLog();
        }

        /// <summary>
        /// 保存功能
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            presenter.SaveLogInfo(txtShowInfo.Text);
        }

        /// <summary>
        /// 查找功能
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 清空功能
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearLogMsg();
        } 
        #endregion
    }
}
