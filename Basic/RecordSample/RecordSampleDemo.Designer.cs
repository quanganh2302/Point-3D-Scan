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
            this.timerData = new System.Windows.Forms.Timer(this.components);
            this.SaveDlg = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.RBInterfero = new System.Windows.Forms.RadioButton();
            this.RBConfocal = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TBSHZ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBSODX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.action = new System.Windows.Forms.Button();
            this.CBFlush = new System.Windows.Forms.CheckBox();
            this.TBSampleCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtSave = new System.Windows.Forms.Button();
            this.BtRecord = new System.Windows.Forms.Button();
            this.PnlChartGrid = new System.Windows.Forms.TableLayoutPanel();
            this.LbNameChart = new System.Windows.Forms.Label();
            this.PnlRightSite = new System.Windows.Forms.TableLayoutPanel();
            this.PnlSettingGrid = new System.Windows.Forms.TableLayoutPanel();
            this.PnlInfoCoorGrid = new System.Windows.Forms.TableLayoutPanel();
            this.LbZCoorValue = new System.Windows.Forms.Label();
            this.LbZAxisCoor = new System.Windows.Forms.Label();
            this.LbYCoorValue = new System.Windows.Forms.Label();
            this.LbYAxisCoor = new System.Windows.Forms.Label();
            this.LbXCoorValue = new System.Windows.Forms.Label();
            this.LbXAxisCoor = new System.Windows.Forms.Label();
            this.PnlZCoorGird = new System.Windows.Forms.TableLayoutPanel();
            this.LbZCoor = new System.Windows.Forms.Label();
            this.PnlXYCoorGrid = new System.Windows.Forms.TableLayoutPanel();
            this.LbXYCoor = new System.Windows.Forms.Label();
            this.PnlListBtnSetting = new System.Windows.Forms.TableLayoutPanel();
            this.PnlControlGrid = new System.Windows.Forms.TableLayoutPanel();
            this.PnlZControl = new System.Windows.Forms.Panel();
            this.LbZAxis = new System.Windows.Forms.Label();
            this.PnlXYControl = new System.Windows.Forms.TableLayoutPanel();
            this.PnlChangeSpeedArea = new System.Windows.Forms.TableLayoutPanel();
            this.PnlXYBtn = new System.Windows.Forms.Panel();
            this.axDBDeviceManager1 = new AxDATABUILDERAXLibLB.AxDBDeviceManager();
            this.axDBTriggerManager1 = new AxDATABUILDERAXLibLB.AxDBTriggerManager();
            this.axDBCommManager1 = new AxDATABUILDERAXLibLB.AxDBCommManager();
            this.LbXYSpeed = new System.Windows.Forms.Label();
            this.LbXYAxis = new System.Windows.Forms.Label();
            this.PnlTchAreaGrid = new System.Windows.Forms.TableLayoutPanel();
            this.PnlTchGrid = new System.Windows.Forms.TableLayoutPanel();
            this.LbPos4 = new System.Windows.Forms.Label();
            this.LbPos1 = new System.Windows.Forms.Label();
            this.LbPos3 = new System.Windows.Forms.Label();
            this.LbPos2 = new System.Windows.Forms.Label();
            this.LbTitleSetting = new System.Windows.Forms.Label();
            this.LbTitleControl = new System.Windows.Forms.Label();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerComboBox = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.PbScan = new TCHRLibBasicRecordSample.CustomUi.DSM_ProgressBar();
            this.PnlZMap = new TCHRLibBasicRecordSample.CustomUi.DSM_GridMap();
            this.PnlXYMap = new TCHRLibBasicRecordSample.CustomUi.DSM_GridMap();
            this.CbbRunMode = new TCHRLibBasicRecordSample.CustomUi.TabControl.DSM_ComboBox();
            this.CbbSignalMode = new TCHRLibBasicRecordSample.CustomUi.TabControl.DSM_ComboBox();
            this.CbbScanArea = new TCHRLibBasicRecordSample.CustomUi.TabControl.DSM_ComboBox();
            this.CbbSaveMode = new TCHRLibBasicRecordSample.CustomUi.TabControl.DSM_ComboBox();
            this.BtnSaveData = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.TbZControl = new TCHRLibBasicRecordSample.CustomUi.DSM_TrackBarImg();
            this.TbXYspeed = new TCHRLibBasicRecordSample.CustomUi.DSM_Trackbar();
            this.BtnXYDownSpeed = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnXYUpSpeed = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnDownLeft = new TCHRLibBasicRecordSample.CustomUi.DSM_SpecialButton();
            this.BtnLeftUp = new TCHRLibBasicRecordSample.CustomUi.DSM_SpecialButton();
            this.BtnHome = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnRightDown = new TCHRLibBasicRecordSample.CustomUi.DSM_SpecialButton();
            this.BtnLeft = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnUpRight = new TCHRLibBasicRecordSample.CustomUi.DSM_SpecialButton();
            this.BtnRight = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnDown = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnUp = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnRsTch = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnRunScan = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnSetPos4 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.TbPos4 = new TCHRLibBasicRecordSample.CustomUi.DSM_TextBox();
            this.BtnRunPos4 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnRunPos3 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnSetPos3 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.TbPos3 = new TCHRLibBasicRecordSample.CustomUi.DSM_TextBox();
            this.BtnRunPos1 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnSetPos1 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnRunPos2 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.BtnSetPos2 = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.TbPos2 = new TCHRLibBasicRecordSample.CustomUi.DSM_TextBox();
            this.TbPos1 = new TCHRLibBasicRecordSample.CustomUi.DSM_TextBox();
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
            this.PnlRightSite.SuspendLayout();
            this.PnlSettingGrid.SuspendLayout();
            this.PnlInfoCoorGrid.SuspendLayout();
            this.PnlZCoorGird.SuspendLayout();
            this.PnlXYCoorGrid.SuspendLayout();
            this.PnlListBtnSetting.SuspendLayout();
            this.PnlControlGrid.SuspendLayout();
            this.PnlZControl.SuspendLayout();
            this.PnlXYControl.SuspendLayout();
            this.PnlChangeSpeedArea.SuspendLayout();
            this.PnlXYBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axDBDeviceManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axDBTriggerManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axDBCommManager1)).BeginInit();
            this.PnlTchAreaGrid.SuspendLayout();
            this.PnlTchGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
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
            this.PnlSetting.Size = new System.Drawing.Size(683, 130);
            this.PnlSetting.TabIndex = 25;
            // 
            // PnlDSPage
            // 
            this.PnlDSPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDSPage.Location = new System.Drawing.Point(0, 64);
            this.PnlDSPage.Margin = new System.Windows.Forms.Padding(0);
            this.PnlDSPage.Name = "PnlDSPage";
            this.PnlDSPage.Size = new System.Drawing.Size(683, 66);
            this.PnlDSPage.TabIndex = 1;
            // 
            // PnlNavSetting
            // 
            this.PnlNavSetting.BackColor = System.Drawing.Color.Silver;
            this.PnlNavSetting.ColumnCount = 3;
            this.PnlNavSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PnlNavSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.PnlNavSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.PnlNavSetting.Controls.Add(this.PnlAdvanceSetting, 1, 0);
            this.PnlNavSetting.Controls.Add(this.PnlDefaultSetting, 0, 0);
            this.PnlNavSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlNavSetting.Location = new System.Drawing.Point(0, 0);
            this.PnlNavSetting.Margin = new System.Windows.Forms.Padding(0);
            this.PnlNavSetting.Name = "PnlNavSetting";
            this.PnlNavSetting.RowCount = 1;
            this.PnlNavSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlNavSetting.Size = new System.Drawing.Size(683, 64);
            this.PnlNavSetting.TabIndex = 0;
            // 
            // PnlAdvanceSetting
            // 
            this.PnlAdvanceSetting.BackColor = System.Drawing.Color.Silver;
            this.PnlAdvanceSetting.Controls.Add(this.BtnAdvanceSetting);
            this.PnlAdvanceSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlAdvanceSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlAdvanceSetting.Location = new System.Drawing.Point(141, 5);
            this.PnlAdvanceSetting.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.PnlAdvanceSetting.Name = "PnlAdvanceSetting";
            this.PnlAdvanceSetting.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.PnlAdvanceSetting.Size = new System.Drawing.Size(140, 59);
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
            this.BtnAdvanceSetting.Size = new System.Drawing.Size(140, 53);
            this.BtnAdvanceSetting.TabIndex = 28;
            this.BtnAdvanceSetting.Text = "Advance setting";
            this.BtnAdvanceSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAdvanceSetting.UseVisualStyleBackColor = false;
            this.BtnAdvanceSetting.Click += new System.EventHandler(this.Btn_Click);
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
            this.PnlDefaultSetting.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.PnlDefaultSetting.Size = new System.Drawing.Size(126, 59);
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
            this.BtnDefaultSetting.Size = new System.Drawing.Size(126, 53);
            this.BtnDefaultSetting.TabIndex = 28;
            this.BtnDefaultSetting.Text = "Default setting";
            this.BtnDefaultSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDefaultSetting.UseVisualStyleBackColor = false;
            this.BtnDefaultSetting.Click += new System.EventHandler(this.Btn_Click);
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
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
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
            this.PnlMainGrid.ColumnCount = 2;
            this.PnlMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.PnlMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.PnlMainGrid.Controls.Add(this.PnlLeftSite, 0, 0);
            this.PnlMainGrid.Controls.Add(this.PnlRightSite, 1, 0);
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
            this.PnlLeftSite.Controls.Add(this.PnlScanArea, 0, 1);
            this.PnlLeftSite.Controls.Add(this.PnlProgressGrid, 0, 3);
            this.PnlLeftSite.Controls.Add(this.PnlHidden, 0, 0);
            this.PnlLeftSite.Controls.Add(this.PnlChartGrid, 0, 5);
            this.PnlLeftSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlLeftSite.Location = new System.Drawing.Point(0, 0);
            this.PnlLeftSite.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.PnlLeftSite.Name = "PnlLeftSite";
            this.PnlLeftSite.RowCount = 6;
            this.PnlLeftSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.PnlLeftSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlLeftSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.PnlLeftSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.PnlLeftSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.PnlLeftSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.PnlLeftSite.Size = new System.Drawing.Size(837, 803);
            this.PnlLeftSite.TabIndex = 28;
            // 
            // PnlScanArea
            // 
            this.PnlScanArea.AutoSize = true;
            this.PnlScanArea.Controls.Add(this.ImgAreaScan);
            this.PnlScanArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlScanArea.Location = new System.Drawing.Point(0, 24);
            this.PnlScanArea.Margin = new System.Windows.Forms.Padding(0);
            this.PnlScanArea.Name = "PnlScanArea";
            this.PnlScanArea.Padding = new System.Windows.Forms.Padding(36, 0, 36, 24);
            this.PnlScanArea.Size = new System.Drawing.Size(847, 404);
            this.PnlScanArea.TabIndex = 62;
            // 
            // ImgAreaScan
            // 
            this.ImgAreaScan.BackColor = System.Drawing.Color.Gold;
            this.ImgAreaScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgAreaScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgAreaScan.Location = new System.Drawing.Point(36, 0);
            this.ImgAreaScan.Name = "ImgAreaScan";
            this.ImgAreaScan.Size = new System.Drawing.Size(775, 380);
            this.ImgAreaScan.TabIndex = 34;
            this.ImgAreaScan.TabStop = false;
            // 
            // PnlProgressGrid
            // 
            this.PnlProgressGrid.ColumnCount = 1;
            this.PnlProgressGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlProgressGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlProgressGrid.Controls.Add(this.LbScanProgress, 0, 1);
            this.PnlProgressGrid.Controls.Add(this.PbScan, 0, 0);
            this.PnlProgressGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlProgressGrid.Location = new System.Drawing.Point(0, 430);
            this.PnlProgressGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlProgressGrid.Name = "PnlProgressGrid";
            this.PnlProgressGrid.Padding = new System.Windows.Forms.Padding(36, 8, 36, 8);
            this.PnlProgressGrid.RowCount = 2;
            this.PnlProgressGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.54639F));
            this.PnlProgressGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.45361F));
            this.PnlProgressGrid.Size = new System.Drawing.Size(847, 96);
            this.PnlProgressGrid.TabIndex = 62;
            // 
            // LbScanProgress
            // 
            this.LbScanProgress.AutoSize = true;
            this.LbScanProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbScanProgress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbScanProgress.Location = new System.Drawing.Point(38, 49);
            this.LbScanProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbScanProgress.Name = "LbScanProgress";
            this.LbScanProgress.Size = new System.Drawing.Size(771, 39);
            this.LbScanProgress.TabIndex = 62;
            this.LbScanProgress.Text = "Scanning ...";
            this.LbScanProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlHidden
            // 
            this.PnlHidden.Controls.Add(this.tabControl1);
            this.PnlHidden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlHidden.Location = new System.Drawing.Point(0, 0);
            this.PnlHidden.Margin = new System.Windows.Forms.Padding(0);
            this.PnlHidden.Name = "PnlHidden";
            this.PnlHidden.Size = new System.Drawing.Size(847, 24);
            this.PnlHidden.TabIndex = 31;
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
            this.tabControl1.Size = new System.Drawing.Size(847, 24);
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
            this.tabPage1.Size = new System.Drawing.Size(839, 0);
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
            this.panel10.Controls.Add(this.label1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(2, 4);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(835, 0);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Connection Info";
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
            this.tabPage2.Size = new System.Drawing.Size(839, 0);
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
            this.panel9.Controls.Add(this.label4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(2, 4);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(835, 0);
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Selected signals:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.action);
            this.panel2.Controls.Add(this.CBFlush);
            this.panel2.Controls.Add(this.TBSampleCount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtSave);
            this.panel2.Controls.Add(this.BtRecord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 0);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sample Count:";
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
            // 
            // PnlChartGrid
            // 
            this.PnlChartGrid.ColumnCount = 1;
            this.PnlChartGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlChartGrid.Controls.Add(this.LbNameChart, 0, 1);
            this.PnlChartGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlChartGrid.Location = new System.Drawing.Point(0, 528);
            this.PnlChartGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlChartGrid.Name = "PnlChartGrid";
            this.PnlChartGrid.Padding = new System.Windows.Forms.Padding(36, 24, 36, 24);
            this.PnlChartGrid.RowCount = 2;
            this.PnlChartGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlChartGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlChartGrid.Size = new System.Drawing.Size(847, 275);
            this.PnlChartGrid.TabIndex = 63;
            // 
            // LbNameChart
            // 
            this.LbNameChart.AutoSize = true;
            this.LbNameChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbNameChart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNameChart.Location = new System.Drawing.Point(38, 228);
            this.LbNameChart.Margin = new System.Windows.Forms.Padding(2, 16, 2, 0);
            this.LbNameChart.Name = "LbNameChart";
            this.LbNameChart.Size = new System.Drawing.Size(771, 23);
            this.LbNameChart.TabIndex = 63;
            this.LbNameChart.Text = "Line Chart";
            this.LbNameChart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.PnlRightSite.Location = new System.Drawing.Point(857, 0);
            this.PnlRightSite.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PnlRightSite.Name = "PnlRightSite";
            this.PnlRightSite.RowCount = 5;
            this.PnlRightSite.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlRightSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.PnlRightSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlRightSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.PnlRightSite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlRightSite.Size = new System.Drawing.Size(683, 803);
            this.PnlRightSite.TabIndex = 28;
            // 
            // PnlSettingGrid
            // 
            this.PnlSettingGrid.BackColor = System.Drawing.Color.MistyRose;
            this.PnlSettingGrid.ColumnCount = 4;
            this.PnlSettingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PnlSettingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.PnlSettingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.PnlSettingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.PnlSettingGrid.Controls.Add(this.PnlInfoCoorGrid, 3, 0);
            this.PnlSettingGrid.Controls.Add(this.PnlZCoorGird, 2, 0);
            this.PnlSettingGrid.Controls.Add(this.PnlXYCoorGrid, 1, 0);
            this.PnlSettingGrid.Controls.Add(this.PnlListBtnSetting, 0, 0);
            this.PnlSettingGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSettingGrid.Location = new System.Drawing.Point(0, 158);
            this.PnlSettingGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlSettingGrid.Name = "PnlSettingGrid";
            this.PnlSettingGrid.Padding = new System.Windows.Forms.Padding(36, 24, 24, 24);
            this.PnlSettingGrid.RowCount = 1;
            this.PnlSettingGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlSettingGrid.Size = new System.Drawing.Size(683, 308);
            this.PnlSettingGrid.TabIndex = 34;
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
            this.PnlInfoCoorGrid.Location = new System.Drawing.Point(570, 24);
            this.PnlInfoCoorGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlInfoCoorGrid.Name = "PnlInfoCoorGrid";
            this.PnlInfoCoorGrid.RowCount = 5;
            this.PnlInfoCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.PnlInfoCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlInfoCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlInfoCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlInfoCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlInfoCoorGrid.Size = new System.Drawing.Size(89, 260);
            this.PnlInfoCoorGrid.TabIndex = 27;
            // 
            // LbZCoorValue
            // 
            this.LbZCoorValue.AutoSize = true;
            this.LbZCoorValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbZCoorValue.Location = new System.Drawing.Point(28, 208);
            this.LbZCoorValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbZCoorValue.Name = "LbZCoorValue";
            this.LbZCoorValue.Size = new System.Drawing.Size(59, 26);
            this.LbZCoorValue.TabIndex = 32;
            this.LbZCoorValue.Text = "0.00 mm";
            this.LbZCoorValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LbZAxisCoor
            // 
            this.LbZAxisCoor.AutoSize = true;
            this.LbZAxisCoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbZAxisCoor.Location = new System.Drawing.Point(2, 208);
            this.LbZAxisCoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbZAxisCoor.Name = "LbZAxisCoor";
            this.LbZAxisCoor.Size = new System.Drawing.Size(22, 26);
            this.LbZAxisCoor.TabIndex = 32;
            this.LbZAxisCoor.Text = "Z:";
            this.LbZAxisCoor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LbYCoorValue
            // 
            this.LbYCoorValue.AutoSize = true;
            this.LbYCoorValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbYCoorValue.Location = new System.Drawing.Point(28, 182);
            this.LbYCoorValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbYCoorValue.Name = "LbYCoorValue";
            this.LbYCoorValue.Size = new System.Drawing.Size(59, 26);
            this.LbYCoorValue.TabIndex = 32;
            this.LbYCoorValue.Text = "0.00 mm";
            this.LbYCoorValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LbYAxisCoor
            // 
            this.LbYAxisCoor.AutoSize = true;
            this.LbYAxisCoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbYAxisCoor.Location = new System.Drawing.Point(2, 182);
            this.LbYAxisCoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbYAxisCoor.Name = "LbYAxisCoor";
            this.LbYAxisCoor.Size = new System.Drawing.Size(22, 26);
            this.LbYAxisCoor.TabIndex = 32;
            this.LbYAxisCoor.Text = "Y:";
            this.LbYAxisCoor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LbXCoorValue
            // 
            this.LbXCoorValue.AutoSize = true;
            this.LbXCoorValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbXCoorValue.Location = new System.Drawing.Point(28, 156);
            this.LbXCoorValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbXCoorValue.Name = "LbXCoorValue";
            this.LbXCoorValue.Size = new System.Drawing.Size(59, 26);
            this.LbXCoorValue.TabIndex = 24;
            this.LbXCoorValue.Text = "0.00 mm";
            this.LbXCoorValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LbXAxisCoor
            // 
            this.LbXAxisCoor.AutoSize = true;
            this.LbXAxisCoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbXAxisCoor.Location = new System.Drawing.Point(2, 156);
            this.LbXAxisCoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbXAxisCoor.Name = "LbXAxisCoor";
            this.LbXAxisCoor.Size = new System.Drawing.Size(22, 26);
            this.LbXAxisCoor.TabIndex = 24;
            this.LbXAxisCoor.Text = "X:";
            this.LbXAxisCoor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PnlZCoorGird
            // 
            this.PnlZCoorGird.ColumnCount = 1;
            this.PnlZCoorGird.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlZCoorGird.Controls.Add(this.LbZCoor, 0, 1);
            this.PnlZCoorGird.Controls.Add(this.PnlZMap, 0, 0);
            this.PnlZCoorGird.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlZCoorGird.Location = new System.Drawing.Point(465, 24);
            this.PnlZCoorGird.Margin = new System.Windows.Forms.Padding(0);
            this.PnlZCoorGird.Name = "PnlZCoorGird";
            this.PnlZCoorGird.RowCount = 2;
            this.PnlZCoorGird.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.PnlZCoorGird.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlZCoorGird.Size = new System.Drawing.Size(105, 260);
            this.PnlZCoorGird.TabIndex = 28;
            // 
            // LbZCoor
            // 
            this.LbZCoor.AutoSize = true;
            this.LbZCoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbZCoor.Location = new System.Drawing.Point(2, 234);
            this.LbZCoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbZCoor.Name = "LbZCoor";
            this.LbZCoor.Size = new System.Drawing.Size(101, 26);
            this.LbZCoor.TabIndex = 22;
            this.LbZCoor.Text = "Z Coordinate";
            this.LbZCoor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PnlXYCoorGrid
            // 
            this.PnlXYCoorGrid.ColumnCount = 1;
            this.PnlXYCoorGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlXYCoorGrid.Controls.Add(this.LbXYCoor, 0, 1);
            this.PnlXYCoorGrid.Controls.Add(this.PnlXYMap, 0, 0);
            this.PnlXYCoorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlXYCoorGrid.Location = new System.Drawing.Point(191, 24);
            this.PnlXYCoorGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlXYCoorGrid.Name = "PnlXYCoorGrid";
            this.PnlXYCoorGrid.RowCount = 2;
            this.PnlXYCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.PnlXYCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlXYCoorGrid.Size = new System.Drawing.Size(274, 260);
            this.PnlXYCoorGrid.TabIndex = 27;
            // 
            // LbXYCoor
            // 
            this.LbXYCoor.AutoSize = true;
            this.LbXYCoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbXYCoor.Location = new System.Drawing.Point(2, 234);
            this.LbXYCoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbXYCoor.Name = "LbXYCoor";
            this.LbXYCoor.Size = new System.Drawing.Size(270, 26);
            this.LbXYCoor.TabIndex = 22;
            this.LbXYCoor.Text = "X,Y Coordinate";
            this.LbXYCoor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PnlListBtnSetting
            // 
            this.PnlListBtnSetting.ColumnCount = 1;
            this.PnlListBtnSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlListBtnSetting.Controls.Add(this.CbbRunMode, 0, 0);
            this.PnlListBtnSetting.Controls.Add(this.CbbSignalMode, 0, 4);
            this.PnlListBtnSetting.Controls.Add(this.CbbScanArea, 0, 2);
            this.PnlListBtnSetting.Controls.Add(this.CbbSaveMode, 0, 6);
            this.PnlListBtnSetting.Controls.Add(this.BtnSaveData, 0, 8);
            this.PnlListBtnSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlListBtnSetting.Location = new System.Drawing.Point(36, 24);
            this.PnlListBtnSetting.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.PnlListBtnSetting.Name = "PnlListBtnSetting";
            this.PnlListBtnSetting.RowCount = 9;
            this.PnlListBtnSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.PnlListBtnSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.PnlListBtnSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.PnlListBtnSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.PnlListBtnSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.PnlListBtnSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.PnlListBtnSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.PnlListBtnSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.PnlListBtnSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.PnlListBtnSetting.Size = new System.Drawing.Size(147, 260);
            this.PnlListBtnSetting.TabIndex = 33;
            // 
            // PnlControlGrid
            // 
            this.PnlControlGrid.BackColor = System.Drawing.Color.Pink;
            this.PnlControlGrid.ColumnCount = 3;
            this.PnlControlGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.PnlControlGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.PnlControlGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.PnlControlGrid.Controls.Add(this.PnlZControl, 1, 0);
            this.PnlControlGrid.Controls.Add(this.PnlXYControl, 0, 0);
            this.PnlControlGrid.Controls.Add(this.PnlTchAreaGrid, 2, 0);
            this.PnlControlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlControlGrid.Location = new System.Drawing.Point(0, 494);
            this.PnlControlGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlControlGrid.Name = "PnlControlGrid";
            this.PnlControlGrid.Padding = new System.Windows.Forms.Padding(36, 24, 24, 24);
            this.PnlControlGrid.RowCount = 1;
            this.PnlControlGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlControlGrid.Size = new System.Drawing.Size(683, 309);
            this.PnlControlGrid.TabIndex = 27;
            // 
            // PnlZControl
            // 
            this.PnlZControl.Controls.Add(this.TbZControl);
            this.PnlZControl.Controls.Add(this.LbZAxis);
            this.PnlZControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlZControl.Location = new System.Drawing.Point(339, 27);
            this.PnlZControl.Name = "PnlZControl";
            this.PnlZControl.Padding = new System.Windows.Forms.Padding(10, 36, 10, 8);
            this.PnlZControl.Size = new System.Drawing.Size(65, 255);
            this.PnlZControl.TabIndex = 39;
            // 
            // LbZAxis
            // 
            this.LbZAxis.AutoSize = true;
            this.LbZAxis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbZAxis.Location = new System.Drawing.Point(10, 0);
            this.LbZAxis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbZAxis.Name = "LbZAxis";
            this.LbZAxis.Size = new System.Drawing.Size(80, 23);
            this.LbZAxis.TabIndex = 62;
            this.LbZAxis.Text = "Z - Axis";
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
            this.PnlXYControl.Size = new System.Drawing.Size(300, 261);
            this.PnlXYControl.TabIndex = 27;
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
            this.PnlChangeSpeedArea.Location = new System.Drawing.Point(0, 219);
            this.PnlChangeSpeedArea.Margin = new System.Windows.Forms.Padding(0);
            this.PnlChangeSpeedArea.Name = "PnlChangeSpeedArea";
            this.PnlChangeSpeedArea.RowCount = 1;
            this.PnlChangeSpeedArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlChangeSpeedArea.Size = new System.Drawing.Size(300, 42);
            this.PnlChangeSpeedArea.TabIndex = 27;
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
            this.PnlXYBtn.Size = new System.Drawing.Size(300, 219);
            this.PnlXYBtn.TabIndex = 27;
            // 
            // axDBDeviceManager1
            // 
            this.axDBDeviceManager1.Enabled = true;
            this.axDBDeviceManager1.Location = new System.Drawing.Point(273, 63);
            this.axDBDeviceManager1.Name = "axDBDeviceManager1";
            this.axDBDeviceManager1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDBDeviceManager1.OcxState")));
            this.axDBDeviceManager1.Size = new System.Drawing.Size(30, 30);
            this.axDBDeviceManager1.TabIndex = 65;
            this.axDBDeviceManager1.BeforeRead += new System.EventHandler(this.axDBDeviceManager1_BeforeRead);
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
            // axDBCommManager1
            // 
            this.axDBCommManager1.Enabled = true;
            this.axDBCommManager1.Location = new System.Drawing.Point(273, 3);
            this.axDBCommManager1.Name = "axDBCommManager1";
            this.axDBCommManager1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDBCommManager1.OcxState")));
            this.axDBCommManager1.Size = new System.Drawing.Size(30, 30);
            this.axDBCommManager1.TabIndex = 63;
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
            // PnlTchAreaGrid
            // 
            this.PnlTchAreaGrid.BackColor = System.Drawing.Color.Pink;
            this.PnlTchAreaGrid.ColumnCount = 1;
            this.PnlTchAreaGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTchAreaGrid.Controls.Add(this.BtnRsTch, 0, 3);
            this.PnlTchAreaGrid.Controls.Add(this.BtnRunScan, 0, 4);
            this.PnlTchAreaGrid.Controls.Add(this.PnlTchGrid, 0, 1);
            this.PnlTchAreaGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTchAreaGrid.Location = new System.Drawing.Point(410, 27);
            this.PnlTchAreaGrid.Name = "PnlTchAreaGrid";
            this.PnlTchAreaGrid.RowCount = 5;
            this.PnlTchAreaGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.PnlTchAreaGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.PnlTchAreaGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.PnlTchAreaGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PnlTchAreaGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PnlTchAreaGrid.Size = new System.Drawing.Size(246, 255);
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
            this.PnlTchGrid.Location = new System.Drawing.Point(3, 39);
            this.PnlTchGrid.Name = "PnlTchGrid";
            this.PnlTchGrid.RowCount = 4;
            this.PnlTchGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.PnlTchGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.PnlTchGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.PnlTchGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.PnlTchGrid.Size = new System.Drawing.Size(240, 169);
            this.PnlTchGrid.TabIndex = 27;
            // 
            // LbPos4
            // 
            this.LbPos4.AutoSize = true;
            this.LbPos4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbPos4.Location = new System.Drawing.Point(2, 129);
            this.LbPos4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbPos4.Name = "LbPos4";
            this.LbPos4.Size = new System.Drawing.Size(67, 43);
            this.LbPos4.TabIndex = 60;
            this.LbPos4.Text = "Position 4:";
            this.LbPos4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbPos1
            // 
            this.LbPos1.AutoSize = true;
            this.LbPos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbPos1.Location = new System.Drawing.Point(2, 0);
            this.LbPos1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbPos1.Name = "LbPos1";
            this.LbPos1.Size = new System.Drawing.Size(67, 43);
            this.LbPos1.TabIndex = 60;
            this.LbPos1.Text = "Position 1:";
            this.LbPos1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbPos3
            // 
            this.LbPos3.AutoSize = true;
            this.LbPos3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbPos3.Location = new System.Drawing.Point(2, 86);
            this.LbPos3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbPos3.Name = "LbPos3";
            this.LbPos3.Size = new System.Drawing.Size(67, 43);
            this.LbPos3.TabIndex = 60;
            this.LbPos3.Text = "Position 3:";
            this.LbPos3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbPos2
            // 
            this.LbPos2.AutoSize = true;
            this.LbPos2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbPos2.Location = new System.Drawing.Point(2, 43);
            this.LbPos2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbPos2.Name = "LbPos2";
            this.LbPos2.Size = new System.Drawing.Size(67, 43);
            this.LbPos2.TabIndex = 60;
            this.LbPos2.Text = "Position 2:";
            this.LbPos2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbTitleSetting
            // 
            this.LbTitleSetting.AutoSize = true;
            this.LbTitleSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbTitleSetting.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitleSetting.Location = new System.Drawing.Point(3, 130);
            this.LbTitleSetting.Name = "LbTitleSetting";
            this.LbTitleSetting.Size = new System.Drawing.Size(677, 28);
            this.LbTitleSetting.TabIndex = 26;
            this.LbTitleSetting.Text = "Setting up";
            this.LbTitleSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbTitleControl
            // 
            this.LbTitleControl.AutoSize = true;
            this.LbTitleControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbTitleControl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitleControl.Location = new System.Drawing.Point(3, 466);
            this.LbTitleControl.Name = "LbTitleControl";
            this.LbTitleControl.Size = new System.Drawing.Size(677, 28);
            this.LbTitleControl.TabIndex = 27;
            this.LbTitleControl.Text = "Control";
            this.LbTitleControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chart4
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea1);
            this.chart4.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart4.Legends.Add(legend1);
            this.chart4.Location = new System.Drawing.Point(0, 0);
            this.chart4.Margin = new System.Windows.Forms.Padding(1);
            this.chart4.Name = "chart4";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart4.Series.Add(series1);
            this.chart4.Size = new System.Drawing.Size(775, 192);
            this.chart4.TabIndex = 34;
            this.chart4.Text = "chart4";
            // 
            // timerComboBox
            // 
            this.timerComboBox.Interval = 1;
            this.timerComboBox.Tick += new System.EventHandler(this.timerComboBox_Tick);
            // 
            // PbScan
            // 
            this.PbScan.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.PbScan.ChannelHeight = 24;
            this.PbScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbScan.ForeBackColor = System.Drawing.Color.RosyBrown;
            this.PbScan.ForeColor = System.Drawing.Color.White;
            this.PbScan.Location = new System.Drawing.Point(39, 11);
            this.PbScan.Name = "PbScan";
            this.PbScan.ShowMaximun = false;
            this.PbScan.ShowValue = TCHRLibBasicRecordSample.CustomUi.TextPosition.Sliding;
            this.PbScan.Size = new System.Drawing.Size(769, 35);
            this.PbScan.SliderColor = System.Drawing.Color.RosyBrown;
            this.PbScan.SliderHeight = 24;
            this.PbScan.SymbolAfter = "%";
            this.PbScan.SymbolBefore = "";
            this.PbScan.TabIndex = 35;
            // 
            // PnlZMap
            // 
            this.PnlZMap.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.PnlZMap.BorderColor = System.Drawing.Color.SlateBlue;
            this.PnlZMap.BorderSize = 2;
            this.PnlZMap.CoordinateX = 0D;
            this.PnlZMap.CoordinateY = 0D;
            this.PnlZMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlZMap.DragEnabled = false;
            this.PnlZMap.GridSize = 25;
            this.PnlZMap.LineColor = System.Drawing.Color.White;
            this.PnlZMap.LineSize = 1;
            this.PnlZMap.Location = new System.Drawing.Point(3, 3);
            this.PnlZMap.MainLineColor = System.Drawing.Color.White;
            this.PnlZMap.MainLineSizeX = 2;
            this.PnlZMap.MainLineSizeY = 4;
            this.PnlZMap.Name = "PnlZMap";
            this.PnlZMap.PointColor = System.Drawing.Color.Orange;
            this.PnlZMap.PointDisplayStyle = TCHRLibBasicRecordSample.CustomUi.PointDisplayStyle.Circle;
            this.PnlZMap.PointSize = 20;
            this.PnlZMap.PointX = 50;
            this.PnlZMap.PointY = 50;
            this.PnlZMap.Size = new System.Drawing.Size(99, 228);
            this.PnlZMap.TabIndex = 23;
            this.PnlZMap.Text = "dsM_GridMap1";
            // 
            // PnlXYMap
            // 
            this.PnlXYMap.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.PnlXYMap.BorderColor = System.Drawing.Color.SlateBlue;
            this.PnlXYMap.BorderSize = 2;
            this.PnlXYMap.CoordinateX = 0D;
            this.PnlXYMap.CoordinateY = 0D;
            this.PnlXYMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlXYMap.DragEnabled = true;
            this.PnlXYMap.GridSize = 25;
            this.PnlXYMap.LineColor = System.Drawing.Color.White;
            this.PnlXYMap.LineSize = 1;
            this.PnlXYMap.Location = new System.Drawing.Point(3, 3);
            this.PnlXYMap.MainLineColor = System.Drawing.Color.White;
            this.PnlXYMap.MainLineSizeX = 2;
            this.PnlXYMap.MainLineSizeY = 2;
            this.PnlXYMap.Name = "PnlXYMap";
            this.PnlXYMap.PointColor = System.Drawing.Color.Orange;
            this.PnlXYMap.PointDisplayStyle = TCHRLibBasicRecordSample.CustomUi.PointDisplayStyle.Plus;
            this.PnlXYMap.PointSize = 20;
            this.PnlXYMap.PointX = 50;
            this.PnlXYMap.PointY = 50;
            this.PnlXYMap.Size = new System.Drawing.Size(268, 228);
            this.PnlXYMap.TabIndex = 23;
            this.PnlXYMap.Text = "dsM_GridMap1";
            // 
            // CbbRunMode
            // 
            this.CbbRunMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.CbbRunMode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CbbRunMode.BorderSize = 1;
            this.CbbRunMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CbbRunMode.DropDownHeight = 200;
            this.CbbRunMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbbRunMode.DropDownWidth = 200;
            this.CbbRunMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CbbRunMode.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CbbRunMode.Items.AddRange(new object[] {
            "Zigzac mode",
            "Raster mode"});
            this.CbbRunMode.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(92)))), ((int)(((byte)(86)))));
            this.CbbRunMode.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CbbRunMode.Location = new System.Drawing.Point(3, 3);
            this.CbbRunMode.MinimumSize = new System.Drawing.Size(40, 26);
            this.CbbRunMode.Name = "CbbRunMode";
            this.CbbRunMode.Padding = new System.Windows.Forms.Padding(1);
            this.CbbRunMode.Size = new System.Drawing.Size(141, 35);
            this.CbbRunMode.TabIndex = 6;
            this.CbbRunMode.Texts = "Run mode";
            // 
            // CbbSignalMode
            // 
            this.CbbSignalMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.CbbSignalMode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CbbSignalMode.BorderSize = 1;
            this.CbbSignalMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CbbSignalMode.DropDownHeight = 200;
            this.CbbSignalMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbbSignalMode.DropDownWidth = 200;
            this.CbbSignalMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CbbSignalMode.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CbbSignalMode.Items.AddRange(new object[] {
            "Z axis",
            "X axis",
            "Y axis",
            "Incentive"});
            this.CbbSignalMode.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(92)))), ((int)(((byte)(86)))));
            this.CbbSignalMode.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CbbSignalMode.Location = new System.Drawing.Point(3, 111);
            this.CbbSignalMode.MinimumSize = new System.Drawing.Size(40, 26);
            this.CbbSignalMode.Name = "CbbSignalMode";
            this.CbbSignalMode.Padding = new System.Windows.Forms.Padding(1);
            this.CbbSignalMode.Size = new System.Drawing.Size(141, 35);
            this.CbbSignalMode.TabIndex = 8;
            this.CbbSignalMode.Texts = "Chart Info";
            // 
            // CbbScanArea
            // 
            this.CbbScanArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.CbbScanArea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CbbScanArea.BorderSize = 1;
            this.CbbScanArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CbbScanArea.DropDownHeight = 200;
            this.CbbScanArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbbScanArea.DropDownWidth = 200;
            this.CbbScanArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CbbScanArea.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CbbScanArea.Items.AddRange(new object[] {
            "30x30 mm",
            "40x40 mm",
            "60x60 mm"});
            this.CbbScanArea.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(92)))), ((int)(((byte)(86)))));
            this.CbbScanArea.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CbbScanArea.Location = new System.Drawing.Point(3, 57);
            this.CbbScanArea.MinimumSize = new System.Drawing.Size(40, 26);
            this.CbbScanArea.Name = "CbbScanArea";
            this.CbbScanArea.Padding = new System.Windows.Forms.Padding(1);
            this.CbbScanArea.Size = new System.Drawing.Size(141, 35);
            this.CbbScanArea.TabIndex = 29;
            this.CbbScanArea.Texts = "Scan area";
            // 
            // CbbSaveMode
            // 
            this.CbbSaveMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.CbbSaveMode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CbbSaveMode.BorderSize = 1;
            this.CbbSaveMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CbbSaveMode.DropDownHeight = 200;
            this.CbbSaveMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbbSaveMode.DropDownWidth = 200;
            this.CbbSaveMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CbbSaveMode.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CbbSaveMode.Items.AddRange(new object[] {
            "Save as CSV",
            "Save as BCRF",
            "Save as SUR"});
            this.CbbSaveMode.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(92)))), ((int)(((byte)(86)))));
            this.CbbSaveMode.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CbbSaveMode.Location = new System.Drawing.Point(3, 165);
            this.CbbSaveMode.MinimumSize = new System.Drawing.Size(40, 26);
            this.CbbSaveMode.Name = "CbbSaveMode";
            this.CbbSaveMode.Padding = new System.Windows.Forms.Padding(1);
            this.CbbSaveMode.Size = new System.Drawing.Size(141, 35);
            this.CbbSaveMode.TabIndex = 32;
            this.CbbSaveMode.Texts = "Save mode";
            // 
            // BtnSaveData
            // 
            this.BtnSaveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnSaveData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnSaveData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSaveData.BorderRadius = 8;
            this.BtnSaveData.BorderSize = 1;
            this.BtnSaveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSaveData.FlatAppearance.BorderSize = 0;
            this.BtnSaveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSaveData.Location = new System.Drawing.Point(3, 219);
            this.BtnSaveData.Name = "BtnSaveData";
            this.BtnSaveData.Size = new System.Drawing.Size(141, 38);
            this.BtnSaveData.TabIndex = 33;
            this.BtnSaveData.Text = "SAVE";
            this.BtnSaveData.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSaveData.UseVisualStyleBackColor = false;
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
            this.TbZControl.Location = new System.Drawing.Point(10, 36);
            this.TbZControl.MaximumPercent = 100;
            this.TbZControl.MinimumPercent = 0;
            this.TbZControl.Name = "TbZControl";
            this.TbZControl.Orientation = TCHRLibBasicRecordSample.CustomUi.DSM_TrackBarImg.TrackbarOrientation.Vertical;
            this.TbZControl.Size = new System.Drawing.Size(45, 211);
            this.TbZControl.TabIndex = 63;
            this.TbZControl.ThumbColor = System.Drawing.Color.Red;
            this.TbZControl.ThumbImage = global::TCHRLibBasicRecordSample.Properties.Resources.icon_Zmove;
            this.TbZControl.ThumbSize = 40;
            this.TbZControl.TrackColorLeft = System.Drawing.Color.Blue;
            this.TbZControl.TrackColorRight = System.Drawing.Color.Gray;
            this.TbZControl.Value = 0;
            this.TbZControl.VerticalReversed = true;
            this.TbZControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TbZControl_MouseDown);
            this.TbZControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TbZControl_MouseUp);
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
            // BtnXYDownSpeed
            // 
            this.BtnXYDownSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnXYDownSpeed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnXYDownSpeed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnXYDownSpeed.BorderRadius = 1;
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
            this.BtnXYDownSpeed.UseVisualStyleBackColor = false;
            this.BtnXYDownSpeed.Click += new System.EventHandler(this.BtnXYDownSpeed_Click);
            // 
            // BtnXYUpSpeed
            // 
            this.BtnXYUpSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnXYUpSpeed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnXYUpSpeed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnXYUpSpeed.BorderRadius = 1;
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
            this.BtnXYUpSpeed.UseVisualStyleBackColor = false;
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
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
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
            this.BtnLeft.UseVisualStyleBackColor = false;
            this.BtnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnLeft_MouseDown);
            this.BtnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnLeft_MouseUp);
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
            this.BtnRight.UseVisualStyleBackColor = false;
            this.BtnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnRight_MouseDown);
            this.BtnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnRight_MouseUp);
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
            this.BtnDown.UseVisualStyleBackColor = false;
            this.BtnDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnDown_MouseDown);
            this.BtnDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnDown_MouseUp);
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
            this.BtnUp.UseVisualStyleBackColor = false;
            this.BtnUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnUp_MouseDown);
            this.BtnUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnUp_MouseUp);
            // 
            // BtnRsTch
            // 
            this.BtnRsTch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnRsTch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnRsTch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRsTch.BorderRadius = 1;
            this.BtnRsTch.BorderSize = 1;
            this.BtnRsTch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRsTch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRsTch.FlatAppearance.BorderSize = 0;
            this.BtnRsTch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRsTch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRsTch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRsTch.Location = new System.Drawing.Point(3, 224);
            this.BtnRsTch.Name = "BtnRsTch";
            this.BtnRsTch.Size = new System.Drawing.Size(240, 4);
            this.BtnRsTch.TabIndex = 59;
            this.BtnRsTch.Text = "Reset Teaching Point";
            this.BtnRsTch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRsTch.UseVisualStyleBackColor = false;
            // 
            // BtnRunScan
            // 
            this.BtnRunScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnRunScan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnRunScan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunScan.BorderRadius = 1;
            this.BtnRunScan.BorderSize = 1;
            this.BtnRunScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRunScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRunScan.FlatAppearance.BorderSize = 0;
            this.BtnRunScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRunScan.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRunScan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunScan.Location = new System.Drawing.Point(3, 239);
            this.BtnRunScan.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.BtnRunScan.Name = "BtnRunScan";
            this.BtnRunScan.Size = new System.Drawing.Size(240, 8);
            this.BtnRunScan.TabIndex = 58;
            this.BtnRunScan.Text = "START SCAN";
            this.BtnRunScan.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunScan.UseVisualStyleBackColor = false;
            this.BtnRunScan.Click += new System.EventHandler(this.BtRecord_Click);
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
            this.BtnSetPos4.Location = new System.Drawing.Point(193, 132);
            this.BtnSetPos4.Name = "BtnSetPos4";
            this.BtnSetPos4.Size = new System.Drawing.Size(44, 37);
            this.BtnSetPos4.TabIndex = 52;
            this.BtnSetPos4.Text = "Set";
            this.BtnSetPos4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSetPos4.UseVisualStyleBackColor = false;
            // 
            // TbPos4
            // 
            this.TbPos4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.TbPos4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbPos4.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.TbPos4.BorderSize = 1;
            this.TbPos4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPos4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbPos4.Location = new System.Drawing.Point(76, 134);
            this.TbPos4.Margin = new System.Windows.Forms.Padding(5);
            this.TbPos4.Multiline = false;
            this.TbPos4.Name = "TbPos4";
            this.TbPos4.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.TbPos4.PasswordChar = false;
            this.TbPos4.Size = new System.Drawing.Size(61, 40);
            this.TbPos4.TabIndex = 57;
            this.TbPos4.UnderlineStyle = false;
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
            this.BtnRunPos4.Location = new System.Drawing.Point(145, 132);
            this.BtnRunPos4.Name = "BtnRunPos4";
            this.BtnRunPos4.Size = new System.Drawing.Size(42, 37);
            this.BtnRunPos4.TabIndex = 53;
            this.BtnRunPos4.Text = "Run";
            this.BtnRunPos4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunPos4.UseVisualStyleBackColor = false;
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
            this.BtnRunPos3.Location = new System.Drawing.Point(145, 89);
            this.BtnRunPos3.Name = "BtnRunPos3";
            this.BtnRunPos3.Size = new System.Drawing.Size(42, 37);
            this.BtnRunPos3.TabIndex = 49;
            this.BtnRunPos3.Text = "Run";
            this.BtnRunPos3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunPos3.UseVisualStyleBackColor = false;
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
            this.BtnSetPos3.Location = new System.Drawing.Point(193, 89);
            this.BtnSetPos3.Name = "BtnSetPos3";
            this.BtnSetPos3.Size = new System.Drawing.Size(44, 37);
            this.BtnSetPos3.TabIndex = 48;
            this.BtnSetPos3.Text = "Set";
            this.BtnSetPos3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSetPos3.UseVisualStyleBackColor = false;
            // 
            // TbPos3
            // 
            this.TbPos3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.TbPos3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbPos3.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.TbPos3.BorderSize = 1;
            this.TbPos3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPos3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbPos3.Location = new System.Drawing.Point(76, 91);
            this.TbPos3.Margin = new System.Windows.Forms.Padding(5);
            this.TbPos3.Multiline = false;
            this.TbPos3.Name = "TbPos3";
            this.TbPos3.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.TbPos3.PasswordChar = false;
            this.TbPos3.Size = new System.Drawing.Size(61, 40);
            this.TbPos3.TabIndex = 55;
            this.TbPos3.UnderlineStyle = false;
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
            this.BtnRunPos1.Location = new System.Drawing.Point(145, 3);
            this.BtnRunPos1.Name = "BtnRunPos1";
            this.BtnRunPos1.Size = new System.Drawing.Size(42, 37);
            this.BtnRunPos1.TabIndex = 41;
            this.BtnRunPos1.Text = "Run";
            this.BtnRunPos1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunPos1.UseVisualStyleBackColor = false;
            this.BtnRunPos1.Click += new System.EventHandler(this.BtnRunPos1_Click);
            this.BtnRunPos1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnRunPos1_MouseDown);
            this.BtnRunPos1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnRunPos1_MouseUp);
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
            this.BtnSetPos1.Location = new System.Drawing.Point(193, 3);
            this.BtnSetPos1.Name = "BtnSetPos1";
            this.BtnSetPos1.Size = new System.Drawing.Size(44, 37);
            this.BtnSetPos1.TabIndex = 41;
            this.BtnSetPos1.Text = "Set";
            this.BtnSetPos1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSetPos1.UseVisualStyleBackColor = false;
            this.BtnSetPos1.Click += new System.EventHandler(this.BtnSetPos1_Click);
            this.BtnSetPos1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSetPos1_MouseDown);
            this.BtnSetPos1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnSetPos1_MouseUp);
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
            this.BtnRunPos2.Location = new System.Drawing.Point(145, 46);
            this.BtnRunPos2.Name = "BtnRunPos2";
            this.BtnRunPos2.Size = new System.Drawing.Size(42, 37);
            this.BtnRunPos2.TabIndex = 45;
            this.BtnRunPos2.Text = "Run";
            this.BtnRunPos2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunPos2.UseVisualStyleBackColor = false;
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
            this.BtnSetPos2.Location = new System.Drawing.Point(193, 46);
            this.BtnSetPos2.Name = "BtnSetPos2";
            this.BtnSetPos2.Size = new System.Drawing.Size(44, 37);
            this.BtnSetPos2.TabIndex = 44;
            this.BtnSetPos2.Text = "Set";
            this.BtnSetPos2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnSetPos2.UseVisualStyleBackColor = false;
            // 
            // TbPos2
            // 
            this.TbPos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.TbPos2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbPos2.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.TbPos2.BorderSize = 1;
            this.TbPos2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPos2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbPos2.Location = new System.Drawing.Point(76, 48);
            this.TbPos2.Margin = new System.Windows.Forms.Padding(5);
            this.TbPos2.Multiline = false;
            this.TbPos2.Name = "TbPos2";
            this.TbPos2.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.TbPos2.PasswordChar = false;
            this.TbPos2.Size = new System.Drawing.Size(61, 40);
            this.TbPos2.TabIndex = 54;
            this.TbPos2.UnderlineStyle = false;
            // 
            // TbPos1
            // 
            this.TbPos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.TbPos1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbPos1.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.TbPos1.BorderSize = 1;
            this.TbPos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPos1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TbPos1.Location = new System.Drawing.Point(76, 5);
            this.TbPos1.Margin = new System.Windows.Forms.Padding(5);
            this.TbPos1.Multiline = false;
            this.TbPos1.Name = "TbPos1";
            this.TbPos1.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.TbPos1.PasswordChar = false;
            this.TbPos1.Size = new System.Drawing.Size(61, 40);
            this.TbPos1.TabIndex = 56;
            this.TbPos1.UnderlineStyle = false;
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
            this.PnlRightSite.ResumeLayout(false);
            this.PnlRightSite.PerformLayout();
            this.PnlSettingGrid.ResumeLayout(false);
            this.PnlInfoCoorGrid.ResumeLayout(false);
            this.PnlInfoCoorGrid.PerformLayout();
            this.PnlZCoorGird.ResumeLayout(false);
            this.PnlZCoorGird.PerformLayout();
            this.PnlXYCoorGrid.ResumeLayout(false);
            this.PnlXYCoorGrid.PerformLayout();
            this.PnlListBtnSetting.ResumeLayout(false);
            this.PnlControlGrid.ResumeLayout(false);
            this.PnlZControl.ResumeLayout(false);
            this.PnlZControl.PerformLayout();
            this.PnlXYControl.ResumeLayout(false);
            this.PnlChangeSpeedArea.ResumeLayout(false);
            this.PnlXYBtn.ResumeLayout(false);
            this.PnlXYBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axDBDeviceManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axDBTriggerManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axDBCommManager1)).EndInit();
            this.PnlTchAreaGrid.ResumeLayout(false);
            this.PnlTchGrid.ResumeLayout(false);
            this.PnlTchGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerData;
        private System.Windows.Forms.SaveFileDialog SaveDlg;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel PnlSetting;
        private System.Windows.Forms.Panel PnlDSPage;
        private System.Windows.Forms.TableLayoutPanel PnlNavSetting;
        private System.Windows.Forms.Panel PnlAdvanceSetting;
        private System.Windows.Forms.Button BtnAdvanceSetting;
        private System.Windows.Forms.Panel PnlDefaultSetting;
        private System.Windows.Forms.Button BtnDefaultSetting;
        private System.Windows.Forms.Panel PnlControlBar;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Label LbZCoorValue;
        private System.Windows.Forms.Label LbYCoorValue;
        private System.Windows.Forms.Label LbXCoorValue;
        private System.Windows.Forms.Label LbTitleSetting;
        private System.Windows.Forms.TableLayoutPanel PnlMainGrid;
        private System.Windows.Forms.TableLayoutPanel PnlRightSite;
        private System.Windows.Forms.TableLayoutPanel PnlLeftSite;
        private System.Windows.Forms.Label LbTitleControl;
        private System.Windows.Forms.TableLayoutPanel PnlSettingGrid;
        private System.Windows.Forms.Timer timerComboBox;
        private System.Windows.Forms.TableLayoutPanel PnlListBtnSetting;
        private CustomUi.TabControl.DSM_ComboBox CbbRunMode;
        private CustomUi.TabControl.DSM_ComboBox CbbSignalMode;
        private CustomUi.TabControl.DSM_ComboBox CbbScanArea;
        private System.Windows.Forms.Label LbXAxisCoor;
        private System.Windows.Forms.Label LbYAxisCoor;
        private System.Windows.Forms.Label LbZAxisCoor;
        private CustomUi.TabControl.DSM_ComboBox CbbSaveMode;
        private CustomUi.DSM_Button BtnSaveData;
        private CustomUi.DSM_TextBox TbPos4;
        private CustomUi.DSM_TextBox TbPos1;
        private CustomUi.DSM_TextBox TbPos3;
        private CustomUi.DSM_TextBox TbPos2;
        private CustomUi.DSM_Button BtnSetPos4;
        private CustomUi.DSM_Button BtnRunPos4;
        private CustomUi.DSM_Button BtnSetPos3;
        private CustomUi.DSM_Button BtnRunPos3;
        private CustomUi.DSM_Button BtnSetPos2;
        private CustomUi.DSM_Button BtnRunPos2;
        private CustomUi.DSM_Button BtnSetPos1;
        private CustomUi.DSM_Button BtnRunPos1;
        private CustomUi.DSM_Button BtnRsTch;
        private CustomUi.DSM_Button BtnRunScan;
        private System.Windows.Forms.TableLayoutPanel PnlControlGrid;
        private System.Windows.Forms.TableLayoutPanel PnlXYControl;
        private System.Windows.Forms.Panel PnlXYBtn;
        private System.Windows.Forms.Panel PnlZControl;
        private System.Windows.Forms.TableLayoutPanel PnlZCoorGird;
        private System.Windows.Forms.Label LbZCoor;
        private System.Windows.Forms.TableLayoutPanel PnlInfoCoorGrid;
        private System.Windows.Forms.Label LbPos4;
        private System.Windows.Forms.Label LbPos3;
        private System.Windows.Forms.Label LbPos2;
        private System.Windows.Forms.Label LbPos1;
        private System.Windows.Forms.TableLayoutPanel PnlTchGrid;
        private System.Windows.Forms.TableLayoutPanel PnlChangeSpeedArea;
        private CustomUi.DSM_Button BtnXYDownSpeed;
        private CustomUi.DSM_Button BtnXYUpSpeed;
        private CustomUi.DSM_Trackbar TbXYspeed;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button action;
        private System.Windows.Forms.CheckBox CBFlush;
        private System.Windows.Forms.TextBox TBSampleCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.Button BtRecord;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton RBInterfero;
        private System.Windows.Forms.RadioButton RBConfocal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBSHZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBSODX;
        private System.Windows.Forms.Label label4;
        private CustomUi.DSM_SpecialButton BtnLeftUp;
        private CustomUi.DSM_SpecialButton BtnDownLeft;
        private CustomUi.DSM_Button BtnHome;
        private CustomUi.DSM_SpecialButton BtnRightDown;
        private CustomUi.DSM_Button BtnLeft;
        private CustomUi.DSM_SpecialButton BtnUpRight;
        private CustomUi.DSM_Button BtnRight;
        private CustomUi.DSM_Button BtnDown;
        private CustomUi.DSM_Button BtnUp;
        private System.Windows.Forms.Label LbZAxis;
        private System.Windows.Forms.Label LbXYAxis;
        private System.Windows.Forms.TableLayoutPanel PnlTchAreaGrid;
        private System.Windows.Forms.Panel PnlScanArea;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.Label LbNameChart;
        private System.Windows.Forms.PictureBox ImgAreaScan;
        private System.Windows.Forms.TableLayoutPanel PnlProgressGrid;
        private System.Windows.Forms.Label LbScanProgress;
        private CustomUi.DSM_ProgressBar PbScan;
        private System.Windows.Forms.TableLayoutPanel PnlChartGrid;
        private System.Windows.Forms.Label LbXYSpeed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private CustomUi.DSM_TrackBarImg TbZControl;
        private System.ComponentModel.IContainer components;
        private AxDATABUILDERAXLibLB.AxDBDeviceManager axDBDeviceManager1;
        private AxDATABUILDERAXLibLB.AxDBTriggerManager axDBTriggerManager1;
        private AxDATABUILDERAXLibLB.AxDBCommManager axDBCommManager1;
        private System.Windows.Forms.TableLayoutPanel PnlXYCoorGrid;
        private System.Windows.Forms.Label LbXYCoor;
        private CustomUi.DSM_GridMap PnlXYMap;
        private CustomUi.DSM_GridMap PnlZMap;
    }
}

