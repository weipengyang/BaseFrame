using BaseFrame.FrameInterface.PresenterInterface;
using BaseFrame.FrameInterface.ViewInterface;
using BaseFrame.Utility;
using BaseFrame.Utility.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Presenter
{
    /*
     *请将下面块注释中xml格式的配置数据复制到“./Configuration/autofac.config”文件中。
     * 
    <!--FileReaderPresenter View 界面关联的 IFileReaderPresenter 接口配置-->
    <component instance-scope="singleinstance"
      type="BaseFrame.Presenter.FileReaderPresenter, BaseFrame">
      <services>
        <service type="BaseFrame.FrameInterface.PresenterInterface.IFileReaderPresenter, BaseFrame"/>
        <service type="BaseFrame.Interface.IDependencyService, BaseFrame"/>
      </services>
    </component>
    */

    /// <summary>
    /// MVP模式中View页面对应的Presenter：用于后台逻辑处理。
    /// </summary>
    /// <remarks>
    /// type="BaseFrame.Presenter.FileReaderPresenter, BaseFrame"
    /// </remarks>
    public class FileReaderPresenter : BasePresenter, IFileReaderPresenter
    {
        #region Fields
        /// <summary>
        /// 文件处理界面显示接口。
        /// </summary>
        private IFileReaderView fileReaderView;
        #endregion

        #region Constructor
        /// <summary>
        /// MVP模式中View页面对应的Presenter：用于后台逻辑处理。
        /// </summary>
        public FileReaderPresenter()
        {
        }
        #endregion

        #region Properties

        #endregion

        #region Public Methods
        /// <summary>
        /// 开始选择并读取文件内容。
        /// </summary>
        public void StartReadFile()
        {
            IList<FileName> lstFiles = ServiceContainer.FileService.BrowseForOpenFile(new BaseFrame.Utility.Files.FileOpeningInfo()
            {
                CanMultiSelect = false,
                Description = "请选择text文件",
                FileFilter = @"文本文件|*.txt",
            });

            if(lstFiles == null || lstFiles.Count<=0)
            {
                return;
            }

            FileName file = lstFiles.First();
            string allText = System.IO.File.ReadAllText(file, Encoding.Default);
            fileReaderView.ShowFileContent(allText);
        }
        #endregion

        #region Protected Methods
        /// <summary>
        /// 内部数据的初始化。
        /// </summary>
        protected override void InternalInitData()
        {
            fileReaderView = ServiceContainer.GetInstance<IFileReaderView>();
            this.AttachView(fileReaderView);
        }
        #endregion

        #region Private Methods

        #endregion

        #region CommandHandler

        #endregion

        #region EventHandler

        #endregion
    }
}
