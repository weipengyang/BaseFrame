using BaseFrame.View.MessageBoxViews;
using BaseFrame.Utility;
using BaseFrame.Utility.MessageService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseFrame.Examples.MsgViewExamples
{
    /// <summary>
    /// 消息框示例窗体。
    /// </summary>
    public partial class ShowMessageViewExampleForm : Form
    {
        #region Fields
        string msgShort = "人生何其短，切莫入错行。";

        string caption = "Title-ShowMessageViewExampleForm";

        string fmtMsg = "DateTime:{0:yyyy-MM-dd HH:mm:ss.fff};int:{1};string:{2}.";

        string msg = "人生何其短，切莫入错行。----创意无处不在—Life's Too Short for the Wrong Job 这是Scholz & Friends 广告公司为德国的一个招聘网站Jobsintown.de做的一个系列广告 “Life's Too Short for the Wrong Job”，非常有创意。";
        #endregion

        /// <summary>
        /// 消息框示例窗体。
        /// </summary>
        public ShowMessageViewExampleForm()
        {
            InitializeComponent();
        }

        #region Event Handler
        private void btnShowError_Click(object sender, EventArgs e)
        {
            ServiceContainer.MessageService.ShowError(msg);

            //ServiceContainer.MessageService.ShowWarning(msg);
            //ServiceContainer.MessageService.ShowMessage(msg, "ShowMessage");
            //bool questResult = ServiceContainer.MessageService.AskQuestion(msg, "AskQuestion");
            //ServiceContainer.MessageService.ShowMessageFormatted(fmtMsg, "ShowMessageFormatted", DateTime.Now, 123, "DDDD");
        }

        private void btnShowWarning_Click(object sender, EventArgs e)
        {
            ServiceContainer.MessageService.ShowWarning(msg);
        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            ServiceContainer.MessageService.ShowMessage(msg, "ShowMessage");
        }

        private void btnAskQuestion_Click(object sender, EventArgs e)
        {
            bool questResult = ServiceContainer.MessageService.AskQuestion(msg, "AskQuestion");

            LogMsg(questResult.ToString());
            ServiceContainer.MessageService.ShowMessageFormatted("AskQuestion选择结果：{0}", "AskQuestion选择结果", questResult);
        }

        private void btnShowCustomDialog_Click(object sender, EventArgs e)
        {
            int result = ServiceContainer.MessageService.ShowCustomDialog("ShowCustomDialog 长消息", msg,
                                                                        0, 3,
                                                                        ConstStringResources.GlobalOKButtonText,
                                                                        ConstStringResources.GlobalYesToAll,
                                                                        ConstStringResources.GlobalCloseButtonText,
                                                                        ConstStringResources.GlobalCancelButtonText);
            LogMsg(result.ToString());
            ServiceContainer.MessageService.ShowMessageFormatted("ShowCustomDialog 长消息 选择的按钮下标：{0}", "ShowCustomDialog 长消息 选择的按钮下标", result);

            result = ServiceContainer.MessageService.ShowCustomDialog("ShowCustomDialog 短消息", msgShort,
                                                                        0, 2,
                                                                        ConstStringResources.GlobalOKButtonText,
                                                                        //ConstStringResources.GlobalYesToAll,
                                                                        ConstStringResources.GlobalCloseButtonText,
                                                                        ConstStringResources.GlobalCancelButtonText);
            LogMsg(result.ToString());
            ServiceContainer.MessageService.ShowMessageFormatted("ShowCustomDialog 短消息 选择的按钮下标：{0}", "ShowCustomDialog 短消息 选择的按钮下标", result);
        }

        private void btnInputMsgBox_Click(object sender, EventArgs e)
        {
            string msg = ServiceContainer.MessageService.ShowInputBox("ShowInputBox", "请输入名称：", "default");
            LogMsg(msg);
            ServiceContainer.MessageService.ShowMessageFormatted("ShowInputBox 输入结果:{0}{1}", "ShowInputBox 输入结果", Environment.NewLine, msg);
        }

        private void btnStartThread_Click(object sender, EventArgs e)
        {
            AsynchronousWaitDialog.ShowWaitDialogForAsyncOperation("已开启线程处理，请耐心等待...", progressMonitor =>
            {
                ThreadArg tArg = new ThreadArg(progressMonitor);
                Task task = new Task(TestThread, tArg);
                task.Start();
            });
        }

        private void btnStartLongTimeAction_Click(object sender, EventArgs e)
        {
            var progressDlg = AsynchronousWaitDialog.ShowWaitDialog("已开启长时间耗时处理，请耐心等待...");
            ThreadArg tArg = new ThreadArg(progressDlg);
            TestThread(tArg);
        } 
        #endregion

        #region Private Methods
        void LogMsg(string msg)
        {
            System.Diagnostics.Trace.Write("LogMsg:");
            System.Diagnostics.Trace.WriteLine(msg);
        }

        void TestThread(object objArg)
        {
            System.Threading.Thread.Sleep(1000);
            ThreadArg tArg = objArg as ThreadArg;
            int projectsLoaded = 0;
            int projectCount = 4;
            int index = 1;
            using (var progress = tArg.ProgressMonitor)
            {
                while (projectsLoaded < projectCount)
                {
                    ////progress.TaskName = "Loading " + index;
                    using (IProgressMonitor progressMonitor = progress.CreateSubTask(1.0 / projectCount))
                    {
                        progressMonitor.TaskName = "SubTask" + index;
                        for (int i = 1; i <= 5; i++)
                        {
                            progressMonitor.Progress = i * 0.2;
                            progressMonitor.TaskName = string.Format("SubTask{0}--{1:P0}", index, progressMonitor.Progress);
                            System.Threading.Thread.Sleep(1000);
                        }
                        //System.Threading.Thread.Sleep(2500);
                    }
                    index++;
                    projectsLoaded++;
                    progress.Progress = (double)projectsLoaded / projectCount;
                }
                progress.TaskName = "加载完成！";
            }
        }

        class ThreadArg
        {
            public IProgressMonitor ProgressMonitor { get; private set; }

            public ThreadArg(IProgressMonitor progressReporter)
            {
                this.ProgressMonitor = progressReporter;
            }
        } 
        #endregion
    }
}
