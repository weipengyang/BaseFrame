namespace BaseFrame.Examples.MsgViewExamples
{
    partial class ThreadMsgExampleViewToolBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThreadMsgExampleViewToolBar));
            this.ribbonBarThreadMsg = new DevComponents.DotNetBar.RibbonBar();
            this.btnUiThreadLongTimeMsg = new DevComponents.DotNetBar.ButtonItem();
            this.btnThreadMsg = new DevComponents.DotNetBar.ButtonItem();
            this.SuspendLayout();
            // 
            // ribbonBarThreadMsg
            // 
            this.ribbonBarThreadMsg.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarThreadMsg.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarThreadMsg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarThreadMsg.ContainerControlProcessDialogKey = true;
            this.ribbonBarThreadMsg.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarThreadMsg.DragDropSupport = true;
            this.ribbonBarThreadMsg.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnUiThreadLongTimeMsg,
            this.btnThreadMsg});
            this.ribbonBarThreadMsg.Location = new System.Drawing.Point(0, 0);
            this.ribbonBarThreadMsg.Name = "ribbonBarThreadMsg";
            this.ribbonBarThreadMsg.Size = new System.Drawing.Size(294, 98);
            this.ribbonBarThreadMsg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarThreadMsg.TabIndex = 2;
            this.ribbonBarThreadMsg.Text = "测试多线程消息";
            // 
            // 
            // 
            this.ribbonBarThreadMsg.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarThreadMsg.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnUiThreadLongTimeMsg
            // 
            this.btnUiThreadLongTimeMsg.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnUiThreadLongTimeMsg.Image = ((System.Drawing.Image)(resources.GetObject("btnUiThreadLongTimeMsg.Image")));
            this.btnUiThreadLongTimeMsg.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnUiThreadLongTimeMsg.Name = "btnUiThreadLongTimeMsg";
            this.btnUiThreadLongTimeMsg.RibbonWordWrap = false;
            this.btnUiThreadLongTimeMsg.Text = "测试UI长时间耗时操作消息";
            this.btnUiThreadLongTimeMsg.Click += new System.EventHandler(this.btnUiThreadLongTimeMsg_Click);
            // 
            // btnThreadMsg
            // 
            this.btnThreadMsg.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnThreadMsg.Image = ((System.Drawing.Image)(resources.GetObject("btnThreadMsg.Image")));
            this.btnThreadMsg.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThreadMsg.Name = "btnThreadMsg";
            this.btnThreadMsg.RibbonWordWrap = false;
            this.btnThreadMsg.Text = "测试多线程消息通知";
            this.btnThreadMsg.Click += new System.EventHandler(this.btnThreadMsg_Click);
            // 
            // ThreadMsgExampleViewToolBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonBarThreadMsg);
            this.Name = "ThreadMsgExampleViewToolBar";
            this.Size = new System.Drawing.Size(296, 98);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBarThreadMsg;
        private DevComponents.DotNetBar.ButtonItem btnUiThreadLongTimeMsg;
        private DevComponents.DotNetBar.ButtonItem btnThreadMsg;
    }
}
