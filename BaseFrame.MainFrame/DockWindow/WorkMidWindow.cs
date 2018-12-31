using BaseFrame.Frame;
using System.Windows.Forms;

namespace BaseFrame.MainFrame
{
    public partial class WorkMidWindow : ToolWindow
    {
        public WorkMidWindow()
        {
            InitializeComponent();
            MidViewContent midView = new MidViewContent();
            ViewControl = midView.ViewControl;
        }
    }
}
