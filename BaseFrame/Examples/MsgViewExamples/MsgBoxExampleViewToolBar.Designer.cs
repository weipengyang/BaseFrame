namespace BaseFrame.Examples.MsgViewExamples
{
    partial class MsgBoxExampleViewToolBar
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBoxExampleViewToolBar));
            this.ribbonBarMsgBox = new DevComponents.DotNetBar.RibbonBar();
            this.btnShowError = new DevComponents.DotNetBar.ButtonItem();
            this.btnShowWarning = new DevComponents.DotNetBar.ButtonItem();
            this.btnShowMessage = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarCustomDialog = new DevComponents.DotNetBar.RibbonBar();
            this.btnAskQuestion = new DevComponents.DotNetBar.ButtonItem();
            this.btnShowCustomDialog = new DevComponents.DotNetBar.ButtonItem();
            this.btnInputMsgBox = new DevComponents.DotNetBar.ButtonItem();
            this.SuspendLayout();
            // 
            // ribbonBarMsgBox
            // 
            this.ribbonBarMsgBox.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarMsgBox.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarMsgBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarMsgBox.ContainerControlProcessDialogKey = true;
            this.ribbonBarMsgBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarMsgBox.DragDropSupport = true;
            this.ribbonBarMsgBox.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnShowError,
            this.btnShowWarning,
            this.btnShowMessage});
            this.ribbonBarMsgBox.Location = new System.Drawing.Point(0, 0);
            this.ribbonBarMsgBox.Name = "ribbonBarMsgBox";
            this.ribbonBarMsgBox.Size = new System.Drawing.Size(349, 88);
            this.ribbonBarMsgBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarMsgBox.TabIndex = 1;
            this.ribbonBarMsgBox.Text = "MessageBox";
            // 
            // 
            // 
            this.ribbonBarMsgBox.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarMsgBox.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnShowError
            // 
            this.btnShowError.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnShowError.Image = ((System.Drawing.Image)(resources.GetObject("btnShowError.Image")));
            this.btnShowError.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnShowError.Name = "btnShowError";
            this.btnShowError.RibbonWordWrap = false;
            this.btnShowError.Text = "ShowError消息框";
            this.btnShowError.Click += new System.EventHandler(this.btnShowError_Click);
            // 
            // btnShowWarning
            // 
            this.btnShowWarning.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnShowWarning.Image = ((System.Drawing.Image)(resources.GetObject("btnShowWarning.Image")));
            this.btnShowWarning.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnShowWarning.Name = "btnShowWarning";
            this.btnShowWarning.RibbonWordWrap = false;
            this.btnShowWarning.Text = "ShowWarning消息框";
            this.btnShowWarning.Click += new System.EventHandler(this.btnShowWarning_Click);
            // 
            // btnShowMessage
            // 
            this.btnShowMessage.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnShowMessage.Image = ((System.Drawing.Image)(resources.GetObject("btnShowMessage.Image")));
            this.btnShowMessage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnShowMessage.Name = "btnShowMessage";
            this.btnShowMessage.RibbonWordWrap = false;
            this.btnShowMessage.Text = "ShowMessage消息框";
            this.btnShowMessage.Click += new System.EventHandler(this.btnShowMessage_Click);
            // 
            // ribbonBarCustomDialog
            // 
            this.ribbonBarCustomDialog.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarCustomDialog.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarCustomDialog.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarCustomDialog.CanCustomize = false;
            this.ribbonBarCustomDialog.ContainerControlProcessDialogKey = true;
            this.ribbonBarCustomDialog.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarCustomDialog.DragDropSupport = true;
            this.ribbonBarCustomDialog.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAskQuestion,
            this.btnShowCustomDialog,
            this.btnInputMsgBox});
            this.ribbonBarCustomDialog.Location = new System.Drawing.Point(349, 0);
            this.ribbonBarCustomDialog.Name = "ribbonBarCustomDialog";
            this.ribbonBarCustomDialog.Size = new System.Drawing.Size(403, 88);
            this.ribbonBarCustomDialog.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarCustomDialog.TabIndex = 4;
            this.ribbonBarCustomDialog.Text = "CustomDialog";
            // 
            // 
            // 
            this.ribbonBarCustomDialog.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarCustomDialog.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnAskQuestion
            // 
            this.btnAskQuestion.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnAskQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnAskQuestion.Image")));
            this.btnAskQuestion.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAskQuestion.Name = "btnAskQuestion";
            this.btnAskQuestion.RibbonWordWrap = false;
            this.btnAskQuestion.Text = "AskQuestion消息框";
            this.btnAskQuestion.Click += new System.EventHandler(this.btnAskQuestion_Click);
            // 
            // btnShowCustomDialog
            // 
            this.btnShowCustomDialog.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnShowCustomDialog.Image = ((System.Drawing.Image)(resources.GetObject("btnShowCustomDialog.Image")));
            this.btnShowCustomDialog.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnShowCustomDialog.Name = "btnShowCustomDialog";
            this.btnShowCustomDialog.RibbonWordWrap = false;
            this.btnShowCustomDialog.Text = "ShowCustomDialog消息框";
            this.btnShowCustomDialog.Click += new System.EventHandler(this.btnShowCustomDialog_Click);
            // 
            // btnInputMsgBox
            // 
            this.btnInputMsgBox.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnInputMsgBox.Image = ((System.Drawing.Image)(resources.GetObject("btnInputMsgBox.Image")));
            this.btnInputMsgBox.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnInputMsgBox.Name = "btnInputMsgBox";
            this.btnInputMsgBox.RibbonWordWrap = false;
            this.btnInputMsgBox.Text = "ShowInputBox消息框";
            this.btnInputMsgBox.Click += new System.EventHandler(this.btnInputMsgBox_Click);
            // 
            // MsgBoxExampleViewToolBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonBarCustomDialog);
            this.Controls.Add(this.ribbonBarMsgBox);
            this.Name = "MsgBoxExampleViewToolBar";
            this.Size = new System.Drawing.Size(846, 88);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBarMsgBox;
        private DevComponents.DotNetBar.ButtonItem btnShowError;
        private DevComponents.DotNetBar.ButtonItem btnShowWarning;
        private DevComponents.DotNetBar.RibbonBar ribbonBarCustomDialog;
        private DevComponents.DotNetBar.ButtonItem btnAskQuestion;
        private DevComponents.DotNetBar.ButtonItem btnShowCustomDialog;
        private DevComponents.DotNetBar.ButtonItem btnShowMessage;
        private DevComponents.DotNetBar.ButtonItem btnInputMsgBox;
    }
}
