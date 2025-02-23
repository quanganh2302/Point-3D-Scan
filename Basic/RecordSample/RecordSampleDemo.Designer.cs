namespace TCHRLibBasicRecordSample
{
    partial class TRecordSample
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.PbScan = new TCHRLibBasicRecordSample.Componets.DSM_ProgressBar();
            this.PnlHidden = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.axDBTriggerManager1 = new AxDATABUILDERAXLibLB.AxDBTriggerManager();
            this.axDBDeviceManager1 = new AxDATABUILDERAXLibLB.AxDBDeviceManager();
            this.axDBCommManager1 = new AxDATABUILDERAXLibLB.AxDBCommManager();
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
            this.PnlLineChartArea = new System.Windows.Forms.Panel();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.PnlZMap = new System.Windows.Forms.Panel();
            this.PnlXYCoorGrid = new System.Windows.Forms.TableLayoutPanel();
            this.PnlXYMap = new System.Windows.Forms.Panel();
            this.LbXYCoor = new System.Windows.Forms.Label();
            this.PnlListBtnSetting = new System.Windows.Forms.TableLayoutPanel();
            this.CbbRunMode = new TCHRLibBasicRecordSample.Componets.TabControl.DSM_ComboBox();
            this.CbbSignalMode = new TCHRLibBasicRecordSample.Componets.TabControl.DSM_ComboBox();
            this.CbbScanArea = new TCHRLibBasicRecordSample.Componets.TabControl.DSM_ComboBox();
            this.CbbSaveMode = new TCHRLibBasicRecordSample.Componets.TabControl.DSM_ComboBox();
            this.BtnResetSetting = new TCHRLibBasicRecordSample.Componets.DSM_Button();
            this.PnlControlGrid = new System.Windows.Forms.TableLayoutPanel();
            this.PnlZControl = new System.Windows.Forms.Panel();
            this.LbZAxis = new System.Windows.Forms.Label();
            this.TbZCoor = new TCHRLibBasicRecordSample.Componets.DSM_Trackbar();
            this.PnlXYControl = new System.Windows.Forms.TableLayoutPanel();
            this.PnlChangeSpeedArea = new System.Windows.Forms.TableLayoutPanel();
            this.TbXYspeed = new TCHRLibBasicRecordSample.Componets.DSM_Trackbar();
            this.BtnXYDownSpeed = new TCHRLibBasicRecordSample.Componets.DSM_Button();
            this.BtnXYUpSpeed = new TCHRLibBasicRecordSample.Componets.DSM_Button();
            this.PnlXYBtn = new System.Windows.Forms.Panel();
            this.BtnDownLeft = new TCHRLibBasicRecordSample.Componets.DSM_SpecialButton();
            this.LbXYSpeed = new System.Windows.Forms.Label();
            this.LbXYAxis = new System.Windows.Forms.Label();
            this.BtnLeftUp = new TCHRLibBasicRecordSample.Componets.DSM_SpecialButton();
            this.BtnHome = new TCHRLibBasicRecordSample.Componets.DSM_Button();
            this.BtnRightDown = new TCHRLibBasicRecordSample.Componets.DSM_SpecialButton();
            this.BtnLeft = new TCHRLibBasicRecordSample.Componets.DSM_Button();
            this.BtnUpRight = new TCHRLibBasicRecordSample.Componets.DSM_SpecialButton();
            this.BtnRight = new TCHRLibBasicRecordSample.Componets.DSM_Button();
            this.BtnDown = new TCHRLibBasicRecordSample.Componets.DSM_Button();
            this.BtnUp = new TCHRLibBasicRecordSample.Componets.DSM_Button();
            this.PnlTchAreaGrid = new System.Windows.Forms.TableLayoutPanel();
            this.BtnRsTch = new TCHRLibBasicRecordSample.Componets.DSM_Button();
            this.BtnRunScan = new TCHRLibBasicRecordSample.Componets.DSM_Button();
            this.PnlTchGrid = new System.Windows.Forms.TableLayoutPanel();
            this.LbPos4 = new System.Windows.Forms.Label();
            this.LbPos1 = new System.Windows.Forms.Label();
            this.dsM_Button8 = new TCHRLibBasicRecordSample.Componets.DSM_Button();
            this.dsM_TextBox4 = new TCHRLibBasicRecordSample.Componets.DSM_TextBox();
            this.dsM_Button9 = new TCHRLibBasicRecordSample.Componets.DSM_Button();
            this.LbPos3 = new System.Windows.Forms.Label();
            this.LbPos2 = new System.Windows.Forms.Label();
            this.dsM_Button12 = new TCHRLibBasicRecordSample.Componets.DSM_Button();
            this.dsM_Button11 = new TCHRLibBasicRecordSample.Componets.DSM_Button();
            this.dsM_TextBox3 = new TCHRLibBasicRecordSample.Componets.DSM_TextBox();
            this.dsM_Button1 = new TCHRLibBasicRecordSample.Componets.DSM_Button();
            this.dsM_Button2 = new TCHRLibBasicRecordSample.Componets.DSM_Button();
            this.dsM_Button6 = new TCHRLibBasicRecordSample.Componets.DSM_Button();
            this.dsM_Button5 = new TCHRLibBasicRecordSample.Componets.DSM_Button();
            this.dsM_TextBox2 = new TCHRLibBasicRecordSample.Componets.DSM_TextBox();
            this.dsM_TextBox1 = new TCHRLibBasicRecordSample.Componets.DSM_TextBox();
            this.LbTitleSetting = new System.Windows.Forms.Label();
            this.LbTitleControl = new System.Windows.Forms.Label();
            this.timerComboBox = new System.Windows.Forms.Timer(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.axDBTriggerManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axDBDeviceManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axDBCommManager1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PnlChartGrid.SuspendLayout();
            this.PnlLineChartArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
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
            this.PnlTchAreaGrid.SuspendLayout();
            this.PnlTchGrid.SuspendLayout();
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
            this.PnlDefaultSetting.BackColor = System.Drawing.Color.Red;
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
            this.PbScan.ShowValue = TCHRLibBasicRecordSample.Componets.TextPosition.Sliding;
            this.PbScan.Size = new System.Drawing.Size(769, 35);
            this.PbScan.SliderColor = System.Drawing.Color.RosyBrown;
            this.PbScan.SliderHeight = 24;
            this.PbScan.SymbolAfter = "%";
            this.PbScan.SymbolBefore = "";
            this.PbScan.TabIndex = 35;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
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
            this.panel10.Controls.Add(this.axDBTriggerManager1);
            this.panel10.Controls.Add(this.axDBDeviceManager1);
            this.panel10.Controls.Add(this.axDBCommManager1);
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
            // axDBTriggerManager1
            // 
            this.axDBTriggerManager1.Enabled = true;
            this.axDBTriggerManager1.Location = new System.Drawing.Point(486, 13);
            this.axDBTriggerManager1.Name = "axDBTriggerManager1";
            this.axDBTriggerManager1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDBTriggerManager1.OcxState")));
            this.axDBTriggerManager1.Size = new System.Drawing.Size(24, 24);
            this.axDBTriggerManager1.TabIndex = 19;
            // 
            // axDBDeviceManager1
            // 
            this.axDBDeviceManager1.Enabled = true;
            this.axDBDeviceManager1.Location = new System.Drawing.Point(456, 15);
            this.axDBDeviceManager1.Name = "axDBDeviceManager1";
            this.axDBDeviceManager1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDBDeviceManager1.OcxState")));
            this.axDBDeviceManager1.Size = new System.Drawing.Size(24, 24);
            this.axDBDeviceManager1.TabIndex = 18;
            // 
            // axDBCommManager1
            // 
            this.axDBCommManager1.Enabled = true;
            this.axDBCommManager1.Location = new System.Drawing.Point(425, 15);
            this.axDBCommManager1.Name = "axDBCommManager1";
            this.axDBCommManager1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDBCommManager1.OcxState")));
            this.axDBCommManager1.Size = new System.Drawing.Size(24, 24);
            this.axDBCommManager1.TabIndex = 17;
            // 
            // RBCHRC
            // 
            this.RBCHRC.AutoSize = true;
            this.RBCHRC.Checked = true;
            this.RBCHRC.Location = new System.Drawing.Point(170, 65);
            this.RBCHRC.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RBCHRC.Name = "RBCHRC";
            this.RBCHRC.Size = new System.Drawing.Size(62, 20);
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
            this.RBCLS.Size = new System.Drawing.Size(130, 20);
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
            this.RBCHR2.Size = new System.Drawing.Size(54, 20);
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
            this.RBCHR1.Size = new System.Drawing.Size(136, 20);
            this.RBCHR1.TabIndex = 11;
            this.RBCHR1.Text = "First Generation CHR";
            this.RBCHR1.UseVisualStyleBackColor = true;
            // 
            // TbConInfo
            // 
            this.TbConInfo.Location = new System.Drawing.Point(107, 15);
            this.TbConInfo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TbConInfo.Name = "TbConInfo";
            this.TbConInfo.Size = new System.Drawing.Size(2, 21);
            this.TbConInfo.TabIndex = 10;
            this.TbConInfo.Text = "192.168.170.2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Connection Info";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.panel9);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
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
            this.RBInterfero.Size = new System.Drawing.Size(103, 20);
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
            this.RBConfocal.Size = new System.Drawing.Size(76, 20);
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
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Measuring Methos:";
            // 
            // TBSHZ
            // 
            this.TBSHZ.Location = new System.Drawing.Point(107, 31);
            this.TBSHZ.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TBSHZ.Name = "TBSHZ";
            this.TBSHZ.Size = new System.Drawing.Size(2, 21);
            this.TBSHZ.TabIndex = 3;
            this.TBSHZ.Text = "2000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Scanrate:";
            // 
            // TBSODX
            // 
            this.TBSODX.Location = new System.Drawing.Point(107, 57);
            this.TBSODX.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TBSODX.Name = "TBSODX";
            this.TBSODX.Size = new System.Drawing.Size(2, 21);
            this.TBSODX.TabIndex = 1;
            this.TBSODX.Text = "83, 65, 66";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
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
            this.CBFlush.Size = new System.Drawing.Size(106, 20);
            this.CBFlush.TabIndex = 5;
            this.CBFlush.Text = "Flush Old Data";
            this.CBFlush.UseVisualStyleBackColor = true;
            // 
            // TBSampleCount
            // 
            this.TBSampleCount.Location = new System.Drawing.Point(6, 23);
            this.TBSampleCount.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TBSampleCount.Name = "TBSampleCount";
            this.TBSampleCount.Size = new System.Drawing.Size(2, 21);
            this.TBSampleCount.TabIndex = 4;
            this.TBSampleCount.Text = "10000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
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
            this.PnlChartGrid.Controls.Add(this.PnlLineChartArea, 0, 0);
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
            this.LbNameChart.Location = new System.Drawing.Point(38, 232);
            this.LbNameChart.Margin = new System.Windows.Forms.Padding(2, 16, 2, 0);
            this.LbNameChart.Name = "LbNameChart";
            this.LbNameChart.Size = new System.Drawing.Size(771, 19);
            this.LbNameChart.TabIndex = 63;
            this.LbNameChart.Text = "Line Chart";
            this.LbNameChart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PnlLineChartArea
            // 
            this.PnlLineChartArea.Controls.Add(this.chart4);
            this.PnlLineChartArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlLineChartArea.Location = new System.Drawing.Point(36, 24);
            this.PnlLineChartArea.Margin = new System.Windows.Forms.Padding(0);
            this.PnlLineChartArea.Name = "PnlLineChartArea";
            this.PnlLineChartArea.Size = new System.Drawing.Size(775, 192);
            this.PnlLineChartArea.TabIndex = 0;
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
            this.PnlSettingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.PnlSettingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.PnlSettingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.PnlSettingGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
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
            this.PnlInfoCoorGrid.Location = new System.Drawing.Point(576, 24);
            this.PnlInfoCoorGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlInfoCoorGrid.Name = "PnlInfoCoorGrid";
            this.PnlInfoCoorGrid.RowCount = 5;
            this.PnlInfoCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.PnlInfoCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlInfoCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlInfoCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlInfoCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlInfoCoorGrid.Size = new System.Drawing.Size(83, 260);
            this.PnlInfoCoorGrid.TabIndex = 27;
            // 
            // LbZCoorValue
            // 
            this.LbZCoorValue.AutoSize = true;
            this.LbZCoorValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbZCoorValue.Location = new System.Drawing.Point(24, 208);
            this.LbZCoorValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbZCoorValue.Name = "LbZCoorValue";
            this.LbZCoorValue.Size = new System.Drawing.Size(57, 26);
            this.LbZCoorValue.TabIndex = 32;
            this.LbZCoorValue.Text = "0.00 mm";
            this.LbZCoorValue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LbZAxisCoor
            // 
            this.LbZAxisCoor.AutoSize = true;
            this.LbZAxisCoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbZAxisCoor.Location = new System.Drawing.Point(2, 208);
            this.LbZAxisCoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbZAxisCoor.Name = "LbZAxisCoor";
            this.LbZAxisCoor.Size = new System.Drawing.Size(18, 26);
            this.LbZAxisCoor.TabIndex = 32;
            this.LbZAxisCoor.Text = "Z:";
            this.LbZAxisCoor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LbYCoorValue
            // 
            this.LbYCoorValue.AutoSize = true;
            this.LbYCoorValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbYCoorValue.Location = new System.Drawing.Point(24, 182);
            this.LbYCoorValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbYCoorValue.Name = "LbYCoorValue";
            this.LbYCoorValue.Size = new System.Drawing.Size(57, 26);
            this.LbYCoorValue.TabIndex = 32;
            this.LbYCoorValue.Text = "0.00 mm";
            this.LbYCoorValue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LbYAxisCoor
            // 
            this.LbYAxisCoor.AutoSize = true;
            this.LbYAxisCoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbYAxisCoor.Location = new System.Drawing.Point(2, 182);
            this.LbYAxisCoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbYAxisCoor.Name = "LbYAxisCoor";
            this.LbYAxisCoor.Size = new System.Drawing.Size(18, 26);
            this.LbYAxisCoor.TabIndex = 32;
            this.LbYAxisCoor.Text = "Y:";
            this.LbYAxisCoor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LbXCoorValue
            // 
            this.LbXCoorValue.AutoSize = true;
            this.LbXCoorValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbXCoorValue.Location = new System.Drawing.Point(24, 156);
            this.LbXCoorValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbXCoorValue.Name = "LbXCoorValue";
            this.LbXCoorValue.Size = new System.Drawing.Size(57, 26);
            this.LbXCoorValue.TabIndex = 24;
            this.LbXCoorValue.Text = "0.00 mm";
            this.LbXCoorValue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LbXAxisCoor
            // 
            this.LbXAxisCoor.AutoSize = true;
            this.LbXAxisCoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbXAxisCoor.Location = new System.Drawing.Point(2, 156);
            this.LbXAxisCoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbXAxisCoor.Name = "LbXAxisCoor";
            this.LbXAxisCoor.Size = new System.Drawing.Size(18, 26);
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
            this.PnlZCoorGird.Location = new System.Drawing.Point(471, 24);
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
            // PnlZMap
            // 
            this.PnlZMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlZMap.BackColor = System.Drawing.Color.DimGray;
            this.PnlZMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlZMap.Location = new System.Drawing.Point(12, 0);
            this.PnlZMap.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.PnlZMap.Name = "PnlZMap";
            this.PnlZMap.Size = new System.Drawing.Size(81, 234);
            this.PnlZMap.TabIndex = 0;
            this.PnlZMap.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlZMap_Paint);
            // 
            // PnlXYCoorGrid
            // 
            this.PnlXYCoorGrid.ColumnCount = 1;
            this.PnlXYCoorGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlXYCoorGrid.Controls.Add(this.PnlXYMap, 0, 0);
            this.PnlXYCoorGrid.Controls.Add(this.LbXYCoor, 0, 1);
            this.PnlXYCoorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlXYCoorGrid.Location = new System.Drawing.Point(197, 24);
            this.PnlXYCoorGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlXYCoorGrid.Name = "PnlXYCoorGrid";
            this.PnlXYCoorGrid.RowCount = 2;
            this.PnlXYCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.PnlXYCoorGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlXYCoorGrid.Size = new System.Drawing.Size(274, 260);
            this.PnlXYCoorGrid.TabIndex = 27;
            // 
            // PnlXYMap
            // 
            this.PnlXYMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlXYMap.BackColor = System.Drawing.Color.DimGray;
            this.PnlXYMap.Location = new System.Drawing.Point(12, 0);
            this.PnlXYMap.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.PnlXYMap.Name = "PnlXYMap";
            this.PnlXYMap.Size = new System.Drawing.Size(250, 234);
            this.PnlXYMap.TabIndex = 0;
            this.PnlXYMap.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlXYMap_Paint);
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
            this.PnlListBtnSetting.Controls.Add(this.BtnResetSetting, 0, 8);
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
            this.PnlListBtnSetting.Size = new System.Drawing.Size(153, 260);
            this.PnlListBtnSetting.TabIndex = 33;
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
            "Zigzac Scanning",
            "Raster Scanning"});
            this.CbbRunMode.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(92)))), ((int)(((byte)(86)))));
            this.CbbRunMode.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CbbRunMode.Location = new System.Drawing.Point(3, 3);
            this.CbbRunMode.MinimumSize = new System.Drawing.Size(40, 26);
            this.CbbRunMode.Name = "CbbRunMode";
            this.CbbRunMode.Padding = new System.Windows.Forms.Padding(1);
            this.CbbRunMode.Size = new System.Drawing.Size(147, 35);
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
            this.CbbSignalMode.Size = new System.Drawing.Size(147, 35);
            this.CbbSignalMode.TabIndex = 8;
            this.CbbSignalMode.Texts = "Signal mode";
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
            this.CbbScanArea.Size = new System.Drawing.Size(147, 35);
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
            ".Csv type",
            ".Bcrf type",
            ".Sur type"});
            this.CbbSaveMode.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(92)))), ((int)(((byte)(86)))));
            this.CbbSaveMode.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CbbSaveMode.Location = new System.Drawing.Point(3, 165);
            this.CbbSaveMode.MinimumSize = new System.Drawing.Size(40, 26);
            this.CbbSaveMode.Name = "CbbSaveMode";
            this.CbbSaveMode.Padding = new System.Windows.Forms.Padding(1);
            this.CbbSaveMode.Size = new System.Drawing.Size(147, 35);
            this.CbbSaveMode.TabIndex = 32;
            this.CbbSaveMode.Texts = "Save mode";
            // 
            // BtnResetSetting
            // 
            this.BtnResetSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnResetSetting.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnResetSetting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnResetSetting.BorderRadius = 8;
            this.BtnResetSetting.BorderSize = 1;
            this.BtnResetSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResetSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnResetSetting.FlatAppearance.BorderSize = 0;
            this.BtnResetSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetSetting.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnResetSetting.Location = new System.Drawing.Point(3, 219);
            this.BtnResetSetting.Name = "BtnResetSetting";
            this.BtnResetSetting.Size = new System.Drawing.Size(147, 38);
            this.BtnResetSetting.TabIndex = 33;
            this.BtnResetSetting.Text = "Reset Setting";
            this.BtnResetSetting.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnResetSetting.UseVisualStyleBackColor = false;
            // 
            // PnlControlGrid
            // 
            this.PnlControlGrid.BackColor = System.Drawing.Color.Pink;
            this.PnlControlGrid.ColumnCount = 4;
            this.PnlControlGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.PnlControlGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.PnlControlGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PnlControlGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
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
            this.PnlZControl.Controls.Add(this.LbZAxis);
            this.PnlZControl.Controls.Add(this.TbZCoor);
            this.PnlZControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlZControl.Location = new System.Drawing.Point(339, 27);
            this.PnlZControl.Name = "PnlZControl";
            this.PnlZControl.Padding = new System.Windows.Forms.Padding(0, 36, 0, 8);
            this.PnlZControl.Size = new System.Drawing.Size(65, 255);
            this.PnlZControl.TabIndex = 39;
            // 
            // LbZAxis
            // 
            this.LbZAxis.AutoSize = true;
            this.LbZAxis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbZAxis.Location = new System.Drawing.Point(0, 0);
            this.LbZAxis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbZAxis.Name = "LbZAxis";
            this.LbZAxis.Size = new System.Drawing.Size(63, 19);
            this.LbZAxis.TabIndex = 62;
            this.LbZAxis.Text = "Z - Axis";
            // 
            // TbZCoor
            // 
            this.TbZCoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbZCoor.Location = new System.Drawing.Point(0, 36);
            this.TbZCoor.Margin = new System.Windows.Forms.Padding(3, 36, 3, 3);
            this.TbZCoor.MaximumPercent = 100;
            this.TbZCoor.MinimumPercent = 0;
            this.TbZCoor.Name = "TbZCoor";
            this.TbZCoor.Orientation = TCHRLibBasicRecordSample.Componets.DSM_Trackbar.TrackbarOrientation.Vertical;
            this.TbZCoor.Size = new System.Drawing.Size(65, 211);
            this.TbZCoor.TabIndex = 38;
            this.TbZCoor.ThumbColor = System.Drawing.Color.Red;
            this.TbZCoor.TrackColorLeft = System.Drawing.Color.Blue;
            this.TbZCoor.TrackColorRight = System.Drawing.Color.Gray;
            this.TbZCoor.Value = 0;
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
            // TbXYspeed
            // 
            this.TbXYspeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbXYspeed.Location = new System.Drawing.Point(45, 3);
            this.TbXYspeed.MaximumPercent = 100;
            this.TbXYspeed.MinimumPercent = 0;
            this.TbXYspeed.Name = "TbXYspeed";
            this.TbXYspeed.Orientation = TCHRLibBasicRecordSample.Componets.DSM_Trackbar.TrackbarOrientation.Horizontal;
            this.TbXYspeed.Size = new System.Drawing.Size(210, 36);
            this.TbXYspeed.TabIndex = 27;
            this.TbXYspeed.Text = "dsM_Trackbar2";
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
            this.BtnXYDownSpeed.Image = ((System.Drawing.Image)(resources.GetObject("BtnXYDownSpeed.Image")));
            this.BtnXYDownSpeed.Location = new System.Drawing.Point(3, 3);
            this.BtnXYDownSpeed.Name = "BtnXYDownSpeed";
            this.BtnXYDownSpeed.Size = new System.Drawing.Size(36, 36);
            this.BtnXYDownSpeed.TabIndex = 28;
            this.BtnXYDownSpeed.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnXYDownSpeed.UseVisualStyleBackColor = false;
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
            this.BtnXYUpSpeed.Image = ((System.Drawing.Image)(resources.GetObject("BtnXYUpSpeed.Image")));
            this.BtnXYUpSpeed.Location = new System.Drawing.Point(261, 3);
            this.BtnXYUpSpeed.Name = "BtnXYUpSpeed";
            this.BtnXYUpSpeed.Size = new System.Drawing.Size(36, 36);
            this.BtnXYUpSpeed.TabIndex = 29;
            this.BtnXYUpSpeed.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnXYUpSpeed.UseVisualStyleBackColor = false;
            // 
            // PnlXYBtn
            // 
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
            this.BtnDownLeft.Image = ((System.Drawing.Image)(resources.GetObject("BtnDownLeft.Image")));
            this.BtnDownLeft.Location = new System.Drawing.Point(60, 142);
            this.BtnDownLeft.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDownLeft.Name = "BtnDownLeft";
            this.BtnDownLeft.Size = new System.Drawing.Size(64, 64);
            this.BtnDownLeft.TabIndex = 9;
            this.BtnDownLeft.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnDownLeft.UseVisualStyleBackColor = false;
            // 
            // LbXYSpeed
            // 
            this.LbXYSpeed.AutoSize = true;
            this.LbXYSpeed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbXYSpeed.Location = new System.Drawing.Point(-4, 196);
            this.LbXYSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbXYSpeed.Name = "LbXYSpeed";
            this.LbXYSpeed.Size = new System.Drawing.Size(84, 19);
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
            this.LbXYAxis.Size = new System.Drawing.Size(76, 19);
            this.LbXYAxis.TabIndex = 61;
            this.LbXYAxis.Text = "XY - Axis";
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
            this.BtnLeftUp.Image = ((System.Drawing.Image)(resources.GetObject("BtnLeftUp.Image")));
            this.BtnLeftUp.Location = new System.Drawing.Point(60, 23);
            this.BtnLeftUp.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLeftUp.Name = "BtnLeftUp";
            this.BtnLeftUp.Size = new System.Drawing.Size(64, 64);
            this.BtnLeftUp.TabIndex = 8;
            this.BtnLeftUp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnLeftUp.UseVisualStyleBackColor = false;
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
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.Location = new System.Drawing.Point(128, 90);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(2);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(48, 48);
            this.BtnHome.TabIndex = 3;
            this.BtnHome.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnHome.UseVisualStyleBackColor = false;
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
            this.BtnRightDown.Image = ((System.Drawing.Image)(resources.GetObject("BtnRightDown.Image")));
            this.BtnRightDown.Location = new System.Drawing.Point(180, 142);
            this.BtnRightDown.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRightDown.Name = "BtnRightDown";
            this.BtnRightDown.Size = new System.Drawing.Size(64, 64);
            this.BtnRightDown.TabIndex = 10;
            this.BtnRightDown.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRightDown.UseVisualStyleBackColor = false;
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
            this.BtnLeft.Image = ((System.Drawing.Image)(resources.GetObject("BtnLeft.Image")));
            this.BtnLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLeft.Location = new System.Drawing.Point(60, 91);
            this.BtnLeft.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnLeft.Size = new System.Drawing.Size(64, 48);
            this.BtnLeft.TabIndex = 4;
            this.BtnLeft.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnLeft.UseVisualStyleBackColor = false;
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
            this.BtnUpRight.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpRight.Image")));
            this.BtnUpRight.Location = new System.Drawing.Point(180, 23);
            this.BtnUpRight.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpRight.Name = "BtnUpRight";
            this.BtnUpRight.Size = new System.Drawing.Size(64, 64);
            this.BtnUpRight.TabIndex = 11;
            this.BtnUpRight.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnUpRight.UseVisualStyleBackColor = false;
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
            this.BtnRight.Image = ((System.Drawing.Image)(resources.GetObject("BtnRight.Image")));
            this.BtnRight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRight.Location = new System.Drawing.Point(180, 90);
            this.BtnRight.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.BtnRight.Size = new System.Drawing.Size(64, 48);
            this.BtnRight.TabIndex = 5;
            this.BtnRight.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRight.UseVisualStyleBackColor = false;
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
            this.BtnDown.Image = ((System.Drawing.Image)(resources.GetObject("BtnDown.Image")));
            this.BtnDown.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDown.Location = new System.Drawing.Point(128, 142);
            this.BtnDown.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.BtnDown.Size = new System.Drawing.Size(48, 64);
            this.BtnDown.TabIndex = 6;
            this.BtnDown.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnDown.UseVisualStyleBackColor = false;
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
            this.BtnUp.Image = ((System.Drawing.Image)(resources.GetObject("BtnUp.Image")));
            this.BtnUp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnUp.Location = new System.Drawing.Point(128, 23);
            this.BtnUp.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnUp.Size = new System.Drawing.Size(48, 64);
            this.BtnUp.TabIndex = 7;
            this.BtnUp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnUp.UseVisualStyleBackColor = false;
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
            this.PnlTchAreaGrid.Size = new System.Drawing.Size(220, 255);
            this.PnlTchAreaGrid.TabIndex = 40;
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
            this.BtnRsTch.Size = new System.Drawing.Size(214, 4);
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
            this.BtnRunScan.Size = new System.Drawing.Size(214, 8);
            this.BtnRunScan.TabIndex = 58;
            this.BtnRunScan.Text = "START SCAN";
            this.BtnRunScan.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnRunScan.UseVisualStyleBackColor = false;
            // 
            // PnlTchGrid
            // 
            this.PnlTchGrid.ColumnCount = 4;
            this.PnlTchGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.09091F));
            this.PnlTchGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.90909F));
            this.PnlTchGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PnlTchGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PnlTchGrid.Controls.Add(this.LbPos4, 0, 3);
            this.PnlTchGrid.Controls.Add(this.LbPos1, 0, 0);
            this.PnlTchGrid.Controls.Add(this.dsM_Button8, 3, 3);
            this.PnlTchGrid.Controls.Add(this.dsM_TextBox4, 1, 3);
            this.PnlTchGrid.Controls.Add(this.dsM_Button9, 2, 3);
            this.PnlTchGrid.Controls.Add(this.LbPos3, 0, 2);
            this.PnlTchGrid.Controls.Add(this.LbPos2, 0, 1);
            this.PnlTchGrid.Controls.Add(this.dsM_Button12, 2, 2);
            this.PnlTchGrid.Controls.Add(this.dsM_Button11, 3, 2);
            this.PnlTchGrid.Controls.Add(this.dsM_TextBox3, 1, 2);
            this.PnlTchGrid.Controls.Add(this.dsM_Button1, 2, 0);
            this.PnlTchGrid.Controls.Add(this.dsM_Button2, 3, 0);
            this.PnlTchGrid.Controls.Add(this.dsM_Button6, 2, 1);
            this.PnlTchGrid.Controls.Add(this.dsM_Button5, 3, 1);
            this.PnlTchGrid.Controls.Add(this.dsM_TextBox2, 1, 1);
            this.PnlTchGrid.Controls.Add(this.dsM_TextBox1, 1, 0);
            this.PnlTchGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTchGrid.Location = new System.Drawing.Point(3, 39);
            this.PnlTchGrid.Name = "PnlTchGrid";
            this.PnlTchGrid.RowCount = 4;
            this.PnlTchGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.PnlTchGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.PnlTchGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.PnlTchGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.PnlTchGrid.Size = new System.Drawing.Size(214, 169);
            this.PnlTchGrid.TabIndex = 27;
            // 
            // LbPos4
            // 
            this.LbPos4.AutoSize = true;
            this.LbPos4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbPos4.Location = new System.Drawing.Point(2, 129);
            this.LbPos4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbPos4.Name = "LbPos4";
            this.LbPos4.Size = new System.Drawing.Size(58, 43);
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
            this.LbPos1.Size = new System.Drawing.Size(58, 43);
            this.LbPos1.TabIndex = 60;
            this.LbPos1.Text = "Position 1:";
            this.LbPos1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dsM_Button8
            // 
            this.dsM_Button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.dsM_Button8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.dsM_Button8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button8.BorderRadius = 8;
            this.dsM_Button8.BorderSize = 1;
            this.dsM_Button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dsM_Button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsM_Button8.FlatAppearance.BorderSize = 0;
            this.dsM_Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dsM_Button8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.dsM_Button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button8.Location = new System.Drawing.Point(173, 132);
            this.dsM_Button8.Name = "dsM_Button8";
            this.dsM_Button8.Size = new System.Drawing.Size(38, 37);
            this.dsM_Button8.TabIndex = 52;
            this.dsM_Button8.Text = "Set";
            this.dsM_Button8.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button8.UseVisualStyleBackColor = false;
            // 
            // dsM_TextBox4
            // 
            this.dsM_TextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.dsM_TextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_TextBox4.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.dsM_TextBox4.BorderSize = 1;
            this.dsM_TextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsM_TextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_TextBox4.Location = new System.Drawing.Point(67, 134);
            this.dsM_TextBox4.Margin = new System.Windows.Forms.Padding(5);
            this.dsM_TextBox4.Multiline = false;
            this.dsM_TextBox4.Name = "dsM_TextBox4";
            this.dsM_TextBox4.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.dsM_TextBox4.PasswordChar = false;
            this.dsM_TextBox4.Size = new System.Drawing.Size(56, 37);
            this.dsM_TextBox4.TabIndex = 57;
            this.dsM_TextBox4.UnderlineStyle = false;
            // 
            // dsM_Button9
            // 
            this.dsM_Button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.dsM_Button9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.dsM_Button9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button9.BorderRadius = 8;
            this.dsM_Button9.BorderSize = 1;
            this.dsM_Button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dsM_Button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsM_Button9.FlatAppearance.BorderSize = 0;
            this.dsM_Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dsM_Button9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.dsM_Button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button9.Location = new System.Drawing.Point(131, 132);
            this.dsM_Button9.Name = "dsM_Button9";
            this.dsM_Button9.Size = new System.Drawing.Size(36, 37);
            this.dsM_Button9.TabIndex = 53;
            this.dsM_Button9.Text = "Run";
            this.dsM_Button9.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button9.UseVisualStyleBackColor = false;
            // 
            // LbPos3
            // 
            this.LbPos3.AutoSize = true;
            this.LbPos3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbPos3.Location = new System.Drawing.Point(2, 86);
            this.LbPos3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbPos3.Name = "LbPos3";
            this.LbPos3.Size = new System.Drawing.Size(58, 43);
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
            this.LbPos2.Size = new System.Drawing.Size(58, 43);
            this.LbPos2.TabIndex = 60;
            this.LbPos2.Text = "Position 2:";
            this.LbPos2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dsM_Button12
            // 
            this.dsM_Button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.dsM_Button12.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.dsM_Button12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button12.BorderRadius = 8;
            this.dsM_Button12.BorderSize = 1;
            this.dsM_Button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dsM_Button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsM_Button12.FlatAppearance.BorderSize = 0;
            this.dsM_Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dsM_Button12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.dsM_Button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button12.Location = new System.Drawing.Point(131, 89);
            this.dsM_Button12.Name = "dsM_Button12";
            this.dsM_Button12.Size = new System.Drawing.Size(36, 37);
            this.dsM_Button12.TabIndex = 49;
            this.dsM_Button12.Text = "Run";
            this.dsM_Button12.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button12.UseVisualStyleBackColor = false;
            // 
            // dsM_Button11
            // 
            this.dsM_Button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.dsM_Button11.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.dsM_Button11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button11.BorderRadius = 8;
            this.dsM_Button11.BorderSize = 1;
            this.dsM_Button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dsM_Button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsM_Button11.FlatAppearance.BorderSize = 0;
            this.dsM_Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dsM_Button11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.dsM_Button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button11.Location = new System.Drawing.Point(173, 89);
            this.dsM_Button11.Name = "dsM_Button11";
            this.dsM_Button11.Size = new System.Drawing.Size(38, 37);
            this.dsM_Button11.TabIndex = 48;
            this.dsM_Button11.Text = "Set";
            this.dsM_Button11.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button11.UseVisualStyleBackColor = false;
            // 
            // dsM_TextBox3
            // 
            this.dsM_TextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.dsM_TextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_TextBox3.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.dsM_TextBox3.BorderSize = 1;
            this.dsM_TextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsM_TextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_TextBox3.Location = new System.Drawing.Point(67, 91);
            this.dsM_TextBox3.Margin = new System.Windows.Forms.Padding(5);
            this.dsM_TextBox3.Multiline = false;
            this.dsM_TextBox3.Name = "dsM_TextBox3";
            this.dsM_TextBox3.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.dsM_TextBox3.PasswordChar = false;
            this.dsM_TextBox3.Size = new System.Drawing.Size(56, 37);
            this.dsM_TextBox3.TabIndex = 55;
            this.dsM_TextBox3.UnderlineStyle = false;
            // 
            // dsM_Button1
            // 
            this.dsM_Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.dsM_Button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.dsM_Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button1.BorderRadius = 8;
            this.dsM_Button1.BorderSize = 1;
            this.dsM_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dsM_Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsM_Button1.FlatAppearance.BorderSize = 0;
            this.dsM_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dsM_Button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.dsM_Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button1.Location = new System.Drawing.Point(131, 3);
            this.dsM_Button1.Name = "dsM_Button1";
            this.dsM_Button1.Size = new System.Drawing.Size(36, 37);
            this.dsM_Button1.TabIndex = 41;
            this.dsM_Button1.Text = "Run";
            this.dsM_Button1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button1.UseVisualStyleBackColor = false;
            // 
            // dsM_Button2
            // 
            this.dsM_Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.dsM_Button2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.dsM_Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button2.BorderRadius = 8;
            this.dsM_Button2.BorderSize = 1;
            this.dsM_Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dsM_Button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsM_Button2.FlatAppearance.BorderSize = 0;
            this.dsM_Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dsM_Button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.dsM_Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button2.Location = new System.Drawing.Point(173, 3);
            this.dsM_Button2.Name = "dsM_Button2";
            this.dsM_Button2.Size = new System.Drawing.Size(38, 37);
            this.dsM_Button2.TabIndex = 41;
            this.dsM_Button2.Text = "Set";
            this.dsM_Button2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button2.UseVisualStyleBackColor = false;
            // 
            // dsM_Button6
            // 
            this.dsM_Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.dsM_Button6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.dsM_Button6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button6.BorderRadius = 8;
            this.dsM_Button6.BorderSize = 1;
            this.dsM_Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dsM_Button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsM_Button6.FlatAppearance.BorderSize = 0;
            this.dsM_Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dsM_Button6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.dsM_Button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button6.Location = new System.Drawing.Point(131, 46);
            this.dsM_Button6.Name = "dsM_Button6";
            this.dsM_Button6.Size = new System.Drawing.Size(36, 37);
            this.dsM_Button6.TabIndex = 45;
            this.dsM_Button6.Text = "Run";
            this.dsM_Button6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button6.UseVisualStyleBackColor = false;
            // 
            // dsM_Button5
            // 
            this.dsM_Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.dsM_Button5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.dsM_Button5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button5.BorderRadius = 8;
            this.dsM_Button5.BorderSize = 1;
            this.dsM_Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dsM_Button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsM_Button5.FlatAppearance.BorderSize = 0;
            this.dsM_Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dsM_Button5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.dsM_Button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button5.Location = new System.Drawing.Point(173, 46);
            this.dsM_Button5.Name = "dsM_Button5";
            this.dsM_Button5.Size = new System.Drawing.Size(38, 37);
            this.dsM_Button5.TabIndex = 44;
            this.dsM_Button5.Text = "Set";
            this.dsM_Button5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_Button5.UseVisualStyleBackColor = false;
            // 
            // dsM_TextBox2
            // 
            this.dsM_TextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.dsM_TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_TextBox2.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.dsM_TextBox2.BorderSize = 1;
            this.dsM_TextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsM_TextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_TextBox2.Location = new System.Drawing.Point(67, 48);
            this.dsM_TextBox2.Margin = new System.Windows.Forms.Padding(5);
            this.dsM_TextBox2.Multiline = false;
            this.dsM_TextBox2.Name = "dsM_TextBox2";
            this.dsM_TextBox2.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.dsM_TextBox2.PasswordChar = false;
            this.dsM_TextBox2.Size = new System.Drawing.Size(56, 37);
            this.dsM_TextBox2.TabIndex = 54;
            this.dsM_TextBox2.UnderlineStyle = false;
            // 
            // dsM_TextBox1
            // 
            this.dsM_TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.dsM_TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_TextBox1.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.dsM_TextBox1.BorderSize = 1;
            this.dsM_TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsM_TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dsM_TextBox1.Location = new System.Drawing.Point(67, 5);
            this.dsM_TextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.dsM_TextBox1.Multiline = false;
            this.dsM_TextBox1.Name = "dsM_TextBox1";
            this.dsM_TextBox1.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.dsM_TextBox1.PasswordChar = false;
            this.dsM_TextBox1.Size = new System.Drawing.Size(56, 37);
            this.dsM_TextBox1.TabIndex = 56;
            this.dsM_TextBox1.UnderlineStyle = false;
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
            // timerComboBox
            // 
            this.timerComboBox.Interval = 1;
            this.timerComboBox.Tick += new System.EventHandler(this.timerComboBox_Tick);
            // 
            // TRecordSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
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
            ((System.ComponentModel.ISupportInitialize)(this.axDBTriggerManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axDBDeviceManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axDBCommManager1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PnlChartGrid.ResumeLayout(false);
            this.PnlChartGrid.PerformLayout();
            this.PnlLineChartArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
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
            this.PnlTchAreaGrid.ResumeLayout(false);
            this.PnlTchGrid.ResumeLayout(false);
            this.PnlTchGrid.PerformLayout();
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
        private System.Windows.Forms.Label LbXYCoor;
        private System.Windows.Forms.Label LbZCoorValue;
        private System.Windows.Forms.Label LbYCoorValue;
        private System.Windows.Forms.Panel PnlZMap;
        private System.Windows.Forms.Panel PnlXYMap;
        private System.Windows.Forms.Label LbXCoorValue;
        private System.Windows.Forms.Label LbTitleSetting;
        private System.Windows.Forms.TableLayoutPanel PnlMainGrid;
        private System.Windows.Forms.TableLayoutPanel PnlRightSite;
        private System.Windows.Forms.TableLayoutPanel PnlLeftSite;
        private System.Windows.Forms.Label LbTitleControl;
        private System.Windows.Forms.TableLayoutPanel PnlSettingGrid;
        private System.Windows.Forms.Timer timerComboBox;
        private System.Windows.Forms.TableLayoutPanel PnlListBtnSetting;
        private Componets.TabControl.DSM_ComboBox CbbRunMode;
        private Componets.TabControl.DSM_ComboBox CbbSignalMode;
        private Componets.TabControl.DSM_ComboBox CbbScanArea;
        private System.Windows.Forms.Label LbXAxisCoor;
        private System.Windows.Forms.Label LbYAxisCoor;
        private System.Windows.Forms.Label LbZAxisCoor;
        private Componets.TabControl.DSM_ComboBox CbbSaveMode;
        private Componets.DSM_Button BtnResetSetting;
        private Componets.DSM_Trackbar TbZCoor;
        private Componets.DSM_TextBox dsM_TextBox4;
        private Componets.DSM_TextBox dsM_TextBox1;
        private Componets.DSM_TextBox dsM_TextBox3;
        private Componets.DSM_TextBox dsM_TextBox2;
        private Componets.DSM_Button dsM_Button8;
        private Componets.DSM_Button dsM_Button9;
        private Componets.DSM_Button dsM_Button11;
        private Componets.DSM_Button dsM_Button12;
        private Componets.DSM_Button dsM_Button5;
        private Componets.DSM_Button dsM_Button6;
        private Componets.DSM_Button dsM_Button2;
        private Componets.DSM_Button dsM_Button1;
        private Componets.DSM_Button BtnRsTch;
        private Componets.DSM_Button BtnRunScan;
        private System.Windows.Forms.TableLayoutPanel PnlControlGrid;
        private System.Windows.Forms.TableLayoutPanel PnlXYControl;
        private System.Windows.Forms.Panel PnlXYBtn;
        private System.Windows.Forms.Panel PnlZControl;
        private System.Windows.Forms.TableLayoutPanel PnlXYCoorGrid;
        private System.Windows.Forms.TableLayoutPanel PnlZCoorGird;
        private System.Windows.Forms.Label LbZCoor;
        private System.Windows.Forms.TableLayoutPanel PnlInfoCoorGrid;
        private System.Windows.Forms.Label LbPos4;
        private System.Windows.Forms.Label LbPos3;
        private System.Windows.Forms.Label LbPos2;
        private System.Windows.Forms.Label LbPos1;
        private System.Windows.Forms.TableLayoutPanel PnlTchGrid;
        private System.Windows.Forms.TableLayoutPanel PnlChangeSpeedArea;
        private Componets.DSM_Button BtnXYDownSpeed;
        private Componets.DSM_Button BtnXYUpSpeed;
        private Componets.DSM_Trackbar TbXYspeed;
        private System.Windows.Forms.Panel PnlHidden;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel10;
        private AxDATABUILDERAXLibLB.AxDBTriggerManager axDBTriggerManager1;
        private AxDATABUILDERAXLibLB.AxDBDeviceManager axDBDeviceManager1;
        private AxDATABUILDERAXLibLB.AxDBCommManager axDBCommManager1;
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
        private Componets.DSM_SpecialButton BtnLeftUp;
        private Componets.DSM_SpecialButton BtnDownLeft;
        private Componets.DSM_Button BtnHome;
        private Componets.DSM_SpecialButton BtnRightDown;
        private Componets.DSM_Button BtnLeft;
        private Componets.DSM_SpecialButton BtnUpRight;
        private Componets.DSM_Button BtnRight;
        private Componets.DSM_Button BtnDown;
        private Componets.DSM_Button BtnUp;
        private System.Windows.Forms.Label LbZAxis;
        private System.Windows.Forms.Label LbXYAxis;
        private System.Windows.Forms.TableLayoutPanel PnlTchAreaGrid;
        private System.Windows.Forms.Panel PnlScanArea;
        private System.Windows.Forms.Panel PnlLineChartArea;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.Label LbNameChart;
        private System.Windows.Forms.PictureBox ImgAreaScan;
        private System.Windows.Forms.TableLayoutPanel PnlProgressGrid;
        private System.Windows.Forms.Label LbScanProgress;
        private Componets.DSM_ProgressBar PbScan;
        private System.Windows.Forms.TableLayoutPanel PnlChartGrid;
        private System.Windows.Forms.Label LbXYSpeed;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

