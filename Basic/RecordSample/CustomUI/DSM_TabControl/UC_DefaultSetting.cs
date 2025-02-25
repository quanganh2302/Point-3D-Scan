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
    public partial class UC_DefaultSetting : UserControl
    {
        // Declare the instance without initializing immediately.
        private TRecordSample _tRecordSample;
        public event EventHandler<string> RadioButtonChanged; // Event to notify changes
        public bool IsRbCHRCChecked
        {
            get { return RbCHRC.Checked; }
            set { RbCHRC.Checked = value; }
        }
        public bool IsRbCHR1Checked
        {
            get { return RbCHR1.Checked; }
            set { RbCHR1.Checked = value; }
        }

        public bool IsRbCHR2Checked
        {
            get { return RbCHR2.Checked; }
            set { RbCHR2.Checked = value; }
        }

        public bool IsRbCLSChecked
        {
            get { return RbCLS.Checked; }
            set { RbCLS.Checked = value; }
        }

        public UC_DefaultSetting()
        {
            InitializeComponent();
            // Optional: Set up other initialization here.
            this.BackColor = TRecordSample.CardBg;
            this.ForeColor = TRecordSample.ForeGroundWhite;
            panel1.BackColor = TRecordSample.MainBg;
            RbCHR1.CheckedColor = TRecordSample.orange;
            RbCHR2.CheckedColor = TRecordSample.orange;
            RbCHRC.CheckedColor = TRecordSample.orange;
            RbCLS.CheckedColor = TRecordSample.orange;
            RbCHRC.Checked = true;

            // Attach event handlers to radio buttons
            RbCHR1.CheckedChanged += RadioButton_CheckedChanged;
            RbCHR2.CheckedChanged += RadioButton_CheckedChanged;
            RbCHRC.CheckedChanged += RadioButton_CheckedChanged;
            RbCLS.CheckedChanged += RadioButton_CheckedChanged;


            this.Load += UC_DefaultSetting_Load;
        }

        private void UC_DefaultSetting_Load(object sender, EventArgs e)
        {
            // Now that the UserControl is loaded, create the TRecordSample instance.
            _tRecordSample = new TRecordSample();

            // Now you can access properties that require a valid handle.


            InConnect.Text = "192.168.170.2";

            // Wire up the event handler.
            BtnConnect.Click += _tRecordSample.BtConnect_Click;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {

        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                // Fire the event when a radio button is checked
                RadioButtonChanged?.Invoke(this, rb.Name);
            }
        }
    }
}
