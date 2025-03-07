namespace TCHRLibBasicRecordSample
{
    partial class TRecordSample
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer Components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (Components != null))
            {
                Components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRecordSample));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timerData = new System.Windows.Forms.Timer(this.components);
            this.SaveDlg = new System.Windows.Forms.SaveFileDialog();
            this.PnlSetting = new System.Windows.Forms.Panel();
            this.PnlDSPage = new System.Windows.Forms.Panel();
            this.PnlNavSetting = new System.Windows.Forms.TableLayoutPanel();
            this.PnlAdvanceSetting = new System.Windows.Forms.Panel();
            this.BtnAdvanceSetting = new System.Windows.Forms.Button();
            this.PnlDefaultSetting = new System.Windows.Forms.Panel();
            this.BtnDefaultSetting = new System.Windows.Forms.Button();
            this.PnlControlBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.PnlMainGrid = new System.Windows.Forms.TableLayoutPanel();
            this.PnlLeftSite = new System.Windows.Forms.TableLayoutPanel();
            this.PnlScanArea = new System.Windows.Forms.Panel();
            this.ImgAreaScan = new System.Windows.Forms.PictureBox();
            this.PnlProgressGrid = new System.Windows.Forms.TableLayoutPanel();
            this.LbScanProgress = new System.Windows.Forms.Label();
            this.PnlHidden = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.RBCHRC = new System.Windows.Forms.RadioButton();
            this.BtDisCon = new System.Windows.Forms.Button();
            this.BtConnect = new System.Windows.Forms.Button();
            this.RBCLS = new System.Windows.Forms.RadioButton();
            this.RBCHR2 = new System.Windows.Forms.RadioButton();
            this.RBCHR1 = new System.Windows.Forms.RadioButton();
            this.TbConInfo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.RBInterfero = new System.Windows.Forms.RadioButton();
            this.RBConfocal = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TBSHZ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBSODX = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.action = new System.Windows.Forms.Button();
            this.CBFlush = new System.Windows.Forms.CheckBox();
            this.TBSampleCount = new System.Windows.Forms.TextBox();
            this.BtSave = new System.Windows.Forms.Button();
            this.BtRecord = new System.Windows.Forms.Button();
            this.PnlChartGrid = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PnlRightSite = new System.Windows.Forms.TableLayoutPanel();
            this.LbTitleSetting = new System.Windows.Forms.Label();
            this.LbTitleControl = new System.Windows.Forms.Label();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerDropDown1 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LbNameChart = new System.Windows.Forms.Label();
            this.PbScan = new TCHRLibBasicRecordSample.CustomUi.DSM_ProgressBar();
            this.DropDown3 = new TCHRLibBasicRecordSample.CustomUI.DSM_DropDownTable(this.components);
            this.BtnSlow = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnFast = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown1 = new TCHRLibBasicRecordSample.CustomUI.DSM_DropDownTable(this.components);
            this.BtnZZ = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRaster = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnOther1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown2 = new TCHRLibBasicRecordSample.CustomUI.DSM_DropDownTable(this.components);
            this.Btn30mm = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn40mm = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn50mm = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnOther2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown4 = new TCHRLibBasicRecordSample.CustomUI.DSM_DropDownTable(this.components);
            this.BtnCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnBCRF = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSUR = new System.Windows.Forms.ToolStripMenuItem();
            this.axDBCommManager1 = new AxDATABUILDERAXLibLB.AxDBCommManager();
            this.axDBTriggerManager1 = new AxDATABUILDERAXLibLB.AxDBTriggerManager();
            this.axDBDeviceManager1 = new AxDATABUILDERAXLibLB.AxDBDeviceManager();
            this.PnlTchAreaGrid = new System.Windows.Forms.TableLayoutPanel();
            this.PnlTchGrid = new System.Windows.Forms.TableLayoutPanel();
            this.TbPos1 = new TCHRLibBasicRecordSample.CustomUi.DSM_TextBox();
            this.TbPos2 = new TCHRLibBasicRecordSample.CustomUi.DSM_TextBox();
            this.BtnSetPos2 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnRunPos2 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnSetPos1 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnRunPos1 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.TbPos3 = new TCHRLibBasicRecordSample.CustomUi.DSM_TextBox();
            this.BtnSetPos3 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnRunPos3 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.LbPos2 = new System.Windows.Forms.Label();
            this.LbPos3 = new System.Windows.Forms.Label();
            this.BtnRunPos4 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.TbPos4 = new TCHRLibBasicRecordSample.CustomUi.DSM_TextBox();
            this.BtnSetPos4 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.LbPos1 = new System.Windows.Forms.Label();
            this.LbPos4 = new System.Windows.Forms.Label();
            this.LbTchPoint = new System.Windows.Forms.Label();
            this.PnlBtnRunGrid = new System.Windows.Forms.TableLayoutPanel();
            this.BtnRunScan = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnSave = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.PnlXYControl = new System.Windows.Forms.TableLayoutPanel();
            this.PnlXYBtn = new System.Windows.Forms.Panel();
            this.BtnUp = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnDown = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnRight = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnUpRight = new TCHRLibBasicRecordSample.CustomUi.DSM_SpecialButton();
            this.BtnLeft = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnRightDown = new TCHRLibBasicRecordSample.CustomUi.DSM_SpecialButton();
            this.BtnHome = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnLeftUp = new TCHRLibBasicRecordSample.CustomUi.DSM_SpecialButton();
            this.LbXYAxis = new System.Windows.Forms.Label();
            this.LbXYSpeed = new System.Windows.Forms.Label();
            this.BtnDownLeft = new TCHRLibBasicRecordSample.CustomUi.DSM_SpecialButton();
            this.PnlChangeSpeedArea = new System.Windows.Forms.TableLayoutPanel();
            this.BtnXYUpSpeed = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnXYDownSpeed = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.TbXYspeed = new TCHRLibBasicRecordSample.CustomUi.DSM_Trackbar();
            this.PnlZControl = new System.Windows.Forms.Panel();
            this.LbZAxis = new System.Windows.Forms.Label();
            this.TbZControl = new TCHRLibBasicRecordSample.CustomUi.DSM_TrackBarImg();
            this.PnlControlGrid = new System.Windows.Forms.TableLayoutPanel();
            this.PnlListBtnSetting = new System.Windows.Forms.TableLayoutPanel();
            this.PnlSelect3 = new System.Windows.Forms.Panel();
            this.BtnSelect3 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.PnlSelect4 = new System.Windows.Forms.Panel();
            this.BtnSelect4 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.PnlSelect2 = new System.Windows.Forms.Panel();
            this.BtnSelect2 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.PnlSelect1 = new System.Windows.Forms.Panel();
            this.BtnSelect1 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.PnlXYCoorGrid = new System.Windows.Forms.TableLayoutPanel();
            this.PnlXYMap = new TCHRLibBasicRecordSample.CustomUi.DSM_GridMap();
            this.LbXYCoor = new System.Windows.Forms.Label();
            this.PnlZCoorGird = new System.Windows.Forms.TableLayoutPanel();
            this.PnlZMap = new TCHRLibBasicRecordSample.CustomUi.DSM_GridMap();
            this.LbZCoor = new System.Windows.Forms.Label();
            this.PnlInfoCoorGrid = new System.Windows.Forms.TableLayoutPanel();
            this.LbXAxisCoor = new System.Windows.Forms.Label();
            this.LbXCoorValue = new System.Windows.Forms.Label();
            this.LbYAxisCoor = new System.Windows.Forms.Label();
            this.LbYCoorValue = new System.Windows.Forms.Label();
            this.LbZAxisCoor = new System.Windows.Forms.Label();
            this.LbZCoorValue = new System.Windows.Forms.Label();
            this.PnlSettingGrid = new System.Windows.Forms.TableLayoutPanel();
            this.PnlSetting.SuspendLayout();
            this.PnlNavSetting.SuspendLayout();
            this.PnlAdvanceSetting.SuspendLayout();
            this.PnlDefaultSetting.SuspendLayout();
            this.PnlControlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.PnlMain.SuspendLayout();
            this.PnlMainGrid.SuspendLayout();
            this.PnlLeftSite.SuspendLayout();
            this.PnlScanArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAreaScan)).BeginInit();
            this.PnlProgressGrid.SuspendLayout();
            this.PnlHidden.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PnlChartGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.PnlRightSite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.DropDown3.SuspendLayout();
            this.DropDown1.SuspendLayout();
            this.DropDown2.SuspendLayout();
            this.DropDown4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axDBCommManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axDBTriggerManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axDBDeviceManager1)).BeginInit();
            this.PnlTchAreaGrid.SuspendLayout();
            this.PnlTchGrid.SuspendLayout();
            this.PnlBtnRunGrid.SuspendLayout();
            this.PnlXYControl.SuspendLayout();
            this.PnlXYBtn.SuspendLayout();
            this.PnlChangeSpeedArea.SuspendLayout();
            this.PnlZControl.SuspendLayout();
            this.PnlControlGrid.SuspendLayout();
            this.PnlListBtnSetting.SuspendLayout();
            this.PnlSelect3.SuspendLayout();
            this.PnlSelect4.SuspendLayout();
            this.PnlSelect2.SuspendLayout();
            this.PnlSelect1.SuspendLayout();
            this.PnlXYCoorGrid.SuspendLayout();
            this.PnlZCoorGird.SuspendLayout();
            this.PnlInfoCoorGrid.SuspendLayout();
            this.PnlSettingGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerData
            // 
            this.timerData.Tick += new System.EventHandler(this.timerData_Tick);
            // 
            // SaveDlg
            // 
            this.SaveDlg.Filter = "Text Files (*.txt)|*.txt";
            // 
            // PnlSetting
            // 
            this.PnlSetting.BackColor = System.Drawing.Color.White;
            this.PnlSetting.Controls.Add(this.PnlDSPage);
            this.PnlSetting.Controls.Add(this.PnlNavSetting);
            this.PnlSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSetting.Location = new System.Drawing.Point(0, 0);
            this.PnlSetting.Margin = new System.Windows.Forms.Padding(0);
            this.PnlSetting.Name = "PnlSetting";
            this.PnlSetting.Size = new System.Drawing.Size(740, 130);
            this.PnlSetting.TabIndex = 25;
            // 
            // PnlDSPage
            // 
            this.PnlDSPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDSPage.Location = new System.Drawing.Point(0, 64);
            this.PnlDSPage.Margin = new System.Windows.Forms.Padding(0);
            this.PnlDSPage.Name = "PnlDSPage";
            this.PnlDSPage.Size = new System.Drawing.Size(740, 66);
            this.PnlDSPage.TabIndex = 1;
            // 
            // PnlNavSetting
            // 
            this.PnlNavSetting.BackColor = System.Drawing.Color.Silver;
            this.PnlNavSetting.ColumnCount = 3;
            this.PnlNavSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.32653F));
            this.PnlNavSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.PnlNavSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.30612F));
            this.PnlNavSetting.Controls.Add(this.PnlAdvanceSetting, 1, 0);
            this.PnlNavSetting.Controls.Add(this.PnlDefaultSetting, 0, 0);
            this.PnlNavSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlNavSetting.Location = new System.Drawing.Point(0, 0);
            this.PnlNavSetting.Margin = new System.Windows.Forms.Padding(0);
            this.PnlNavSetting.Name = "PnlNavSetting";
            this.PnlNavSetting.RowCount = 1;
            this.PnlNavSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlNavSetting.Size = new System.Drawing.Size(740, 64);
            this.PnlNavSetting.TabIndex = 0;
            // 
            // PnlAdvanceSetting
            // 
            this.PnlAdvanceSetting.BackColor = System.Drawing.Color.Silver;
            this.PnlAdvanceSetting.Controls.Add(this.BtnAdvanceSetting);
            this.PnlAdvanceSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlAdvanceSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlAdvanceSetting.Location = new System.Drawing.Point(125, 5);
            this.PnlAdvanceSetting.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.PnlAdvanceSetting.Name = "PnlAdvanceSetting";
            this.PnlAdvanceSetting.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.PnlAdvanceSetting.Size = new System.Drawing.Size(125, 59);
            this.PnlAdvanceSetting.TabIndex = 1;
            // 
            // BtnAdvanceSetting
            // 
            this.BtnAdvanceSetting.BackColor = System.Drawing.Color.Silver;
            this.BtnAdvanceSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdvanceSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdvanceSetting.FlatAppearance.BorderSize = 0;
            this.BtnAdvanceSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdvanceSetting.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdvanceSetting.ForeColor = System.Drawing.SystemColors.GrayText;
            this.BtnAdvanceSetting.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdvanceSetting.Image")));
            this.BtnAdvanceSetting.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAdvanceSetting.Location = new System.Drawing.Point(0, 0);
            this.BtnAdvanceSetting.Name = "BtnAdvanceSetting";
            this.BtnAdvanceSetting.Size = new System.Drawing.Size(125, 55);
            this.BtnAdvanceSetting.TabIndex = 28;
            this.BtnAdvanceSetting.Text = "Advance setting";
            this.BtnAdvanceSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAdvanceSetting.UseVisualStyleBackColor = false;
            this.BtnAdvanceSetting.Click += new System.EventHandler(this.BtnNavSet_Click);
            // 
            // PnlDefaultSetting
            // 
            this.PnlDefaultSetting.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PnlDefaultSetting.Controls.Add(this.BtnDefaultSetting);
            this.PnlDefaultSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlDefaultSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDefaultSetting.Location = new System.Drawing.Point(5, 5);
            this.PnlDefaultSetting.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.PnlDefaultSetting.Name = "PnlDefaultSetting";
            this.PnlDefaultSetting.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.PnlDefaultSetting.Size = new System.Drawing.Size(110, 59);
            this.PnlDefaultSetting.TabIndex = 0;
            // 
            // BtnDefaultSetting
            // 
            this.BtnDefaultSetting.BackColor = System.Drawing.Color.Silver;
            this.BtnDefaultSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDefaultSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDefaultSetting.FlatAppearance.BorderSize = 0;
            this.BtnDefaultSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDefaultSetting.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDefaultSetting.ForeColor = System.Drawing.SystemColors.GrayText;
            this.BtnDefaultSetting.Image = ((System.Drawing.Image)(resources.GetObject("BtnDefaultSetting.Image")));
            this.BtnDefaultSetting.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDefaultSetting.Location = new System.Drawing.Point(0, 0);
            this.BtnDefaultSetting.Name = "BtnDefaultSetting";
            this.BtnDefaultSetting.Size = new System.Drawing.Size(110, 55);
            this.BtnDefaultSetting.TabIndex = 28;
            this.BtnDefaultSetting.Text = "Default setting";
            this.BtnDefaultSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDefaultSetting.UseVisualStyleBackColor = false;
            this.BtnDefaultSetting.Click += new System.EventHandler(this.BtnNavSet_Click);
            // 
            // PnlControlBar
            // 
            this.PnlControlBar.BackColor = System.Drawing.Color.DimGray;
            this.PnlControlBar.Controls.Add(this.pictureBox1);
            this.PnlControlBar.Controls.Add(this.BtnClose);
            this.PnlControlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlControlBar.Location = new System.Drawing.Point(0, 0);
            this.PnlControlBar.Name = "PnlControlBar";
            this.PnlControlBar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.PnlControlBar.Size = new System.Drawing.Size(1540, 42);
            this.PnlControlBar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::TCHRLibBasicRecordSample.Properties.Resources.logo_01;
            this.pictureBox1.InitialImage = global::TCHRLibBasicRecordSample.Properties.Resources.logo_01;
            this.pictureBox1.Location = new System.Drawing.Point(8, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(1499, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(41, 42);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 0;
            this.BtnClose.TabStop = false;
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.Color.Transparent;
            this.PnlMain.Controls.Add(this.PnlMainGrid);
            this.PnlMain.Controls.Add(this.PnlControlBar);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(1540, 845);
            this.PnlMain.TabIndex = 5;
            // 
            // PnlMainGrid
            // 
            this.PnlMainGrid.ColumnCount = 3;
            this.PnlMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.PnlMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlMainGrid.Controls.Add(this.PnlLeftSite, 0, 0);
            this.PnlMainGrid.Controls.Add(this.PnlRightSite, 2, 0);
            this.PnlMainGrid.Controls.Add(this.PnlHidden, 1, 0);
            this.PnlMainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainGrid.Location = new System.Drawing.Point(0, 42);
            this.PnlMainGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMainGrid.Name = "PnlMainGrid";
            this.PnlMainGrid.RowCount = 1;
            this.PnlMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMainGrid.Size = new System.Drawing.Size(1540, 803);
            this.PnlMainGrid.TabIndex = 27;
            // 
            // PnlLeftSite
            // 
            this.PnlLeftSite.BackColor = System.Drawing.Color.PaleGreen;
            this.PnlLeftSite.ColumnCount = 1;
            this.PnlLeftSite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlLeftSite.Controls.Add(this.PnlScanArea, 0, 0);
            this.PnlLeftSite.Controls.Add(this.PnlProgressGrid, 0, 2);
            this.PnlLeftSite.Controls.Add(this.PnlChartGrid, 0, 4);
            this.PnlLeftSite.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeftSite.Location = new System.Drawing.Point(0, 0);
            this.PnlLeftSite.Margin = new System.Windows.Forms.Padding(0);
            this.PnlLeftSite.Name = "PnlLeftSite";
            this.PnlLeftSite.RowCount = 5;
            this.PnlLeftSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlLeftSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.PnlLeftSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.PnlLeftSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.PnlLeftSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.PnlLeftSite.Size = new System.Drawing.Size(752, 803);
            this.PnlLeftSite.TabIndex = 28;
            // 
            // PnlScanArea
            // 
            this.PnlScanArea.AutoSize = true;
            this.PnlScanArea.Controls.Add(this.ImgAreaScan);
            this.PnlScanArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlScanArea.Location = new System.Drawing.Point(12, 24);
            this.PnlScanArea.Margin = new System.Windows.Forms.Padding(0);
            this.PnlScanArea.Name = "PnlScanArea";
            this.PnlScanArea.Padding = new System.Windows.Forms.Padding(36, 24, 36, 24);
            this.PnlScanArea.Size = new System.Drawing.Size(740, 360);
            this.PnlScanArea.TabIndex = 62;
            // 
            // ImgAreaScan
            // 
            this.ImgAreaScan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImgAreaScan.BackColor = System.Drawing.Color.Transparent;
            this.ImgAreaScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgAreaScan.Location = new System.Drawing.Point(-19, -4);
            this.ImgAreaScan.Name = "ImgAreaScan";
            this.ImgAreaScan.Size = new System.Drawing.Size(775, 164);
            this.ImgAreaScan.TabIndex = 34;
            this.ImgAreaScan.TabStop = false;
            // 
            // PnlProgressGrid
            // 
            this.PnlProgressGrid.ColumnCount = 1;
            this.PnlProgressGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlProgressGrid.Controls.Add(this.LbScanProgress, 0, 1);
            this.PnlProgressGrid.Controls.Add(this.PbScan, 0, 0);
            this.PnlProgressGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlProgressGrid.Location = new System.Drawing.Point(12, 408);
            this.PnlProgressGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlProgressGrid.Name = "PnlProgressGrid";
            this.PnlProgressGrid.Padding = new System.Windows.Forms.Padding(36, 8, 36, 8);
            this.PnlProgressGrid.RowCount = 2;
            this.PnlProgressGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.PnlProgressGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.PnlProgressGrid.Size = new System.Drawing.Size(740, 96);
            this.PnlProgressGrid.TabIndex = 62;
            // 
            // LbScanProgress
            // 
            this.LbScanProgress.AutoSize = true;
            this.LbScanProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbScanProgress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbScanProgress.Location = new System.Drawing.Point(36, 56);
            this.LbScanProgress.Margin = new System.Windows.Forms.Padding(0);
            this.LbScanProgress.Name = "LbScanProgress";
            this.LbScanProgress.Size = new System.Drawing.Size(668, 32);
            this.LbScanProgress.TabIndex = 62;
            this.LbScanProgress.Text = "Scanning ...";
            this.LbScanProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlHidden
            // 
            this.PnlHidden.Controls.Add(this.tabControl1);
            this.PnlHidden.Location = new System.Drawing.Point(752, 0);
            this.PnlHidden.Margin = new System.Windows.Forms.Padding(0);
            this.PnlHidden.Name = "PnlHidden";
            this.PnlHidden.Size = new System.Drawing.Size(36, 24);
            this.PnlHidden.TabIndex = 31;
            this.PnlHidden.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(36, 24);
            this.tabControl1.TabIndex = 25;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.panel10);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage1.Size = new System.Drawing.Size(28, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Default setting";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkGray;
            this.panel10.Controls.Add(this.RBCHRC);
            this.panel10.Controls.Add(this.BtDisCon);
            this.panel10.Controls.Add(this.BtConnect);
            this.panel10.Controls.Add(this.RBCLS);
            this.panel10.Controls.Add(this.RBCHR2);
            this.panel10.Controls.Add(this.RBCHR1);
            this.panel10.Controls.Add(this.TbConInfo);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(2, 4);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(24, 0);
            this.panel10.TabIndex = 11;
            // 
            // RBCHRC
            // 
            this.RBCHRC.AutoSize = true;
            this.RBCHRC.Checked = true;
            this.RBCHRC.Location = new System.Drawing.Point(170, 65);
            this.RBCHRC.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RBCHRC.Name = "RBCHRC";
            this.RBCHRC.Size = new System.Drawing.Size(75, 23);
            this.RBCHRC.TabIndex = 16;
            this.RBCHRC.TabStop = true;
            this.RBCHRC.Text = "CHR C";
            this.RBCHRC.UseVisualStyleBackColor = true;
            // 
            // BtDisCon
            // 
            this.BtDisCon.Enabled = false;
            this.BtDisCon.Location = new System.Drawing.Point(303, 12);
            this.BtDisCon.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtDisCon.Name = "BtDisCon";
            this.BtDisCon.Size = new System.Drawing.Size(89, 33);
            this.BtDisCon.TabIndex = 15;
            this.BtDisCon.Text = "Disconnect";
            this.BtDisCon.UseVisualStyleBackColor = true;
            this.BtDisCon.Click += new System.EventHandler(this.BtConnect_Click);
            // 
            // BtConnect
            // 
            this.BtConnect.Location = new System.Drawing.Point(219, 11);
            this.BtConnect.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtConnect.Name = "BtConnect";
            this.BtConnect.Size = new System.Drawing.Size(79, 39);
            this.BtConnect.TabIndex = 14;
            this.BtConnect.Text = "Connect";
            this.BtConnect.UseVisualStyleBackColor = true;
            this.BtConnect.Click += new System.EventHandler(this.BtConnect_Click);
            // 
            // RBCLS
            // 
            this.RBCLS.AutoSize = true;
            this.RBCLS.Location = new System.Drawing.Point(9, 65);
            this.RBCLS.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RBCLS.Name = "RBCLS";
            this.RBCLS.Size = new System.Drawing.Size(162, 23);
            this.RBCLS.TabIndex = 13;
            this.RBCLS.Text = "Multi-Channel CHR";
            this.RBCLS.UseVisualStyleBackColor = true;
            // 
            // RBCHR2
            // 
            this.RBCHR2.AutoSize = true;
            this.RBCHR2.Location = new System.Drawing.Point(170, 41);
            this.RBCHR2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RBCHR2.Name = "RBCHR2";
            this.RBCHR2.Size = new System.Drawing.Size(65, 23);
            this.RBCHR2.TabIndex = 12;
            this.RBCHR2.Text = "CHR²";
            this.RBCHR2.UseVisualStyleBackColor = true;
            // 
            // RBCHR1
            // 
            this.RBCHR1.AutoSize = true;
            this.RBCHR1.Location = new System.Drawing.Point(9, 41);
            this.RBCHR1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RBCHR1.Name = "RBCHR1";
            this.RBCHR1.Size = new System.Drawing.Size(171, 23);
            this.RBCHR1.TabIndex = 11;
            this.RBCHR1.Text = "First Generation CHR";
            this.RBCHR1.UseVisualStyleBackColor = true;
            // 
            // TbConInfo
            // 
            this.TbConInfo.Location = new System.Drawing.Point(107, 15);
            this.TbConInfo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TbConInfo.Name = "TbConInfo";
            this.TbConInfo.Size = new System.Drawing.Size(2, 24);
            this.TbConInfo.TabIndex = 10;
            this.TbConInfo.Text = "192.168.170.2";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.panel9);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage2.Size = new System.Drawing.Size(28, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advance setting";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkGray;
            this.panel9.Controls.Add(this.RBInterfero);
            this.panel9.Controls.Add(this.RBConfocal);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.TBSHZ);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.TBSODX);
            this.panel9.Location = new System.Drawing.Point(340, 21);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(275, 200);
            this.panel9.TabIndex = 11;
            // 
            // RBInterfero
            // 
            this.RBInterfero.AutoSize = true;
            this.RBInterfero.Location = new System.Drawing.Point(201, 9);
            this.RBInterfero.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RBInterfero.Name = "RBInterfero";
            this.RBInterfero.Size = new System.Drawing.Size(129, 23);
            this.RBInterfero.TabIndex = 6;
            this.RBInterfero.Text = "Interferometric";
            this.RBInterfero.UseVisualStyleBackColor = true;
            this.RBInterfero.Click += new System.EventHandler(this.RBConfocal_Click);
            // 
            // RBConfocal
            // 
            this.RBConfocal.AutoSize = true;
            this.RBConfocal.Checked = true;
            this.RBConfocal.Location = new System.Drawing.Point(121, 9);
            this.RBConfocal.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RBConfocal.Name = "RBConfocal";
            this.RBConfocal.Size = new System.Drawing.Size(94, 23);
            this.RBConfocal.TabIndex = 5;
            this.RBConfocal.TabStop = true;
            this.RBConfocal.Text = "Confocal";
            this.RBConfocal.UseVisualStyleBackColor = true;
            this.RBConfocal.Click += new System.EventHandler(this.RBConfocal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Measuring Methos:";
            // 
            // TBSHZ
            // 
            this.TBSHZ.Location = new System.Drawing.Point(107, 31);
            this.TBSHZ.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TBSHZ.Name = "TBSHZ";
            this.TBSHZ.Size = new System.Drawing.Size(2, 24);
            this.TBSHZ.TabIndex = 3;
            this.TBSHZ.Text = "2000";
            this.TBSHZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBSHZ_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Scanrate:";
            // 
            // TBSODX
            // 
            this.TBSODX.Location = new System.Drawing.Point(107, 57);
            this.TBSODX.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TBSODX.Name = "TBSODX";
            this.TBSODX.Size = new System.Drawing.Size(2, 24);
            this.TBSODX.TabIndex = 1;
            this.TBSODX.Text = "83, 65, 66";
            this.TBSODX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBSODX_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.action);
            this.panel2.Controls.Add(this.CBFlush);
            this.panel2.Controls.Add(this.TBSampleCount);
            this.panel2.Controls.Add(this.BtSave);
            this.panel2.Controls.Add(this.BtRecord);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 200);
            this.panel2.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save csv";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // action
            // 
            this.action.Location = new System.Drawing.Point(226, 53);
            this.action.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(79, 31);
            this.action.TabIndex = 6;
            this.action.Text = "Action";
            this.action.UseVisualStyleBackColor = true;
            this.action.Click += new System.EventHandler(this.action_Click);
            // 
            // CBFlush
            // 
            this.CBFlush.AutoSize = true;
            this.CBFlush.Checked = true;
            this.CBFlush.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBFlush.Location = new System.Drawing.Point(2, 57);
            this.CBFlush.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CBFlush.Name = "CBFlush";
            this.CBFlush.Size = new System.Drawing.Size(132, 23);
            this.CBFlush.TabIndex = 5;
            this.CBFlush.Text = "Flush Old Data";
            this.CBFlush.UseVisualStyleBackColor = true;
            // 
            // TBSampleCount
            // 
            this.TBSampleCount.Location = new System.Drawing.Point(6, 23);
            this.TBSampleCount.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TBSampleCount.Name = "TBSampleCount";
            this.TBSampleCount.Size = new System.Drawing.Size(2, 24);
            this.TBSampleCount.TabIndex = 4;
            this.TBSampleCount.Text = "10000";
            // 
            // BtSave
            // 
            this.BtSave.Enabled = false;
            this.BtSave.Location = new System.Drawing.Point(128, 55);
            this.BtSave.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(85, 28);
            this.BtSave.TabIndex = 1;
            this.BtSave.Text = "Save Data";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // BtRecord
            // 
            this.BtRecord.Location = new System.Drawing.Point(128, 4);
            this.BtRecord.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BtRecord.Name = "BtRecord";
            this.BtRecord.Size = new System.Drawing.Size(85, 47);
            this.BtRecord.TabIndex = 0;
            this.BtRecord.Tag = "0";
            this.BtRecord.Text = "Start Recording";
            this.BtRecord.UseVisualStyleBackColor = true;
            this.BtRecord.Click += new System.EventHandler(this.BtRecord_Click);
            // 
            // PnlChartGrid
            // 
            this.PnlChartGrid.ColumnCount = 1;
            this.PnlChartGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlChartGrid.Controls.Add(this.LbNameChart, 0, 1);
            this.PnlChartGrid.Controls.Add(this.chart1, 0, 0);
            this.PnlChartGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlChartGrid.Location = new System.Drawing.Point(12, 528);
            this.PnlChartGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlChartGrid.Name = "PnlChartGrid";
            this.PnlChartGrid.Padding = new System.Windows.Forms.Padding(36, 24, 36, 24);
            this.PnlChartGrid.RowCount = 2;
            this.PnlChartGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlChartGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlChartGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlChartGrid.Size = new System.Drawing.Size(740, 275);
            this.PnlChartGrid.TabIndex = 63;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Black;
            this.chart1.BorderlineColor = System.Drawing.Color.Yellow;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Yellow;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorGrid.Interval = 0D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(36, 24);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Yellow;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerSize = 2;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(668, 188);
            this.chart1.TabIndex = 65;
            this.chart1.Text = "chart1";
            // 
            // PnlRightSite
            // 
            this.PnlRightSite.BackColor = System.Drawing.Color.DarkRed;
            this.PnlRightSite.ColumnCount = 1;
            this.PnlRightSite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlRightSite.Controls.Add(this.PnlSettingGrid, 0, 2);
            this.PnlRightSite.Controls.Add(this.PnlControlGrid, 0, 4);
            this.PnlRightSite.Controls.Add(this.PnlSetting, 0, 0);
            this.PnlRightSite.Controls.Add(this.LbTitleSetting, 0, 1);
            this.PnlRightSite.Controls.Add(this.LbTitleControl, 0, 3);
            this.PnlRightSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlRightSite.Location = new System.Drawing.Point(788, 0);
            this.PnlRightSite.Margin = new System.Windows.Forms.Padding(0);
            this.PnlRightSite.Name = "PnlRightSite";
            this.PnlRightSite.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.PnlRightSite.RowCount = 5;
            this.PnlRightSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.PnlRightSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.PnlRightSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlRightSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.PnlRightSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlRightSite.Size = new System.Drawing.Size(752, 803);
            this.PnlRightSite.TabIndex = 28;
            // 
            // LbTitleSetting
            // 
            this.LbTitleSetting.AutoSize = true;
            this.LbTitleSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbTitleSetting.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitleSetting.Location = new System.Drawing.Point(3, 120);
            this.LbTitleSetting.Name = "LbTitleSetting";
            this.LbTitleSetting.Size = new System.Drawing.Size(734, 28);
            this.LbTitleSetting.TabIndex = 26;
            this.LbTitleSetting.Text = "Setting up";
            this.LbTitleSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbTitleControl
            // 
            this.LbTitleControl.AutoSize = true;
            this.LbTitleControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbTitleControl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitleControl.Location = new System.Drawing.Point(3, 461);
            this.LbTitleControl.Name = "LbTitleControl";
            this.LbTitleControl.Size = new System.Drawing.Size(734, 28);
            this.LbTitleControl.TabIndex = 27;
            this.LbTitleControl.Text = "Control";
            this.LbTitleControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chart4
            // 
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea2);
            this.chart4.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart4.Legends.Add(legend2);
            this.chart4.Location = new System.Drawing.Point(0, 0);
            this.chart4.Margin = new System.Windows.Forms.Padding(1);
            this.chart4.Name = "chart4";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart4.Series.Add(series2);
            this.chart4.Size = new System.Drawing.Size(775, 192);
            this.chart4.TabIndex = 34;
            this.chart4.Text = "chart4";
            // 
            // timerDropDown1
            // 
            this.timerDropDown1.Interval = 1;
            this.timerDropDown1.Tick += new System.EventHandler(this.timerComboBox_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LbNameChart
            // 
            this.LbNameChart.AutoSize = true;
            this.LbNameChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbNameChart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNameChart.Location = new System.Drawing.Point(38, 228);
            this.LbNameChart.Margin = new System.Windows.Forms.Padding(2, 16, 2, 0);
            this.LbNameChart.Name = "LbNameChart";
            this.LbNameChart.Size = new System.Drawing.Size(664, 23);
            this.LbNameChart.TabIndex = 63;
            this.LbNameChart.Text = "Spectrum view";
            this.LbNameChart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PbScan
            // 
            this.PbScan.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.PbScan.ChannelHeight = 18;
            this.PbScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbScan.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.PbScan.ForeBackColor = System.Drawing.Color.Transparent;
            this.PbScan.ForeColor = System.Drawing.Color.White;
            this.PbScan.Location = new System.Drawing.Point(39, 11);
            this.PbScan.Name = "PbScan";
            this.PbScan.ShowMaximun = false;
            this.PbScan.ShowValue = TCHRLibBasicRecordSample.CustomUi.TextPosition.Sliding;
            this.PbScan.Size = new System.Drawing.Size(662, 42);
            this.PbScan.SliderColor = System.Drawing.Color.RosyBrown;
            this.PbScan.SliderHeight = 18;
            this.PbScan.SymbolAfter = "%";
            this.PbScan.SymbolBefore = "";
            this.PbScan.TabIndex = 35;
            // 
            // DropDown3
            // 
            this.DropDown3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DropDown3.IsMainMenu = false;
            this.DropDown3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSlow,
            this.BtnNormal,
            this.BtnFast});
            this.DropDown3.MenuItemHeight = 25;
            this.DropDown3.MenuItemTextColor = System.Drawing.Color.Empty;
            this.DropDown3.Name = "DropDown1";
            this.DropDown3.PrimaryColor = System.Drawing.Color.Empty;
            this.DropDown3.Size = new System.Drawing.Size(155, 76);
            // 
            // BtnSlow
            // 
            this.BtnSlow.Name = "BtnSlow";
            this.BtnSlow.Size = new System.Drawing.Size(154, 24);
            this.BtnSlow.Text = "Slow           ";
            this.BtnSlow.Click += new System.EventHandler(this.BtnSlow_Click);
            // 
            // BtnNormal
            // 
            this.BtnNormal.Name = "BtnNormal";
            this.BtnNormal.Size = new System.Drawing.Size(154, 24);
            this.BtnNormal.Text = "Normal";
            this.BtnNormal.Click += new System.EventHandler(this.BtnNormal_Click);
            // 
            // BtnFast
            // 
            this.BtnFast.Name = "BtnFast";
            this.BtnFast.Size = new System.Drawing.Size(154, 24);
            this.BtnFast.Text = "Fast";
            this.BtnFast.Click += new System.EventHandler(this.BtnFast_Click);
            // 
            // DropDown1
            // 
            this.DropDown1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DropDown1.IsMainMenu = false;
            this.DropDown1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnZZ,
            this.BtnRaster,
            this.BtnOther1});
            this.DropDown1.MenuItemHeight = 25;
            this.DropDown1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.DropDown1.Name = "DropDown1";
            this.DropDown1.PrimaryColor = System.Drawing.Color.Empty;
            this.DropDown1.Size = new System.Drawing.Size(154, 76);
            // 
            // BtnZZ
            // 
            this.BtnZZ.Name = "BtnZZ";
            this.BtnZZ.Size = new System.Drawing.Size(153, 24);
            this.BtnZZ.Text = "ZicZag Run";
            this.BtnZZ.Click += new System.EventHandler(this.BtnZZ_Click);
            // 
            // BtnRaster
            // 
            this.BtnRaster.Name = "BtnRaster";
            this.BtnRaster.Size = new System.Drawing.Size(153, 24);
            this.BtnRaster.Text = "Raster Run";
            this.BtnRaster.Click += new System.EventHandler(this.BtnRaster_Click);
            // 
            // BtnOther1
            // 
            this.BtnOther1.Name = "BtnOther1";
            this.BtnOther1.Size = new System.Drawing.Size(153, 24);
            this.BtnOther1.Text = "Other";
            this.BtnOther1.Click += new System.EventHandler(this.BtnOther1_Click);
            // 
            // DropDown2
            // 
            this.DropDown2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DropDown2.IsMainMenu = false;
            this.DropDown2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn30mm,
            this.Btn40mm,
            this.Btn50mm,
            this.BtnOther2});
            this.DropDown2.MenuItemHeight = 25;
            this.DropDown2.MenuItemTextColor = System.Drawing.Color.Empty;
            this.DropDown2.Name = "DropDown1";
            this.DropDown2.PrimaryColor = System.Drawing.Color.Empty;
            this.DropDown2.Size = new System.Drawing.Size(152, 100);
            // 
            // Btn30mm
            // 
            this.Btn30mm.Name = "Btn30mm";
            this.Btn30mm.Size = new System.Drawing.Size(151, 24);
            this.Btn30mm.Text = "30x30mm  ";
            this.Btn30mm.Click += new System.EventHandler(this.Btn30mm_Click);
            // 
            // Btn40mm
            // 
            this.Btn40mm.Name = "Btn40mm";
            this.Btn40mm.Size = new System.Drawing.Size(151, 24);
            this.Btn40mm.Text = "40x40mm";
            this.Btn40mm.Click += new System.EventHandler(this.Btn40mm_Click);
            // 
            // Btn50mm
            // 
            this.Btn50mm.Name = "Btn50mm";
            this.Btn50mm.Size = new System.Drawing.Size(151, 24);
            this.Btn50mm.Text = "50x50mm";
            this.Btn50mm.Click += new System.EventHandler(this.Btn50mm_Click);
            // 
            // BtnOther2
            // 
            this.BtnOther2.Name = "BtnOther2";
            this.BtnOther2.Size = new System.Drawing.Size(151, 24);
            this.BtnOther2.Text = "Other";
            this.BtnOther2.Click += new System.EventHandler(this.BtnOther2_Click);
            // 
            // DropDown4
            // 
            this.DropDown4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DropDown4.IsMainMenu = false;
            this.DropDown4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCSV,
            this.BtnBCRF,
            this.BtnSUR});
            this.DropDown4.MenuItemHeight = 25;
            this.DropDown4.MenuItemTextColor = System.Drawing.Color.Empty;
            this.DropDown4.Name = "DropDown1";
            this.DropDown4.PrimaryColor = System.Drawing.Color.Empty;
            this.DropDown4.Size = new System.Drawing.Size(152, 76);
            // 
            // BtnCSV
            // 
            this.BtnCSV.Name = "BtnCSV";
            this.BtnCSV.Size = new System.Drawing.Size(151, 24);
            this.BtnCSV.Text = "Save CSV";
            this.BtnCSV.Click += new System.EventHandler(this.BtnCSV_Click);
            // 
            // BtnBCRF
            // 
            this.BtnBCRF.Name = "BtnBCRF";
            this.BtnBCRF.Size = new System.Drawing.Size(151, 24);
            this.BtnBCRF.Text = "Save BCRF ";
            this.BtnBCRF.Click += new System.EventHandler(this.BtnBCRF_Click);
            // 
            // BtnSUR
            // 
            this.BtnSUR.Name = "BtnSUR";
            this.BtnSUR.Size = new System.Drawing.Size(151, 24);
            this.BtnSUR.Text = "Save SUR";
            this.BtnSUR.Click += new System.EventHandler(this.BtnSUR_Click);
            // 
            // axDBCommManager1
            // 
            this.axDBCommManager1.Enabled = true;
            this.axDBCommManager1.Location = new System.Drawing.Point(273, 3);
            this.axDBCommManager1.Name = "axDBCommManager1";
            this.axDBCommManager1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDBCommManager1.OcxState")));
            this.axDBCommManager1.Size = new System.Drawing.Size(30, 30);
            this.axDBCommManager1.TabIndex = 63;
            // 
            // axDBTriggerManager1
            // 
            this.axDBTriggerManager1.Enabled = true;
            this.axDBTriggerManager1.Location = new System.Drawing.Point(273, 33);
            this.axDBTriggerManager1.Name = "axDBTriggerManager1";
            this.axDBTriggerManager1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDBTriggerManager1.OcxState")));
            this.axDBTriggerManager1.Size = new System.Drawing.Size(30, 30);
            this.axDBTriggerManager1.TabIndex = 64;
            // 
            // axDBDeviceManager1
            // 
            this.axDBDeviceManager1.Enabled = true;
            this.axDBDeviceManager1.Location = new System.Drawing.Point(270, 57);
            this.axDBDeviceManager1.Name = "axDBDeviceManager1";
            this.axDBDeviceManager1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDBDeviceManager1.OcxState")));
            this.axDBDeviceManager1.Size = new System.Drawing.Size(30, 30);
            this.axDBDeviceManager1.TabIndex = 65;
            this.axDBDeviceManager1.BeforeRead += new System.EventHandler(this.axDBDeviceManager1_BeforeRead);
            // 
            // PnlTchAreaGrid
            // 
            this.PnlTchAreaGrid.BackColor = System.Drawing.Color.Pink;
            this.PnlTchAreaGrid.ColumnCount = 1;
            this.PnlTchAreaGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTchAreaGrid.Controls.Add(this.PnlBtnRunGrid, 0, 3);
            this.PnlTchAreaGrid.Controls.Add(this.LbTchPoint, 0, 0);
            this.PnlTchAreaGrid.Controls.Add(this.PnlTchGrid, 0, 1);
            this.PnlTchAreaGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTchAreaGrid.Location = new System.Drawing.Point(396, 27);
            this.PnlTchAreaGrid.Name = "PnlTchAreaGrid";
            this.PnlTchAreaGrid.RowCount = 4;
            this.PnlTchAreaGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.PnlTchAreaGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.PnlTchAreaGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTchAreaGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.PnlTchAreaGrid.Size = new System.Drawing.Size(317, 260);
            this.PnlTchAreaGrid.TabIndex = 40;
            // 
            // PnlTchGrid
            // 
            this.PnlTchGrid.ColumnCount = 4;
            this.PnlTchGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.90654F));
            this.PnlTchGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.90654F));
            this.PnlTchGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PnlTchGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PnlTchGrid.Controls.Add(this.LbPos4, 0, 3);
            this.PnlTchGrid.Controls.Add(this.LbPos1, 0, 0);
            this.PnlTchGrid.Controls.Add(this.BtnSetPos4, 3, 3);
            this.PnlTchGrid.Controls.Add(this.TbPos4, 1, 3);
            this.PnlTchGrid.Controls.Add(this.BtnRunPos4, 2, 3);
            this.PnlTchGrid.Controls.Add(this.LbPos3, 0, 2);
            this.PnlTchGrid.Controls.Add(this.LbPos2, 0, 1);
            this.PnlTchGrid.Controls.Add(this.BtnRunPos3, 2, 2);
            this.PnlTchGrid.Controls.Add(this.BtnSetPos3, 3, 2);
            this.PnlTchGrid.Controls.Add(this.TbPos3, 1, 2);
            this.PnlTchGrid.Controls.Add(this.BtnRunPos1, 2, 0);
            this.PnlTchGrid.Controls.Add(this.BtnSetPos1, 3, 0);
            this.PnlTchGrid.Controls.Add(this.BtnRunPos2, 2, 1);
            this.PnlTchGrid.Controls.Add(this.BtnSetPos2, 3, 1);
            this.PnlTchGrid.Controls.Add(this.TbPos2, 1, 1);
            this.PnlTchGrid.Controls.Add(this.TbPos1, 1, 0);
            this.PnlTchGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTchGrid.Location = new System.Drawing.Point(3, 27);
            this.PnlTchGrid.Name = "PnlTchGrid";
            this.PnlTchGrid.RowCount = 4;
            this.PnlTchGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.PnlTchGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.PnlTchGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.PnlTchGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.PnlTchGrid.Size = new System.Drawing.Size(311, 169);
            this.PnlTchGrid.TabIndex = 27;
            // 
            // TbPos1
            // 
            this.TbPos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.TbPos1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbPos1.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.TbPos1.BorderSize = 1;
            this.TbPos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPos1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbPos1.Location = new System.Drawing.Point(98, 5);
            this.TbPos1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TbPos1.Multiline = false;
            this.TbPos1.Name = "TbPos1";
            this.TbPos1.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.TbPos1.PasswordChar = false;
            this.TbPos1.Size = new System.Drawing.Size(83, 40);
            this.TbPos1.TabIndex = 56;
            this.TbPos1.UnderlineStyle = false;
            // 
            // TbPos2
            // 
            this.TbPos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.TbPos2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbPos2.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.TbPos2.BorderSize = 1;
            this.TbPos2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPos2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbPos2.Location = new System.Drawing.Point(98, 48);
            this.TbPos2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TbPos2.Multiline = false;
            this.TbPos2.Name = "TbPos2";
            this.TbPos2.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.TbPos2.PasswordChar = false;
            this.TbPos2.Size = new System.Drawing.Size(83, 40);
            this.TbPos2.TabIndex = 54;
            this.TbPos2.UnderlineStyle = false;
            // 
            // BtnSetPos2
            // 
            this.BtnSetPos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnSetPos2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnSetPos2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSetPos2.BorderRadius = 8;
            this.BtnSetPos2.BorderSize = 1;
            this.BtnSetPos2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetPos2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSetPos2.FlatAppearance.BorderSize = 0;
            this.BtnSetPos2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetPos2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnSetPos2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSetPos2.Location = new System.Drawing.Point(254, 46);
            this.BtnSetPos2.Margin = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.BtnSetPos2.Name = "BtnSetPos2";
            this.BtnSetPos2.Size = new System.Drawing.Size(57, 37);
            this.BtnSetPos2.TabIndex = 44;
            this.BtnSetPos2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSetPos2.TextContent = "";
            this.BtnSetPos2.UseVisualStyleBackColor = false;
            this.BtnSetPos2.Click += new System.EventHandler(this.BtnSetPos2_Click);
            // 
            // BtnRunPos2
            // 
            this.BtnRunPos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnRunPos2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnRunPos2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunPos2.BorderRadius = 8;
            this.BtnRunPos2.BorderSize = 1;
            this.BtnRunPos2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRunPos2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRunPos2.FlatAppearance.BorderSize = 0;
            this.BtnRunPos2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRunPos2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnRunPos2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunPos2.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_run;
            this.BtnRunPos2.Location = new System.Drawing.Point(189, 46);
            this.BtnRunPos2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.BtnRunPos2.Name = "BtnRunPos2";
            this.BtnRunPos2.Size = new System.Drawing.Size(59, 37);
            this.BtnRunPos2.TabIndex = 45;
            this.BtnRunPos2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunPos2.TextContent = "";
            this.BtnRunPos2.UseVisualStyleBackColor = false;
            // 
            // BtnSetPos1
            // 
            this.BtnSetPos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnSetPos1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnSetPos1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSetPos1.BorderRadius = 8;
            this.BtnSetPos1.BorderSize = 1;
            this.BtnSetPos1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetPos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSetPos1.FlatAppearance.BorderSize = 0;
            this.BtnSetPos1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetPos1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnSetPos1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSetPos1.Location = new System.Drawing.Point(254, 3);
            this.BtnSetPos1.Margin = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.BtnSetPos1.Name = "BtnSetPos1";
            this.BtnSetPos1.Size = new System.Drawing.Size(57, 37);
            this.BtnSetPos1.TabIndex = 41;
            this.BtnSetPos1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSetPos1.TextContent = "";
            this.BtnSetPos1.UseVisualStyleBackColor = false;
            this.BtnSetPos1.Click += new System.EventHandler(this.BtnSetPos1_Click);
            this.BtnSetPos1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSetPos1_MouseDown);
            this.BtnSetPos1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnSetPos1_MouseUp);
            // 
            // BtnRunPos1
            // 
            this.BtnRunPos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnRunPos1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnRunPos1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunPos1.BorderRadius = 8;
            this.BtnRunPos1.BorderSize = 1;
            this.BtnRunPos1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRunPos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRunPos1.FlatAppearance.BorderSize = 0;
            this.BtnRunPos1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRunPos1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnRunPos1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunPos1.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_run;
            this.BtnRunPos1.Location = new System.Drawing.Point(189, 3);
            this.BtnRunPos1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.BtnRunPos1.Name = "BtnRunPos1";
            this.BtnRunPos1.Size = new System.Drawing.Size(59, 37);
            this.BtnRunPos1.TabIndex = 41;
            this.BtnRunPos1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunPos1.TextContent = "";
            this.BtnRunPos1.UseVisualStyleBackColor = false;
            this.BtnRunPos1.Click += new System.EventHandler(this.BtnRunPos1_Click);
            this.BtnRunPos1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnRunPos1_MouseDown);
            this.BtnRunPos1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnRunPos1_MouseUp);
            // 
            // TbPos3
            // 
            this.TbPos3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.TbPos3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbPos3.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.TbPos3.BorderSize = 1;
            this.TbPos3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPos3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbPos3.Location = new System.Drawing.Point(98, 91);
            this.TbPos3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TbPos3.Multiline = false;
            this.TbPos3.Name = "TbPos3";
            this.TbPos3.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.TbPos3.PasswordChar = false;
            this.TbPos3.Size = new System.Drawing.Size(83, 40);
            this.TbPos3.TabIndex = 55;
            this.TbPos3.UnderlineStyle = false;
            // 
            // BtnSetPos3
            // 
            this.BtnSetPos3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnSetPos3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnSetPos3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSetPos3.BorderRadius = 8;
            this.BtnSetPos3.BorderSize = 1;
            this.BtnSetPos3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetPos3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSetPos3.FlatAppearance.BorderSize = 0;
            this.BtnSetPos3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetPos3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnSetPos3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSetPos3.Location = new System.Drawing.Point(254, 89);
            this.BtnSetPos3.Margin = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.BtnSetPos3.Name = "BtnSetPos3";
            this.BtnSetPos3.Size = new System.Drawing.Size(57, 37);
            this.BtnSetPos3.TabIndex = 48;
            this.BtnSetPos3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSetPos3.TextContent = "";
            this.BtnSetPos3.UseVisualStyleBackColor = false;
            this.BtnSetPos3.Click += new System.EventHandler(this.BtnSetPos3_Click);
            // 
            // BtnRunPos3
            // 
            this.BtnRunPos3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnRunPos3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnRunPos3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunPos3.BorderRadius = 8;
            this.BtnRunPos3.BorderSize = 1;
            this.BtnRunPos3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRunPos3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRunPos3.FlatAppearance.BorderSize = 0;
            this.BtnRunPos3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRunPos3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnRunPos3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunPos3.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_run;
            this.BtnRunPos3.Location = new System.Drawing.Point(189, 89);
            this.BtnRunPos3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.BtnRunPos3.Name = "BtnRunPos3";
            this.BtnRunPos3.Size = new System.Drawing.Size(59, 37);
            this.BtnRunPos3.TabIndex = 49;
            this.BtnRunPos3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunPos3.TextContent = "";
            this.BtnRunPos3.UseVisualStyleBackColor = false;
            // 
            // LbPos2
            // 
            this.LbPos2.AutoSize = true;
            this.LbPos2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbPos2.Location = new System.Drawing.Point(2, 43);
            this.LbPos2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbPos2.Name = "LbPos2";
            this.LbPos2.Size = new System.Drawing.Size(89, 43);
            this.LbPos2.TabIndex = 60;
            this.LbPos2.Text = "Position 2:";
            this.LbPos2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbPos3
            // 
            this.LbPos3.AutoSize = true;
            this.LbPos3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbPos3.Location = new System.Drawing.Point(2, 86);
            this.LbPos3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbPos3.Name = "LbPos3";
            this.LbPos3.Size = new System.Drawing.Size(89, 43);
            this.LbPos3.TabIndex = 60;
            this.LbPos3.Text = "Position 3:";
            this.LbPos3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnRunPos4
            // 
            this.BtnRunPos4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnRunPos4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnRunPos4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunPos4.BorderRadius = 8;
            this.BtnRunPos4.BorderSize = 1;
            this.BtnRunPos4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRunPos4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRunPos4.FlatAppearance.BorderSize = 0;
            this.BtnRunPos4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRunPos4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnRunPos4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunPos4.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_run;
            this.BtnRunPos4.Location = new System.Drawing.Point(189, 132);
            this.BtnRunPos4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.BtnRunPos4.Name = "BtnRunPos4";
            this.BtnRunPos4.Size = new System.Drawing.Size(59, 37);
            this.BtnRunPos4.TabIndex = 53;
            this.BtnRunPos4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunPos4.TextContent = "";
            this.BtnRunPos4.UseVisualStyleBackColor = false;
            // 
            // TbPos4
            // 
            this.TbPos4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.TbPos4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbPos4.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.TbPos4.BorderSize = 1;
            this.TbPos4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPos4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbPos4.Location = new System.Drawing.Point(98, 134);
            this.TbPos4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TbPos4.Multiline = false;
            this.TbPos4.Name = "TbPos4";
            this.TbPos4.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.TbPos4.PasswordChar = false;
            this.TbPos4.Size = new System.Drawing.Size(83, 40);
            this.TbPos4.TabIndex = 57;
            this.TbPos4.UnderlineStyle = false;
            // 
            // BtnSetPos4
            // 
            this.BtnSetPos4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnSetPos4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnSetPos4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSetPos4.BorderRadius = 8;
            this.BtnSetPos4.BorderSize = 1;
            this.BtnSetPos4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetPos4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSetPos4.FlatAppearance.BorderSize = 0;
            this.BtnSetPos4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetPos4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnSetPos4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSetPos4.Location = new System.Drawing.Point(254, 132);
            this.BtnSetPos4.Margin = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.BtnSetPos4.Name = "BtnSetPos4";
            this.BtnSetPos4.Size = new System.Drawing.Size(57, 37);
            this.BtnSetPos4.TabIndex = 52;
            this.BtnSetPos4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSetPos4.TextContent = "";
            this.BtnSetPos4.UseVisualStyleBackColor = false;
            this.BtnSetPos4.Click += new System.EventHandler(this.BtnSetPos4_Click);
            // 
            // LbPos1
            // 
            this.LbPos1.AutoSize = true;
            this.LbPos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbPos1.Location = new System.Drawing.Point(2, 0);
            this.LbPos1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbPos1.Name = "LbPos1";
            this.LbPos1.Size = new System.Drawing.Size(89, 43);
            this.LbPos1.TabIndex = 60;
            this.LbPos1.Text = "Position 1:";
            this.LbPos1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbPos4
            // 
            this.LbPos4.AutoSize = true;
            this.LbPos4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbPos4.Location = new System.Drawing.Point(2, 129);
            this.LbPos4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbPos4.Name = "LbPos4";
            this.LbPos4.Size = new System.Drawing.Size(89, 43);
            this.LbPos4.TabIndex = 60;
            this.LbPos4.Text = "Position 4:";
            this.LbPos4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbTchPoint
            // 
            this.LbTchPoint.AutoSize = true;
            this.LbTchPoint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTchPoint.Location = new System.Drawing.Point(2, 0);
            this.LbTchPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbTchPoint.Name = "LbTchPoint";
            this.LbTchPoint.Size = new System.Drawing.Size(81, 23);
            this.LbTchPoint.TabIndex = 63;
            this.LbTchPoint.Text = "Control";
            // 
            // PnlBtnRunGrid
            // 
            this.PnlBtnRunGrid.ColumnCount = 2;
            this.PnlBtnRunGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.PnlBtnRunGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.PnlBtnRunGrid.Controls.Add(this.BtnSave, 1, 0);
            this.PnlBtnRunGrid.Controls.Add(this.BtnRunScan, 0, 0);
            this.PnlBtnRunGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBtnRunGrid.Location = new System.Drawing.Point(0, 218);
            this.PnlBtnRunGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlBtnRunGrid.Name = "PnlBtnRunGrid";
            this.PnlBtnRunGrid.RowCount = 1;
            this.PnlBtnRunGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlBtnRunGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.PnlBtnRunGrid.Size = new System.Drawing.Size(317, 42);
            this.PnlBtnRunGrid.TabIndex = 64;
            // 
            // BtnRunScan
            // 
            this.BtnRunScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnRunScan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnRunScan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunScan.BorderRadius = 8;
            this.BtnRunScan.BorderSize = 1;
            this.BtnRunScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRunScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRunScan.FlatAppearance.BorderSize = 0;
            this.BtnRunScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRunScan.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRunScan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunScan.Location = new System.Drawing.Point(0, 0);
            this.BtnRunScan.Margin = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.BtnRunScan.Name = "BtnRunScan";
            this.BtnRunScan.Size = new System.Drawing.Size(158, 42);
            this.BtnRunScan.TabIndex = 59;
            this.BtnRunScan.Text = "SCAN";
            this.BtnRunScan.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunScan.TextContent = "SCAN";
            this.BtnRunScan.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSave.BorderRadius = 8;
            this.BtnSave.BorderSize = 1;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSave.Location = new System.Drawing.Point(190, 0);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(124, 42);
            this.BtnSave.TabIndex = 60;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSave.TextContent = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = false;
            // 
            // PnlXYControl
            // 
            this.PnlXYControl.ColumnCount = 1;
            this.PnlXYControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlXYControl.Controls.Add(this.PnlChangeSpeedArea, 0, 1);
            this.PnlXYControl.Controls.Add(this.PnlXYBtn, 0, 0);
            this.PnlXYControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlXYControl.Location = new System.Drawing.Point(36, 24);
            this.PnlXYControl.Margin = new System.Windows.Forms.Padding(0);
            this.PnlXYControl.Name = "PnlXYControl";
            this.PnlXYControl.RowCount = 2;
            this.PnlXYControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlXYControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.PnlXYControl.Size = new System.Drawing.Size(300, 266);
            this.PnlXYControl.TabIndex = 27;
            // 
            // PnlXYBtn
            // 
            this.PnlXYBtn.Controls.Add(this.axDBDeviceManager1);
            this.PnlXYBtn.Controls.Add(this.axDBTriggerManager1);
            this.PnlXYBtn.Controls.Add(this.axDBCommManager1);
            this.PnlXYBtn.Controls.Add(this.BtnDownLeft);
            this.PnlXYBtn.Controls.Add(this.LbXYSpeed);
            this.PnlXYBtn.Controls.Add(this.LbXYAxis);
            this.PnlXYBtn.Controls.Add(this.BtnLeftUp);
            this.PnlXYBtn.Controls.Add(this.BtnHome);
            this.PnlXYBtn.Controls.Add(this.BtnRightDown);
            this.PnlXYBtn.Controls.Add(this.BtnLeft);
            this.PnlXYBtn.Controls.Add(this.BtnUpRight);
            this.PnlXYBtn.Controls.Add(this.BtnRight);
            this.PnlXYBtn.Controls.Add(this.BtnDown);
            this.PnlXYBtn.Controls.Add(this.BtnUp);
            this.PnlXYBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlXYBtn.Location = new System.Drawing.Point(0, 0);
            this.PnlXYBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PnlXYBtn.Name = "PnlXYBtn";
            this.PnlXYBtn.Size = new System.Drawing.Size(300, 224);
            this.PnlXYBtn.TabIndex = 27;
            // 
            // BtnUp
            // 
            this.BtnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnUp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnUp.BorderColor = System.Drawing.Color.Black;
            this.BtnUp.BorderRadius = 9;
            this.BtnUp.BorderSize = 2;
            this.BtnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUp.FlatAppearance.BorderSize = 0;
            this.BtnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnUp.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_up;
            this.BtnUp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnUp.Location = new System.Drawing.Point(128, 23);
            this.BtnUp.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnUp.Size = new System.Drawing.Size(48, 64);
            this.BtnUp.TabIndex = 7;
            this.BtnUp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnUp.TextContent = "";
            this.BtnUp.UseVisualStyleBackColor = false;
            this.BtnUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnUp_MouseDown);
            this.BtnUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnUp_MouseUp);
            // 
            // BtnDown
            // 
            this.BtnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnDown.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnDown.BorderColor = System.Drawing.Color.Black;
            this.BtnDown.BorderRadius = 9;
            this.BtnDown.BorderSize = 2;
            this.BtnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDown.FlatAppearance.BorderSize = 0;
            this.BtnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDown.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnDown.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_down;
            this.BtnDown.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDown.Location = new System.Drawing.Point(128, 142);
            this.BtnDown.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.BtnDown.Size = new System.Drawing.Size(48, 64);
            this.BtnDown.TabIndex = 6;
            this.BtnDown.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnDown.TextContent = "";
            this.BtnDown.UseVisualStyleBackColor = false;
            this.BtnDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnDown_MouseDown);
            this.BtnDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnDown_MouseUp);
            // 
            // BtnRight
            // 
            this.BtnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnRight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnRight.BorderColor = System.Drawing.Color.Black;
            this.BtnRight.BorderRadius = 9;
            this.BtnRight.BorderSize = 2;
            this.BtnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRight.FlatAppearance.BorderSize = 0;
            this.BtnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRight.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRight.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_right;
            this.BtnRight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRight.Location = new System.Drawing.Point(180, 90);
            this.BtnRight.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.BtnRight.Size = new System.Drawing.Size(64, 48);
            this.BtnRight.TabIndex = 5;
            this.BtnRight.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRight.TextContent = "";
            this.BtnRight.UseVisualStyleBackColor = false;
            this.BtnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnRight_MouseDown);
            this.BtnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnRight_MouseUp);
            // 
            // BtnUpRight
            // 
            this.BtnUpRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnUpRight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnUpRight.BorderColor = System.Drawing.Color.White;
            this.BtnUpRight.BorderRadius = 9;
            this.BtnUpRight.BorderSize = 1;
            this.BtnUpRight.Corner = 2;
            this.BtnUpRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpRight.FlatAppearance.BorderSize = 0;
            this.BtnUpRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpRight.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnUpRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnUpRight.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_45_deg;
            this.BtnUpRight.Location = new System.Drawing.Point(180, 23);
            this.BtnUpRight.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpRight.Name = "BtnUpRight";
            this.BtnUpRight.Size = new System.Drawing.Size(64, 64);
            this.BtnUpRight.TabIndex = 11;
            this.BtnUpRight.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnUpRight.UseVisualStyleBackColor = false;
            this.BtnUpRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnUpRight_MouseDown);
            this.BtnUpRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnUpRight_MouseUp);
            // 
            // BtnLeft
            // 
            this.BtnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnLeft.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnLeft.BorderColor = System.Drawing.Color.Black;
            this.BtnLeft.BorderRadius = 9;
            this.BtnLeft.BorderSize = 2;
            this.BtnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLeft.FlatAppearance.BorderSize = 0;
            this.BtnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLeft.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnLeft.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_left;
            this.BtnLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLeft.Location = new System.Drawing.Point(60, 90);
            this.BtnLeft.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnLeft.Size = new System.Drawing.Size(64, 48);
            this.BtnLeft.TabIndex = 4;
            this.BtnLeft.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnLeft.TextContent = "";
            this.BtnLeft.UseVisualStyleBackColor = false;
            this.BtnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnLeft_MouseDown);
            this.BtnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnLeft_MouseUp);
            // 
            // BtnRightDown
            // 
            this.BtnRightDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnRightDown.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnRightDown.BorderColor = System.Drawing.Color.White;
            this.BtnRightDown.BorderRadius = 9;
            this.BtnRightDown.BorderSize = 1;
            this.BtnRightDown.Corner = 3;
            this.BtnRightDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRightDown.FlatAppearance.BorderSize = 0;
            this.BtnRightDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRightDown.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnRightDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRightDown.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_315_deg;
            this.BtnRightDown.Location = new System.Drawing.Point(180, 142);
            this.BtnRightDown.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRightDown.Name = "BtnRightDown";
            this.BtnRightDown.Size = new System.Drawing.Size(64, 64);
            this.BtnRightDown.TabIndex = 10;
            this.BtnRightDown.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRightDown.UseVisualStyleBackColor = false;
            this.BtnRightDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnRightDown_MouseDown);
            this.BtnRightDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnRightDown_MouseUp);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnHome.BorderColor = System.Drawing.Color.Black;
            this.BtnHome.BorderRadius = 9;
            this.BtnHome.BorderSize = 2;
            this.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnHome.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_home;
            this.BtnHome.Location = new System.Drawing.Point(128, 90);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(2);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(48, 48);
            this.BtnHome.TabIndex = 3;
            this.BtnHome.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnHome.TextContent = "";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            this.BtnHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnHome_MouseDown);
            this.BtnHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnHome_MouseUp);
            // 
            // BtnLeftUp
            // 
            this.BtnLeftUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnLeftUp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnLeftUp.BorderColor = System.Drawing.Color.White;
            this.BtnLeftUp.BorderRadius = 9;
            this.BtnLeftUp.BorderSize = 1;
            this.BtnLeftUp.Corner = 1;
            this.BtnLeftUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLeftUp.FlatAppearance.BorderSize = 0;
            this.BtnLeftUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLeftUp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnLeftUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnLeftUp.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_135_deg;
            this.BtnLeftUp.Location = new System.Drawing.Point(60, 23);
            this.BtnLeftUp.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLeftUp.Name = "BtnLeftUp";
            this.BtnLeftUp.Size = new System.Drawing.Size(64, 64);
            this.BtnLeftUp.TabIndex = 8;
            this.BtnLeftUp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnLeftUp.UseVisualStyleBackColor = false;
            this.BtnLeftUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnLeftUp_MouseDown);
            this.BtnLeftUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnLeftUp_MouseUp);
            // 
            // LbXYAxis
            // 
            this.LbXYAxis.AutoSize = true;
            this.LbXYAxis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbXYAxis.Location = new System.Drawing.Point(0, 0);
            this.LbXYAxis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbXYAxis.Name = "LbXYAxis";
            this.LbXYAxis.Size = new System.Drawing.Size(96, 23);
            this.LbXYAxis.TabIndex = 61;
            this.LbXYAxis.Text = "XY - Axis";
            // 
            // LbXYSpeed
            // 
            this.LbXYSpeed.AutoSize = true;
            this.LbXYSpeed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbXYSpeed.Location = new System.Drawing.Point(-4, 196);
            this.LbXYSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbXYSpeed.Name = "LbXYSpeed";
            this.LbXYSpeed.Size = new System.Drawing.Size(104, 23);
            this.LbXYSpeed.TabIndex = 62;
            this.LbXYSpeed.Text = "XY Speed";
            // 
            // BtnDownLeft
            // 
            this.BtnDownLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnDownLeft.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnDownLeft.BorderColor = System.Drawing.Color.White;
            this.BtnDownLeft.BorderRadius = 9;
            this.BtnDownLeft.BorderSize = 1;
            this.BtnDownLeft.Corner = 4;
            this.BtnDownLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDownLeft.FlatAppearance.BorderSize = 0;
            this.BtnDownLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDownLeft.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnDownLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnDownLeft.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_215_deg;
            this.BtnDownLeft.Location = new System.Drawing.Point(60, 142);
            this.BtnDownLeft.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDownLeft.Name = "BtnDownLeft";
            this.BtnDownLeft.Size = new System.Drawing.Size(64, 64);
            this.BtnDownLeft.TabIndex = 9;
            this.BtnDownLeft.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnDownLeft.UseVisualStyleBackColor = false;
            this.BtnDownLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnDownLeft_MouseDown);
            this.BtnDownLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnDownLeft_MouseUp);
            // 
            // PnlChangeSpeedArea
            // 
            this.PnlChangeSpeedArea.BackColor = System.Drawing.Color.Pink;
            this.PnlChangeSpeedArea.ColumnCount = 3;
            this.PnlChangeSpeedArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlChangeSpeedArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlChangeSpeedArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlChangeSpeedArea.Controls.Add(this.TbXYspeed, 1, 0);
            this.PnlChangeSpeedArea.Controls.Add(this.BtnXYDownSpeed, 0, 0);
            this.PnlChangeSpeedArea.Controls.Add(this.BtnXYUpSpeed, 2, 0);
            this.PnlChangeSpeedArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlChangeSpeedArea.Location = new System.Drawing.Point(0, 224);
            this.PnlChangeSpeedArea.Margin = new System.Windows.Forms.Padding(0);
            this.PnlChangeSpeedArea.Name = "PnlChangeSpeedArea";
            this.PnlChangeSpeedArea.RowCount = 1;
            this.PnlChangeSpeedArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlChangeSpeedArea.Size = new System.Drawing.Size(300, 42);
            this.PnlChangeSpeedArea.TabIndex = 27;
            // 
            // BtnXYUpSpeed
            // 
            this.BtnXYUpSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnXYUpSpeed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnXYUpSpeed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnXYUpSpeed.BorderRadius = 4;
            this.BtnXYUpSpeed.BorderSize = 1;
            this.BtnXYUpSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnXYUpSpeed.FlatAppearance.BorderSize = 0;
            this.BtnXYUpSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXYUpSpeed.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnXYUpSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnXYUpSpeed.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_triangle_right;
            this.BtnXYUpSpeed.Location = new System.Drawing.Point(261, 3);
            this.BtnXYUpSpeed.Name = "BtnXYUpSpeed";
            this.BtnXYUpSpeed.Size = new System.Drawing.Size(36, 36);
            this.BtnXYUpSpeed.TabIndex = 29;
            this.BtnXYUpSpeed.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnXYUpSpeed.TextContent = "";
            this.BtnXYUpSpeed.UseVisualStyleBackColor = false;
            this.BtnXYUpSpeed.Click += new System.EventHandler(this.BtnXYUpSpeed_Click_1);
            this.BtnXYUpSpeed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnXYUpSpeed_MouseDown);
            this.BtnXYUpSpeed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnXYUpSpeed_MouseUp);
            // 
            // BtnXYDownSpeed
            // 
            this.BtnXYDownSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnXYDownSpeed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnXYDownSpeed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnXYDownSpeed.BorderRadius = 4;
            this.BtnXYDownSpeed.BorderSize = 1;
            this.BtnXYDownSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnXYDownSpeed.FlatAppearance.BorderSize = 0;
            this.BtnXYDownSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXYDownSpeed.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnXYDownSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnXYDownSpeed.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_triangle_left;
            this.BtnXYDownSpeed.Location = new System.Drawing.Point(3, 3);
            this.BtnXYDownSpeed.Name = "BtnXYDownSpeed";
            this.BtnXYDownSpeed.Size = new System.Drawing.Size(36, 36);
            this.BtnXYDownSpeed.TabIndex = 28;
            this.BtnXYDownSpeed.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnXYDownSpeed.TextContent = "";
            this.BtnXYDownSpeed.UseVisualStyleBackColor = false;
            this.BtnXYDownSpeed.Click += new System.EventHandler(this.BtnXYDownSpeed_Click);
            this.BtnXYDownSpeed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnXYDownSpeed_MouseDown);
            this.BtnXYDownSpeed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnXYDownSpeed_MouseUp);
            // 
            // TbXYspeed
            // 
            this.TbXYspeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbXYspeed.Location = new System.Drawing.Point(45, 3);
            this.TbXYspeed.MaximumPercent = 100;
            this.TbXYspeed.MinimumPercent = 0;
            this.TbXYspeed.Name = "TbXYspeed";
            this.TbXYspeed.Orientation = TCHRLibBasicRecordSample.CustomUi.DSM_Trackbar.TrackbarOrientation.Horizontal;
            this.TbXYspeed.Size = new System.Drawing.Size(210, 36);
            this.TbXYspeed.TabIndex = 27;
            this.TbXYspeed.ThumbColor = System.Drawing.Color.Red;
            this.TbXYspeed.TrackColorLeft = System.Drawing.Color.Blue;
            this.TbXYspeed.TrackColorRight = System.Drawing.Color.Gray;
            this.TbXYspeed.Value = 0;
            // 
            // PnlZControl
            // 
            this.PnlZControl.Controls.Add(this.TbZControl);
            this.PnlZControl.Controls.Add(this.LbZAxis);
            this.PnlZControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlZControl.Location = new System.Drawing.Point(339, 27);
            this.PnlZControl.Name = "PnlZControl";
            this.PnlZControl.Padding = new System.Windows.Forms.Padding(10, 42, 10, 8);
            this.PnlZControl.Size = new System.Drawing.Size(51, 260);
            this.PnlZControl.TabIndex = 39;
            // 
            // LbZAxis
            // 
            this.LbZAxis.AutoSize = true;
            this.LbZAxis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbZAxis.Location = new System.Drawing.Point(0, 0);
            this.LbZAxis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbZAxis.Name = "LbZAxis";
            this.LbZAxis.Size = new System.Drawing.Size(80, 23);
            this.LbZAxis.TabIndex = 62;
            this.LbZAxis.Text = "Z - Axis";
            // 
            // TbZControl
            // 
            this.TbZControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.TbZControl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.TbZControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbZControl.BorderInColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbZControl.BorderRadius = 8;
            this.TbZControl.BorderSize = 1;
            this.TbZControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TbZControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbZControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbZControl.LimitImageEnd = global::TCHRLibBasicRecordSample.Properties.Resources.Icon_Z_down;
            this.TbZControl.LimitImageStart = global::TCHRLibBasicRecordSample.Properties.Resources.Icon_Z_up;
            this.TbZControl.Location = new System.Drawing.Point(10, 42);
            this.TbZControl.Margin = new System.Windows.Forms.Padding(0);
            this.TbZControl.MaximumPercent = 100;
            this.TbZControl.MinimumPercent = 0;
            this.TbZControl.Name = "TbZControl";
            this.TbZControl.Orientation = TCHRLibBasicRecordSample.CustomUi.DSM_TrackBarImg.TrackbarOrientation.Vertical;
            this.TbZControl.Size = new System.Drawing.Size(31, 210);
            this.TbZControl.TabIndex = 63;
            this.TbZControl.ThumbColor = System.Drawing.Color.Red;
            this.TbZControl.ThumbImage = global::TCHRLibBasicRecordSample.Properties.Resources.icon_Zmove_40;
            this.TbZControl.ThumbSize = 40;
            this.TbZControl.TrackColorLeft = System.Drawing.Color.Blue;
            this.TbZControl.TrackColorRight = System.Drawing.Color.Gray;
            this.TbZControl.Value = 0;
            this.TbZControl.VerticalReversed = true;
            this.TbZControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TbZControl_MouseDown);
            this.TbZControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TbZControl_MouseUp);
            // 
            // PnlControlGrid
            // 
            this.PnlControlGrid.BackColor = System.Drawing.Color.Pink;
            this.PnlControlGrid.ColumnCount = 3;
            this.PnlControlGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.PnlControlGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PnlControlGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.PnlControlGrid.Controls.Add(this.PnlZControl, 1, 0);
            this.PnlControlGrid.Controls.Add(this.PnlXYControl, 0, 0);
            this.PnlControlGrid.Controls.Add(this.PnlTchAreaGrid, 2, 0);
            this.PnlControlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlControlGrid.Location = new System.Drawing.Point(0, 489);
            this.PnlControlGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlControlGrid.Name = "PnlControlGrid";
            this.PnlControlGrid.Padding = new System.Windows.Forms.Padding(36, 24, 24, 24);
            this.PnlControlGrid.RowCount = 1;
            this.PnlControlGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlControlGrid.Size = new System.Drawing.Size(740, 314);
            this.PnlControlGrid.TabIndex = 27;
            // 
            // PnlListBtnSetting
            // 
            this.PnlListBtnSetting.ColumnCount = 1;
            this.PnlListBtnSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlListBtnSetting.Controls.Add(this.PnlSelect1, 0, 0);
            this.PnlListBtnSetting.Controls.Add(this.PnlSelect2, 0, 2);
            this.PnlListBtnSetting.Controls.Add(this.PnlSelect4, 0, 6);
            this.PnlListBtnSetting.Controls.Add(this.PnlSelect3, 0, 4);
            this.PnlListBtnSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlListBtnSetting.Location = new System.Drawing.Point(36, 24);
            this.PnlListBtnSetting.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.PnlListBtnSetting.Name = "PnlListBtnSetting";
            this.PnlListBtnSetting.RowCount = 8;
            this.PnlListBtnSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PnlListBtnSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlListBtnSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PnlListBtnSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlListBtnSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PnlListBtnSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlListBtnSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PnlListBtnSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.PnlListBtnSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlListBtnSetting.Size = new System.Drawing.Size(152, 265);
            this.PnlListBtnSetting.TabIndex = 33;
            // 
            // PnlSelect3
            // 
            this.PnlSelect3.BackColor = System.Drawing.Color.Red;
            this.PnlSelect3.Controls.Add(this.BtnSelect3);
            this.PnlSelect3.Location = new System.Drawing.Point(0, 126);
            this.PnlSelect3.Margin = new System.Windows.Forms.Padding(0);
            this.PnlSelect3.Name = "PnlSelect3";
            this.PnlSelect3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.PnlSelect3.Size = new System.Drawing.Size(152, 50);
            this.PnlSelect3.TabIndex = 35;
            // 
            // BtnSelect3
            // 
            this.BtnSelect3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnSelect3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnSelect3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSelect3.BorderRadius = 0;
            this.BtnSelect3.BorderSize = 0;
            this.BtnSelect3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelect3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSelect3.FlatAppearance.BorderSize = 0;
            this.BtnSelect3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelect3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSelect3.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_arrow_down;
            this.BtnSelect3.Location = new System.Drawing.Point(0, 0);
            this.BtnSelect3.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSelect3.Name = "BtnSelect3";
            this.BtnSelect3.Size = new System.Drawing.Size(152, 48);
            this.BtnSelect3.TabIndex = 34;
            this.BtnSelect3.Text = "Speed mode";
            this.BtnSelect3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSelect3.TextContent = "Speed mode";
            this.BtnSelect3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSelect3.UseVisualStyleBackColor = false;
            this.BtnSelect3.Click += new System.EventHandler(this.BtnSelect3_Click);
            // 
            // PnlSelect4
            // 
            this.PnlSelect4.BackColor = System.Drawing.Color.Red;
            this.PnlSelect4.Controls.Add(this.BtnSelect4);
            this.PnlSelect4.Location = new System.Drawing.Point(0, 189);
            this.PnlSelect4.Margin = new System.Windows.Forms.Padding(0);
            this.PnlSelect4.Name = "PnlSelect4";
            this.PnlSelect4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.PnlSelect4.Size = new System.Drawing.Size(152, 50);
            this.PnlSelect4.TabIndex = 34;
            // 
            // BtnSelect4
            // 
            this.BtnSelect4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnSelect4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnSelect4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSelect4.BorderRadius = 0;
            this.BtnSelect4.BorderSize = 0;
            this.BtnSelect4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelect4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSelect4.FlatAppearance.BorderSize = 0;
            this.BtnSelect4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelect4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSelect4.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_arrow_down;
            this.BtnSelect4.Location = new System.Drawing.Point(0, 0);
            this.BtnSelect4.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSelect4.Name = "BtnSelect4";
            this.BtnSelect4.Size = new System.Drawing.Size(152, 48);
            this.BtnSelect4.TabIndex = 34;
            this.BtnSelect4.Text = "Save Mode";
            this.BtnSelect4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSelect4.TextContent = "Save Mode";
            this.BtnSelect4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSelect4.UseVisualStyleBackColor = false;
            this.BtnSelect4.Click += new System.EventHandler(this.BtnSelect4_Click);
            // 
            // PnlSelect2
            // 
            this.PnlSelect2.BackColor = System.Drawing.Color.Red;
            this.PnlSelect2.Controls.Add(this.BtnSelect2);
            this.PnlSelect2.Location = new System.Drawing.Point(0, 63);
            this.PnlSelect2.Margin = new System.Windows.Forms.Padding(0);
            this.PnlSelect2.Name = "PnlSelect2";
            this.PnlSelect2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.PnlSelect2.Size = new System.Drawing.Size(152, 50);
            this.PnlSelect2.TabIndex = 33;
            // 
            // BtnSelect2
            // 
            this.BtnSelect2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnSelect2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnSelect2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSelect2.BorderRadius = 0;
            this.BtnSelect2.BorderSize = 0;
            this.BtnSelect2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelect2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSelect2.FlatAppearance.BorderSize = 0;
            this.BtnSelect2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelect2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSelect2.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_arrow_down;
            this.BtnSelect2.Location = new System.Drawing.Point(0, 0);
            this.BtnSelect2.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSelect2.Name = "BtnSelect2";
            this.BtnSelect2.Size = new System.Drawing.Size(152, 48);
            this.BtnSelect2.TabIndex = 34;
            this.BtnSelect2.Text = "Scan Area";
            this.BtnSelect2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSelect2.TextContent = "Scan Area";
            this.BtnSelect2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSelect2.UseVisualStyleBackColor = false;
            this.BtnSelect2.Click += new System.EventHandler(this.BtnSelect2_Click);
            // 
            // PnlSelect1
            // 
            this.PnlSelect1.BackColor = System.Drawing.Color.Red;
            this.PnlSelect1.Controls.Add(this.BtnSelect1);
            this.PnlSelect1.Location = new System.Drawing.Point(0, 0);
            this.PnlSelect1.Margin = new System.Windows.Forms.Padding(0);
            this.PnlSelect1.Name = "PnlSelect1";
            this.PnlSelect1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.PnlSelect1.Size = new System.Drawing.Size(152, 50);
            this.PnlSelect1.TabIndex = 33;
            // 
            // BtnSelect1
            // 
            this.BtnSelect1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BtnSelect1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BtnSelect1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSelect1.BorderRadius = 0;
            this.BtnSelect1.BorderSize = 0;
            this.BtnSelect1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelect1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSelect1.FlatAppearance.BorderSize = 0;
            this.BtnSelect1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelect1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSelect1.Image = global::TCHRLibBasicRecordSample.Properties.Resources.icon_arrow_down;
            this.BtnSelect1.Location = new System.Drawing.Point(0, 0);
            this.BtnSelect1.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSelect1.Name = "BtnSelect1";
            this.BtnSelect1.Size = new System.Drawing.Size(152, 48);
            this.BtnSelect1.TabIndex = 34;
            this.BtnSelect1.Text = "Run Mode";
            this.BtnSelect1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSelect1.TextContent = "Run Mode";
            this.BtnSelect1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSelect1.UseVisualStyleBackColor = false;
            this.BtnSelect1.Click += new System.EventHandler(this.BtnSelect1_Click);
            // 
            // PnlXYCoorGrid
            // 
            this.PnlXYCoorGrid.ColumnCount = 1;
            this.PnlXYCoorGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlXYCoorGrid.Controls.Add(this.LbXYCoor, 0, 1);
            this.PnlXYCoorGrid.Controls.Add(this.PnlXYMap, 0, 0);
            this.PnlXYCoorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlXYCoorGrid.Location = new System.Drawing.Point(196, 24);
            this.PnlXYCoorGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlXYCoorGrid.Name = "PnlXYCoorGrid";
            this.PnlXYCoorGrid.RowCount = 2;
            this.PnlXYCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.PnlXYCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlXYCoorGrid.Size = new System.Drawing.Size(286, 265);
            this.PnlXYCoorGrid.TabIndex = 27;
            // 
            // PnlXYMap
            // 
            this.PnlXYMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.PnlXYMap.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.PnlXYMap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.PnlXYMap.BorderSize = 4;
            this.PnlXYMap.CoordinateX = 0D;
            this.PnlXYMap.CoordinateY = 0D;
            this.PnlXYMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlXYMap.DragEnabled = true;
            this.PnlXYMap.GridSize = 100;
            this.PnlXYMap.LineColor = System.Drawing.Color.White;
            this.PnlXYMap.LineSize = 1;
            this.PnlXYMap.Location = new System.Drawing.Point(8, 0);
            this.PnlXYMap.MainLineColor = System.Drawing.Color.White;
            this.PnlXYMap.MainLineSizeX = 1;
            this.PnlXYMap.MainLineSizeY = 1;
            this.PnlXYMap.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.PnlXYMap.Name = "PnlXYMap";
            this.PnlXYMap.PointColor = System.Drawing.Color.Orange;
            this.PnlXYMap.PointDisplayStyle = TCHRLibBasicRecordSample.CustomUi.PointDisplayStyle.Plus;
            this.PnlXYMap.PointSize = 24;
            this.PnlXYMap.PointX = 50;
            this.PnlXYMap.PointY = 50;
            this.PnlXYMap.Size = new System.Drawing.Size(274, 238);
            this.PnlXYMap.TabIndex = 23;
            this.PnlXYMap.Text = "dsM_GridMap1";
            this.PnlXYMap.Click += new System.EventHandler(this.PnlXYMap_Click);
            // 
            // LbXYCoor
            // 
            this.LbXYCoor.AutoSize = true;
            this.LbXYCoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbXYCoor.Location = new System.Drawing.Point(2, 238);
            this.LbXYCoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbXYCoor.Name = "LbXYCoor";
            this.LbXYCoor.Size = new System.Drawing.Size(282, 27);
            this.LbXYCoor.TabIndex = 22;
            this.LbXYCoor.Text = "X,Y Coordinate";
            this.LbXYCoor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PnlZCoorGird
            // 
            this.PnlZCoorGird.ColumnCount = 1;
            this.PnlZCoorGird.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlZCoorGird.Controls.Add(this.LbZCoor, 0, 1);
            this.PnlZCoorGird.Controls.Add(this.PnlZMap, 0, 0);
            this.PnlZCoorGird.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlZCoorGird.Location = new System.Drawing.Point(482, 24);
            this.PnlZCoorGird.Margin = new System.Windows.Forms.Padding(0);
            this.PnlZCoorGird.Name = "PnlZCoorGird";
            this.PnlZCoorGird.RowCount = 2;
            this.PnlZCoorGird.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.PnlZCoorGird.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlZCoorGird.Size = new System.Drawing.Size(130, 265);
            this.PnlZCoorGird.TabIndex = 28;
            // 
            // PnlZMap
            // 
            this.PnlZMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.PnlZMap.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.PnlZMap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.PnlZMap.BorderSize = 4;
            this.PnlZMap.CoordinateX = 0D;
            this.PnlZMap.CoordinateY = 0D;
            this.PnlZMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlZMap.DragEnabled = false;
            this.PnlZMap.GridSize = 25;
            this.PnlZMap.LineColor = System.Drawing.Color.White;
            this.PnlZMap.LineSize = 1;
            this.PnlZMap.Location = new System.Drawing.Point(4, 0);
            this.PnlZMap.MainLineColor = System.Drawing.Color.White;
            this.PnlZMap.MainLineSizeX = 1;
            this.PnlZMap.MainLineSizeY = 1;
            this.PnlZMap.Margin = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.PnlZMap.Name = "PnlZMap";
            this.PnlZMap.PointColor = System.Drawing.Color.Orange;
            this.PnlZMap.PointDisplayStyle = TCHRLibBasicRecordSample.CustomUi.PointDisplayStyle.Circle;
            this.PnlZMap.PointSize = 20;
            this.PnlZMap.PointX = 50;
            this.PnlZMap.PointY = 50;
            this.PnlZMap.Size = new System.Drawing.Size(118, 238);
            this.PnlZMap.TabIndex = 23;
            this.PnlZMap.Text = "dsM_GridMap1";
            // 
            // LbZCoor
            // 
            this.LbZCoor.AutoSize = true;
            this.LbZCoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbZCoor.Location = new System.Drawing.Point(2, 238);
            this.LbZCoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbZCoor.Name = "LbZCoor";
            this.LbZCoor.Size = new System.Drawing.Size(126, 27);
            this.LbZCoor.TabIndex = 22;
            this.LbZCoor.Text = "Z Coordinate";
            this.LbZCoor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PnlInfoCoorGrid
            // 
            this.PnlInfoCoorGrid.ColumnCount = 2;
            this.PnlInfoCoorGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlInfoCoorGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlInfoCoorGrid.Controls.Add(this.LbZCoorValue, 1, 3);
            this.PnlInfoCoorGrid.Controls.Add(this.LbZAxisCoor, 0, 3);
            this.PnlInfoCoorGrid.Controls.Add(this.LbYCoorValue, 1, 2);
            this.PnlInfoCoorGrid.Controls.Add(this.LbYAxisCoor, 0, 2);
            this.PnlInfoCoorGrid.Controls.Add(this.LbXCoorValue, 1, 1);
            this.PnlInfoCoorGrid.Controls.Add(this.LbXAxisCoor, 0, 1);
            this.PnlInfoCoorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlInfoCoorGrid.Location = new System.Drawing.Point(612, 24);
            this.PnlInfoCoorGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlInfoCoorGrid.Name = "PnlInfoCoorGrid";
            this.PnlInfoCoorGrid.RowCount = 5;
            this.PnlInfoCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.PnlInfoCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlInfoCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlInfoCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlInfoCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlInfoCoorGrid.Size = new System.Drawing.Size(104, 265);
            this.PnlInfoCoorGrid.TabIndex = 27;
            // 
            // LbXAxisCoor
            // 
            this.LbXAxisCoor.AutoSize = true;
            this.LbXAxisCoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbXAxisCoor.Location = new System.Drawing.Point(2, 159);
            this.LbXAxisCoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbXAxisCoor.Name = "LbXAxisCoor";
            this.LbXAxisCoor.Size = new System.Drawing.Size(22, 26);
            this.LbXAxisCoor.TabIndex = 24;
            this.LbXAxisCoor.Text = "X:";
            this.LbXAxisCoor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LbXCoorValue
            // 
            this.LbXCoorValue.AutoSize = true;
            this.LbXCoorValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbXCoorValue.Location = new System.Drawing.Point(28, 159);
            this.LbXCoorValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbXCoorValue.Name = "LbXCoorValue";
            this.LbXCoorValue.Size = new System.Drawing.Size(74, 26);
            this.LbXCoorValue.TabIndex = 24;
            this.LbXCoorValue.Text = "0.00 mm";
            this.LbXCoorValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LbYAxisCoor
            // 
            this.LbYAxisCoor.AutoSize = true;
            this.LbYAxisCoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbYAxisCoor.Location = new System.Drawing.Point(2, 185);
            this.LbYAxisCoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbYAxisCoor.Name = "LbYAxisCoor";
            this.LbYAxisCoor.Size = new System.Drawing.Size(22, 26);
            this.LbYAxisCoor.TabIndex = 32;
            this.LbYAxisCoor.Text = "Y:";
            this.LbYAxisCoor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LbYCoorValue
            // 
            this.LbYCoorValue.AutoSize = true;
            this.LbYCoorValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbYCoorValue.Location = new System.Drawing.Point(28, 185);
            this.LbYCoorValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbYCoorValue.Name = "LbYCoorValue";
            this.LbYCoorValue.Size = new System.Drawing.Size(74, 26);
            this.LbYCoorValue.TabIndex = 32;
            this.LbYCoorValue.Text = "0.00 mm";
            this.LbYCoorValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LbZAxisCoor
            // 
            this.LbZAxisCoor.AutoSize = true;
            this.LbZAxisCoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbZAxisCoor.Location = new System.Drawing.Point(2, 211);
            this.LbZAxisCoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbZAxisCoor.Name = "LbZAxisCoor";
            this.LbZAxisCoor.Size = new System.Drawing.Size(22, 26);
            this.LbZAxisCoor.TabIndex = 32;
            this.LbZAxisCoor.Text = "Z:";
            this.LbZAxisCoor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LbZCoorValue
            // 
            this.LbZCoorValue.AutoSize = true;
            this.LbZCoorValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbZCoorValue.Location = new System.Drawing.Point(28, 211);
            this.LbZCoorValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbZCoorValue.Name = "LbZCoorValue";
            this.LbZCoorValue.Size = new System.Drawing.Size(74, 26);
            this.LbZCoorValue.TabIndex = 32;
            this.LbZCoorValue.Text = "0.00 mm";
            this.LbZCoorValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // PnlSettingGrid
            // 
            this.PnlSettingGrid.BackColor = System.Drawing.Color.MistyRose;
            this.PnlSettingGrid.ColumnCount = 4;
            this.PnlSettingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.PnlSettingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.PnlSettingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PnlSettingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PnlSettingGrid.Controls.Add(this.PnlInfoCoorGrid, 3, 0);
            this.PnlSettingGrid.Controls.Add(this.PnlZCoorGird, 2, 0);
            this.PnlSettingGrid.Controls.Add(this.PnlXYCoorGrid, 1, 0);
            this.PnlSettingGrid.Controls.Add(this.PnlListBtnSetting, 0, 0);
            this.PnlSettingGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSettingGrid.Location = new System.Drawing.Point(0, 148);
            this.PnlSettingGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlSettingGrid.Name = "PnlSettingGrid";
            this.PnlSettingGrid.Padding = new System.Windows.Forms.Padding(36, 24, 24, 24);
            this.PnlSettingGrid.RowCount = 1;
            this.PnlSettingGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlSettingGrid.Size = new System.Drawing.Size(740, 313);
            this.PnlSettingGrid.TabIndex = 34;
            // 
            // TRecordSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.PnlMain);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TRecordSample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHRDLL Demo";
            this.Load += new System.EventHandler(this.TRecordSample_Load);
            this.PnlSetting.ResumeLayout(false);
            this.PnlNavSetting.ResumeLayout(false);
            this.PnlAdvanceSetting.ResumeLayout(false);
            this.PnlDefaultSetting.ResumeLayout(false);
            this.PnlControlBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.PnlMain.ResumeLayout(false);
            this.PnlMainGrid.ResumeLayout(false);
            this.PnlLeftSite.ResumeLayout(false);
            this.PnlLeftSite.PerformLayout();
            this.PnlScanArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgAreaScan)).EndInit();
            this.PnlProgressGrid.ResumeLayout(false);
            this.PnlProgressGrid.PerformLayout();
            this.PnlHidden.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PnlChartGrid.ResumeLayout(false);
            this.PnlChartGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.PnlRightSite.ResumeLayout(false);
            this.PnlRightSite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.DropDown3.ResumeLayout(false);
            this.DropDown1.ResumeLayout(false);
            this.DropDown2.ResumeLayout(false);
            this.DropDown4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axDBCommManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axDBTriggerManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axDBDeviceManager1)).EndInit();
            this.PnlTchAreaGrid.ResumeLayout(false);
            this.PnlTchAreaGrid.PerformLayout();
            this.PnlTchGrid.ResumeLayout(false);
            this.PnlTchGrid.PerformLayout();
            this.PnlBtnRunGrid.ResumeLayout(false);
            this.PnlXYControl.ResumeLayout(false);
            this.PnlXYBtn.ResumeLayout(false);
            this.PnlXYBtn.PerformLayout();
            this.PnlChangeSpeedArea.ResumeLayout(false);
            this.PnlZControl.ResumeLayout(false);
            this.PnlZControl.PerformLayout();
            this.PnlControlGrid.ResumeLayout(false);
            this.PnlListBtnSetting.ResumeLayout(false);
            this.PnlSelect3.ResumeLayout(false);
            this.PnlSelect4.ResumeLayout(false);
            this.PnlSelect2.ResumeLayout(false);
            this.PnlSelect1.ResumeLayout(false);
            this.PnlXYCoorGrid.ResumeLayout(false);
            this.PnlXYCoorGrid.PerformLayout();
            this.PnlZCoorGird.ResumeLayout(false);
            this.PnlZCoorGird.PerformLayout();
            this.PnlInfoCoorGrid.ResumeLayout(false);
            this.PnlInfoCoorGrid.PerformLayout();
            this.PnlSettingGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerData;
        private System.Windows.Forms.SaveFileDialog SaveDlg;
        private System.Windows.Forms.Panel PnlSetting;
        private System.Windows.Forms.Panel PnlDSPage;
        private System.Windows.Forms.TableLayoutPanel PnlNavSetting;
        private System.Windows.Forms.Panel PnlDefaultSetting;
        private System.Windows.Forms.Panel PnlControlBar;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Label LbTitleSetting;
        private System.Windows.Forms.TableLayoutPanel PnlMainGrid;
        private System.Windows.Forms.TableLayoutPanel PnlRightSite;
        private System.Windows.Forms.TableLayoutPanel PnlLeftSite;
        private System.Windows.Forms.Label LbTitleControl;
        private System.Windows.Forms.Timer timerDropDown1;
        private System.Windows.Forms.Panel PnlHidden;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton RBCHRC;
        private System.Windows.Forms.Button BtDisCon;
        private System.Windows.Forms.Button BtConnect;
        private System.Windows.Forms.RadioButton RBCLS;
        private System.Windows.Forms.RadioButton RBCHR2;
        private System.Windows.Forms.RadioButton RBCHR1;
        private System.Windows.Forms.TextBox TbConInfo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button action;
        private System.Windows.Forms.CheckBox CBFlush;
        private System.Windows.Forms.TextBox TBSampleCount;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.Button BtRecord;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton RBInterfero;
        private System.Windows.Forms.RadioButton RBConfocal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBSHZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBSODX;
        private System.Windows.Forms.Panel PnlScanArea;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.PictureBox ImgAreaScan;
        private System.Windows.Forms.TableLayoutPanel PnlProgressGrid;
        private System.Windows.Forms.Label LbScanProgress;
        private CustomUi.DSM_ProgressBar PbScan;
        private System.Windows.Forms.TableLayoutPanel PnlChartGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnDefaultSetting;
        private System.Windows.Forms.Panel PnlAdvanceSetting;
        private System.Windows.Forms.Button BtnAdvanceSetting;
        private CustomUI.DSM_DropDownTable DropDown3;
        private System.Windows.Forms.ToolStripMenuItem BtnSlow;
        private System.Windows.Forms.ToolStripMenuItem BtnNormal;
        private System.Windows.Forms.ToolStripMenuItem BtnFast;
        private CustomUI.DSM_DropDownTable DropDown1;
        private System.Windows.Forms.ToolStripMenuItem BtnZZ;
        private System.Windows.Forms.ToolStripMenuItem BtnRaster;
        private System.Windows.Forms.ToolStripMenuItem BtnOther1;
        private CustomUI.DSM_DropDownTable DropDown2;
        private System.Windows.Forms.ToolStripMenuItem Btn30mm;
        private System.Windows.Forms.ToolStripMenuItem Btn40mm;
        private System.Windows.Forms.ToolStripMenuItem Btn50mm;
        private System.Windows.Forms.ToolStripMenuItem BtnOther2;
        private CustomUI.DSM_DropDownTable DropDown4;
        private System.Windows.Forms.ToolStripMenuItem BtnCSV;
        private System.Windows.Forms.ToolStripMenuItem BtnBCRF;
        private System.Windows.Forms.ToolStripMenuItem BtnSUR;
        private System.Windows.Forms.Label LbNameChart;
        private System.Windows.Forms.TableLayoutPanel PnlSettingGrid;
        private System.Windows.Forms.TableLayoutPanel PnlInfoCoorGrid;
        private System.Windows.Forms.Label LbZCoorValue;
        private System.Windows.Forms.Label LbZAxisCoor;
        private System.Windows.Forms.Label LbYCoorValue;
        private System.Windows.Forms.Label LbYAxisCoor;
        private System.Windows.Forms.Label LbXCoorValue;
        private System.Windows.Forms.Label LbXAxisCoor;
        private System.Windows.Forms.TableLayoutPanel PnlZCoorGird;
        private System.Windows.Forms.Label LbZCoor;
        private CustomUi.DSM_GridMap PnlZMap;
        private System.Windows.Forms.TableLayoutPanel PnlXYCoorGrid;
        private System.Windows.Forms.Label LbXYCoor;
        private CustomUi.DSM_GridMap PnlXYMap;
        private System.Windows.Forms.TableLayoutPanel PnlListBtnSetting;
        private System.Windows.Forms.Panel PnlSelect1;
        private CustomUi.DSM_Button BtnSelect1;
        private System.Windows.Forms.Panel PnlSelect2;
        private CustomUi.DSM_Button BtnSelect2;
        private System.Windows.Forms.Panel PnlSelect4;
        private CustomUi.DSM_Button BtnSelect4;
        private System.Windows.Forms.Panel PnlSelect3;
        private CustomUi.DSM_Button BtnSelect3;
        private System.Windows.Forms.TableLayoutPanel PnlControlGrid;
        private System.Windows.Forms.Panel PnlZControl;
        private CustomUi.DSM_TrackBarImg TbZControl;
        private System.Windows.Forms.Label LbZAxis;
        private System.Windows.Forms.TableLayoutPanel PnlXYControl;
        private System.Windows.Forms.TableLayoutPanel PnlChangeSpeedArea;
        private CustomUi.DSM_Trackbar TbXYspeed;
        private CustomUi.DSM_Button BtnXYDownSpeed;
        private CustomUi.DSM_Button BtnXYUpSpeed;
        private System.Windows.Forms.Panel PnlXYBtn;
        private AxDATABUILDERAXLibLB.AxDBDeviceManager axDBDeviceManager1;
        private AxDATABUILDERAXLibLB.AxDBTriggerManager axDBTriggerManager1;
        private AxDATABUILDERAXLibLB.AxDBCommManager axDBCommManager1;
        private CustomUi.DSM_SpecialButton BtnDownLeft;
        private System.Windows.Forms.Label LbXYSpeed;
        private System.Windows.Forms.Label LbXYAxis;
        private CustomUi.DSM_SpecialButton BtnLeftUp;
        private CustomUi.DSM_Button BtnHome;
        private CustomUi.DSM_SpecialButton BtnRightDown;
        private CustomUi.DSM_Button BtnLeft;
        private CustomUi.DSM_SpecialButton BtnUpRight;
        private CustomUi.DSM_Button BtnRight;
        private CustomUi.DSM_Button BtnDown;
        private CustomUi.DSM_Button BtnUp;
        private System.Windows.Forms.TableLayoutPanel PnlTchAreaGrid;
        private System.Windows.Forms.TableLayoutPanel PnlBtnRunGrid;
        private CustomUi.DSM_Button BtnSave;
        private CustomUi.DSM_Button BtnRunScan;
        private System.Windows.Forms.Label LbTchPoint;
        private System.Windows.Forms.TableLayoutPanel PnlTchGrid;
        private System.Windows.Forms.Label LbPos4;
        private System.Windows.Forms.Label LbPos1;
        private CustomUi.DSM_Button BtnSetPos4;
        private CustomUi.DSM_TextBox TbPos4;
        private CustomUi.DSM_Button BtnRunPos4;
        private System.Windows.Forms.Label LbPos3;
        private System.Windows.Forms.Label LbPos2;
        private CustomUi.DSM_Button BtnRunPos3;
        private CustomUi.DSM_Button BtnSetPos3;
        private CustomUi.DSM_TextBox TbPos3;
        private CustomUi.DSM_Button BtnRunPos1;
        private CustomUi.DSM_Button BtnSetPos1;
        private CustomUi.DSM_Button BtnRunPos2;
        private CustomUi.DSM_Button BtnSetPos2;
        private CustomUi.DSM_TextBox TbPos2;
        private CustomUi.DSM_TextBox TbPos1;
    }
}

