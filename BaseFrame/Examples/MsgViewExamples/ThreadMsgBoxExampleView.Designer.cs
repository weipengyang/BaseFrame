namespace BaseFrame.Examples.MsgViewExamples
{
    partial class ThreadMsgBoxExampleView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnStartThread = new DevComponents.DotNetBar.ButtonX();
            this.btnStartLongTimeAction = new DevComponents.DotNetBar.ButtonX();
            this.lbMsg = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnStartThread
            // 
            this.btnStartThread.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStartThread.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStartThread.Location = new System.Drawing.Point(63, 269);
            this.btnStartThread.Name = "btnStartThread";
            this.btnStartThread.Size = new System.Drawing.Size(123, 38);
            this.btnStartThread.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStartThread.TabIndex = 0;
            this.btnStartThread.Text = "开始线程处理提示";
            this.btnStartThread.Click += new System.EventHandler(this.btnStartThread_Click);
            // 
            // btnStartLongTimeAction
            // 
            this.btnStartLongTimeAction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStartLongTimeAction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStartLongTimeAction.Location = new System.Drawing.Point(347, 269);
            this.btnStartLongTimeAction.Name = "btnStartLongTimeAction";
            this.btnStartLongTimeAction.Size = new System.Drawing.Size(163, 38);
            this.btnStartLongTimeAction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStartLongTimeAction.TabIndex = 1;
            this.btnStartLongTimeAction.Text = "开始UI长时间处理提示";
            this.btnStartLongTimeAction.Click += new System.EventHandler(this.btnStartLongTimeAction_Click);
            // 
            // lbMsg
            // 
            // 
            // 
            // 
            this.lbMsg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbMsg.Location = new System.Drawing.Point(63, 85);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(447, 23);
            this.lbMsg.TabIndex = 2;
            this.lbMsg.Text = "线程处理消息提示示例页面。";
            // 
            // ThreadMsgBoxExampleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 545);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.btnStartLongTimeAction);
            this.Controls.Add(this.btnStartThread);
            this.Name = "ThreadMsgBoxExampleView";
            this.Text = "ThreadMsgBoxExampleView";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnStartThread;
        private DevComponents.DotNetBar.ButtonX btnStartLongTimeAction;
        private DevComponents.DotNetBar.LabelX lbMsg;
    }
}