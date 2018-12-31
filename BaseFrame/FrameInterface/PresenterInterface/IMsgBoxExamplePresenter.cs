using BaseFrame.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.FrameInterface.PresenterInterface
{
    /// <summary>
    /// MVP模式中的具体逻辑处理实现：IMsgBoxExamplePresenter。
    /// </summary>
    /// <remarks>
    /// service="BaseFrame.FrameInterface.PresenterInterface.IMsgBoxExamplePresenter, BaseFrame"
    /// </remarks>
    public interface IMsgBoxExamplePresenter : IPresenter
    {
        void HandleTaskShowError();

        void HandleTaskShowWarning();

        void HandleTaskShowMessage();

        void HandleTaskAskQuestion();

        void HandleTaskShowInputBox();

        void HandleTaskShowCustomDialog();
    }
}
