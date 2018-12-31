using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Utility.Files
{
    /// <summary>
    /// 文件相关的服务接口。
    /// </summary>
    public interface IFileService
    {
        #region BrowseForFolder
        /// <summary>
        /// 显示选择文件夹对话框。
        /// Shows a 'browse for folder' dialog.
        /// </summary>
        /// <param name="description">Description shown in the dialog.</param>
        /// <param name="selectedPath">Optional: Initially selected folder.</param>
        /// <returns>The selected folder; or <c>null</c> if the user cancelled the dialog.</returns>
        string BrowseForFolder(string description, string selectedPath = null);
        #endregion

        #region BrowseForFiles
        /// <summary>
        /// 显示保存文件对话框。
        /// Shows a 'save file dialog' dialog.
        /// </summary>
        /// <param name="fileCreationInfo"></param>
        /// <returns></returns>
        string BrowseForNewFile(FileCreationInfo fileCreationInfo);

        /// <summary>
        /// 显示选择并打开文件对话框。
        /// </summary>
        /// <param name="fileOpenningInfo"></param>
        /// <returns></returns>
        IList<FileName> BrowseForOpenFile(FileOpeningInfo fileOpenningInfo);
        #endregion

        #region OpenAndSelectFile
        /// <summary>
        /// 打开目录，并选中指定文件。
        /// </summary>
        /// <param name="fileFullName"></param>
        /// <returns></returns>
        bool OpenAndSelectFile(string fileFullName);
        #endregion
    }
}
