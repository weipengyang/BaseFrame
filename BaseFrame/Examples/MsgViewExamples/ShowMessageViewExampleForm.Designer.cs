namespace BaseFrame.Examples.MsgViewExamples
{
    partial class ShowMessageViewExampleForm
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
            this.grpbChoices = new System.Windows.Forms.GroupBox();
            this.btnInputMsgBox = new System.Windows.Forms.Button();
            this.btnShowCustomDialog = new System.Windows.Forms.Button();
            this.btnAskQuestion = new System.Windows.Forms.Button();
            this.btnShowMessage = new System.Windows.Forms.Button();
            this.btnShowWarning = new System.Windows.Forms.Button();
            this.btnShowError = new System.Windows.Forms.Button();
            this.grpbThreadWait = new System.Windows.Forms.GroupBox();
            this.lbThreadMsg = new System.Windows.Forms.Label();
            this.btnStartThread = new System.Windows.Forms.Button();
            this.btnStartLongTimeAction = new System.Windows.Forms.Button();
            this.grpbChoices.SuspendLayout();
            this.grpbThreadWait.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbChoices
            // 
            this.grpbChoices.Controls.Add(this.btnInputMsgBox);
            this.grpbChoices.Controls.Add(this.btnShowCustomDialog);
            this.grpbChoices.Controls.Add(this.btnAskQuestion);
            this.grpbChoices.Controls.Add(this.btnShowMessage);
            this.grpbChoices.Controls.Add(this.btnShowWarning);
            this.grpbChoices.Controls.Add(this.btnShowError);
            this.grpbChoices.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpbChoices.Location = new System.Drawing.Point(0, 0);
            this.grpbChoices.Name = "grpbChoices";
            this.grpbChoices.Size = new System.Drawing.Size(568, 623);
            this.grpbChoices.TabIndex = 1;
            this.grpbChoices.TabStop = false;
            this.grpbChoices.Text = "测试选择消息框";
            // 
            // btnInputMsgBox
            // 
            this.btnInputMsgBox.Location = new System.Drawing.Point(319, 226);
            this.btnInputMsgBox.Name = "btnInputMsgBox";
            this.btnInputMsgBox.Size = new System.Drawing.Size(224, 23);
            this.btnInputMsgBox.TabIndex = 4;
            this.btnInputMsgBox.Text = "6、显示用户输入框【InputBox】";
            this.btnInputMsgBox.UseVisualStyleBackColor = true;
            this.btnInputMsgBox.Click += new System.EventHandler(this.btnInputMsgBox_Click);
            // 
            // btnShowCustomDialog
            // 
            this.btnShowCustomDialog.Location = new System.Drawing.Point(29, 226);
            this.btnShowCustomDialog.Name = "btnShowCustomDialog";
            this.btnShowCustomDialog.Size = new System.Drawing.Size(224, 23);
            this.btnShowCustomDialog.TabIndex = 1;
            this.btnShowCustomDialog.Text = "5、显示自定义框【ShowCustomDialog】";
            this.btnShowCustomDialog.UseVisualStyleBackColor = true;
            this.btnShowCustomDialog.Click += new System.EventHandler(this.btnShowCustomDialog_Click);
            // 
            // btnAskQuestion
            // 
            this.btnAskQuestion.Location = new System.Drawing.Point(319, 138);
            this.btnAskQuestion.Name = "btnAskQuestion";
            this.btnAskQuestion.Size = new System.Drawing.Size(224, 23);
            this.btnAskQuestion.TabIndex = 0;
            this.btnAskQuestion.Text = "4、显示问询消息框【AskQuestion】";
            this.btnAskQuestion.UseVisualStyleBackColor = true;
            this.btnAskQuestion.Click += new System.EventHandler(this.btnAskQuestion_Click);
            // 
            // btnShowMessage
            // 
            this.btnShowMessage.Location = new System.Drawing.Point(29, 138);
            this.btnShowMessage.Name = "btnShowMessage";
            this.btnShowMessage.Size = new System.Drawing.Size(224, 23);
            this.btnShowMessage.TabIndex = 0;
            this.btnShowMessage.Text = "3、显示普通消息框【ShowMessage】";
            this.btnShowMessage.UseVisualStyleBackColor = true;
            this.btnShowMessage.Click += new System.EventHandler(this.btnShowMessage_Click);
            // 
            // btnShowWarning
            // 
            this.btnShowWarning.Location = new System.Drawing.Point(319, 56);
            this.btnShowWarning.Name = "btnShowWarning";
            this.btnShowWarning.Size = new System.Drawing.Size(224, 23);
            this.btnShowWarning.TabIndex = 0;
            this.btnShowWarning.Text = "2、显示警告消息框【ShowWarning】";
            this.btnShowWarning.UseVisualStyleBackColor = true;
            this.btnShowWarning.Click += new System.EventHandler(this.btnShowWarning_Click);
            // 
            // btnShowError
            // 
            this.btnShowError.Location = new System.Drawing.Point(29, 56);
            this.btnShowError.Name = "btnShowError";
            this.btnShowError.Size = new System.Drawing.Size(224, 23);
            this.btnShowError.TabIndex = 0;
            this.btnShowError.Text = "1、显示错误消息框【ShowError】";
            this.btnShowError.UseVisualStyleBackColor = true;
            this.btnShowError.Click += new System.EventHandler(this.btnShowError_Click);
            // 
            // grpbThreadWait
            // 
            this.grpbThreadWait.Controls.Add(this.btnStartLongTimeAction);
            this.grpbThreadWait.Controls.Add(this.btnStartThread);
            this.grpbThreadWait.Controls.Add(this.lbThreadMsg);
            this.grpbThreadWait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbThreadWait.Location = new System.Drawing.Point(568, 0);
            this.grpbThreadWait.Name = "grpbThreadWait";
            this.grpbThreadWait.Size = new System.Drawing.Size(524, 623);
            this.grpbThreadWait.TabIndex = 2;
            this.grpbThreadWait.TabStop = false;
            this.grpbThreadWait.Text = "多线程等待消息框";
            // 
            // lbThreadMsg
            // 
            this.lbThreadMsg.AutoSize = true;
            this.lbThreadMsg.Location = new System.Drawing.Point(69, 66);
            this.lbThreadMsg.Name = "lbThreadMsg";
            this.lbThreadMsg.Size = new System.Drawing.Size(89, 12);
            this.lbThreadMsg.TabIndex = 0;
            this.lbThreadMsg.Text = "线程处理消息。";
            // 
            // btnStartThread
            // 
            this.btnStartThread.Location = new System.Drawing.Point(83, 138);
            this.btnStartThread.Name = "btnStartThread";
            this.btnStartThread.Size = new System.Drawing.Size(124, 23);
            this.btnStartThread.TabIndex = 1;
            this.btnStartThread.Text = "开启线程处理";
            this.btnStartThread.UseVisualStyleBackColor = true;
            this.btnStartThread.Click += new System.EventHandler(this.btnStartThread_Click);
            // 
            // btnStartLongTimeAction
            // 
            this.btnStartLongTimeAction.Location = new System.Drawing.Point(322, 138);
            this.btnStartLongTimeAction.Name = "btnStartLongTimeAction";
            this.btnStartLongTimeAction.Size = new System.Drawing.Size(141, 23);
            this.btnStartLongTimeAction.TabIndex = 2;
            this.btnStartLongTimeAction.Text = "开始长时间处理";
            this.btnStartLongTimeAction.UseVisualStyleBackColor = true;
            this.btnStartLongTimeAction.Click += new System.EventHandler(this.btnStartLongTimeAction_Click);
            // 
            // ShowMessageViewExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 623);
            this.Controls.Add(this.grpbThreadWait);
            this.Controls.Add(this.grpbChoices);
            this.Name = "ShowMessageViewExampleForm";
            this.Text = "ShowMessageViewExampleForm";
            this.grpbChoices.ResumeLayout(false);
            this.grpbThreadWait.ResumeLayout(false);
            this.grpbThreadWait.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbChoices;
        private System.Windows.Forms.Button btnInputMsgBox;
        private System.Windows.Forms.Button btnShowCustomDialog;
        private System.Windows.Forms.Button btnShowError;
        private System.Windows.Forms.Button btnShowWarning;
        private System.Windows.Forms.Button btnShowMessage;
        private System.Windows.Forms.Button btnAskQuestion;
        private System.Windows.Forms.GroupBox grpbThreadWait;
        private System.Windows.Forms.Label lbThreadMsg;
        private System.Windows.Forms.Button btnStartThread;
        private System.Windows.Forms.Button btnStartLongTimeAction;
    }
}