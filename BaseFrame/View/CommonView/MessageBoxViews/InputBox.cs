using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseFrame.View.MessageBoxViews
{
    public partial class InputBox : Form
    {

        string result;

        public string Result
        {
            get
            {
                return result;
            }
        }

        public InputBox()
            :this("Text", "Caption", "")
        {
        }

        public InputBox(string text, string caption, string defaultValue)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            this.Text = caption;
            acceptButton.Text = "确定";
            cancelButton.Text = "取消";

            Size size;
            using (Graphics g = this.CreateGraphics())
            {
                Rectangle screen = Screen.PrimaryScreen.WorkingArea;
                SizeF sizeF = g.MeasureString(text, label.Font, screen.Width - 20);
                size = sizeF.ToSize();
                size.Width += 4;
            }
            if (size.Width < 200)
                size.Width = 200;
            Size clientSize = this.ClientSize;
            clientSize.Width += size.Width - label.Width;
            clientSize.Height += size.Height - label.Height;
            this.ClientSize = clientSize;
            label.Text = text;
            textBox.Text = defaultValue;
            this.DialogResult = DialogResult.Cancel;
            RightToLeftConverter.ConvertRecursive(this);
        }

        void CancelButtonClick(object sender, System.EventArgs e)
        {
            result = null;
            this.Close();
        }

        void AcceptButtonClick(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            result = textBox.Text;
            this.Close();
        }
    }
}
