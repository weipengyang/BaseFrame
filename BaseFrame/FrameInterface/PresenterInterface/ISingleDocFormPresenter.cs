using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Presenter
{
    /// <summary>
    /// 单窗体结构对应的Presenter接口。
    /// </summary>
    public interface ISingleDocFormPresenter : ISingleDocPresenter
    {
        /// <summary>
        /// 开始接收日志
        /// </summary>
        void StartReceiveLog();

        /// <summary>
        /// 停止接收日志
        /// </summary>
        void StopReceiveLog();

        /// <summary>
        /// 保存日志信息到日志文件中
        /// </summary>
        /// <param name="logInfo">日志信息</param>
        void SaveLogInfo(string logInfo);

        /// <summary>
        /// 保存日志信息到日志文件中
        /// </summary>
        /// <param name="fileName">日志文件名称</param>
        /// <param name="logInfo">日志信息</param>
        void SaveLogInfo(string fileName, string logInfo);
    }
}
