using BaseFrame.Interface;
using BaseFrame.Interface.ViewInterface;
using BaseFrame.View.MessageBoxViews;
using BaseFrame.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseFrame.Service
{
    /// <summary>
    /// Class with static methods to show message boxes.
    /// All text displayed using the MessageService is passed to the
    /// <see cref="StringParser"/> to replace ${res} markers.
    /// </summary>
    public class WinFormsMessageService : IDialogMessageService, IMessageService, IDependencyService
    {
        /// <summary>
        /// Gets/Sets the form used as owner for shown message boxes.
        /// </summary>
        public IWin32Window DialogOwner { get; set; }

        /// <summary>
        /// Gets/Sets the object used to synchronize message boxes shown on other threads.
        /// </summary>
        public ISynchronizeInvoke DialogSynchronizeInvoke { get; set; }

        /// <inheritdoc/>
        public string DefaultMessageBoxTitle { get; set; }

        /// <inheritdoc/>
        public string ProductName { get; set; }

        /// <summary>
        /// 创建IMessageService接口的实现：弹出界面提示。
        /// </summary>
        public WinFormsMessageService()
        {
            this.DefaultMessageBoxTitle = this.ProductName = "Flow";
        }

        void BeginInvoke(MethodInvoker method)
        {
            ISynchronizeInvoke si = DialogSynchronizeInvoke;
            if (si == null || !si.InvokeRequired)
                method();
            else
                si.BeginInvoke(method, null);
        }

        void Invoke(MethodInvoker method)
        {
            ISynchronizeInvoke si = DialogSynchronizeInvoke;
            if (si == null || !si.InvokeRequired)
                method();
            else
                si.Invoke(method, null);
        }

        /// <summary>
        /// 初始化对话框服务。
        /// </summary>
        /// <param name="dialogOwner"></param>
        /// <param name="dialogSynchronizeInvoker"></param>
        public void InitDialogMessageService(IWin32Window dialogOwner, ISynchronizeInvoke dialogSynchronizeInvoker)
        {
            this.DialogOwner = dialogOwner;
            this.DialogSynchronizeInvoke = dialogSynchronizeInvoker;
        }

        /// <summary>
        /// 初始化通过依赖注入初始化数据：在此方法中解决循环依赖问题。
        /// </summary>
        public void InitDependencyData()
        {
            IMainView mainView = ServiceContainer.GetInstance<IMainView>();
            this.InitDialogMessageService(mainView.MainWin32Window, mainView.SynchronizingObject);
        }

        /// <inheritdoc/>
        public virtual void ShowException(Exception ex, string message)
        {
            LoggingService.Error(message, ex);
            LoggingService.Warn("Stack trace of last exception log:\n" + Environment.StackTrace);
            if (ex != null)
            {
                message += "\n\nException occurred: " + ex.ToString();
            }
            DoShowMessage(message, ConstStringResources.GlobalErrorText, MessageBoxIcon.Error);
        }

        void DoShowMessage(string message, string caption, MessageBoxIcon icon)
        {
            BeginInvoke(
                delegate {
                    MessageBox.Show(DialogOwner,
                                    message, caption ?? DefaultMessageBoxTitle,
                                    MessageBoxButtons.OK, icon,
                                    MessageBoxDefaultButton.Button1, GetOptions(message, caption));
                });
        }

        /// <inheritdoc/>
        public void ShowError(string message)
        {
            LoggingService.Error(message);
            DoShowMessage(message, ConstStringResources.GlobalErrorText, MessageBoxIcon.Error);
        }

        /// <inheritdoc/>
        public void ShowWarning(string message)
        {
            LoggingService.Warn(message);
            DoShowMessage(message, ConstStringResources.GlobalWarningText, MessageBoxIcon.Warning);
        }

        /// <inheritdoc/>
        public void ShowMessage(string message, string caption)
        {
            LoggingService.Info(message);
            DoShowMessage(message, caption, MessageBoxIcon.Information);
        }

        /// <inheritdoc/>
        public void ShowErrorFormatted(string formatstring, params object[] formatitems)
        {
            LoggingService.Error(formatstring);
            DoShowMessage(StringParser.Format(formatstring, formatitems), ConstStringResources.GlobalErrorText, MessageBoxIcon.Error);
        }

        /// <inheritdoc/>
        public void ShowWarningFormatted(string formatstring, params object[] formatitems)
        {
            LoggingService.Warn(formatstring);
            DoShowMessage(StringParser.Format(formatstring, formatitems), ConstStringResources.GlobalWarningText, MessageBoxIcon.Warning);
        }

        /// <inheritdoc/>
        public void ShowMessageFormatted(string formatstring, string caption, params object[] formatitems)
        {
            LoggingService.Info(formatstring);
            DoShowMessage(StringParser.Format(formatstring, formatitems), caption, MessageBoxIcon.Information);
        }

        /// <inheritdoc/>
        public bool AskQuestion(string question, string caption)
        {
            DialogResult result = DialogResult.None;
            Invoke(
                delegate {
                    result = MessageBox.Show(DialogOwner,
                                             question,
                                             caption ?? ConstStringResources.GlobalQuestionText,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question,
                                             MessageBoxDefaultButton.Button1,
                                             GetOptions(question, caption));
                });
            return result == DialogResult.Yes;
        }

        static MessageBoxOptions GetOptions(string text, string caption)
        {
            return IsRtlText(text) ? MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign : 0;
        }

        static bool IsRtlText(string text)
        {
            if (!RightToLeftConverter.IsRightToLeft)
                return false;
            foreach (char c in text)
            {
                if (char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherLetter)
                    return true;
            }
            return false;
        }

        /// <inheritdoc/>
        public int ShowCustomDialog(string caption, string dialogText, int acceptButtonIndex, int cancelButtonIndex, params string[] buttontexts)
        {
            int result = 0;
            Invoke(
                delegate {
                    using (CustomDialog messageBox = new CustomDialog(caption, dialogText, acceptButtonIndex, cancelButtonIndex, buttontexts))
                    {
                        messageBox.ShowDialog(DialogOwner);
                        result = messageBox.Result;
                    }
                });
            return result;
        }

        /// <inheritdoc/>
        public string ShowInputBox(string caption, string dialogText, string defaultValue)
        {
            string result = null;
            Invoke(
                delegate {
                    using (InputBox inputBox = new InputBox(dialogText, caption, defaultValue))
                    {
                        inputBox.ShowDialog(DialogOwner);
                        result = inputBox.Result;
                    }
                });
            return result;
        }

        ////public void InformSaveError(FileName fileName, string message, string dialogName, Exception exceptionGot)
        ////{
        ////    BeginInvoke(
        ////        delegate {
        ////            using (SaveErrorInformDialog dlg = new SaveErrorInformDialog(fileName, message, dialogName, exceptionGot))
        ////            {
        ////                dlg.ShowDialog(DialogOwner);
        ////            }
        ////        });
        ////}

        ////public ChooseSaveErrorResult ChooseSaveError(FileName fileName, string message, string dialogName, Exception exceptionGot, bool chooseLocationEnabled)
        ////{
        ////    ChooseSaveErrorResult r = ChooseSaveErrorResult.Ignore;
        ////    Invoke(
        ////        delegate {
        ////            restartlabel:
        ////            using (SaveErrorChooseDialog dlg = new SaveErrorChooseDialog(fileName, message, dialogName, exceptionGot, chooseLocationEnabled))
        ////            {
        ////                switch (dlg.ShowDialog(DialogOwner))
        ////                {
        ////                    case DialogResult.OK:
        ////                        // choose location:
        ////                        using (SaveFileDialog fdiag = new SaveFileDialog())
        ////                        {
        ////                            fdiag.OverwritePrompt = true;
        ////                            fdiag.AddExtension = true;
        ////                            fdiag.CheckFileExists = false;
        ////                            fdiag.CheckPathExists = true;
        ////                            fdiag.Title = "Choose alternate file name";
        ////                            fdiag.FileName = fileName;
        ////                            if (fdiag.ShowDialog() == DialogResult.OK)
        ////                            {
        ////                                r = ChooseSaveErrorResult.SaveAlternative(FileName.Create(fdiag.FileName));
        ////                                break;
        ////                            }
        ////                            else
        ////                            {
        ////                                goto restartlabel;
        ////                            }
        ////                        }
        ////                    case DialogResult.Retry:
        ////                        r = ChooseSaveErrorResult.Retry;
        ////                        break;
        ////                    default:
        ////                        r = ChooseSaveErrorResult.Ignore;
        ////                        break;
        ////                }
        ////            }
        ////        });
        ////    return r;
        ////}

        /// <inheritdoc/>
        public void ShowHandledException(Exception ex, string message = null)
        {
            LoggingService.Error(message, ex);
            LoggingService.Warn("Stack trace of last exception log:\n" + Environment.StackTrace);
            if (message == null)
            {
                message = ex.Message;
            }
            else
            {
                message = message + "\r\n\r\n" + ex.Message;
            }
            DoShowMessage(message, ConstStringResources.GlobalErrorText, MessageBoxIcon.Error);
        }
    }
}
