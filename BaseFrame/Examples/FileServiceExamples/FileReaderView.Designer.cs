namespace BaseFrame.View.MultiDocView
{
    partial class FileReaderView
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
            this.txtbFileContent = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnReadFile = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // txtbFileContent
            // 
            this.txtbFileContent.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtbFileContent.Border.Class = "TextBoxBorder";
            this.txtbFileContent.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbFileContent.DisabledBackColor = System.Drawing.Color.White;
            this.txtbFileContent.ForeColor = System.Drawing.Color.Black;
            this.txtbFileContent.Location = new System.Drawing.Point(12, 63);
            this.txtbFileContent.Multiline = true;
            this.txtbFileContent.Name = "txtbFileContent";
            this.txtbFileContent.PreventEnterBeep = true;
            this.txtbFileContent.Size = new System.Drawing.Size(295, 229);
            this.txtbFileContent.TabIndex = 0;
            // 
            // btnReadFile
            // 
            this.btnReadFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReadFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReadFile.Location = new System.Drawing.Point(364, 269);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(132, 23);
            this.btnReadFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReadFile.TabIndex = 1;
            this.btnReadFile.Text = "选择并读取文件";
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // FileReaderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 545);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.txtbFileContent);
            this.DoubleBuffered = true;
            this.Name = "FileReaderView";
            this.Text = "FileReaderView";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtbFileContent;
        private DevComponents.DotNetBar.ButtonX btnReadFile;
    }
}