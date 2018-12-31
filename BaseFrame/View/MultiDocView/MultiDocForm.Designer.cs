namespace BaseFrame.MultiDocView
{
    partial class MultiDocForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiDocForm));
            this.rbnctrlHeaderFunc = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.msgBoxExampleViewToolBar1 = new BaseFrame.Examples.MsgViewExamples.MsgBoxExampleViewToolBar();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.threadMsgExampleViewToolBar1 = new BaseFrame.Examples.MsgViewExamples.ThreadMsgExampleViewToolBar();
            this.rbnitmManageMsgBox = new DevComponents.DotNetBar.RibbonTabItem();
            this.rbnitmThreadMsgBox = new DevComponents.DotNetBar.RibbonTabItem();
            this.buttonChangeStyle = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem68 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonStyleMetro = new DevComponents.DotNetBar.ButtonItem();
            this.buttonStyleOffice2010Blue = new DevComponents.DotNetBar.ButtonItem();
            this.buttonStyleOffice2010Silver = new DevComponents.DotNetBar.ButtonItem();
            this.buttonStyleOffice2010Black = new DevComponents.DotNetBar.ButtonItem();
            this.buttonStyleVS2010 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem69 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonStyleOffice2007Blue = new DevComponents.DotNetBar.ButtonItem();
            this.buttonStyleOffice2007Black = new DevComponents.DotNetBar.ButtonItem();
            this.buttonStyleOffice2007Silver = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem70 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem71 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonStyleCustom = new DevComponents.DotNetBar.ColorPickerDropDown();
            this.buttonItem47 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem48 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem49 = new DevComponents.DotNetBar.ButtonItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.barStatusBar = new DevComponents.DotNetBar.Bar();
            this.lbStatusMsg = new DevComponents.DotNetBar.LabelItem();
            this.rbnctrlHeaderFunc.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barStatusBar)).BeginInit();
            this.SuspendLayout();
            // 
            // rbnctrlHeaderFunc
            // 
            this.rbnctrlHeaderFunc.BackColor = System.Drawing.SystemColors.Control;
            this.rbnctrlHeaderFunc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbnctrlHeaderFunc.BackgroundImage")));
            // 
            // 
            // 
            this.rbnctrlHeaderFunc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbnctrlHeaderFunc.CaptionVisible = true;
            this.rbnctrlHeaderFunc.Controls.Add(this.ribbonPanel1);
            this.rbnctrlHeaderFunc.Controls.Add(this.ribbonPanel2);
            this.rbnctrlHeaderFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbnctrlHeaderFunc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnctrlHeaderFunc.ForeColor = System.Drawing.Color.Black;
            this.rbnctrlHeaderFunc.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rbnitmManageMsgBox,
            this.rbnitmThreadMsgBox,
            this.buttonChangeStyle});
            this.rbnctrlHeaderFunc.KeyTipsFont = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnctrlHeaderFunc.Location = new System.Drawing.Point(5, 1);
            this.rbnctrlHeaderFunc.MdiSystemItemVisible = false;
            this.rbnctrlHeaderFunc.MouseWheelTabScrollEnabled = false;
            this.rbnctrlHeaderFunc.Name = "rbnctrlHeaderFunc";
            this.rbnctrlHeaderFunc.RibbonStripFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnctrlHeaderFunc.Size = new System.Drawing.Size(979, 151);
            this.rbnctrlHeaderFunc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbnctrlHeaderFunc.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.rbnctrlHeaderFunc.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.rbnctrlHeaderFunc.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.rbnctrlHeaderFunc.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.rbnctrlHeaderFunc.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.rbnctrlHeaderFunc.SystemText.QatDialogAddButton = "&Add >>";
            this.rbnctrlHeaderFunc.SystemText.QatDialogCancelButton = "Cancel";
            this.rbnctrlHeaderFunc.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.rbnctrlHeaderFunc.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.rbnctrlHeaderFunc.SystemText.QatDialogOkButton = "OK";
            this.rbnctrlHeaderFunc.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.rbnctrlHeaderFunc.SystemText.QatDialogRemoveButton = "&Remove";
            this.rbnctrlHeaderFunc.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.rbnctrlHeaderFunc.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.rbnctrlHeaderFunc.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.rbnctrlHeaderFunc.TabGroupHeight = 14;
            this.rbnctrlHeaderFunc.TabGroupsVisible = true;
            this.rbnctrlHeaderFunc.TabIndex = 9;
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.msgBoxExampleViewToolBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.ribbonPanel1.Size = new System.Drawing.Size(979, 95);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            // 
            // msgBoxExampleViewToolBar1
            // 
            this.msgBoxExampleViewToolBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgBoxExampleViewToolBar1.Location = new System.Drawing.Point(3, 0);
            this.msgBoxExampleViewToolBar1.Name = "msgBoxExampleViewToolBar1";
            this.msgBoxExampleViewToolBar1.Size = new System.Drawing.Size(973, 93);
            this.msgBoxExampleViewToolBar1.TabIndex = 0;
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.threadMsgExampleViewToolBar1);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.ribbonPanel2.Size = new System.Drawing.Size(989, 95);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 4;
            this.ribbonPanel2.Visible = false;
            // 
            // threadMsgExampleViewToolBar1
            // 
            this.threadMsgExampleViewToolBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threadMsgExampleViewToolBar1.Location = new System.Drawing.Point(3, 0);
            this.threadMsgExampleViewToolBar1.Name = "threadMsgExampleViewToolBar1";
            this.threadMsgExampleViewToolBar1.Size = new System.Drawing.Size(983, 93);
            this.threadMsgExampleViewToolBar1.TabIndex = 0;
            // 
            // rbnitmManageMsgBox
            // 
            this.rbnitmManageMsgBox.Checked = true;
            this.rbnitmManageMsgBox.Name = "rbnitmManageMsgBox";
            this.rbnitmManageMsgBox.Panel = this.ribbonPanel1;
            this.rbnitmManageMsgBox.Text = "演示弹出消息框";
            this.rbnitmManageMsgBox.Click += new System.EventHandler(this.rbnitmManageMsgBox_Click);
            // 
            // rbnitmThreadMsgBox
            // 
            this.rbnitmThreadMsgBox.ColorTable = DevComponents.DotNetBar.eRibbonTabColor.Orange;
            this.rbnitmThreadMsgBox.Name = "rbnitmThreadMsgBox";
            this.rbnitmThreadMsgBox.Panel = this.ribbonPanel2;
            this.rbnitmThreadMsgBox.Text = "演示多线程消息框";
            this.rbnitmThreadMsgBox.Click += new System.EventHandler(this.rbnitmThreadMsgBox_Click);
            // 
            // buttonChangeStyle
            // 
            this.buttonChangeStyle.AutoExpandOnClick = true;
            this.buttonChangeStyle.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.buttonChangeStyle.Name = "buttonChangeStyle";
            this.buttonChangeStyle.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem68,
            this.buttonStyleMetro,
            this.buttonStyleOffice2010Blue,
            this.buttonStyleOffice2010Silver,
            this.buttonStyleOffice2010Black,
            this.buttonStyleVS2010,
            this.buttonItem69,
            this.buttonStyleOffice2007Blue,
            this.buttonStyleOffice2007Black,
            this.buttonStyleOffice2007Silver,
            this.buttonItem70,
            this.buttonItem71,
            this.buttonStyleCustom});
            this.buttonChangeStyle.Text = "Style";
            // 
            // buttonItem68
            // 
            this.buttonItem68.Checked = true;
            this.buttonItem68.CommandParameter = "Office2016";
            this.buttonItem68.Name = "buttonItem68";
            this.buttonItem68.OptionGroup = "style";
            this.buttonItem68.Text = "Office 2016";
            // 
            // buttonStyleMetro
            // 
            this.buttonStyleMetro.CommandParameter = "Metro";
            this.buttonStyleMetro.Name = "buttonStyleMetro";
            this.buttonStyleMetro.OptionGroup = "style";
            this.buttonStyleMetro.Text = "Metro/Office 2013";
            // 
            // buttonStyleOffice2010Blue
            // 
            this.buttonStyleOffice2010Blue.CommandParameter = "Office2010Blue";
            this.buttonStyleOffice2010Blue.Name = "buttonStyleOffice2010Blue";
            this.buttonStyleOffice2010Blue.OptionGroup = "style";
            this.buttonStyleOffice2010Blue.Text = "Office 2010 Blue";
            // 
            // buttonStyleOffice2010Silver
            // 
            this.buttonStyleOffice2010Silver.CommandParameter = "Office2010Silver";
            this.buttonStyleOffice2010Silver.Name = "buttonStyleOffice2010Silver";
            this.buttonStyleOffice2010Silver.OptionGroup = "style";
            this.buttonStyleOffice2010Silver.Text = "Office 2010 <font color=\"Silver\"><b>Silver</b></font>";
            // 
            // buttonStyleOffice2010Black
            // 
            this.buttonStyleOffice2010Black.CommandParameter = "Office2010Black";
            this.buttonStyleOffice2010Black.Name = "buttonStyleOffice2010Black";
            this.buttonStyleOffice2010Black.OptionGroup = "style";
            this.buttonStyleOffice2010Black.Text = "Office 2010 Black";
            // 
            // buttonStyleVS2010
            // 
            this.buttonStyleVS2010.CommandParameter = "VisualStudio2010Blue";
            this.buttonStyleVS2010.Name = "buttonStyleVS2010";
            this.buttonStyleVS2010.OptionGroup = "style";
            this.buttonStyleVS2010.Text = "Visual Studio 2010";
            // 
            // buttonItem69
            // 
            this.buttonItem69.CommandParameter = "Windows7Blue";
            this.buttonItem69.Name = "buttonItem69";
            this.buttonItem69.OptionGroup = "style";
            this.buttonItem69.Text = "Windows 7";
            // 
            // buttonStyleOffice2007Blue
            // 
            this.buttonStyleOffice2007Blue.CommandParameter = "Office2007Blue";
            this.buttonStyleOffice2007Blue.Name = "buttonStyleOffice2007Blue";
            this.buttonStyleOffice2007Blue.OptionGroup = "style";
            this.buttonStyleOffice2007Blue.Text = "Office 2007 <font color=\"Blue\"><b>Blue</b></font>";
            // 
            // buttonStyleOffice2007Black
            // 
            this.buttonStyleOffice2007Black.CommandParameter = "Office2007Black";
            this.buttonStyleOffice2007Black.Name = "buttonStyleOffice2007Black";
            this.buttonStyleOffice2007Black.OptionGroup = "style";
            this.buttonStyleOffice2007Black.Text = "Office 2007 <font color=\"black\"><b>Black</b></font>";
            // 
            // buttonStyleOffice2007Silver
            // 
            this.buttonStyleOffice2007Silver.CommandParameter = "Office2007Silver";
            this.buttonStyleOffice2007Silver.Name = "buttonStyleOffice2007Silver";
            this.buttonStyleOffice2007Silver.OptionGroup = "style";
            this.buttonStyleOffice2007Silver.Text = "Office 2007 <font color=\"Silver\"><b>Silver</b></font>";
            // 
            // buttonItem70
            // 
            this.buttonItem70.CommandParameter = "Office2007VistaGlass";
            this.buttonItem70.Name = "buttonItem70";
            this.buttonItem70.OptionGroup = "style";
            this.buttonItem70.Text = "Vista Glass";
            // 
            // buttonItem71
            // 
            this.buttonItem71.CommandParameter = "VisualStudio2012Light";
            this.buttonItem71.Name = "buttonItem71";
            this.buttonItem71.OptionGroup = "style";
            this.buttonItem71.Text = "Visual Studio 2012 Light";
            // 
            // buttonStyleCustom
            // 
            this.buttonStyleCustom.BeginGroup = true;
            this.buttonStyleCustom.Name = "buttonStyleCustom";
            this.buttonStyleCustom.Text = "Custom scheme";
            this.buttonStyleCustom.Tooltip = "Custom color scheme is created based on currently selected color table. Try selec" +
    "ting Silver or Blue color table and then creating custom color scheme.";
            // 
            // buttonItem47
            // 
            this.buttonItem47.BeginGroup = true;
            this.buttonItem47.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem47.Image")));
            this.buttonItem47.Name = "buttonItem47";
            this.buttonItem47.Text = "Search for Templates Online...";
            // 
            // buttonItem48
            // 
            this.buttonItem48.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem48.Image")));
            this.buttonItem48.Name = "buttonItem48";
            this.buttonItem48.Text = "Browse for Templates...";
            // 
            // buttonItem49
            // 
            this.buttonItem49.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem49.Image")));
            this.buttonItem49.Name = "buttonItem49";
            this.buttonItem49.Text = "Save Current Template...";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "6";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "7";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "8";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "9";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "10";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "11";
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "12";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "13";
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "14";
            // 
            // barStatusBar
            // 
            this.barStatusBar.AccessibleDescription = "DotNetBar Bar (barStatusBar)";
            this.barStatusBar.AccessibleName = "DotNetBar Bar";
            this.barStatusBar.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.barStatusBar.AntiAlias = true;
            this.barStatusBar.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            this.barStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barStatusBar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStatusBar.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle;
            this.barStatusBar.IsMaximized = false;
            this.barStatusBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lbStatusMsg});
            this.barStatusBar.ItemSpacing = 2;
            this.barStatusBar.Location = new System.Drawing.Point(5, 667);
            this.barStatusBar.Name = "barStatusBar";
            this.barStatusBar.PaddingBottom = 0;
            this.barStatusBar.PaddingTop = 0;
            this.barStatusBar.Size = new System.Drawing.Size(979, 19);
            this.barStatusBar.Stretch = true;
            this.barStatusBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barStatusBar.TabIndex = 11;
            this.barStatusBar.TabStop = false;
            this.barStatusBar.Text = "barStatus";
            // 
            // lbStatusMsg
            // 
            this.lbStatusMsg.Name = "lbStatusMsg";
            this.lbStatusMsg.PaddingLeft = 2;
            this.lbStatusMsg.PaddingRight = 2;
            this.lbStatusMsg.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.lbStatusMsg.Stretch = true;
            // 
            // MultiDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 688);
            this.Controls.Add(this.barStatusBar);
            this.Controls.Add(this.rbnctrlHeaderFunc);
            this.EnableGlass = false;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MultiDocForm";
            this.Text = "MultiDocForm";
            this.Controls.SetChildIndex(this.rbnctrlHeaderFunc, 0);
            this.Controls.SetChildIndex(this.barStatusBar, 0);
            this.rbnctrlHeaderFunc.ResumeLayout(false);
            this.rbnctrlHeaderFunc.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barStatusBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.RibbonControl rbnctrlHeaderFunc;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.ButtonItem buttonItem47;
        private DevComponents.DotNetBar.ButtonItem buttonItem48;
        private DevComponents.DotNetBar.ButtonItem buttonItem49;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.Editors.ComboItem comboItem8;
        private DevComponents.Editors.ComboItem comboItem9;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonTabItem rbnitmManageMsgBox;
        private DevComponents.DotNetBar.RibbonTabItem rbnitmThreadMsgBox;
        private DevComponents.DotNetBar.ButtonItem buttonChangeStyle;
        private DevComponents.DotNetBar.ButtonItem buttonItem68;
        private DevComponents.DotNetBar.ButtonItem buttonStyleMetro;
        private DevComponents.DotNetBar.ButtonItem buttonStyleOffice2010Blue;
        private DevComponents.DotNetBar.ButtonItem buttonStyleOffice2010Silver;
        private DevComponents.DotNetBar.ButtonItem buttonStyleOffice2010Black;
        private DevComponents.DotNetBar.ButtonItem buttonStyleVS2010;
        private DevComponents.DotNetBar.ButtonItem buttonItem69;
        private DevComponents.DotNetBar.ButtonItem buttonStyleOffice2007Blue;
        private DevComponents.DotNetBar.ButtonItem buttonStyleOffice2007Black;
        private DevComponents.DotNetBar.ButtonItem buttonStyleOffice2007Silver;
        private DevComponents.DotNetBar.ButtonItem buttonItem70;
        private DevComponents.DotNetBar.ButtonItem buttonItem71;
        private DevComponents.DotNetBar.ColorPickerDropDown buttonStyleCustom;
        private DevComponents.DotNetBar.Bar barStatusBar;
        private DevComponents.DotNetBar.LabelItem lbStatusMsg;
        private Examples.MsgViewExamples.ThreadMsgExampleViewToolBar threadMsgExampleViewToolBar1;
        private Examples.MsgViewExamples.MsgBoxExampleViewToolBar msgBoxExampleViewToolBar1;
    }
}