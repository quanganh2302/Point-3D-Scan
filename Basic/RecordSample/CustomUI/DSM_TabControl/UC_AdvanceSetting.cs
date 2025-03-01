using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCHRLibBasicRecordSample.CustomUi.TabControl
{
    public partial class UC_AdvanceSetting : UserControl
    {
        // Declare the instance without initializing immediately.
        private string scanRate = "2000";
        private string selectedSignals = "83, 65, 66";
        private string sampleCount = "10000";


        // Declare the instance without initializing immediately.

        public string ScanRate { get => InSR.Text; set => InSR.Text = value; }
        public string SelectedSignals { get => InSS.Text; set => InSS.Text = value; }
        public string SampleCount { get => InSC.Text; set => InSC.Text = value; }


        private TRecordSample _tRecordSample;
        public event EventHandler<string> RadioButtonChanged; // Event to notify changes

        public UC_AdvanceSetting()
        {
            InitializeComponent();
            // Optional: Set up other initialization here.
            this.BackColor = TRecordSample.CardBg;
            this.ForeColor = TRecordSample.ForeGroundWhite;
            panel1.BackColor = TRecordSample.MainBg;
            InSR.Text = scanRate;
            InSS.Text = selectedSignals;
            InSC.Text = sampleCount;
            RbConfocal.Checked = true;
            if (SystemInformation.WorkingArea.Width < 1600)
            {
                PnlCol1.Width = 132;
                PnlCol2.Width = 150;
                PnlCol3.Width = 120;
                PnlCol4.Width = 205;
            }
            else
            {
                PnlCol1.Width = 165;
                PnlCol2.Width = 208;
                PnlCol3.Width = 186;
                PnlCol4.Width = 205;
            }


            RbConfocal.CheckedChanged += RadioButton_CheckedChanged;
            RbInterfero.CheckedChanged += RadioButton_CheckedChanged;

            this.Load += UC_AdvanceSetting_Load;
        }

        private void UC_AdvanceSetting_Load(object sender, EventArgs e)
        {
            // Now that the UserControl is loaded, create the TRecordSample instance.
            _tRecordSample = new TRecordSample();


            // Wire up the event handler.
            InSR.KeyPress += _tRecordSample.TBSHZ_KeyPress;
            InSS.KeyPress += _tRecordSample.TBSODX_KeyPress;
            //InSC.KeyPress += _tRecordSample.BtConnect_Click;

            RbConfocal.Click += _tRecordSample.RBConfocal_Click;
            RbInterfero.Click += _tRecordSample.RBConfocal_Click;

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                // Fire the event when a radio button is checked
                RadioButtonChanged?.Invoke(this, rb.Name);
            }
        }

        public string SelectedRadioButtonName
        {
            get
            {
                if (RbConfocal.Checked)
                    return RbConfocal.Name;
                if (RbInterfero.Checked)
                    return RbInterfero.Name;
                return string.Empty;
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
