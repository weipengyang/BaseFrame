namespace BaseFrame.View.MessageBoxViews
{
    partial class CustomDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        System.Windows.Forms.Label label;
        System.Windows.Forms.Panel panel;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.panelMsg = new System.Windows.Forms.Panel();
            this.panelMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(4, 80);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(266, 32);
            this.panel.TabIndex = 0;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(266, 76);
            this.label.TabIndex = 1;
            this.label.Text = "IMessageService 方法： int ShowCustomDialog(string caption, string dialogText, int a" +
    "cceptButtonIndex, int cancelButtonIndex, params string[] buttontexts);";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMsg
            // 
            this.panelMsg.Controls.Add(this.label);
            this.panelMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMsg.Location = new System.Drawing.Point(4, 4);
            this.panelMsg.Name = "panelMsg";
            this.panelMsg.Size = new System.Drawing.Size(266, 76);
            this.panelMsg.TabIndex = 1;
            // 
            // CustomDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(274, 112);
            this.Controls.Add(this.panelMsg);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomDialog";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomDialog";
            this.panelMsg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMsg;
    }
}