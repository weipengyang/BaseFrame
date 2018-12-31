using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseFrame.Interface;
using BaseFrame.SingleDocView;
using BaseFrame.Model;
using System.IO;
using BaseFrame.BaseMvpInfrastructure.Model;
using BaseFrame.Utility;
using SNBC.DotNetBaseLibrary.SocketUtils;

namespace BaseFrame.Presenter
{
    /// <summary>
    /// 
    /// </summary>
    public class SingleDocFormPresenter : BasePresenter, ISingleDocFormPresenter
    {
        #region 私有变量

        /// <summary>
        /// socket
        /// </summary>
        private UdpHelper socketHelper = null;

        /// <summary>
        /// 与presenter绑定的页面
        /// </summary>
        private ISingleDocForm singleDocView;

        /// <summary>
        /// IP地址
        /// </summary>
        private string ipAddress = "";

        /// <summary>
        /// 端口号
        /// </summary>
        private string port = "";

        #endregion

        /// <summary>
        /// 页面加载时的业务处理
        /// </summary>
        protected override void OnHandleViewLoaded()
        {
            //读取配置文件
            ReadConfig();
            if (!string.IsNullOrWhiteSpace(ipAddress) && !string.IsNullOrWhiteSpace(port))
            {
                //初始化udp
                socketHelper = new UdpHelper(ipAddress, int.Parse(port));
            }
        }

        /// <summary>
        /// 初始化Presenter数据：在此方法中解决循环依赖问题。
        /// </summary>
        protected override void InternalInitData()
        {
            this.singleDocView = ServiceContainer.GetInstance<ISingleDocForm>();
            this.AttachView(this.singleDocView);
        }

        /// <summary>
        /// 开始启动接收日志
        /// </summary>
        public void StartReceiveLog()
        {

            try
            {
                if (socketHelper != null)
                {
                    socketHelper.SetReceiveFunction(ReceiveData);
                }
            }
            catch (Exception ex)
            {
                Constants.log.Error("[SingleDocFormPresenter][StartReceiveLog] 开始接收日志异常，异常信息：", ex);
                ServiceContainer.MessageService.ShowError("开始接收日志错误，原因：" + ex.Message);
            }
        }

        /// <summary>
        /// 接收到数据后的处理
        /// </summary>
        /// <param name="receiveData">接收到的数据</param>
        /// <param name="peerIp">远程的ip地址</param>
        /// <param name="peerPort">远程的端口号</param>
        public void ReceiveData(byte[] receiveData, string peerIp, int peerPort)
        {
            string logInfo = Encoding.UTF8.GetString(receiveData);
            Constants.log.Info("[SingleDocFormPresenter][ReceiveData] 接收到数据，数据为：" + logInfo);
            //接收到数据以后要通知到界面上
            singleDocView.RefreshView(logInfo);
        }

        /// <summary>
        /// 结束接收日志
        /// </summary>
        public void StopReceiveLog()
        {
            try
            {
                if (socketHelper != null)
                {
                    socketHelper.Close();
                }
            }
            catch (Exception ex)
            {
                Constants.log.Error("[SingleDocForm][btnStop_Click] 结束接收日志异常，异常信息：", ex);
                ServiceContainer.MessageService.ShowError("结束接收日志错误，原因：" + ex.Message);
            }
        }

        /// <summary>
        /// 保存日志信息到日志文件中
        /// </summary>
        /// <param name="fileName">日志文件名称</param>
        /// <param name="logInfo">日志信息</param>
        public void SaveLogInfo(string fileName, string logInfo)
        {
            StreamWriter streamWriter;
            if (File.Exists(fileName))
            {
                streamWriter = File.AppendText(fileName);
            }
            else
            {
                streamWriter = new StreamWriter(fileName);
            }
            streamWriter.WriteLine(logInfo);
            streamWriter.Flush();
            streamWriter.Close();
        }

        /// <summary>
        /// 保存日志信息到日志文件中
        /// </summary>
        /// <param name="logInfo">日志信息</param>
        public void SaveLogInfo(string logInfo)
        {
            try
            {
                string fileName = ServiceContainer.FileService.BrowseForNewFile(new BaseFrame.Utility.Files.FileCreationInfo()
                {
                    Description = @"请选择需要保存的文件",
                    FileFilter = @"文本文件|*.txt",
                });
                //fileDialog.OverwritePrompt = false;
                if(string.IsNullOrEmpty(fileName))
                {
                    return;
                }
                this.SaveLogInfo(fileName, logInfo);
                ServiceContainer.MessageService.ShowMessage(@"保存成功！");
                ServiceContainer.FileService.OpenAndSelectFile(fileName);
            }
            catch (Exception exception)
            {
                string errMsg = @"保存失败！原因：" + exception.Message;
                Constants.log.Error(errMsg, exception);
                ServiceContainer.MessageService.ShowError(errMsg);
            }
        }

        /// <summary>
        /// 读取配置文件
        /// </summary>
        private void ReadConfig()
        {
            ipAddress = ConfigurationManager.AppSettings["multicastAddress"];
            port = ConfigurationManager.AppSettings["multicastPort"];
        }
    }
}
