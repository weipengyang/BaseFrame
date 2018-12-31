using BaseFrame.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.FrameInterface.PresenterInterface
{
    /// <summary>
    /// MVP模式中的具体逻辑处理实现：IThreadMsgBoxExamplePresenter。
    /// </summary>
    /// <remarks>
    /// service="BaseFrame.FrameInterface.PresenterInterface.IThreadMsgBoxExamplePresenter, BaseFrame"
    /// </remarks>
    public interface IThreadMsgBoxExamplePresenter : IPresenter
    {
        /// <summary>
        /// 当前调用线程中执行任务处理。
        /// </summary>
        void StartTask();

        /// <summary>
        /// 后台线程执行任务处理。
        /// </summary>
        void StartTaskByThread();
    }
}
