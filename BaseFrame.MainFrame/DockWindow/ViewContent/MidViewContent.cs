using System.Windows.Forms;
using BaseFrame.Frame;

namespace BaseFrame.MainFrame
{
    public class MidViewContent : IViewContent
    {
        public MidViewContent()
        {

        }

        private RichTextBox _box = new RichTextBox();
        public Control ViewControl
        {
            get
            {
                _box.Dock = DockStyle.Fill;
                _box.Name = "RichTextBox";
                return _box;
            }
            set
            {
                _box = (RichTextBox)value;
            }
        }
    }
}
