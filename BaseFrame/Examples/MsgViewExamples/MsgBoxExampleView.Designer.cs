namespace BaseFrame.Examples.MsgViewExamples
{
    partial class MsgBoxExampleView
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
            this.btnShowError = new DevComponents.DotNetBar.ButtonX();
            this.btnShowWarning = new DevComponents.DotNetBar.ButtonX();
            this.btnAskQuestion = new DevComponents.DotNetBar.ButtonX();
            this.btnShowMessage = new DevComponents.DotNetBar.ButtonX();
            this.btnInputMsgBox = new DevComponents.DotNetBar.ButtonX();
            this.btnShowCustomDialog = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btnShowError
            // 
            this.btnShowError.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowError.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowError.Location = new System.Drawing.Point(73, 119);
            this.btnShowError.Name = "btnShowError";
            this.btnShowError.Size = new System.Drawing.Size(226, 32);
            this.btnShowError.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShowError.TabIndex = 0;
            this.btnShowError.Text = "1、显示错误消息框【ShowError】";
            this.btnShowError.Click += new System.EventHandler(this.btnShowError_Click);
            // 
            // btnShowWarning
            // 
            this.btnShowWarning.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowWarning.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowWarning.Location = new System.Drawing.Point(441, 119);
            this.btnShowWarning.Name = "btnShowWarning";
            this.btnShowWarning.Size = new System.Drawing.Size(226, 32);
            this.btnShowWarning.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShowWarning.TabIndex = 1;
            this.btnShowWarning.Text = "2、显示警告消息框【ShowWarning】";
            this.btnShowWarning.Click += new System.EventHandler(this.btnShowWarning_Click);
            // 
            // btnAskQuestion
            // 
            this.btnAskQuestion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAskQuestion.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAskQuestion.Location = new System.Drawing.Point(439, 237);
            this.btnAskQuestion.Name = "btnAskQuestion";
            this.btnAskQuestion.Size = new System.Drawing.Size(226, 32);
            this.btnAskQuestion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAskQuestion.TabIndex = 3;
            this.btnAskQuestion.Text = "4、显示问询消息框【AskQuestion】";
            this.btnAskQuestion.Click += new System.EventHandler(this.btnAskQuestion_Click);
            // 
            // btnShowMessage
            // 
            this.btnShowMessage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowMessage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowMessage.Location = new System.Drawing.Point(71, 237);
            this.btnShowMessage.Name = "btnShowMessage";
            this.btnShowMessage.Size = new System.Drawing.Size(226, 32);
            this.btnShowMessage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShowMessage.TabIndex = 2;
            this.btnShowMessage.Text = "3、显示普通消息框【ShowMessage】";
            this.btnShowMessage.Click += new System.EventHandler(this.btnShowMessage_Click);
            // 
            // btnInputMsgBox
            // 
            this.btnInputMsgBox.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInputMsgBox.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInputMsgBox.Location = new System.Drawing.Point(441, 361);
            this.btnInputMsgBox.Name = "btnInputMsgBox";
            this.btnInputMsgBox.Size = new System.Drawing.Size(226, 32);
            this.btnInputMsgBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInputMsgBox.TabIndex = 5;
            this.btnInputMsgBox.Text = "6、显示用户输入框【InputBox】";
            this.btnInputMsgBox.Click += new System.EventHandler(this.btnInputMsgBox_Click);
            // 
            // btnShowCustomDialog
            // 
            this.btnShowCustomDialog.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowCustomDialog.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowCustomDialog.Location = new System.Drawing.Point(73, 361);
            this.btnShowCustomDialog.Name = "btnShowCustomDialog";
            this.btnShowCustomDialog.Size = new System.Drawing.Size(226, 32);
            this.btnShowCustomDialog.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShowCustomDialog.TabIndex = 4;
            this.btnShowCustomDialog.Text = "5、显示自定义框【ShowCustomDialog】";
            this.btnShowCustomDialog.Click += new System.EventHandler(this.btnShowCustomDialog_Click);
            // 
            // MsgBoxExampleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 545);
            this.Controls.Add(this.btnInputMsgBox);
            this.Controls.Add(this.btnShowCustomDialog);
            this.Controls.Add(this.btnAskQuestion);
            this.Controls.Add(this.btnShowMessage);
            this.Controls.Add(this.btnShowWarning);
            this.Controls.Add(this.btnShowError);
            this.Name = "MsgBoxExampleView";
            this.Text = "MsgBoxExampleView";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnShowError;
        private DevComponents.DotNetBar.ButtonX btnShowWarning;
        private DevComponents.DotNetBar.ButtonX btnAskQuestion;
        private DevComponents.DotNetBar.ButtonX btnShowMessage;
        private DevComponents.DotNetBar.ButtonX btnInputMsgBox;
        private DevComponents.DotNetBar.ButtonX btnShowCustomDialog;
    }
}