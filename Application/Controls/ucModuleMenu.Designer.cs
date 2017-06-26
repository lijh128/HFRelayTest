namespace RelayTest.Application.Controls
{
    partial class ucModuleMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucModuleMenu));
            this.mmuModule = new System.Windows.Forms.MenuStrip();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.mmMain = new DevExpress.XtraBars.Bar();
            this.ToolBar = new DevExpress.XtraBars.Bar();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem3 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem4 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem5 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // mmuModule
            // 
            this.mmuModule.Dock = System.Windows.Forms.DockStyle.None;
            this.mmuModule.Location = new System.Drawing.Point(0, 0);
            this.mmuModule.Name = "mmuModule";
            this.mmuModule.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.mmuModule.Size = new System.Drawing.Size(202, 24);
            this.mmuModule.TabIndex = 0;
            this.mmuModule.Text = "menuStrip1";
            this.mmuModule.Visible = false;
            this.mmuModule.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mmuModule_ItemClicked);
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.mmMain,
            this.ToolBar});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.DockWindowTabFont = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barLargeButtonItem1,
            this.barLargeButtonItem2,
            this.barLargeButtonItem3,
            this.barLargeButtonItem4,
            this.barLargeButtonItem5});
            this.barManager.LargeImages = this.imageCollection1;
            this.barManager.MainMenu = this.mmMain;
            this.barManager.MaxItemId = 7;
            this.barManager.CreateToolbar += new DevExpress.XtraBars.CreateToolbarEventHandler(this.barManager_CreateToolbar);
            // 
            // mmMain
            // 
            this.mmMain.Appearance.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mmMain.Appearance.Options.UseFont = true;
            this.mmMain.BarName = "主菜单";
            this.mmMain.DockCol = 0;
            this.mmMain.DockRow = 0;
            this.mmMain.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.mmMain.FloatLocation = new System.Drawing.Point(250, 212);
            this.mmMain.FloatSize = new System.Drawing.Size(46, 20);
            this.mmMain.OptionsBar.AllowQuickCustomization = false;
            this.mmMain.OptionsBar.DrawDragBorder = false;
            this.mmMain.OptionsBar.UseWholeRow = true;
            this.mmMain.Text = "菜单";
            // 
            // ToolBar
            // 
            this.ToolBar.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToolBar.Appearance.Options.UseFont = true;
            this.ToolBar.BarName = "ToolBar";
            this.ToolBar.DockCol = 0;
            this.ToolBar.DockRow = 1;
            this.ToolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.ToolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barLargeButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barLargeButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barLargeButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barLargeButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barLargeButtonItem5, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.ToolBar.Text = "快捷栏";
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "手动计划单";
            this.barLargeButtonItem1.Id = 2;
            this.barLargeButtonItem1.LargeImageIndex = 1;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            this.barLargeButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItem1_ItemClick);
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Caption = "自动计划单";
            this.barLargeButtonItem2.Id = 3;
            this.barLargeButtonItem2.ImageIndex = 7;
            this.barLargeButtonItem2.LargeImageIndex = 0;
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            // 
            // barLargeButtonItem3
            // 
            this.barLargeButtonItem3.Caption = "用户管理";
            this.barLargeButtonItem3.Id = 4;
            this.barLargeButtonItem3.ImageIndex = 6;
            this.barLargeButtonItem3.LargeImageIndex = 2;
            this.barLargeButtonItem3.Name = "barLargeButtonItem3";
            // 
            // barLargeButtonItem4
            // 
            this.barLargeButtonItem4.Caption = "模块管理";
            this.barLargeButtonItem4.Id = 5;
            this.barLargeButtonItem4.ImageIndex = 8;
            this.barLargeButtonItem4.LargeImageIndex = 3;
            this.barLargeButtonItem4.Name = "barLargeButtonItem4";
            // 
            // barLargeButtonItem5
            // 
            this.barLargeButtonItem5.Caption = "注销";
            this.barLargeButtonItem5.Id = 6;
            this.barLargeButtonItem5.ImageIndex = 9;
            this.barLargeButtonItem5.LargeImageIndex = 4;
            this.barLargeButtonItem5.Name = "barLargeButtonItem5";
            this.barLargeButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItem5_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlTop.Size = new System.Drawing.Size(961, 107);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 132);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(961, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 107);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 25);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(961, 107);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 25);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "png133_033.png");
            this.imageCollection1.Images.SetKeyName(1, "png133_051.png");
            this.imageCollection1.Images.SetKeyName(2, "png133_003.png");
            this.imageCollection1.Images.SetKeyName(3, "png133_010.png");
            this.imageCollection1.Images.SetKeyName(4, "png133_092.png");
            // 
            // ucModuleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.mmuModule);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucModuleMenu";
            this.Size = new System.Drawing.Size(961, 132);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.MenuStrip mmuModule;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar mmMain;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar ToolBar;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem3;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem4;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem5;
    }
}
