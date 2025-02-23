using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCHRLibBasicRecordSample.Componets.TabControl
{
    public partial class UC_DefaultSetting : UserControl
    {
        // Declare the instance without initializing immediately.
        private TRecordSample _tRecordSample;

        public UC_DefaultSetting()
        {
            InitializeComponent();
            // Optional: Set up other initialization here.
            this.BackColor = TRecordSample.CardBg;
            this.ForeColor = TRecordSample.ForeGroundWhite;
            panel1.BackColor = TRecordSample.MainBg;
            //if (SystemInformation.WorkingArea.Width < 1600)
            //{
            //    PnlSettingGrid.Padding = new Padding(36, MarginYScreenLg, 24, MarginYScreenLg);
            //}
            //else
            //{
            //    PnlSettingGrid.Padding = new Padding(36, MarginYScreenXl, 24, MarginYScreenXl);

            //}
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

    }
}
