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
    public partial class CustomDialog : Form
    {
        int acceptButton;
        int cancelButton;
        int result = -1;

        /// <summary>
        /// Gets the index of the button pressed.
        /// </summary>
        public int Result
        {
            get
            {
                return result;
            }
        }

        public CustomDialog()
            : this("caption", "message",
                    0, 3,
                    new[] { ConstStringResources.GlobalYes,
                    ConstStringResources.GlobalYesToAll,
                    ConstStringResources.GlobalNo,
                    ConstStringResources.GlobalCancelButtonText })
        {

        }

        public CustomDialog(string caption, string message, int acceptButton, int cancelButton, string[] buttonLabels)
        {
            this.SuspendLayout();
            InitializeComponent();
            this.Icon = null;
            this.acceptButton = acceptButton;
            this.cancelButton = cancelButton;

            this.Text = caption;

            using (Graphics g = this.CreateGraphics())
            {
                Rectangle screen = Screen.PrimaryScreen.WorkingArea;
                ////SizeF size = g.MeasureString(message, label.Font, screen.Width - 20);
                ////Size clientSize = size.ToSize();

                int maxWidth = screen.Width / 3;
                SizeF size = g.MeasureString(message, label.Font, maxWidth - 20);
                Size clientSize = size.ToSize();
                if(clientSize.Height<120)
                {
                    clientSize.Height = 120;
                }
                Button[] buttons = new Button[buttonLabels.Length];
                int[] positions = new int[buttonLabels.Length];
                int pos = 0;
                for (int i = 0; i < buttons.Length; i++)
                {
                    Button newButton = new Button();
                    newButton.FlatStyle = FlatStyle.System;
                    newButton.Tag = i;
                    string buttonLabel = buttonLabels[i];
                    newButton.Text = buttonLabel;
                    newButton.Click += new EventHandler(ButtonClick);
                    SizeF buttonSize = g.MeasureString(buttonLabel, newButton.Font);
                    newButton.Width = Math.Max(newButton.Width, ((int)Math.Ceiling(buttonSize.Width / 8.0) + 1) * 8);
                    positions[i] = pos;
                    buttons[i] = newButton;
                    pos += newButton.Width + 4;
                }
                if (acceptButton >= 0)
                {
                    AcceptButton = buttons[acceptButton];
                }
                if (cancelButton >= 0)
                {
                    CancelButton = buttons[cancelButton];
                }

                pos += 4; // add space before first button
                          // (we don't start with pos=4 because this space doesn't belong to the button panel)

                if (pos > clientSize.Width)
                {
                    clientSize.Width = pos;
                }
                clientSize.Height += panel.Height + 6;
                this.ClientSize = clientSize;
                int start = (clientSize.Width - pos) / 2;
                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].Location = new Point(start + positions[i], 4);
                }
                panel.Controls.AddRange(buttons);
            }
            label.Text = message;

            RightToLeftConverter.ConvertRecursive(this);
            this.ResumeLayout(false);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (cancelButton == -1 && e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        void ButtonClick(object sender, EventArgs e)
        {
            result = (int)((Control)sender).Tag;
            this.Close();
        }
    }
}
