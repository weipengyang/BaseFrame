
using BaseFrame.Frame;

namespace BaseFrame.MainFrame
{
    public partial class OutputWindow : ToolWindow
    {
        public OutputWindow()
        {
            InitializeComponent();
            MidViewContent midView = new MidViewContent();
            ViewControl = midView.ViewControl;
        }
    }
}
