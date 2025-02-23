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

namespace TCHRLibBasicRecordSample
{
    public partial class TRecordSample : Form
    {
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


        public static int MarginYScreenXl = 24;
        public static int MarginYScreenLg = 12;



        public static readonly FontFamily CenturyGothic = new FontFamily("Century Gothic");
        #endregion

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
            foreach(var pnl in PnlNavSetting.Controls.OfType<Panel>())
            {
                pnl.BackColor = CardBg;
            }
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "BtnDefaultSetting":
                    add_UControls(new Componets.TabControl.UC_DefaultSetting());
                    PnlDefaultSetting.BackColor = orange;
                    break;
                case "BtnAdvanceSetting":
                    add_UControls(new Componets.TabControl.UC_AdvanceSetting());
                    PnlAdvanceSetting.BackColor = orange;
                    break;
            }
        }


        CHRocodileLib.SynchronousConnection Conn;
        //record 1000 samples
        int SampleCount;
        MeasurementMode MeasuringMethod = MeasurementMode.Confocal;
        System.Int32[] SignalIDs;
        float ScanRate;

        int CurrentDataPos;
        CHRocodileLib.Data RecordData = null;

        private Timer timer;
        public TRecordSample()
        {
            InitializeComponent();
            //axDBCommManager1.Connect();
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
            add_UControls(new Componets.TabControl.UC_DefaultSetting());
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
            BtnResetSetting.BorderColor = EmergencyRed;
            LbXYCoor.ForeColor = ForeGroundWhite;
            LbZCoor.ForeColor = ForeGroundWhite;



            LbXAxisCoor.ForeColor = ForeGroundWhite;
            LbXCoorValue.ForeColor = ForeGroundWhite;
            LbYAxisCoor.ForeColor = ForeGroundWhite;
            LbYCoorValue.ForeColor = ForeGroundWhite;
            LbZAxisCoor.ForeColor = ForeGroundWhite;
            LbZCoorValue.ForeColor = ForeGroundWhite;
            if (SystemInformation.WorkingArea.Width < 1600)
            {
                PnlSettingGrid.Padding = new Padding(36, MarginYScreenLg, 24, MarginYScreenLg);
            }
            else
            {
                PnlSettingGrid.Padding = new Padding(36, MarginYScreenXl, 24, MarginYScreenXl);

            }

            // Control area
            if (SystemInformation.WorkingArea.Width < 1600)
            {
                PnlControlGrid.Padding = new Padding(36, MarginYScreenLg, 24, MarginYScreenLg);
                PnlControlGrid.ColumnStyles[1].Width = 23;
                PnlControlGrid.ColumnStyles[2].Width = 76;
                PnlControlGrid.ColumnStyles[3].Width = 1;

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
                PnlControlGrid.ColumnStyles[3].Width = 8;

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

            TbZCoor.ThumbColor = orange;
            TbZCoor.TrackColorLeft = orange;
            TbZCoor.TrackColorRight = ForeGroundWhite;
            if (SystemInformation.WorkingArea.Width < 1600)
            {
                //TbZCoor.Margin = new Padding(3, 0, 3, 3);
                PnlZControl.Padding = new Padding(0, 20, 0, 8);
                LbZAxis.Location = new Point(0);
                LbXYSpeed.Location = new Point(-4, 196);

                
            }
            else
            {
                //TbZCoor.Margin = new Padding(3, 36, 3, 3);
                PnlZControl.Padding = new Padding(0, 36, 0, 8);
                LbZAxis.Location = new Point(0);
                LbXYSpeed.Location = new Point(-4, 280);

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

            // Left site
            PnlHidden.BackColor = CardBg;

            // -> Scan area
            ImgAreaScan.BackColor = MainBg;
            PnlScanArea.BackColor = CardBg;
            if(SystemInformation.WorkingArea.Width < 1600)
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
            PnlLineChartArea.BackColor = CardBg;
            LbNameChart.ForeColor = ForeGroundBlack;
            axDBTriggerManager1.Active = true;

        }

        #region Draw Z coordiante area 


        private void PnlXYMap_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Declare the draw function
            ControlPaint.DrawBorder(g, this.PnlXYMap.ClientRectangle, ForeGroundWhite, ButtonBorderStyle.Solid);

            int width = PnlXYMap.Width; // width of area
            int height = PnlXYMap.Height; // Height of area

            Pen penBorder = new Pen(ForeGroundWhite, 4);
            g.DrawRectangle(penBorder, 0, 0, width - 1F, height - 1F);

            // Set up pens and brushes
            Pen axisPen = new Pen(ForeGroundWhite, 1); // Pen(color, width of line)
            Pen gridPen = new Pen(ForeGroundWhite, 1);

            // Origin point (center of the panel)
            Point origin = new Point(width / 2 - 1, height / 2 - 1);

            // Draw grid lines and labels
            int step = 25; // size of grid lines
            for (int i = 0; i < Math.Max(width, height); i += step)
            {
                // Vertical grid lines
                if (i < width || i != width / 2)
                {
                    g.DrawLine(gridPen, origin.X + i, 0, origin.X + i, height);
                    g.DrawLine(gridPen, origin.X - i, 0, origin.X - i, height);
                }
                // Horizontal grid lines
                if (i < height || i != height / 2)
                {
                    g.DrawLine(gridPen, 0, origin.Y - i, width, origin.Y - i);
                    g.DrawLine(gridPen, 0, origin.Y + i, width, origin.Y + i);

                }
            }
        }

        private void PnlZMap_Paint(object sender, PaintEventArgs e)
        {


            Graphics g = e.Graphics; // Declare the draw function
            ControlPaint.DrawBorder(g, this.PnlZMap.ClientRectangle, ForeGroundWhite, ButtonBorderStyle.Solid);


            int width = PnlZMap.Width; // width of area
            int height = PnlZMap.Height; // Height of area

            Pen penBorder = new Pen(ForeGroundWhite, 4);
            g.DrawRectangle(penBorder, 0, 0, width - 2F, height - 2F);

            // Set up pens and brushes
            Pen axisPen = new Pen(ForeGroundWhite, 1); // Pen(color, width of line)
            Pen gridPen = new Pen(ForeGroundWhite, 1);

            // Origin point (center of the panel)
            Point origin = new Point(width / 2 - 1, height / 2 - 1);

            // Draw grid lines and labels
            int step = 20; // size of grid lines
            for (int i = 0; i < Math.Max(width, height); i += step)
            {
                // Vertical grid lines
                if (i < width || i != width / 2)
                {
                    g.DrawLine(gridPen, origin.X + i, 0, origin.X + i, height);
                    g.DrawLine(gridPen, origin.X - i, 0, origin.X - i, height);
                }
                // Horizontal grid lines
                if (i < height || i != height / 2)
                {
                    g.DrawLine(gridPen, 0, origin.Y - i, width , origin.Y - i);
                    g.DrawLine(gridPen, 0, origin.Y + i, width, origin.Y + i);

                }
            }
            // Draw axes
            //g.DrawLine(axisPen, origin.X, 10, origin.X, height - 10); // Y-axis

            //limitHome.Position = new Point(origin.X - 8, origin.Y - (int)(height * 0.45) - 15);
            //limitNe.Position = new Point(origin.X - 8, origin.Y + (int)(height * 0.45) - 5);

            // distance move display is 95% of Height 
            int distance = (int)(height * 0.95 - 5);
            // percent of distance move to total lenght
            //int percent = (int)(distanceMove / distanceLimtit * 100);
            //// Set limit display position value
            //if (percent < 1)
            //{
            //    percent = 0;
            //}
            //else if (percent > 100)
            //{
            //    percent = 100;
            //}
            //currentPos.Position = new Point(origin.X - 8, percent * distance / 100);
            //currentCoor.Location = new Point(origin.X + 10, percent * distance / 100);
        }

        //private void BlinkTimer_Tick(object sender, EventArgs e)
        //{
        //    isButtonVisible = !isButtonVisible;
        //    currentPos.Visible = isButtonVisible;
        //}

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
            ImgAreaScan.Image = RawDataToBitmapRGB(256, 65, 66, 512, 512);
        }
        public void BtConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("checking");
            bool bConnect = false;
            //connect to device
            if (sender == BtConnect)
            {
                try
                {
                    var DeviceType = CHRocodileLib.DeviceType.Chr1;
                    if (RBCHR2.Checked)
                        DeviceType = CHRocodileLib.DeviceType.Chr2;
                    else if (RBCLS.Checked)
                        DeviceType = CHRocodileLib.DeviceType.MultiChannel;
                    else if (RBCHRC.Checked)
                        DeviceType = CHRocodileLib.DeviceType.ChrCMini;
                    string strConInfo = TbConInfo.Text;
                    Conn = new CHRocodileLib.SynchronousConnection(strConInfo, DeviceType);
                    //set up device
                    SetupDevice();
                    bConnect = true;
                    //labelRecordingHint.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //close connection to device
            else
            {
                StopRecording();
                Conn.Close();
                Conn = null;
            }
            EnableGui(bConnect);

        }


        private void SetupDevice()
        {
            //default signals are: Sample counter, peak 1 value, peak 1 quality/intensity
            //signal definition for CLS device, only 16bit integer signal for peak signal
            if (RBCLS.Checked)
                SignalIDs = new int[] { 83, 16640, 16641 };
            //other devices, float values are ordered
            else
                SignalIDs = new int[] { 65, 66, 256 };
            //Update TextBox
            TBSODX.Text = String.Join(",", SignalIDs.Select(p => p.ToString()).ToArray());
            ScanRate = 4000;
            //CLS device, normally maximum scan rate ist 2000
            //ScanRate = 2000;
            TBSHZ.Text = ScanRate.ToString();
            if (!RBCLS.Checked && !RBCHRC.Checked)
            {
                //set up measuring method (confocal or interferometric)
                SetUpMeasuringMethod();
            }
            SetUpMeasuringMethod();
            SetUpScanrate();
            SetUpOutputSignals();
        }

        private void SetUpMeasuringMethod()
        {
            try
            {
                MeasurementMode nMMD = MeasurementMode.Confocal;
                if (RBInterfero.Checked)
                    nMMD = MeasurementMode.Interferometric;
                var oRsp = Conn.Exec(CHRocodileLib.CmdID.MeasuringMethod, nMMD);
                MeasuringMethod = (MeasurementMode)oRsp.GetParam<int>(0);
            }
            catch
            {
                Debug.Fail("Cannot set measuring method");
            }
            if (MeasuringMethod == MeasurementMode.Confocal)
                RBConfocal.Checked = true;
            else
                RBInterfero.Checked = true;
        }

        private void SetUpOutputSignals()
        {
            try
            {
                //Set device output signals
                char[] delimiters = new char[] { ' ', ',', ';' };
                int[] signals = TBSODX.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).ToArray();
                var oRsp = Conn.Exec(CHRocodileLib.CmdID.OutputSignals, signals);
                SignalIDs = oRsp.GetParam<int[]>(0);
            }
            catch
            {
                Debug.Fail("Cannot set output signals");
            }
            TBSODX.Text = String.Join(",", SignalIDs.Select(p => p.ToString()).ToArray());
        }

        private void SetUpScanrate()
        {
            try
            {
                float nSHZ = float.Parse(TBSHZ.Text);
                var oRsp = Conn.Exec(CHRocodileLib.CmdID.ScanRate, nSHZ);
                ScanRate = oRsp.GetParam<float>(0);
            }
            catch
            {
                Debug.Fail("Cannot set scan rate");
            }
            TBSHZ.Text = ScanRate.ToString();
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
            RBConfocal.Enabled = _bEnabled && (RBCHR1.Checked || RBCHR2.Checked);
            RBInterfero.Enabled = _bEnabled && (RBCHR1.Checked || RBCHR2.Checked);
            TBSHZ.Enabled = _bEnabled;
            TBSODX.Enabled = _bEnabled;
        }

        private void RBConfocal_Click(object sender, EventArgs e)
        {
            SetUpMeasuringMethod();
        }

        private void TBSHZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                SetUpScanrate();
        }

        private void TBSODX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                SetUpOutputSignals();
        }

        private void StartRecording()
        {
            axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "401", 1);
            StartTimer();
            //labelRecordingHint.Visible = false;
            //throw away the old data
            if (CBFlush.Checked)
                Conn.FlushConnectionBuffer();
            //recording sample count
            SampleCount = int.Parse(TBSampleCount.Text);
            //start recording, enter recording modes
            Conn.StartRecording(SampleCount);
            initDataChart();
            CurrentDataPos = 0;
            timerData.Enabled= true;
            EnableSetting(false);
            BtRecord.Text = "Stop Recording";
            BtRecord.Tag = 1;
            BtSave.Enabled = false;
            recordedPoints.Clear();
        }


        private void initDataChart()
        {
            //chart1.Series[0].Points.Clear();
            //chart2.Series[0].Points.Clear();
            //chart3.Series[0].Points.Clear();
            //for (int i = 0; i < SampleCount; i++)
            //{
            //    chart1.Series[0].Points.AddY(0);
            //    chart2.Series[0].Points.AddY(0);
            //    chart3.Series[0].Points.AddY(0);
            //}
        }


        private void StopRecording() 
        {
            timerData.Enabled = false;
            //stop recording, get recorded data buffer/object
            RecordData = Conn.StopRecording();
            axDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "402", 1);
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
                    //chart1.Series[0].Points[CurrentDataPos].YValues[0] = Double.IsNaN(aData[0]) ? 0 : aData[0];
                    //chart2.Series[0].Points[CurrentDataPos].YValues[0] = Double.IsNaN(aData[1]) ? 0 : aData[1];
                    //chart3.Series[0].Points[CurrentDataPos].YValues[0] = Double.IsNaN(aData[2]) ? 0 : aData[2];
                    double signalXValue = (Double.IsNaN(aData[0]) ? 0 : aData[0]);
                    double signalYValue = Double.IsNaN(aData[1]) ? 0 : aData[1];
                    double signalZValue = Double.IsNaN(aData[2]) ? 0 : aData[2];
                    recordedPoints.Add(new Point3D(signalXValue, signalYValue, signalZValue));
                    CurrentDataPos++;                   
                }
                //chart1.ChartAreas[0].RecalculateAxesScale();
                //chart1.Invalidate();
                //chart2.ChartAreas[0].RecalculateAxesScale();
                //chart2.Invalidate();
                //chart3.ChartAreas[0].RecalculateAxesScale();
                //chart3.Invalidate();
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
                    for (int j=0; j<nSigCount; j++)
                    {
                        if (j < RecordData.Info.SignalGenInfo.GlobalSignalCount)
                            sb.Append(s.Get(j)+", ");
                        else
                        {
                            for (int k=0; k< RecordData.Info.SignalGenInfo.ChannelCount; k++)
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
", headerSize, imgWidth, imgHeight, xLength /2 , yLength /2, numVoid);

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
            if (imgWidth <= 0 ||  imgHeight <= 0)
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

    }


}
