using BaseFrame.MultiDocView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.FrameInterface.ViewInterface
{
    /// <summary>
    /// MVP模式中的页面接口：IFileReaderView。
    /// </summary>
    /// <remarks>
    /// service="BaseFrame.FrameInterface.ViewInterface.IFileReaderView, BaseFrame"
    /// </remarks>
    public interface IFileReaderView : IMultiDocSubForm
    {
        /// <summary>
        /// 显示文件内容。
        /// </summary>
        /// <param name="content"></param>
        void ShowFileContent(string content);
    }
}
