using BaseFrame.Core;
using BaseFrame.Dock;
using BaseFrame.Frame;

namespace BaseFrame.MainFrame
{
     public class OpenDocumentCommand: Command
    {
        public override bool Enable()
        {
            return true;
        }
        public override void Run()
        {
            ToolWindow window =new WorkMidWindow();
            window.Text ="测试文档";
            window.Show(DockPanelSingleton.MainDockPanel, DockState.Document);
        }
    }
}
