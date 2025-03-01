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

        private string connectAddress = "192.168.170.2";
        private string contentOfBtn = "Disconnect";

        // Declare the instance without initializing immediately.
        private TRecordSample _tRecordSample;

        public string ConnectAddress
        {
            get => InConnect.Text;
            set => InConnect.Text = value;
        }

        public string ContentOfBtn
        {
            get => contentOfBtn;
            set => contentOfBtn = value;
        }

        public event EventHandler<string> RadioButtonChanged; // Event to notify changes

        public UC_DefaultSetting()
        {
            InitializeComponent();
            connectAddress = "192.168.170.2";
            contentOfBtn = "Connect";
            BtnConnect.Text = contentOfBtn;
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
            InConnect.Text = connectAddress;

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

        private void InConnect__TextChange(object sender, EventArgs e)
        {

        }
    }
}
