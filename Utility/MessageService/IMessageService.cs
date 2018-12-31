using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Utility
{
    /// <summary>
    /// Interface for the MessageService.
    /// </summary>
    public interface IMessageService
    {
        /// <summary>
        /// 获取当前主应用程序的名称。
        /// Gets the application product name.
        /// </summary>
        string ProductName { get; }

        /// <summary>
        /// 获取消息框的默认标题。
        /// Gets the default message box title.
        /// </summary>
        string DefaultMessageBoxTitle { get; }

        /// <summary>
        /// 显示异常信息错误提示框。
        /// Shows an exception.
        /// </summary>
        void ShowException(Exception ex, string message = null);

        /// <summary>
        /// 显示已处理完的异常消息提示框。
        /// Shows an exception.
        /// </summary>
        void ShowHandledException(Exception ex, string message = null);

        /// <summary>
        /// 显示错误消息提示框。
        /// Shows an error.
        /// </summary>
        /// <param name="message"></param>
        void ShowError(string message);

        /// <summary>
        /// 显示警告消息提示框。
        /// Shows a warning message.
        /// </summary>
        /// <param name="message"></param>
        void ShowWarning(string message);

        /// <summary>
        /// 显示普通消息提示框。
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="caption">提示框的标题</param>
        void ShowMessage(string message, string caption = null);

        /// <summary>
        /// 显示错误消息提示框，通过string.Format(string, object)方法，将formatitems参数赋值到formatstring格式化字符串参数中。
        /// </summary>
        /// <param name="formatstring">带有格式化字符串的参数，例如：“时间:{0:yyyy-MM-dd HH:mm:ss.fff}; 个数:{1}; 消息:{2}.”</param>
        /// <param name="formatitems">格式化字符串中需要的参数变量，例如：“DateTime.Now, 123, "格式化错误消息"”</param>
        void ShowErrorFormatted(string formatstring, params object[] formatitems);

        /// <summary>
        /// 显示警告消息提示框，通过string.Format(string, object)方法，将formatitems参数赋值到formatstring格式化字符串参数中。
        /// </summary>
        /// <param name="formatstring">带有格式化字符串的参数，例如：“时间:{0:yyyy-MM-dd HH:mm:ss.fff}; 个数:{1}; 消息:{2}.”</param>
        /// <param name="formatitems">格式化字符串中需要的参数变量，例如：“DateTime.Now, 123, "格式化错误消息"”</param>
        void ShowWarningFormatted(string formatstring, params object[] formatitems);

        /// <summary>
        /// 显示普通消息提示框，通过string.Format(string, object)方法，将formatitems参数赋值到formatstring格式化字符串参数中。
        /// </summary>
        /// <param name="formatstring">带有格式化字符串的参数，例如：“时间:{0:yyyy-MM-dd HH:mm:ss.fff}; 个数:{1}; 消息:{2}.”</param>
        /// <param name="caption">提示框的标题</param>
        /// <param name="formatitems">格式化字符串中需要的参数变量，例如：“DateTime.Now, 123, "格式化错误消息"”</param>
        void ShowMessageFormatted(string formatstring, string caption, params object[] formatitems);

        /// <summary>
        /// 询问用户 是/否 的问题， 并且“是”按钮为窗体回车键默认触发的按钮。
        /// Asks the user a Yes/No question, using "Yes" as the default button.
        /// Returns <c>true</c> if yes was clicked, <c>false</c> if no was clicked.
        /// </summary>
        /// <param name="question"></param>
        /// <param name="caption"></param>
        /// <returns>点击 “是”返回 true； 点击 “否” 则返回 false。</returns>
        bool AskQuestion(string question, string caption = null);

        /// <summary>
        /// 显示消息自定义对话框。
        /// </summary>
        /// <param name="caption">对话框的标题。</param>
        /// <param name="dialogText">对话框需要显示的描述信息。</param>
        /// <param name="acceptButtonIndex">
        /// 默认按钮的下标：回车键默认触发的按钮下标，从0开始。 如果不需要设置，则传入 -1。
        /// </param>
        /// <param name="cancelButtonIndex">
        /// 取消按钮对应的下标：从0开始。 如果不需要设置，则传入 -1。
        /// </param>
        /// <param name="buttontexts">各个按钮对应的的Text描述。</param>
        /// <returns>
        /// 返回用户所点击的按钮的下标。如果没有点击任何按钮，直接关闭对话框，则会返回 -1。
        /// The number of the button that was clicked, or -1 if the dialog was closed  without clicking a button.
        /// </returns>
        int ShowCustomDialog(string caption, string dialogText, int acceptButtonIndex, int cancelButtonIndex, params string[] buttontexts);

        /// <summary>
        /// 显示用户输入信息框。
        /// Shows an input box.
        /// </summary>
        /// <param name="caption"></param>
        /// <param name="dialogText"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        string ShowInputBox(string caption, string dialogText, string defaultValue);
    }
}
