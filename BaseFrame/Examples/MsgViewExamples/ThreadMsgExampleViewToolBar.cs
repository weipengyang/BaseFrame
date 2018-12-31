using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseFrame.Utility;
using BaseFrame.FrameInterface.PresenterInterface;

namespace BaseFrame.Examples.MsgViewExamples
{
    public partial class ThreadMsgExampleViewToolBar : UserControl
    {
        public ThreadMsgExampleViewToolBar()
        {
            InitializeComponent();
        }

        private void btnUiThreadLongTimeMsg_Click(object sender, EventArgs e)
        {
            ServiceContainer.GetInstance<IThreadMsgBoxExamplePresenter>().StartTaskByThread();
        }

        private void btnThreadMsg_Click(object sender, EventArgs e)
        {
            ServiceContainer.GetInstance<IThreadMsgBoxExamplePresenter>().StartTask();
        }
    }
}
