using BaseFrame.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.FrameInterface.PresenterInterface
{
    /// <summary>
    /// MVP模式中的具体逻辑处理实现：IFileReaderPresenter。
    /// </summary>
    /// <remarks>
    /// service="BaseFrame.FrameInterface.PresenterInterface.IFileReaderPresenter, BaseFrame"
    /// </remarks>
    public interface IFileReaderPresenter : IPresenter
    {
        /// <summary>
        /// 开始选择并读取文件内容。
        /// </summary>
        void StartReadFile();
    }
}
