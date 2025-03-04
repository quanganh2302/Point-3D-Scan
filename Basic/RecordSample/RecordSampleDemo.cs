/*
This demo shows how to use the recording mode of the synchronous connection to collect data
When the connection is in the recording modes, all the samples will be saved in a buffer. This buffer can be retrieved upon the calling of "StopRecording".
During recording, no commands can be executed. "GetNextSamples" will return newly recorded data since the last call of "GetNextSamples".
*/


using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using CHRocodileLib;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using FSSCommon;
using System.Runtime.InteropServices;
using TCHRLibBasicRecordSample.CustomUi;
using System.IO.Ports;

namespace TCHRLibBasicRecordSample
{
    public partial class TRecordSample : Form
    {
        // Connect to PLC keyence
        SerialPort sp_main = new SerialPort();


        //Data config
        private string configsFolderPath = Path.Combine(Application.StartupPath, "Configs");
        private string filePath;

        // Fields
        #region Color
        public static Color ForeGroundWhite = ColorTranslator.FromHtml("#E4E4E4");
        public static Color ForeGroundBlack = ColorTranslator.FromHtml("#010B13");
        public static Color NavbarBg = ColorTranslator.FromHtml("#2F2F2F");
        public static Color CardBg = ColorTranslator.FromHtml("#595959");
        public static Color BtnDefaultBg = ColorTranslator.FromHtml("#47433F");
        public static Color BtnChildBg = ColorTranslator.FromHtml("#615C56");
        public static Color BtnActiveBg = ColorTranslator.FromHtml("#A5A39E");
        public static Color MainBg = ColorTranslator.FromHtml("#404040");
        public static Color EmergencyRed = ColorTranslator.FromHtml("#f92f60");
        public static Color orange = ColorTranslator.FromHtml("#ed6a11");
        public static Color BorderBtn = ColorTranslator.FromHtml("#343434");
        public static Color GridBg = ColorTranslator.FromHtml("#2B2926");

        public static int MarginYScreenXl = 24;
        public static int MarginYScreenLg = 12;
        #endregion

        private CustomUi.TabControl.UC_DefaultSetting ucDefaultSetting;
        private CustomUi.TabControl.UC_AdvanceSetting ucAdvanceSetting;

        private bool RbCHR1;
        private bool RbCHR2;
        private bool RbCHRC;
        private bool RbCLS;

        private bool RbConfocal;
        private bool RbInterfero;

        #region Control
        float minSpeed = 2; // Min speed of track bar (m/s)
        float maxSpeed = 10; // Max speed of track bar (m/s)
        float XWorkingRange = 300;// distance of 2 limit X (mm)
        float YWorkingRange = 300;// distance of 2 limit X (mm)

        float ZDistanceMin = -5;// distance of 2 limit Z (mm)
        float ZDistanceMax = -40;// distance of 2 limit Z (mm)

        float XDistanceMin = 0;// distance of 2 limit X (mm)
        float XDistanceMax = 160;// distance of 2 limit X (mm)

        float YDistanceMin = 0;// distance of 2 limit Y (mm)
        float YDistanceMax = -160;// distance of 2 limit Y (mm)

        int threadPitch = 3; // Bước ren
        int pulsesPerRevolution = 3600; // xung/vòng

        float currentXCoor = 0F;
        float currentYCoor = 0F;
        float currentZCoor = 0F;

        private Timer blinkTimer;
        private Timer xyCoorTimer;
        private Timer progressTimer;

        #endregion

        public static readonly FontFamily CenturyGothic = new FontFamily("Century Gothic");

        bool expand = false;
        private void timerComboBox_Tick(object sender, EventArgs e)
        {
            //if (expand == false)
            //{
            //    PnlDropDownDevelop.Height += 15;
            //    if (PnlDropDownDevelop.Height >= PnlDropDownDevelop.MaximumSize.Height)
            //    {
            //        timerComboBox.Stop();
            //        expand = true;
            //    }
            //}
            //else
            //{
            //    PnlDropDownDevelop.Height -= 15;
            //    if (PnlDropDownDevelop.Height <= PnlDropDownDevelop.MinimumSize.Height)
            //    {
            //        timerComboBox.Stop();
            //        expand = false;
            //    }
            //}
        }
        private void BtnSelectDevelop_Click(object sender, EventArgs e)
        {
            timerComboBox.Start();

        }


        private void add_UControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PnlDSPage.Controls.Clear();
            PnlDSPage.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Btn_Click(object sender, EventArgs eventArgs)
        {
            foreach (var pnl in PnlNavSetting.Controls.OfType<Panel>())
            {
                pnl.BackColor = CardBg;
            }
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "BtnDefaultSetting":

                    ShowDefaultSetting();
                    break;
                case "BtnAdvanceSetting":
                    if (ucAdvanceSetting == null)
                    {
                        ucAdvanceSetting = new CustomUi.TabControl.UC_AdvanceSetting();
                    }
                    add_UControls(ucAdvanceSetting);
                    PnlAdvanceSetting.BackColor = orange;
                    break;
            }
        }
        private void ShowDefaultSetting()
        {
            if (ucDefaultSetting == null)
            {
                ucDefaultSetting = new CustomUi.TabControl.UC_DefaultSetting();
            }

            add_UControls(ucDefaultSetting);
            PnlDefaultSetting.BackColor = orange;
        }


        SynchronousConnection Conn;
        SynchronousConnection ConnSync;
        AsynchronousConnection ConnAsync;

        //record 1000 samples
        int SampleCount;
        int SampleCount83;

        int DataAverage;
        const int Spec_Length = 1024;

        MeasurementMode MeasuringMethod = MeasurementMode.Confocal;

        System.Int32[] SignalIDs;
        float ScanRate;

        int CurrentDataPos;
        CHRocodileLib.Data RecordData = null;

        private Timer timer;


        private void UpdateRbcustom()
        {

            RbCLS = ucDefaultSetting.IsCLS;
            RbCHR1 = ucDefaultSetting.IsCHR1;
            RbCHR2 = ucDefaultSetting.IsCHR2;
            RbCHRC = ucDefaultSetting.IsCHRC;

            RbConfocal = ucAdvanceSetting.IsConfocal;
            RbInterfero = ucAdvanceSetting.IsInterfero;
        }

        private void Init()
        {
            //initialize specturm display
            for (int i = 0; i < Spec_Length; i++)
                chart1.Series[0].Points.AddY(0);
        }

        public TRecordSample()
        {
            InitializeComponent();
            // PLC with HOTLINK
            //sp_main.BaudRate = 9600;
            //sp_main.DataBits = 8;
            //sp_main.StopBits = StopBits.One;
            //sp_main.Parity = Parity.Even;

            // PLC with KV COM+
            axDBTriggerManager1.Active = true;


            this.Load += new EventHandler(TRecordSample_Load);
            filePath = Path.Combine(configsFolderPath, "config_data.txt");
            Init();
            // Initialize and start the blink timer
            blinkTimer = new Timer();
            blinkTimer.Interval = 1; // set delay time
            blinkTimer.Tick += BlinkTimer_Tick; // create funtion that performs a task when called

            progressTimer = new Timer();
            progressTimer.Interval = 1; // set delay time
            progressTimer.Tick += ProgressTimer_Tick; // create funtion that performs a task when called

            xyCoorTimer = new Timer();
            xyCoorTimer.Interval = 2000; // set delay time
            xyCoorTimer.Tick += xyCoorTimer_Tick; // create funtion that performs a task when called
            //axDBCommManager1.Connect();
            this.SetStyle(ControlStyles.Selectable, true);
            this.TabStop = true;
            this.BackColor = MainBg;
            this.ForeColor = ForeGroundWhite;
            //Working area
            #region Close button
            BtnClose.Click += BtnClose_Click;
            BtnClose.Cursor = Cursors.Hand;
            #endregion
            MaxSize(this);
            PnlMain.Dock = DockStyle.Fill;
            PnlMainGrid.Dock = DockStyle.Fill;
            PnlRightSite.Dock = DockStyle.Fill;
            PnlLeftSite.Dock = DockStyle.Fill;

            // Layout
            PnlControlBar.BackColor = NavbarBg;
            PnlMain.BackColor = MainBg;

            PnlMainGrid.BackColor = MainBg;
            PnlRightSite.BackColor = MainBg;
            PnlLeftSite.BackColor = MainBg;

            //Connect area
            ucDefaultSetting = new CustomUi.TabControl.UC_DefaultSetting();

            ucDefaultSetting.RadioButtonChanged += UcDefaultSetting_RadioButtonChanged;

            add_UControls(ucDefaultSetting);

            ucDefaultSetting.ConnectButtonClicked += (s, e) => BtConnect_Click(this, e);

            ucAdvanceSetting = new CustomUi.TabControl.UC_AdvanceSetting();

            ucAdvanceSetting.RadioButtonChanged += UcAdvanceSetting_RadioButtonChanged;

            UpdateRbcustom();

            ucAdvanceSetting.SRKeyPress += (s, e) => TBSHZ_KeyPress(this, (KeyPressEventArgs)e);
            ucAdvanceSetting.SSKeyPress += (s, e) => TBSODX_KeyPress(this, (KeyPressEventArgs)e);



            PnlNavSetting.BackColor = CardBg;
            PnlDefaultSetting.BackColor = orange;
            PnlAdvanceSetting.BackColor = CardBg;
            BtnAdvanceSetting.BackColor = CardBg;
            BtnAdvanceSetting.ForeColor = ForeGroundWhite;
            BtnDefaultSetting.BackColor = CardBg;
            BtnDefaultSetting.ForeColor = ForeGroundWhite;
            PnlDSPage.BackColor = CardBg;

            // Setting area
            PnlSettingGrid.BackColor = CardBg;
            BtnSaveData.BorderColor = orange;
            LbXYCoor.ForeColor = ForeGroundWhite;
            LbZCoor.ForeColor = ForeGroundWhite;

            LbXAxisCoor.ForeColor = ForeGroundWhite;
            LbXCoorValue.ForeColor = ForeGroundWhite;
            LbYAxisCoor.ForeColor = ForeGroundWhite;
            LbYCoorValue.ForeColor = ForeGroundWhite;
            LbZAxisCoor.ForeColor = ForeGroundWhite;
            LbZCoorValue.ForeColor = ForeGroundWhite;
            LbZCoorValue.Text = "0.00";
            if (SystemInformation.WorkingArea.Width < 1600)
            {
                PnlSettingGrid.Padding = new Padding(36, MarginYScreenLg, 24, MarginYScreenLg);
                PnlZMap.GridSize = 23;
            }
            else
            {
                PnlSettingGrid.Padding = new Padding(36, MarginYScreenXl, 24, MarginYScreenXl);
                PnlZMap.GridSize = 20;

            }
            PnlZMap.BorderColor = ForeGroundWhite;
            PnlZMap.MainLineColor = ForeGroundWhite;
            PnlZMap.LineColor = ForeGroundWhite;
            PnlZMap.BackColor = GridBg;
            PnlZMap.PointColor = orange;
            PnlZMap.PointX = PnlZMap.Width / 2;
            PnlZMap.PointY = 0 + PnlZMap.PointSize / 2;

            PnlXYMap.BorderColor = ForeGroundWhite;
            PnlXYMap.MainLineColor = ForeGroundWhite;
            PnlXYMap.LineColor = ForeGroundWhite;
            PnlXYMap.BackColor = GridBg;
            PnlXYMap.GridSize = PnlXYMap.Width / 2;
            PnlXYMap.PointClicked += PostDataToPLC;
            // Control area
            if (SystemInformation.WorkingArea.Width < 1600)
            {
                PnlControlGrid.Padding = new Padding(36, MarginYScreenLg, 24, MarginYScreenLg);
                PnlControlGrid.ColumnStyles[1].Width = 23;
                PnlControlGrid.ColumnStyles[2].Width = 76;
                //PnlControlGrid.ColumnStyles[3].Width = 1;

                BtnHome.Size = new Size(48, 48);
                BtnHome.Location = new Point(128, 90);
                BtnHome.BorderRadius = 8;

                BtnUp.Size = new Size(48, 64);
                BtnUp.Location = new Point(128, 23);
                BtnHome.BorderRadius = 8;

                BtnUpRight.Size = new Size(64, 64);
                BtnUpRight.Location = new Point(180, 23);
                BtnUpRight.BorderRadius = 8;

                BtnRight.Size = new Size(64, 48);
                BtnRight.Location = new Point(180, 90);
                BtnRight.BorderRadius = 8;

                BtnRightDown.Size = new Size(64, 64);
                BtnRightDown.Location = new Point(180, 141);
                BtnRightDown.BorderRadius = 8;

                BtnDown.Size = new Size(48, 64);
                BtnDown.Location = new Point(128, 141);
                BtnDown.BorderRadius = 8;

                BtnDownLeft.Size = new Size(64, 64);
                BtnDownLeft.Location = new Point(61, 141);
                BtnDownLeft.BorderRadius = 8;

                BtnLeft.Size = new Size(64, 48);
                BtnLeft.Location = new Point(61, 90);
                BtnLeft.BorderRadius = 8;

                BtnLeftUp.Size = new Size(64, 64);
                BtnLeftUp.Location = new Point(61, 23);
                BtnLeftUp.BorderRadius = 8;


            }
            else
            {
                PnlControlGrid.Padding = new Padding(36, MarginYScreenXl, 24, MarginYScreenXl);
                PnlControlGrid.ColumnStyles[1].Width = 22;
                PnlControlGrid.ColumnStyles[2].Width = 70;
                //PnlControlGrid.ColumnStyles[3].Width = 8;

                BtnHome.Size = new Size(60, 60);
                BtnHome.Location = new Point(119, 126);
                BtnHome.BorderRadius = 9;

                BtnUp.Size = new Size(60, 84);
                BtnUp.Location = new Point(119, 39);
                BtnUp.BorderRadius = 9;

                BtnUpRight.Size = new Size(80, 80);
                BtnUpRight.Location = new Point(183, 43);
                BtnUpRight.BorderRadius = 9;

                BtnRight.Size = new Size(84, 60);
                BtnRight.Location = new Point(183, 127);
                BtnRight.BorderRadius = 9;

                BtnRightDown.Size = new Size(80, 80);
                BtnRightDown.Location = new Point(183, 190);
                BtnRightDown.BorderRadius = 9;

                BtnDown.Size = new Size(60, 84);
                BtnDown.Location = new Point(119, 190);
                BtnDown.BorderRadius = 9;

                BtnDownLeft.Size = new Size(80, 80);
                BtnDownLeft.Location = new Point(35, 190);
                BtnDownLeft.BorderRadius = 9;

                BtnLeft.Size = new Size(84, 60);
                BtnLeft.Location = new Point(31, 127);
                BtnLeft.BorderRadius = 9;

                BtnLeftUp.Size = new Size(80, 80);
                BtnLeftUp.Location = new Point(35, 42);
                BtnLeftUp.BorderRadius = 9;
            }
            PnlControlGrid.BackColor = CardBg;
            BtnHome.BorderColor = BorderBtn;
            BtnUp.BorderColor = BorderBtn;
            BtnDown.BorderColor = BorderBtn;
            BtnRight.BorderColor = BorderBtn;
            BtnLeft.BorderColor = BorderBtn;



            LbXYAxis.ForeColor = ForeGroundBlack;
            LbXYSpeed.ForeColor = ForeGroundBlack;
            LbZAxis.ForeColor = ForeGroundBlack;

            BtnRsTch.BorderColor = EmergencyRed;
            BtnRunScan.BackColor = orange;
            BtnXYDownSpeed.BorderColor = Color.Transparent;

            TbXYspeed.ThumbColor = orange;
            TbXYspeed.TrackColorLeft = orange;
            TbXYspeed.TrackColorRight = ForeGroundWhite;
            TbXYspeed.ValueChanged += TbXYspeed_ValueChanged;

            //TbZCoor.ThumbColor = orange;
            //TbZCoor.TrackColorLeft = orange;
            //TbZCoor.TrackColorRight = ForeGroundWhite;


            if (SystemInformation.WorkingArea.Width < 1600)
            {
                //TbZCoor.Margin = new Padding(3, 0, 3, 3);
                PnlZControl.Padding = new Padding(14, 20, 14, 8);
                LbZAxis.Location = new Point(0);
                LbXYSpeed.Location = new Point(-4, 196);
            }
            else
            {
                //TbZCoor.Margin = new Padding(3, 36, 3, 3);
                PnlZControl.Padding = new Padding(36, 36, 36, 8);
                LbZAxis.Location = new Point(0);
                LbXYSpeed.Location = new Point(-4, 280);
            }
            TbZControl.TrackColorLeft = orange;
            TbZControl.TrackColorRight = BorderBtn;
            TbZControl.BorderColor = BtnDefaultBg;
            TbZControl.BorderInColor = Color.Gray;
            TbZControl.BorderSize = 3;
            TbZControl.BorderRadius = 36;
            TbZControl.ThumbSize = 40;
            TbZControl.VerticalReversed = true;
            TbZControl.Dock = DockStyle.Fill;
            TbZControl.ValueChanged += TbZControl_ValueChanged;
            TbZControl.MouseWheel += TbZControl_MouseWheel;


            if (SystemInformation.WorkingArea.Width < 1600)
            {
                TbZControl.BorderRadius = 32;
            }
            else
            {
                TbZControl.BorderRadius = 36;
            }
            PnlChangeSpeedArea.BackColor = CardBg;
            PnlTchAreaGrid.BackColor = CardBg;
            if (SystemInformation.WorkingArea.Width < 1600)
            {
                PnlTchAreaGrid.RowStyles[0].Height = 20;
                PnlListBtnSetting.Margin = new Padding(0, 0, 8, 0);
                PnlListBtnSetting.RowStyles[1].Height = 2;
                PnlListBtnSetting.RowStyles[3].Height = 2;
                PnlListBtnSetting.RowStyles[5].Height = 2;
                PnlListBtnSetting.RowStyles[7].Height = 2;

                PnlListBtnSetting.RowStyles[0].Height = 18.4F;
                PnlListBtnSetting.RowStyles[2].Height = 18.4F;
                PnlListBtnSetting.RowStyles[4].Height = 18.4F;
                PnlListBtnSetting.RowStyles[6].Height = 18.4F;
                PnlListBtnSetting.RowStyles[8].Height = 18.4F;

                BtnRsTch.Visible = false;
                PnlTchAreaGrid.RowStyles[3].Height = 1;
                PnlTchAreaGrid.RowStyles[4].Height = 99;
            }
            else
            {
                PnlTchAreaGrid.RowStyles[0].Height = 36;
                PnlTchAreaGrid.RowStyles[3].Height = 30;
                PnlTchAreaGrid.RowStyles[4].Height = 70;

                PnlListBtnSetting.Padding = new Padding(0, 0, 16, 0);
                PnlListBtnSetting.RowStyles[1].Height = 5;
                PnlListBtnSetting.RowStyles[3].Height = 5;
                PnlListBtnSetting.RowStyles[5].Height = 5;
                PnlListBtnSetting.RowStyles[7].Height = 5;

                PnlListBtnSetting.RowStyles[0].Height = 16;
                PnlListBtnSetting.RowStyles[2].Height = 16;
                PnlListBtnSetting.RowStyles[4].Height = 16;
                PnlListBtnSetting.RowStyles[6].Height = 16;
                PnlListBtnSetting.RowStyles[8].Height = 16;

                BtnRsTch.Visible = true;

            }

            BtnRunPos1.Click += BtnRunPos_Click;
            BtnRunPos2.Click += BtnRunPos_Click;
            BtnRunPos3.Click += BtnRunPos_Click;
            BtnRunPos4.Click += BtnRunPos_Click;



            // Left site
            PnlHidden.BackColor = CardBg;

            // -> Scan area
            //ImgAreaScan.BackColor = MainBg;
            PnlScanArea.BackColor = CardBg;
            if (SystemInformation.WorkingArea.Width < 1600)
            {
                ImgAreaScan.Width = 500;
                ImgAreaScan.Height = 360;
                PnlScanArea.Padding = new Padding(36, 0, 36, MarginYScreenLg);
            }
            else
            {
                ImgAreaScan.Width = 600;
                ImgAreaScan.Height = 512;
                PnlScanArea.Padding = new Padding(36, 0, 36, MarginYScreenXl);
            }
            ImgAreaScan.Left = (PnlScanArea.Width - ImgAreaScan.Width) / 2;
            ImgAreaScan.Top = (PnlScanArea.Height - ImgAreaScan.Height) / 2;

            // -> Progress area 
            if (SystemInformation.WorkingArea.Width < 1600)
            {
                PnlProgressGrid.Padding = new Padding(36, MarginYScreenLg, 36, MarginYScreenLg);
            }
            else
            {
                PnlProgressGrid.Padding = new Padding(36, MarginYScreenXl, 36, MarginYScreenXl);
            }
            PnlProgressGrid.BackColor = CardBg;
            PbScan.ChannelColor = MainBg;
            PbScan.SliderColor = orange;
            PbScan.Value = 0;
            PbScan.ForeBackColor = CardBg;
            LbScanProgress.Text = "Start Scan";
            LbScanProgress.ForeColor = ForeGroundBlack;


            // -> Chart area
            if (SystemInformation.WorkingArea.Width < 1600)
            {
                PnlChartGrid.Padding = new Padding(36, MarginYScreenLg, 36, MarginYScreenLg);
            }
            else
            {
                PnlChartGrid.Padding = new Padding(36, MarginYScreenXl, 36, MarginYScreenXl);
            }
            PnlChartGrid.BackColor = CardBg;
            //PnlLineChartArea.BackColor = CardBg;
            LbNameChart.ForeColor = ForeGroundBlack;


        }

        private void UcAdvanceSetting_RadioButtonChanged(object sender, string selectedRadioButtonName)
        {
            //RbConfocal = (selectedRadioButtonName == "RbConfocal");
            //RbInterfero = (selectedRadioButtonName == "RbInterfero");
            UpdateRbcustom();
        }

        private void UcDefaultSetting_RadioButtonChanged(object sender, string selectedRadioButtonName)
        {
            //RbCHR1 = (selectedRadioButtonName == "RbCHR1");
            //RbCHR2 = (selectedRadioButtonName == "RbCHR2");
            //RbCHRC = (selectedRadioButtonName == "RbCHRC");
            //RbCLS = (selectedRadioButtonName == "RbCLS");
            UpdateRbcustom();
        }

        private void xyCoorTimer_Tick(object sender, EventArgs e)
        {

            PnlXYMap.PointY = (int)(((ReadFloatKvCom("340", "341") - YDistanceMin) / (float)(YDistanceMax - YDistanceMin)) * PnlXYMap.Height);
            PnlXYMap.PointX = (int)(((ReadFloatKvCom("240", "241") - XDistanceMin) / (float)(XDistanceMax - XDistanceMin)) * PnlXYMap.Width);

            LbXCoorValue.Text = PnlXYMap.PointX.ToString();
            LbYCoorValue.Text = PnlXYMap.PointY.ToString();

            Invalidate();
        }
        private void ProgressTimer_Tick(object sender, EventArgs e)
        {

        }

        #region Draw Z coordiante area 
        private void BlinkTimer_Tick(object sender, EventArgs e)
        {

            LbXCoorValue.Text = ReadFloatKvCom("240", "241").ToString("F2") + "mm";
            LbYCoorValue.Text = ReadFloatKvCom("340", "341").ToString("F2") + "mm";
            LbZCoorValue.Text = ReadFloatKvCom("140", "141").ToString("F2") + "mm";

            PnlXYMap.PointY = (int)(((ReadFloatKvCom("340", "341") - YDistanceMin) / (float)(YDistanceMax - YDistanceMin)) * PnlXYMap.Height);
            PnlXYMap.PointX = (int)(((ReadFloatKvCom("240", "241") - XDistanceMin) / (float)(XDistanceMax - XDistanceMin)) * PnlXYMap.Width);
            PnlZMap.PointY = (int)(((ReadFloatKvCom("140", "141") - ZDistanceMin) / (float)(ZDistanceMax - ZDistanceMin)) * (PnlZMap.Height - PnlZMap.PointSize));

            if (PnlZMap.PointY < PnlZMap.PointSize / 2)
                PnlZMap.PointY = PnlZMap.PointSize / 2;
            else if (PnlZMap.PointY > PnlZMap.Height - PnlZMap.PointSize / 2)
                PnlZMap.PointY = PnlZMap.Height - PnlZMap.PointSize / 2;

            Invalidate();
        }

        #endregion

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void StartTimer()
        {
            timer = new Timer
            {
                Interval = 2000 // 2000ms = 2 seconds
            };
            timer.Tick += new EventHandler(OnTimedEvent);
            timer.Start();
        }
        private void OnTimedEvent(object sender, EventArgs e)
        {
            // Your function to be called every 2 seconds
            ImgAreaScan.Image = RawDataToBitmapRGB(256, 65, 66, ImgAreaScan.Width, ImgAreaScan.Height);
            //ImgAreaScan.Image = RawDataToBitmapRGB(256, 65, 66, 512, 512);

        }
        public void BtConnect_Click(object sender, EventArgs e)
        {

            bool bConnect = false;
            //  ucDefaultSetting.ContentOfBtn = "Connect";
            //connect to device
            if (Conn == null)
            {
                try
                {
                    var DeviceType = CHRocodileLib.DeviceType.Chr1;
                    if (RbCHR2)
                        DeviceType = CHRocodileLib.DeviceType.Chr2;
                    else if (RbCLS)
                        DeviceType = CHRocodileLib.DeviceType.MultiChannel;
                    else if (RbCHRC)
                        DeviceType = CHRocodileLib.DeviceType.ChrCMini;
                    string strConInfo = ucDefaultSetting.ConnectAddress;

                    //set up device
                    ConnAsync = new AsynchronousConnection(strConInfo, DeviceType);

                    //Set output signals 
                    SetOutputSignals();

                    //Start to download spectrum.
                    timer1.Enabled = true;

                    //Open connection in asynchoronous mode
                    //register callback function
                    //data callback function: maximum read in 1000 samples every time and maximum wait for 10ms  
                    ConnAsync.SetDataCallback(OnData, 1000, 10);
                    //general command callback function, which will be called for all the responses/updates from the device
                    ConnAsync.SetGeneralResponseCallback(GenCmdCbFct);
                    //set connection to automatically process device output, 
                    //i.e. let CHRocodileLib to create an internal thread for output processing
                    //all the reponses and data are delivered through callback function withing CHRocodileLib internal thread 
                    ConnAsync.AutomaticMode = true;


                    //Open up the shared connection in synchronous mode based on the first connection
                    //The shared connection is responsible for synchronous spectrum downloading
                    ConnSync = new SynchronousConnection(ConnAsync);

                    Conn = new CHRocodileLib.SynchronousConnection(strConInfo, DeviceType);

                    SetupDevice();

                    SampleCount83 = 0;

                    //TBCMD.Enabled = true;
                    //BtnSendCmd.Enabled = true;

                    bConnect = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // If already connected, disconnect
            else
            {
                StopRecording();
                Conn.Close();
                Conn = null;
                MessageBox.Show("Conn.Close()");
            }
            EnableGui(bConnect);
        }

        private void SetupDevice()
        {
            //default signals are: Sample counter, peak 1 value, peak 1 quality/intensity
            //signal definition for CLS device, only 16bit integer signal for peak signal
            if (RbCLS)
                SignalIDs = new int[] { 83, 16640, 16641 };
            //other devices, float values are ordered
            else
                SignalIDs = new int[] { 65, 66, 256 };
            //Update TextBox
            ucAdvanceSetting.SelectedSignals = String.Join(",", SignalIDs.Select(p => p.ToString()).ToArray());
            ScanRate = 4000;

            //CLS device, normally maximum scan rate ist 2000
            //scanrate = 2000;
            TBSHZ.Text = ScanRate.ToString();
            ucAdvanceSetting.ScanRate = ScanRate.ToString();
            MessageBox.Show(ucAdvanceSetting.ScanRate.ToString());

            if (!RbCLS && !RbCHRC)
            {
                //set up measuring method (confocal or interferometric)
                SetUpMeasuringMethod();
            }
            SetUpMeasuringMethod();
            SetUpScanrate();
            SetUpOutputSignals();
            SetUpPLCSignals();
        }

        private void SetUpPLCSignals()
        {
            maxSpeed = ReadFloatKvCom("212", "213");
            minSpeed = ReadFloatKvCom("224", "225");
        }
        private void SetUpMeasuringMethod()
        {
            try
            {
                MeasurementMode nMMD = MeasurementMode.Confocal;
                if (RbInterfero)
                    nMMD = MeasurementMode.Interferometric;
                var oRsp = Conn.Exec(CHRocodileLib.CmdID.MeasuringMethod, nMMD);
                MeasuringMethod = (MeasurementMode)oRsp.GetParam<int>(0);
            }
            catch
            {
                Debug.Fail("Cannot set measuring method");
            }
            if (MeasuringMethod == MeasurementMode.Confocal)
                RbConfocal = true;
            else
                RbInterfero = true;
        }

        private void SetUpOutputSignals()
        {
            try
            {
                //Set device output signals
                char[] delimiters = new char[] { ' ', ',', ';' };
                int[] signals = ucAdvanceSetting.SelectedSignals.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).ToArray();
                var oRsp = Conn.Exec(CHRocodileLib.CmdID.OutputSignals, signals);
                SignalIDs = oRsp.GetParam<int[]>(0);
            }
            catch
            {
                Debug.Fail("Cannot set output signals");
            }
            ucAdvanceSetting.SelectedSignals = String.Join(",", SignalIDs.Select(p => p.ToString()).ToArray());
        }

        private void SetUpScanrate()
        {
            try
            {
                float nSHZ = float.Parse(ucAdvanceSetting.ScanRate);
                var oRsp = Conn.Exec(CHRocodileLib.CmdID.ScanRate, nSHZ);
                ScanRate = oRsp.GetParam<float>(0);
            }
            catch
            {
                Debug.Fail("Cannot set scan rate");
            }
            ucAdvanceSetting.ScanRate = ScanRate.ToString();
        }


        //Data callback function
        private void OnData(AsyncDataStatus status, Data _oData)
        {

            if (_oData.NumSamples > 0)
            {
                List<string> dataList = new List<string>();
                //display every 100th sample 
                foreach (var s in _oData.Samples())
                {
                    if (SampleCount83 % 100 == 0)
                    {
                        string strTemp = "";
                        for (int j = 0; j < _oData.Info.SignalGenInfo.GlobalSignalCount; j++)
                        {
                            double nTemp = s.Get(j);
                            if (double.IsNaN(nTemp))
                                strTemp += "Nan ";
                            else
                                strTemp += nTemp.ToString() + " ";
                        }
                        for (int k = 0; k < _oData.Info.SignalGenInfo.ChannelCount; k++)
                            for (int j = 0; j < _oData.Info.SignalGenInfo.PeakSignalCount; j++)
                            {
                                double nTemp = s.Get(j + _oData.Info.SignalGenInfo.GlobalSignalCount, k);
                                if (double.IsNaN(nTemp))
                                    strTemp += "Nan ";
                                else
                                    strTemp += nTemp.ToString() + " ";
                            }
                        dataList.Add(strTemp);
                    }
                    SampleCount83++;
                }

                this.BeginInvoke((Action<List<string>, Int64>)delegate (List<string> _DataList, Int64 _nSampleCount)
                {
                    //foreach (var str in _DataList)
                    //{
                    //    RTSample.AppendText(str);
                    //    RTSample.AppendText(Environment.NewLine);
                    //}
                    //TBSampleNumber.Text = _nSampleCount.ToString();
                }, dataList, _oData.NumSamples);
            }

            if (_oData.Status == DataStatus.Error)
            {
                Console.WriteLine("Error in processing device output!");
            }
        }

        private void GenCmdCbFct(Response _Rsp)
        {
            try
            {
                //based on the response ID, interprete 
                switch (_Rsp.Info.CmdID)
                {
                    case CmdID.MeasuringMethod:
                        {
                            MeasuringMethod = (MeasurementMode)_Rsp.GetParam<int>(0);
                            //this.BeginInvoke((Action)delegate { TBMOD.Text = MeasuringMethod.ToString(); });
                            break;
                        }
                    case CmdID.ScanRate:
                        {
                            ScanRate = _Rsp.GetParam<float>(0);
                            this.BeginInvoke((Action)delegate { ucAdvanceSetting.ScanRate = ScanRate.ToString(); });
                            break;
                        }
                    case CmdID.DataAverage:
                        {
                            DataAverage = _Rsp.GetParam<int>(0);
                            //this.BeginInvoke((Action)delegate { TBAVD.Text = DataAverage.ToString(); });
                            break;
                        }
                    case CmdID.OutputSignals:
                        {
                            if (_Rsp.ParamCount > 0)
                                SignalIDs = _Rsp.GetParam<int[]>(0);
                            else
                                SignalIDs = new int[0];
                            //this.BeginInvoke((Action)delegate { TBSODX.Text = String.Join(",", SignalIDs.Select(p => p.ToString()).ToArray()); });
                            break;
                        }
                }
            }
            catch
            {
                // TODO
            }

            //if (_Rsp.Info.CmdID != CmdID.DownloadSpectrum)
            //{
            //    //get response in string form and update response text box
            //    string strRsp = (_Rsp.IsUpdate() ? "(U) " : "    ") + _Rsp.ToString();
            //    this.BeginInvoke((Action<string>)delegate (string _strRsp)
            //    {
            //        RTRsp.AppendText(_strRsp);
            //        RTRsp.AppendText(Environment.NewLine);
            //    }, strRsp);
            //}
        }

        private void SetOutputSignals()
        {
            try
            {
                //Set device output signals

                    SignalIDs = new int[] { 83 };
                ConnAsync.Exec(CmdID.OutputSignals, null, SignalIDs);
            }
            catch
            {
                Debug.Fail("Cannot set output signals");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Synchronously download spectrum.
            try
            {
                var specType = SpecType.Raw;
   

                Response oRsp;
                //for downloading spectra of several channles from multi-channel device,  needs to add start channel index and channel count
                //here only download the specturm of the first channel
                if (RBCLS.Checked)
                    oRsp = ConnSync.Exec(CmdID.DownloadSpectrum, specType, 0, 1);
                else
                    oRsp = ConnSync.Exec(CmdID.DownloadSpectrum, specType);
                //the last parameter of the response is the spectrum data
                var aBytes = oRsp.GetParam<byte[]>(oRsp.ParamCount - 1);
                //convert to 16bit data
                Int16[] SpecData = new Int16[aBytes.Length / 2];
                Buffer.BlockCopy(aBytes, 0, SpecData, 0, aBytes.Length);

                for (int i = 0; i < SpecData.Length; i++)
                    chart1.Series[0].Points[i].YValues[0] = SpecData[i];
                // TODO: check why!?
                //for (int i = SpecData.Length / 2; i < 1024; i++)
                //    chart1.Series[0].Points[i].YValues[0] = 0;
                chart1.ChartAreas[0].RecalculateAxesScale();
                chart1.Invalidate();
            }
            catch
            {
                Debug.Fail("Cannot set download spectrum");
                timer1.Enabled = false;
            }
        }



        private void EnableGui(bool _bEnabled)
        {
            BtConnect.Enabled = !_bEnabled;
            BtDisCon.Enabled = _bEnabled;
            BtRecord.Enabled = _bEnabled;
            EnableSetting(_bEnabled);
        }

        private void EnableSetting(bool _bEnabled)
        {
            RBConfocal.Enabled = _bEnabled && (RbCHR1 || RbCHR2);
            RBInterfero.Enabled = _bEnabled && (RbCHR1 || RbCHR2);
            TBSHZ.Enabled = _bEnabled;
            TBSODX.Enabled = _bEnabled;
        }

        public void RBConfocal_Click(object sender, EventArgs e)
        {
            SetUpMeasuringMethod();
        }

        public void TBSHZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                SetUpScanrate();
        }

        public void TBSODX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                SetUpOutputSignals();
        }

        private void StartRecording()
        {
            OnBitMR("401");
            StartTimer();
            progressTimer.Start();
            //throw away the old data
            if (CBFlush.Checked)
                Conn.FlushConnectionBuffer();
            //recording sample count
            SampleCount = int.Parse(ucAdvanceSetting.SampleCount);
            //start recording, enter recording modes
            Conn.StartRecording(SampleCount);
            //initDataChart();
            CurrentDataPos = 0;
            timerData.Enabled = true;
            EnableSetting(false);
            BtRecord.Text = "Stop Recording";
            BtRecord.Tag = 1;
            BtSave.Enabled = false;
            recordedPoints.Clear();
        }


        private void initDataChart()
        {
            chart1.Series[0].Points.Clear();
            //chart2.Series[0].Points.Clear();
            //chart3.Series[0].Points.Clear();
            for (int i = 0; i < SampleCount83; i++)
            {
                chart1.Series[0].Points.AddY(0);
                //chart2.Series[0].Points.AddY(0);
                //chart3.Series[0].Points.AddY(0);
            }
        }


        private void StopRecording()
        {
            OffBitMR("401");
            timerData.Enabled = false;
            //stop recording, get recorded data buffer/object
            RecordData = Conn.StopRecording();
            progressTimer.Stop();
            EnableSetting(true);
            BtRecord.Text = "Start Recording";
            BtRecord.Tag = 0;
            BtSave.Enabled = true;

        }
        public Color GetColorForValue(double val, double minDist, double maxDist)
        {

            double m_invRange = maxDist - minDist;

            if (m_invRange < 0)
                return Color.Gray;

            if (double.IsNaN(val) || double.IsNegativeInfinity(val))
                val = minDist;

            if (double.IsPositiveInfinity(val))
                val = maxDist;

            byte r = 0, g = 0, b = 0;

            var gray = Math.Min(val, maxDist);
            gray = 8.0 * (Math.Max(gray, minDist) - minDist) / m_invRange;
            const double s = 255.0 / 2.0;

            if (gray <= 1)
            {
                b = (byte)((gray + 1) * s);
            }
            else if (gray <= 3)
            {
                g = (byte)((gray - 1) * s);
                b = 255;
            }
            else if (gray <= 5)
            {
                r = (byte)((gray - 3) * s);
                g = 255;
                b = (byte)((5 - gray) * s);
            }
            else if (gray <= 7)
            {
                r = 255;
                g = (byte)((7 - gray) * s);
            }
            else
            {
                r = (byte)((9 - gray) * s);
            }

            return Color.FromArgb(255, r, g, b);
        }

        public class Point3D
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; } // Z will hold the signal value (e.g., s.Get(1))

            public Point3D(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }
        }
        private List<Point3D> recordedPoints = new List<Point3D>(); // Store points
        private void timerData_Tick(object sender, EventArgs e)
        {
            //read in newly recorded samples and display
            var oData = Conn.GetNextSamples();
            if (oData.NumSamples > 0)
            {
                double[] aData = new double[3];
                foreach (var s in oData.Samples())
                {

                    if (CurrentDataPos >= SampleCount)
                        break;
                    //only read in and show the first 3 signals
                    for (int i = 0; i < 3; i++)
                    {
                        aData[i] = 0;
                        if (oData.Info.SignalGenInfo.GlobalSignalCount > i)
                            aData[i] = s.Get(i);
                        //if not enough global signal, show peak signal. for peak signal, only shows the value for the first channel
                        else if (oData.Info.SignalGenInfo.GlobalSignalCount + oData.Info.SignalGenInfo.PeakSignalCount > i)
                            aData[i] = s.Get(i, 0);
                    }
                    //chart2.Series[0].Points[CurrentDataPos].YValues[0] = Double.IsNaN(aData[1]) ? 0 : aData[1];
                    //chart3.Series[0].Points[CurrentDataPos].YValues[0] = Double.IsNaN(aData[2]) ? 0 : aData[2];
                    double signalXValue = (Double.IsNaN(aData[0]) ? 0 : aData[0]);
                    double signalYValue = Double.IsNaN(aData[1]) ? 0 : aData[1];
                    double signalZValue = Double.IsNaN(aData[2]) ? 0 : aData[2];
                    recordedPoints.Add(new Point3D(signalXValue, signalYValue, signalZValue));
                    CurrentDataPos++;
                }
                PbScan.Value = (int)(CurrentDataPos * 100 / (SampleCount));
                if (PbScan.Value == 0)
                    LbScanProgress.Text = "Initializing scan...";
                else if (PbScan.Value == 100)
                    LbScanProgress.Text = "Scan completed.";
                else
                    LbScanProgress.Text = "Scanning in progress...";
            }
            //enough samples have been acquired, stop recording
            if (CurrentDataPos >= SampleCount)
                StopRecording();

        }

        private void BtRecord_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32((sender as Button).Tag) == 0)
                StartRecording();
            else
                StopRecording();
        }
        //here save the recorded data into a file 
        private void BtSave_Click(object sender, EventArgs e)
        {
            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(SaveDlg.OpenFile());
                var nSigCount = RecordData.Info.SignalGenInfo.GlobalSignalCount
                    + RecordData.Info.SignalGenInfo.PeakSignalCount;

                //reread all the samples, save...
                RecordData.Rewind();
                foreach (var s in RecordData.Samples())
                {
                    StringBuilder sb = new StringBuilder();
                    for (int j = 0; j < nSigCount; j++)
                    {
                        if (j < RecordData.Info.SignalGenInfo.GlobalSignalCount)
                            sb.Append(s.Get(j) + ", ");
                        else
                        {
                            for (int k = 0; k < RecordData.Info.SignalGenInfo.ChannelCount; k++)
                                sb.Append(s.Get(j, k) + ", ");
                        }
                    }
                    writer.WriteLine(sb.ToString());
                }
                writer.Dispose();
            }
        }

        private void action_Click(object sender, EventArgs e)
        {
            //Open a SaveFileDialog to choose the output file name.
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "BCRF Files (*.bcrf)|*.bcrf";
                sfd.Title = "Save as BCRF";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // You can adjust the grid resolution as needed.
                    int gridWidth = 512;
                    int gridHeight = 512;
                    SaveAsBCRFFile(sfd.FileName, gridWidth, gridHeight);
                }
            }

            //using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            //{
            //    saveFileDialog.Filter = "BCRF Files (*.bcrf)|*.bcrf";
            //    saveFileDialog.Title = "Save BCRF File";
            //    saveFileDialog.FileName = "DSM_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

            //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        string selectedPath = saveFileDialog.FileName;
            //        string directoryPath = Path.GetDirectoryName(selectedPath);
            //        string baseFileName = Path.GetFileNameWithoutExtension(selectedPath);
            //            // Tự động thêm số thứ tự (_0, _1, ...)
            //            string fileName = $"{baseFileName}.bcrf";
            //            string filePath = Path.Combine(directoryPath, fileName);
            //    int gridWidth = 512;
            //    int gridHeight = 512;
            //    SaveAsBCRF(filePath, gridWidth, gridHeight);
            //    }
            //}
        }
        /// <summary>
        /// Saves the recorded 3D points as a BCRF file.
        /// The points are interpolated into a regular grid (via simple binning/averaging).
        /// </summary>
        /// <param name="filePath">Full path to save the file.</param>
        /// <param name="imgWidth">Number of pixels along X (grid resolution).</param>
        /// <param name="imgHeight">Number of pixels along Y (grid resolution).</param>
        private void SaveAsBCRFFile(string filePath, int imgWidth, int imgHeight)
        {
            if (recordedPoints.Count == 0)
            {
                MessageBox.Show("No points recorded to save.");
                return;
            }

            double minV = double.MaxValue,
                  maxValue = double.MinValue,
                  minX = minV, maxX = maxValue,
                  minY = minV, maxY = maxValue;
            RecordData.Rewind();
            foreach (var S in recordedPoints)
            {
                double val = S.Z,
                       X = S.X, Y = S.Y;
                if (!(double.IsNaN(val) || double.IsInfinity(val)))
                {
                    minV = Math.Min(minV, val);
                    maxValue = Math.Max(maxValue, val);
                }
                minX = Math.Min(minX, X);
                maxX = Math.Max(maxX, X);
                minY = Math.Min(minY, Y);
                maxY = Math.Max(maxY, Y);
            }
            // Create a heat map instance
            //var heatMap = new ColorHeatMap(minV, maxValue);

            // Calculate the width and height of the scanned rectangle
            // and scale to the size of the image box in the MainForm.
            var rectWidth = Math.Abs(maxX - minX);
            var rectHeight = Math.Abs(maxY - minY);
            var scale = Math.Min(rectWidth, rectHeight) / Math.Max(rectWidth, rectHeight);

            if (rectWidth < rectHeight)
                imgWidth = (int)(imgWidth * scale);
            else
                imgHeight = (int)(imgHeight * scale);

            // 1. Determine the spatial bounds of your data.
            double minXreal = recordedPoints.Min(p => p.X);
            double maxXreal = recordedPoints.Max(p => p.X);
            double minYreal = recordedPoints.Min(p => p.Y);
            double maxYreal = recordedPoints.Max(p => p.Y);
            double xLength = (maxXreal - minXreal);
            double yLength = (maxYreal - minYreal);


            // 2. Create 2D buffers for accumulating Z values and counting points per cell.
            float[,] grid = new float[imgHeight, imgWidth];
            int[,] count = new int[imgHeight, imgWidth];

            // Initialize buffers (not strictly necessary because default is zero)
            for (int y = 0; y < imgHeight; y++)
            {
                for (int x = 0; x < imgWidth; x++)
                {
                    grid[y, x] = 0f;
                    count[y, x] = 0;
                }
            }

            // 3. Bin each recorded point into the grid.
            // (Assumes that the recorded points are roughly distributed over a rectangle.)
            foreach (var p in recordedPoints)
            {
                // Map the point's X and Y to a grid index.
                // Clamp the value to ensure it falls within [0, gridDimension-1].
                int xIdx = (int)((p.X - minX) / (xLength) * (imgWidth - 1));
                int yIdx = (int)((p.Y - minY) / (yLength) * (imgHeight - 1));
                xIdx = Math.Max(0, Math.Min(imgWidth - 1, xIdx));
                yIdx = Math.Max(0, Math.Min(imgHeight - 1, yIdx));

                grid[yIdx, xIdx] += (float)p.Z;
                count[yIdx, xIdx]++;
            }


            // 4. Create a 1D buffer (row‑major order) with the averaged Z values.
            float[] dataBuffer = new float[imgWidth * imgHeight];
            for (int y = 0; y < imgHeight; y++)
            {
                for (int x = 0; x < imgWidth; x++)
                {
                    float avg = (count[y, x] > 0) ? grid[y, x] / count[y, x] : 0f;
                    dataBuffer[y * imgWidth + x] = avg;
                }
            }

            // 5. Build the BCRF header.
            // The header is fixed in size (here 2048 bytes) and includes information about the grid.
            int headerSize = 2048;
            int numVoid = 0; // If you want to mark cells as "void", set accordingly.
            string header = string.Format(
        @"fileformat = bcrf
headersize = {0}
xpixels = {1}
ypixels = {2}
xlength = {3}
ylength = {4}
scanspeed = 1
xunit = mm
yunit = mm
zunit = mm
intelmode = 1
bit2nm = 1
xoffset = 0
yoffset = 0
voidpixels = {5}
zmin = 0
forcecurve = 0
", headerSize, imgWidth, imgHeight, xLength / 2, yLength / 2, numVoid);

            // 6. Write the header and binary data to the file.
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    // Write the header as ASCII text.
                    byte[] headerBytes = Encoding.ASCII.GetBytes(header);
                    // Pad the header with '%' characters so that it reaches the fixed header size.
                    byte[] pad = Enumerable.Repeat((byte)'%', headerSize - headerBytes.Length).ToArray();
                    fs.Write(headerBytes, 0, headerBytes.Length);
                    fs.Write(pad, 0, pad.Length);

                    // Write the data buffer as binary floats.
                    int floatSize = sizeof(float);
                    byte[] dataBytes = new byte[dataBuffer.Length * floatSize];
                    Buffer.BlockCopy(dataBuffer, 0, dataBytes, 0, dataBytes.Length);
                    fs.Write(dataBytes, 0, dataBytes.Length);
                }
                MessageBox.Show("BCRF file saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing BCRF file: " + ex.Message);
            }
        }

        [DllImport("kernel32.dll")]
        private static extern bool WriteFile(IntPtr hFile, IntPtr lpBuffer, int NumberOfBytesToWrite, out int lpNumberOfBytesWritten, IntPtr lpOverlapped);

        public string SaveAsBCRF(string filePath, int imgWidth, int imgHeight)
        {
            string header =
@"fileformat = {0}
headersize = {1}
xpixels = {2}
ypixels = {3}
xlength = {4}
ylength = {5}
scanspeed = 1
xunit = mm
yunit = mm
zunit = mm
intelmode = 1
bit2nm = 1
xoffset = 0
yoffset = 0
voidpixels = {6}
zmin = 0
forcecurve = 0
";

            int headerSize = 2048, numVoid = 0;


            double minV = double.MaxValue,
                  maxValue = double.MinValue,
                  minX = minV, maxX = maxValue,
                  minY = minV, maxY = maxValue;
            RecordData.Rewind();
            foreach (var S in RecordData.Samples())
            {
                double val = S.Get(2),
                       X = S.Get(0), Y = S.Get(1);
                if (!(double.IsNaN(val) || double.IsInfinity(val)))
                {
                    minV = Math.Min(minV, val);
                    maxValue = Math.Max(maxValue, val);
                }
                minX = Math.Min(minX, X);
                maxX = Math.Max(maxX, X);
                minY = Math.Min(minY, Y);
                maxY = Math.Max(maxY, Y);
            }

            var rectWidth = Math.Abs(maxX - minX);
            var rectHeight = Math.Abs(maxY - minY);
            var scale = Math.Min(rectWidth, rectHeight) / Math.Max(rectWidth, rectHeight);

            if (rectWidth < rectHeight)
                imgWidth = (int)(imgWidth * scale);
            else
                imgHeight = (int)(imgHeight * scale);

            double minXreal = recordedPoints.Min(p => p.X);
            double maxXreal = recordedPoints.Max(p => p.X);
            double minYreal = recordedPoints.Min(p => p.Y);
            double maxYreal = recordedPoints.Max(p => p.Y);
            double xLength = (maxXreal - minXreal);
            double yLength = (maxYreal - minYreal);


            string fname = filePath.Length > 0 ? filePath : $"DSM_signal_256.bcrf";
            string outs = String.Format(header, "bcrf",
                          headerSize, imgWidth, imgHeight, xLength, yLength, numVoid);

            using (var file = new FileStream(fname, FileMode.Create, FileAccess.Write))
            {
                var bytes = new ASCIIEncoding().GetBytes(outs);
                var pad = Enumerable.Repeat(Convert.ToByte('%'), headerSize - bytes.Length).ToArray();
                file.Write(bytes, 0, bytes.Length);
                file.Write(pad, 0, pad.Length);

                //unsafe
                //{
                //    var H = file.SafeFileHandle.DangerousGetHandle();
                //    // get the typed pointer to signal's data without copying
                //    var buf = bmp.GetScanLineAs<float>(sigIdx);
                //    WriteFile(H, (IntPtr)buf, (int)(Conn.GetNextSamples().NumSamples * 4), out int written, IntPtr.Zero);
                //    Console.WriteLine($"Total bytes written: {written}");
                //}
            }
            return fname;
        }

        public Bitmap RawDataToBitmapRGB(int sigIdx, int Xidx, int Yidx, int imgWidth, int imgHeight)
        {

            // Get data for the desired plot signal, encoder X and encoder Y
            double minV = double.MaxValue,
                   maxValue = double.MinValue,
                   minX = minV, maxX = maxValue,
                   minY = minV, maxY = maxValue;

            foreach (var S in recordedPoints)
            {
                double val = S.Z,
                       X = S.X, Y = S.Y;
                if (!(double.IsNaN(val) || double.IsInfinity(val)))
                {
                    minV = Math.Min(minV, val);
                    maxValue = Math.Max(maxValue, val);
                }
                minX = Math.Min(minX, X);
                maxX = Math.Max(maxX, X);
                minY = Math.Min(minY, Y);
                maxY = Math.Max(maxY, Y);
            }
            // Create a heat map instance
            var heatMap = new ColorHeatMap(minV, maxValue);

            // Calculate the width and height of the scanned rectangle
            // and scale to the size of the image box in the MainForm.
            var rectWidth = Math.Abs(maxX - minX);
            var rectHeight = Math.Abs(maxY - minY);
            var scale = Math.Min(rectWidth, rectHeight) / Math.Max(rectWidth, rectHeight);

            if (rectWidth < rectHeight)
                imgWidth = (int)(imgWidth * scale);
            else
                imgHeight = (int)(imgHeight * scale);
            if (imgWidth <= 0 || imgHeight <= 0)
            {
                return new Bitmap(1, 1); // Use a 1x1 fallback
            }
            Bitmap bmp = new(imgWidth, imgHeight, PixelFormat.Format32bppArgb);
            //Bitmap bmp = new(512, 512, PixelFormat.Format32bppArgb);

            var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            using (Graphics gfx = Graphics.FromImage(bmp))
            using (SolidBrush brush = new SolidBrush(Color.Transparent))

            {
                gfx.FillRectangle(brush, rect);
            }
            var bdata = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);
            double sx = (double)imgWidth / (maxX - minX),
                   sy = (double)imgHeight / (maxY - minY);

            unsafe
            {
                Int32* ptr = (Int32*)bdata.Scan0;
                Int32 step = bdata.Stride / 4;
                // Loop over all samples to fill the image data buffer
                foreach (var S in recordedPoints)
                {
                    // Determine x and y coordinate of the image based on the return values
                    // of the encoders.
                    var xImg = (int)((S.X - minX) * sx);
                    var yImg = (int)((S.Y - minY) * sy);

                    // Clip x and y to bounds
                    if ((uint)xImg >= (uint)imgWidth || (uint)yImg >= (uint)imgHeight)
                        continue;

                    // Get the heat map color for the current value
                    var color = heatMap.GetColorForValue(S.Z).ToArgb();
                    int ofs = yImg * step + xImg;
                    ptr[ofs] = color;
                    if (xImg > 0 && yImg > 0)
                    {
                        var top = ofs - step;
                        ptr[ofs - 1] = color;
                        ptr[top] = color;
                        ptr[top - 1] = color;
                    }
                }
            }

            bmp.UnlockBits(bdata);
            return bmp;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SavePointsToCsvWithDialog();

        }
        private void SavePointsToCsvWithDialog()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                saveFileDialog.Title = "Save Points to CSV File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SavePointsToCsv(saveFileDialog.FileName); // Pass the chosen file path to the method
                }
            }
        }

        private void SavePointsToCsv(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("X,Y,Z"); // Add a header row
                foreach (var point in recordedPoints)
                {
                    writer.WriteLine($"{point.X},{point.Y},{point.Z}");
                }
            }
            MessageBox.Show("CSV file saved successfully!");
        }

        static void MaxSize(Form form)
        {
            int x = SystemInformation.WorkingArea.Width;
            int y = SystemInformation.WorkingArea.Height;
            form.WindowState = FormWindowState.Normal;
            form.Location = new Point(0, 0);
            form.Size = new Size(x, y);

        }

        private void TRecordSample_Load(object sender, EventArgs e)
        {
            // Ensure the "Configs" folder exists.
            if (!Directory.Exists(configsFolderPath))
            {
                Directory.CreateDirectory(configsFolderPath);

            }

            // Check if user_config.txt exists; if not, create it with 4 empty lines.
            if (!File.Exists(filePath))
            {
                string[] defaultData = { "", "", "", "" };
                File.WriteAllLines(filePath, defaultData);
                MessageBox.Show("user_config.txt was created with default content.");
            }

            // Load the data into the textboxes
            LoadAllTextBoxes();

            // Update the button images based on whether each textbox has data
            UpdateAllButtonImages();
        }
        private void LoadAllTextBoxes()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length >= 4) // Ensure enough lines exist in the file
                {
                    TbPos1.Text = lines[0];
                    TbPos2.Text = lines[1];
                    TbPos3.Text = lines[2];
                    TbPos4.Text = lines[3];
                }
            }
        }
        private void UpdateAllButtonImages()
        {
            UpdateButtonImage(BtnSetPos1, TbPos1.Text);
            UpdateButtonImage(BtnSetPos2, TbPos2.Text);
            UpdateButtonImage(BtnSetPos3, TbPos3.Text);
            UpdateButtonImage(BtnSetPos4, TbPos4.Text);
        }

        private void UpdateButtonImage(CustomUi.DSM_Button button, string text)
        {
            //// If text is NOT empty, use imageA; otherwise, use imageB
            //if (!string.IsNullOrWhiteSpace(text))
            //{
            //    button.Image = Properties.Resources.icon_delete;
            //    button.ImageAlign = ContentAlignment.MiddleCenter;
            //}
            //else
            //{
            //    button.Image = Properties.Resources.icon_save;
            //    button.ImageAlign = ContentAlignment.MiddleCenter;
            //}
            button.Image = Properties.Resources.icon_save;
            button.ImageAlign = ContentAlignment.MiddleCenter;
        }
        // Validate that the input string follows the format "x,y,z" where x, y, and z are numbers.
        private bool IsValidXYZ(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Invalid input format. Please enter values in the format 'x,y,z' (e.g., 10,20,30).");
                return false;
            }

            string[] parts = input.Split(',');
            if (parts.Length != 3)
            {
                MessageBox.Show("Invalid input format. Please enter values in the format 'x,y,z' (e.g., 10,20,30).");
                return false;
            }

            // Try parsing each value.
            if (!float.TryParse(parts[0].Trim(), out float x) ||
                !float.TryParse(parts[1].Trim(), out float y) ||
                !float.TryParse(parts[2].Trim(), out float z))
                return false;

            // Specify desired ranges for each axis.
            float minX = 0, maxX = 100;   // Example: x must be between 0 and 100
            float minY = -50, maxY = 50;    // Example: y must be between -50 and 50
            float minZ = 10, maxZ = 200;   // Example: z must be between 10 and 200

            if (x < minX || x > maxX)
            {
                MessageBox.Show($"x value must be between {minX} and {maxX}.");
                return false;
            }

            if (y < minY || y > maxY)
            {
                MessageBox.Show($"y value must be between {minY} and {maxY}.");
                return false;
            }

            if (z < minZ || z > maxZ)
            {
                MessageBox.Show($"z value must be between {minZ} and {maxZ}.");
                return false;
            }

            return true;
        }
        private void SaveOrDeleteTextBox(int index, CustomUi.DSM_TextBox textBox, CustomUi.DSM_Button button)
        {
            string[] data = { "", "", "", "" };

            // Load existing data if the file exists.
            if (File.Exists(filePath))
            {
                string[] existingData = File.ReadAllLines(filePath);
                for (int i = 0; i < existingData.Length && i < 4; i++)
                {
                    data[i] = existingData[i];
                }
            }


            // Validate and save only if there is text.
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (!IsValidXYZ(textBox.Text))
                {
                    // Validation failed; exit without saving.
                    return;
                }

                data[index] = textBox.Text;
                MessageBox.Show($"Data saved for TextBox {index + 1}!");
            }
            else
            {
                // If textbox is empty, treat it as deletion.
                data[index] = "";
                MessageBox.Show($"Data deleted for TextBox {index + 1}!");
            }

            // Write back all 4 lines
            File.WriteAllLines(filePath, data);

            // Update button images
            UpdateButtonImage(button, textBox.Text);
        }

        private void BtnSetPos1_Click(object sender, EventArgs e)
        {
            SaveOrDeleteTextBox(0, TbPos1, BtnSetPos1);
        }
        private void BtnSetPos2_Click(object sender, EventArgs e)
        {
            SaveOrDeleteTextBox(1, TbPos2, BtnSetPos2);
        }

        private void BtnSetPos3_Click(object sender, EventArgs e)
        {
            SaveOrDeleteTextBox(2, TbPos3, BtnSetPos3);
        }

        private void BtnSetPos4_Click(object sender, EventArgs e)
        {
            SaveOrDeleteTextBox(3, TbPos4, BtnSetPos4);
        }


        private void PostPosScanToPLC(int index, CustomUi.DSM_TextBox textBox, CustomUi.DSM_Button button)
        {
            if (!IsValidXYZ(textBox.Text))
            {
                // Validation failed; exit without saving.
                return;
            }
            string[] parts = textBox.Text.Split(',');
            // Try parsing each value.
            if (!float.TryParse(parts[0].Trim(), out float x) ||
                !float.TryParse(parts[1].Trim(), out float y) ||
                !float.TryParse(parts[2].Trim(), out float z))
                return;
            WriteCMToPLC("8200", "8201", x * 2500);
            WriteCMToPLC("8400", "8401", y * 2500);
            WriteCMToPLC("8000", "8001", z * 2500);
            OnBitMR("410");
            OffBitMR("410");
        }

        private void BtnRunPos_Click(object sender, EventArgs e)
        {
            if (sender == BtnRunPos1)
            {
                PostPosScanToPLC(0, TbPos1, BtnRunPos1);
            }
            else if (sender == BtnRunPos2)
            {
                PostPosScanToPLC(1, TbPos2, BtnRunPos2);
            }
            else if (sender == BtnRunPos3)
            {
                PostPosScanToPLC(2, TbPos3, BtnRunPos3);
            }
            else if (sender == BtnRunPos4)
            {
                PostPosScanToPLC(3, TbPos4, BtnRunPos4);
            }
        }
        private void ConnectToPLC()
        {
            // Connect to device
            try
            {
                // Connect with HOTLINK
                //sp_main.PortName = "COM5";
                //sp_main.Open();
                //sp_main.Write("CR\r");
                // Connect with KV CM+ 
                axDBCommManager1.Connect();
                axDBTriggerManager1.Active = true;
                TbZControl.Value = (int)(((ReadFloatKvCom("140", "141") - ZDistanceMin) / (float)(ZDistanceMax - ZDistanceMin)) * 100);
                PnlZMap.PointY = (int)(((ReadFloatKvCom("140", "141") - ZDistanceMin) / (float)(ZDistanceMax - ZDistanceMin)) * (PnlZMap.Height - PnlZMap.PointSize));
                LbZCoorValue.Text = ReadFloatKvCom("140", "141").ToString("F2") + "mm";
                blinkTimer.Start(); // start delay time
                MessageBox.Show("Connection PLC successful ", "Connection status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed: " + ex.Message, "Error",
        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error,
        MessageBoxDefaultButton.Button1);
            }
        }
        private void PostDataToPLC(object sender, DSM_GridMap.PointClickedEventArgs e)
        {
            OnBitMR("208");
            OnBitMR("308");

            float currentYCoor = ((((float)e.Y / PnlXYMap.Height) * 100 / (float)100 * (YDistanceMax - YDistanceMin)) - YDistanceMin);
            float currentXCoor = ((((float)e.X / PnlXYMap.Width) * 100 / (float)100 * (XDistanceMax - XDistanceMin)) + XDistanceMin);

            WriteCMToPLC("8230", "8231", currentXCoor * 2500);
            WriteCMToPLC("8430", "8431", currentYCoor * 2500);
            OnBitMR("210");
            OnBitMR("310");
            OffBitMR("210");
            OffBitMR("310");
            OffBitMR("208");
            OffBitMR("308");
        }
        private void TbXYspeed_ValueChanged(object sender, EventArgs e)
        {

            SetUpPLCSignals();
            float currentSpeed = ((TbXYspeed.Value / (float)100 * (maxSpeed - minSpeed)) + minSpeed); // Map to range of speed
            WriteDMToPLC("204", "205", currentSpeed); // Write speed value in register
            WriteDMToPLC("304", "305", currentSpeed); // Write speed value in register
            WriteCMToPLC("8234", "8235", currentSpeed * 2500); // Write speed value in register
            WriteCMToPLC("8434", "8435", currentSpeed * 2500); // Write speed value in register
            //LbXCoorValue.Text = currentSpeed.ToString();

        }

        private void TbZControl_ValueChanged(object sender, EventArgs e)
        {

            OnBitMR("108");
            OffBitMR("108");
            float currentZCoor = ((TbZControl.Value / (float)100 * (ZDistanceMax - ZDistanceMin)) + ZDistanceMin); // Map to range of Working distance (mm)
            LbXCoorValue.Text = (currentZCoor * 2500).ToString();
            WriteCMToPLC("8010", "8011", currentZCoor * 2500);

        }
        private void TbZControl_MouseWheel(object sender, MouseEventArgs e)
        {
            LbYCoorValue.Text = TbZControl.Value.ToString();
            OnBitMR("110");
            OffBitMR("110");
        }
        private float ReadFloatKvCom(string lowerWord, string upperWord)
        {
            try
            {
                // Read the lower and upper 16-bit words from the PLC
                int lower = axDBCommManager1.ReadDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_DM, lowerWord);
                int upper = axDBCommManager1.ReadDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_DM, upperWord);

                // Combine the two 16-bit words into a single 32-bit integer (Big-Endian order)
                int intValue = (upper << 16) | (lower & 0xFFFF);

                // Convert the 32-bit integer to a byte array
                byte[] bytes = BitConverter.GetBytes(intValue);

                // Convert the byte array to a float
                float floatValue = BitConverter.ToSingle(bytes, 0);

                return floatValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading {lowerWord} and {upperWord} from device: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // Return a default value in case of failure
            }
        }

        private string ReadFloatHotLink(string bitAddress)
        {
            try
            {
                sp_main.Write("RD" + "" + "CM" + bitAddress + ".L" + "" + "\r");
                string floatValue = sp_main.ReadLine();
                return floatValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading and from device: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "0"; // Return a default value in case of failure
            }
        }


        private void OnBitMR(string bitAddress)
        {
            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, bitAddress, 1);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: {bitAddress} {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OffBitMR(string bitAddress)
        {
            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, bitAddress, 0);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: {bitAddress} {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteDMToPLC(string lowerWord, string upperWord, float value)
        {
            try
            {
                // Convert the float value to a 32-bit integer representation
                int intValue = BitConverter.ToInt32(BitConverter.GetBytes(value), 0);

                // Split the 32-bit integer into two 16-bit words
                int lower = intValue & 0xFFFF;       // Lower 16 bits
                int upper = (intValue >> 16) & 0xFFFF; // Upper 16 bits
                                                       // Write the lower word to the lower address
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_DM, lowerWord, lower);

                // Write the upper word to the upper address
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_DM, upperWord, upper);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //private void WriteCMToPLC(string lowerWord, string upperWord, float value)
        //{
        //    try
        //    {
        //        // Convert the float value to a 32-bit integer representation
        //        int intValue = BitConverter.ToInt32(BitConverter.GetBytes(value), 0);

        //        // Split the 32-bit integer into two 16-bit words
        //        int lower = intValue & 0xFFFF;       // Lower 16 bits
        //        int upper = (intValue >> 16) & 0xFFFF; // Upper 16 bits
        //                                               // Write the lower word to the lower address
        //        axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_CM, lowerWord, lower);

        //        // Write the upper word to the upper address
        //        axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_CM, upperWord, upper);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Notify the user of an error
        //        MessageBox.Show($"Error writing to PLC: {ex.Message}",
        //                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        private void WriteCMToPLC(string lowerWord, string upperWord, float value)
        {
            try
            {
                // Convert the float value to a 32-bit signed integer.
                // Here we use Math.Round to round the float value; 
                // you could also use a simple cast ((int)value) if you prefer truncation.
                int intValue = (int)Math.Round(value);

                // Split the 32-bit integer into two 16-bit words.
                // The lower 16 bits:
                int lower = intValue & 0xFFFF;
                // The upper 16 bits:
                int upper = (intValue >> 16) & 0xFFFF;

                // Write the lower 16-bit word to the PLC address given by lowerWord.
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_CM, lowerWord, lower);
                // Write the upper 16-bit word to the PLC address given by upperWord.
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_CM, upperWord, upper);
            }
            catch (Exception ex)
            {
                // Notify the user if there's an error writing to the PLC.
                MessageBox.Show($"Error writing to PLC: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void axDBDeviceManager1_BeforeRead(object sender, EventArgs e)
        {
            GetCurrentCoordinate();
        }


        private void GetCurrentCoordinate()
        {

            ushort CM8830 = ushort.Parse(axDBDeviceManager1.Devices[1].ValueRead.ToString().ToString());
            ushort CM8831 = ushort.Parse(axDBDeviceManager1.Devices[2].ValueRead.ToString().ToString());

            ushort CM8870 = ushort.Parse(axDBDeviceManager1.Devices[3].ValueRead.ToString().ToString());
            ushort CM8871 = ushort.Parse(axDBDeviceManager1.Devices[4].ValueRead.ToString().ToString());

            ushort CM8910 = ushort.Parse(axDBDeviceManager1.Devices[5].ValueRead.ToString().ToString());
            ushort CM8911 = ushort.Parse(axDBDeviceManager1.Devices[6].ValueRead.ToString().ToString());
            //Combining Two 16-bit Integers
            float xCoordinate = (CM8871 << 16) | CM8870;
            float yCoordinate = (CM8911 << 16) | CM8910;
            float zCoordinate = (CM8831 << 16) | CM8830;

            //string currentCoordinate = (combined2 / (pulsesPerRevolution / threadPitch)).ToString("F2");
            currentXCoor = (xCoordinate / -(pulsesPerRevolution / threadPitch));
            currentYCoor = (yCoordinate / -(pulsesPerRevolution / threadPitch));
            currentZCoor = (zCoordinate / -(pulsesPerRevolution / threadPitch));

            //if (currentXCoor > XWorkingRange || currentYCoor> YWorkingRange || currentZCoor > ZWorkingRange)
            //{
            //    MessageBox.Show($"Something went wrong, Please restart app",
            //                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return; 
            //}

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
        }
        private void BtnHome_MouseDown(object sender, MouseEventArgs e)
        {
            OnBitMR("410");
        }

        private void BtnHome_MouseUp(object sender, MouseEventArgs e)
        {
            OffBitMR("410");
        }
        private void BtnSetPos1_MouseDown(object sender, MouseEventArgs e)
        {
            //try
            //{
            //    axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "409", 1);
            //}
            //catch (Exception ex)
            //{
            //    // Notify the user of an error
            //    MessageBox.Show($"Error writing to PLC: MR409 {ex.Message}",
            //                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void BtnSetPos1_MouseUp(object sender, MouseEventArgs e)
        {
            //try
            //{
            //    axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "409", 0);
            //}
            //catch (Exception ex)
            //{
            //    // Notify the user of an error
            //    MessageBox.Show($"Error writing to PLC: MR409 {ex.Message}",
            //                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }


        private void BtnRunPos1_Click(object sender, EventArgs e)
        {

        }

        private void BtnRunPos1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "106", 1);
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "206", 1);
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "306", 1);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error control PLC run Position Scan 1 {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRunPos1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "106", 0);
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "206", 0);
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "306", 0);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error control PLC run Position Scan 1 {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUp_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "300", 1);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: MR300 {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUp_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "300", 0);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: MR300 {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDown_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "301", 1);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: MR301 {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDown_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "301", 0);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: MR301 {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRight_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "200", 1);

            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: MR200 {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRight_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "200", 0);

            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: MR200 {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "201", 1);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: MR201 {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "201", 0);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: MR201 {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpRight_MouseDown(object sender, MouseEventArgs e)
        {

            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "300", 1);
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "200", 1);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: MR200, MR300 {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpRight_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "300", 0);
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "200", 0);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: MR200, MR300 {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnRightDown_MouseDown(object sender, MouseEventArgs e)
        {

            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "301", 1);
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "200", 1);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: MR201, MR301 {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRightDown_MouseUp(object sender, MouseEventArgs e)
        {

            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "301", 0);
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "200", 0);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: MR200, MR301 {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDownLeft_MouseDown(object sender, MouseEventArgs e)
        {

            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "301", 1);
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "201", 1);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: MR201, MR301 {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDownLeft_MouseUp(object sender, MouseEventArgs e)
        {

            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "301", 0);
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "201", 0);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: MR201, MR301 {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLeftUp_MouseDown(object sender, MouseEventArgs e)
        {

            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "300", 1);
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "201", 1);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: MR201, MR300 {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLeftUp_MouseUp(object sender, MouseEventArgs e)
        {

            try
            {
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "300", 0);
                axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "201", 0);
            }
            catch (Exception ex)
            {
                // Notify the user of an error
                MessageBox.Show($"Error writing to PLC: MR201, MR300 {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRunScan_Click(object sender, EventArgs e)
        {
            StartRecording();
        }

        private void BtnXYDownSpeed_Click(object sender, EventArgs e)
        {
            ConnectToPLC();
        }

        private void TbZControl_MouseUp(object sender, MouseEventArgs e)
        {
            OnBitMR("110");
            OffBitMR("110");

        }

        private void TbZControl_MouseDown(object sender, MouseEventArgs e)
        {
            //OnBitMR("108");
            //OffBitMR("108");
        }

        private void PnlXYMap_Click(object sender, EventArgs e)
        {
        }

        private void BtnXYUpSpeed_Click(object sender, EventArgs e)
        {
        }

        private void BtnXYUpSpeed_Click_1(object sender, EventArgs e)
        {
        }

    }


}
