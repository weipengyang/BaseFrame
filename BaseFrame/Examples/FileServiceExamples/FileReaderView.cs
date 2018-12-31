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

namespace BaseFrame.View.MultiDocView
{
    /*
     *请将下面块注释中xml格式的配置数据复制到“./Configuration/autofac.config”文件中。
     * 
    <!--FileReaderView 界面关联的 IFileReaderView 接口配置-->
    <component instance-scope="singleinstance"
      type="BaseFrame.View.MultiDocView.FileReaderView, BaseFrame">
      <services>
        <service type="BaseFrame.FrameInterface.ViewInterface.IFileReaderView, BaseFrame"/>
        <service type="BaseFrame.Interface.IDependencyService, BaseFrame"/>
      </services>
    </component>
    */

    /// <summary>
    /// MVP模式中的View页面：用于UI显示。
    /// </summary>
    /// <remarks>
    /// type="BaseFrame.View.MultiDocView.FileReaderView, BaseFrame"
    /// </remarks>
    public partial class FileReaderView : MultiDocSubForm, IFileReaderView
    {
        #region Fields
        private IFileReaderPresenter fileReaderPresenter;
        #endregion

        #region Constructor
        /// <summary>
        /// MVP模式中的View页面：用于UI显示。
        /// </summary>
        public FileReaderView()
        {
            InitializeComponent();
        }


        #endregion

        #region Properties

        #endregion

        #region Public Methods
        /// <summary>
        /// 显示文件内容。
        /// </summary>
        /// <param name="content"></param>
        public void ShowFileContent(string content)
        {
            if (this.txtbFileContent.InvokeRequired)
            {
                this.Invoke(new Action<string>(ShowInfo), content);
                return;
            }
            ShowInfo(content);
        }
        #endregion

        #region Protected Methods
        /// <summary>
        /// 内部数据初始化。
        /// </summary>
        protected override void InternalInitData()
        {
            fileReaderPresenter = ServiceContainer.GetInstance<IFileReaderPresenter>();
            this.ApplyPresenter(fileReaderPresenter);
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
            this.txtbFileContent.Text = info;
        }
        #endregion

        #region CommandHandler

        #endregion

        #region EventHandler

        #endregion

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            this.fileReaderPresenter.StartReadFile();
        }
    }
}
