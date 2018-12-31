using BaseFrame.FrameInterface.PresenterInterface;
using BaseFrame.FrameInterface.ViewInterface;
using BaseFrame.View.MessageBoxViews;
using BaseFrame.Utility.MessageService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseFrame.Interface;
using BaseFrame.Utility;

namespace BaseFrame.Presenter
{
    /*
    <!--ThreadMsgBoxExamplePresenter View 界面关联的 IThreadMsgBoxExamplePresenter 接口配置-->
    <component instance-scope="singleinstance"
      type="BaseFrame.Presenter.ThreadMsgBoxExamplePresenter, BaseFrame"
      service="BaseFrame.FrameInterface.PresenterInterface.IThreadMsgBoxExamplePresenter, BaseFrame">
    </component>
    */

    /// <summary>
    /// MVP模式中View页面对应的Presenter：用于后台逻辑处理。
    /// </summary>
    /// <remarks>
    /// type="BaseFrame.Presenter.ThreadMsgBoxExamplePresenter, BaseFrame"
    /// </remarks>
    public class ThreadMsgBoxExamplePresenter : BasePresenter, IThreadMsgBoxExamplePresenter
    {
        #region Fields
        IThreadMsgBoxExampleView threadMsgBoxExampleView;
        #endregion

        #region Constructor
        /// <summary>
        /// MVP模式中View页面对应的Presenter：用于后台逻辑处理。
        /// </summary>
        public ThreadMsgBoxExamplePresenter()
        {
        }
        #endregion

        #region Properties

        #endregion

        #region Public Methods
        /// <summary>
        /// 当前调用线程中执行任务处理。
        /// </summary>
        public void StartTask()
        {
            var progressDlg = AsynchronousWaitDialog.ShowWaitDialog("已开启长时间耗时处理，请耐心等待...");
            ThreadArg tArg = new ThreadArg(progressDlg);
            TestThread(tArg);
        }

        /// <summary>
        /// 后台线程执行任务处理。
        /// </summary>
        public void StartTaskByThread()
        {
            AsynchronousWaitDialog.ShowWaitDialogForAsyncOperation("已开启线程处理，请耐心等待...", progressMonitor =>
            {
                ThreadArg tArg = new ThreadArg(progressMonitor);
                Task task = new Task(TestThread, tArg);
                task.Start();
            });
        }
        #endregion

        #region Protected Methods
        /// <summary>
        /// 初始化Presenter数据：在此方法中解决循环依赖问题。
        /// </summary>
        protected override void InternalInitData()
        {
            this.threadMsgBoxExampleView = ServiceContainer.GetInstance<IThreadMsgBoxExampleView>();
            this.AttachView(this.threadMsgBoxExampleView);
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

        #region CommandHandler

        #endregion

        #region EventHandler

        #endregion
    }
}
