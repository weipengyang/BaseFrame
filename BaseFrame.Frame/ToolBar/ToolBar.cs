using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseFrame.Frame
{
    public class ToolBar : ToolStrip
    {
        public void Add(ToolStripItem item)
        {
            //ToolBarSingleton.MainToolbar.Items.Add(item);
            this.Items.Add(item);
        }
    }
}
