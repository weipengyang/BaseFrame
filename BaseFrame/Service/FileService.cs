using BaseFrame.Interface.ViewInterface;
using BaseFrame.Utility;
using BaseFrame.Utility.Files;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseFrame.Service
{
    /// <summary>
    /// 文件服务。
    /// </summary>
    public sealed class FileService : IFileService
    {
        #region BrowseForFolder
        /// <summary>
        /// 显示选择文件夹对话框。
        /// Shows a 'browse for folder' dialog.
        /// </summary>
        /// <param name="description">Description shown in the dialog.</param>
        /// <param name="selectedPath">Optional: Initially selected folder.</param>
        /// <returns>The selected folder; or <c>null</c> if the user cancelled the dialog.</returns>
        public string BrowseForFolder(string description, string selectedPath)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = StringParser.Parse(description);
                if (selectedPath != null && selectedPath.Length > 0 && Directory.Exists(selectedPath))
                {
                    dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                    dialog.SelectedPath = selectedPath;
                }
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.SelectedPath;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 显示保存文件对话框。
        /// Shows a 'save file dialog' dialog.
        /// </summary>
        /// <param name="fileCreationInfo"></param>
        /// <returns></returns>
        public string BrowseForNewFile(FileCreationInfo fileCreationInfo)
        {
            string fileFullName = string.Empty;
            //OpenFileDialog
            using (SaveFileDialog fdiag = new SaveFileDialog())
            {
                fdiag.AddExtension = true;
                if (!string.IsNullOrEmpty(fileCreationInfo.ExtensionNameWithDot))
                {
                    fdiag.DefaultExt = fileCreationInfo.ExtensionNameWithDot;
                }
                if (!string.IsNullOrWhiteSpace(fileCreationInfo.FileFilter))
                {
                    fdiag.Filter = fileCreationInfo.FileFilter;
                }
                if (fileCreationInfo.DefualtFileName != null && fileCreationInfo.DefualtFileName.Length > 0)
                {
                    fdiag.FileName = fileCreationInfo.DefualtFileName;
                }
                fdiag.FilterIndex = 0;
                if (string.IsNullOrEmpty(fileCreationInfo.Description))
                {
                    fdiag.Title = "请选择文件的保存位置和名称";
                }
                else
                {
                    fdiag.Title = fileCreationInfo.Description;
                }
                if (fileCreationInfo.InitialPath != null && fileCreationInfo.InitialPath.Length > 0 && Directory.Exists(fileCreationInfo.InitialPath))
                {
                    fdiag.InitialDirectory = fileCreationInfo.InitialPath;
                }

                //fdiag.CheckFileExists = true;
                fdiag.CheckPathExists = true;

                if (fdiag.ShowDialog(ServiceContainer.GetInstance<IMainView>().MainWin32Window) == DialogResult.OK)
                {
                    fileFullName = fdiag.FileNames.FirstOrDefault();
                }
            }
            return fileFullName;
        }

        /// <summary>
        /// 显示选择并打开文件对话框。
        /// </summary>
        /// <param name="fileOpenningInfo"></param>
        /// <returns></returns>
        public IList<FileName> BrowseForOpenFile(FileOpeningInfo fileOpenningInfo)
        {
            List<FileName> lst = null;
            using (OpenFileDialog fdiag = new OpenFileDialog())
            {
                fdiag.AddExtension = true;
                if (!string.IsNullOrWhiteSpace(fileOpenningInfo.FileFilter))
                {
                    fdiag.Filter = fileOpenningInfo.FileFilter;
                }
                fdiag.FilterIndex = 0;
                fdiag.Multiselect = fileOpenningInfo.CanMultiSelect;
                fdiag.CheckFileExists = true;

                if (fdiag.ShowDialog(ServiceContainer.GetInstance<IMainView>().MainWin32Window) == DialogResult.OK)
                {
                    lst = Array.ConvertAll(fdiag.FileNames, FileName.Create).ToList();
                }
            }
            return lst;
        }
        #endregion

        #region OpenAndSelectFile
        /// <summary>
        /// 打开目录，并选中指定文件。
        /// 此方法是以后台线程方式处理（System.Threading.Tasks.Task）。
        /// </summary>
        /// <param name="fileFullName"></param>
        /// <returns></returns>
        public bool OpenAndSelectFile(string fileFullName)
        {
            bool success = false;
            try
            {
                System.Threading.Tasks.Task tsk = new System.Threading.Tasks.Task(
                    delegate ()
                    {
                        Process.Start("Explorer.exe", string.Concat("/select,", fileFullName));
                    });
                tsk.Start();
                //Process.Start("Explorer.exe", string.Concat("/select,", fileFullName));
                success = true;
            }
            catch (Exception err)
            {
                LoggingService.Error("FileService.OpenAndSelectFile Error: " + err.Message, err);
                success = false;
            }
            return success;
        }
        #endregion
    }
}
