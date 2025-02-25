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
        private TRecordSample _tRecordSample;

        public UC_AdvanceSetting()
        {
            InitializeComponent();
            // Optional: Set up other initialization here.
            this.BackColor = TRecordSample.CardBg;
            this.ForeColor = TRecordSample.ForeGroundWhite;
            panel1.BackColor = TRecordSample.MainBg;
            InSR.Text = "2000";
            InSS.Text = "83, 65, 66";
            InSC.Text = "10000";
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

            //if (SystemInformation.WorkingArea.Width < 1600)
            //{
            //    PnlSettingGrid.Padding = new Padding(36, MarginYScreenLg, 24, MarginYScreenLg);
            //}
            //else
            //{
            //    PnlSettingGrid.Padding = new Padding(36, MarginYScreenXl, 24, MarginYScreenXl);

            //}

        }

    }
}
