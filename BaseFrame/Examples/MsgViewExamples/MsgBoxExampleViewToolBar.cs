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
    public partial class MsgBoxExampleViewToolBar : UserControl
    {
        public MsgBoxExampleViewToolBar()
        {
            InitializeComponent();
        }

        private void btnShowError_Click(object sender, EventArgs e)
        {
            ServiceContainer.GetInstance<IMsgBoxExamplePresenter>().HandleTaskShowError();
        }

        private void btnShowWarning_Click(object sender, EventArgs e)
        {
            ServiceContainer.GetInstance<IMsgBoxExamplePresenter>().HandleTaskShowWarning();
        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            ServiceContainer.GetInstance<IMsgBoxExamplePresenter>().HandleTaskShowMessage();
        }

        private void btnAskQuestion_Click(object sender, EventArgs e)
        {
            ServiceContainer.GetInstance<IMsgBoxExamplePresenter>().HandleTaskAskQuestion();
        }

        private void btnShowCustomDialog_Click(object sender, EventArgs e)
        {
            ServiceContainer.GetInstance<IMsgBoxExamplePresenter>().HandleTaskShowCustomDialog();
        }

        private void btnInputMsgBox_Click(object sender, EventArgs e)
        {
            ServiceContainer.GetInstance<IMsgBoxExamplePresenter>().HandleTaskShowInputBox();
        }
    }
}
