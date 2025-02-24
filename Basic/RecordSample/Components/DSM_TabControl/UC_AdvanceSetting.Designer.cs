
namespace TCHRLibBasicRecordSample.Componets.TabControl
{
    partial class UC_AdvanceSetting
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlMainGrid = new System.Windows.Forms.TableLayoutPanel();
            this.PnlContentGrid = new System.Windows.Forms.TableLayoutPanel();
            this.PnlCol1 = new System.Windows.Forms.TableLayoutPanel();
            this.InSR = new TCHRLibBasicRecordSample.Componets.DSM_TextBox();
            this.LbSR = new System.Windows.Forms.Label();
            this.PnlCol3 = new System.Windows.Forms.TableLayoutPanel();
            this.InSC = new TCHRLibBasicRecordSample.Componets.DSM_TextBox();
            this.LbSC = new System.Windows.Forms.Label();
            this.PnlCol2 = new System.Windows.Forms.TableLayoutPanel();
            this.InSS = new TCHRLibBasicRecordSample.Componets.DSM_TextBox();
            this.LbSS = new System.Windows.Forms.Label();
            this.PnlCol4 = new System.Windows.Forms.Panel();
            this.RbConfocal = new TCHRLibBasicRecordSample.Componets.DSM_RadioButton();
            this.RbInterfero = new TCHRLibBasicRecordSample.Componets.DSM_RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlMainGrid.SuspendLayout();
            this.PnlContentGrid.SuspendLayout();
            this.PnlCol1.SuspendLayout();
            this.PnlCol3.SuspendLayout();
            this.PnlCol2.SuspendLayout();
            this.PnlCol4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 1);
            this.panel1.TabIndex = 8;
            // 
            // PnlMainGrid
            // 
            this.PnlMainGrid.ColumnCount = 1;
            this.PnlMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMainGrid.Controls.Add(this.PnlContentGrid, 0, 1);
            this.PnlMainGrid.Controls.Add(this.panel1, 0, 0);
            this.PnlMainGrid.Location = new System.Drawing.Point(0, 0);
            this.PnlMainGrid.Name = "PnlMainGrid";
            this.PnlMainGrid.RowCount = 2;
            this.PnlMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.PnlMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.PnlMainGrid.Size = new System.Drawing.Size(900, 66);
            this.PnlMainGrid.TabIndex = 9;
            // 
            // PnlContentGrid
            // 
            this.PnlContentGrid.ColumnCount = 4;
            this.PnlContentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlContentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlContentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlContentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlContentGrid.Controls.Add(this.PnlCol1, 0, 0);
            this.PnlContentGrid.Controls.Add(this.PnlCol3, 2, 0);
            this.PnlContentGrid.Controls.Add(this.PnlCol2, 1, 0);
            this.PnlContentGrid.Controls.Add(this.PnlCol4, 3, 0);
            this.PnlContentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContentGrid.Location = new System.Drawing.Point(0, 1);
            this.PnlContentGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlContentGrid.Name = "PnlContentGrid";
            this.PnlContentGrid.Padding = new System.Windows.Forms.Padding(36, 0, 24, 0);
            this.PnlContentGrid.RowCount = 1;
            this.PnlContentGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlContentGrid.Size = new System.Drawing.Size(900, 66);
            this.PnlContentGrid.TabIndex = 13;
            // 
            // PnlCol1
            // 
            this.PnlCol1.ColumnCount = 2;
            this.PnlCol1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlCol1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlCol1.Controls.Add(this.InSR, 0, 0);
            this.PnlCol1.Controls.Add(this.LbSR, 0, 0);
            this.PnlCol1.Location = new System.Drawing.Point(39, 3);
            this.PnlCol1.Name = "PnlCol1";
            this.PnlCol1.RowCount = 1;
            this.PnlCol1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlCol1.Size = new System.Drawing.Size(165, 60);
            this.PnlCol1.TabIndex = 10;
            // 
            // InSR
            // 
            this.InSR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.InSR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.InSR.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.InSR.BorderSize = 1;
            this.InSR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.InSR.Location = new System.Drawing.Point(84, 15);
            this.InSR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InSR.Multiline = false;
            this.InSR.Name = "InSR";
            this.InSR.Padding = new System.Windows.Forms.Padding(8);
            this.InSR.PasswordChar = false;
            this.InSR.Size = new System.Drawing.Size(79, 30);
            this.InSR.TabIndex = 7;
            this.InSR.UnderlineStyle = false;
            // 
            // LbSR
            // 
            this.LbSR.AutoSize = true;
            this.LbSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbSR.Location = new System.Drawing.Point(0, 0);
            this.LbSR.Margin = new System.Windows.Forms.Padding(0);
            this.LbSR.Name = "LbSR";
            this.LbSR.Size = new System.Drawing.Size(82, 60);
            this.LbSR.TabIndex = 2;
            this.LbSR.Text = "Scanrate:";
            this.LbSR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlCol3
            // 
            this.PnlCol3.ColumnCount = 2;
            this.PnlCol3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlCol3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlCol3.Controls.Add(this.InSC, 0, 0);
            this.PnlCol3.Controls.Add(this.LbSC, 0, 0);
            this.PnlCol3.Location = new System.Drawing.Point(348, 3);
            this.PnlCol3.Name = "PnlCol3";
            this.PnlCol3.RowCount = 1;
            this.PnlCol3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlCol3.Size = new System.Drawing.Size(109, 60);
            this.PnlCol3.TabIndex = 12;
            // 
            // InSC
            // 
            this.InSC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InSC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.InSC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.InSC.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.InSC.BorderSize = 1;
            this.InSC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.InSC.Location = new System.Drawing.Point(56, 15);
            this.InSC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InSC.Multiline = false;
            this.InSC.Name = "InSC";
            this.InSC.Padding = new System.Windows.Forms.Padding(8);
            this.InSC.PasswordChar = false;
            this.InSC.Size = new System.Drawing.Size(51, 30);
            this.InSC.TabIndex = 7;
            this.InSC.UnderlineStyle = false;
            // 
            // LbSC
            // 
            this.LbSC.AutoSize = true;
            this.LbSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbSC.Location = new System.Drawing.Point(0, 0);
            this.LbSC.Margin = new System.Windows.Forms.Padding(0);
            this.LbSC.Name = "LbSC";
            this.LbSC.Size = new System.Drawing.Size(54, 60);
            this.LbSC.TabIndex = 2;
            this.LbSC.Text = "Sample Count:";
            this.LbSC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlCol2
            // 
            this.PnlCol2.ColumnCount = 2;
            this.PnlCol2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlCol2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlCol2.Controls.Add(this.InSS, 0, 0);
            this.PnlCol2.Controls.Add(this.LbSS, 0, 0);
            this.PnlCol2.Location = new System.Drawing.Point(210, 3);
            this.PnlCol2.Name = "PnlCol2";
            this.PnlCol2.RowCount = 1;
            this.PnlCol2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlCol2.Size = new System.Drawing.Size(132, 60);
            this.PnlCol2.TabIndex = 11;
            // 
            // InSS
            // 
            this.InSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InSS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.InSS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.InSS.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.InSS.BorderSize = 1;
            this.InSS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.InSS.Location = new System.Drawing.Point(68, 15);
            this.InSS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InSS.Multiline = false;
            this.InSS.Name = "InSS";
            this.InSS.Padding = new System.Windows.Forms.Padding(8);
            this.InSS.PasswordChar = false;
            this.InSS.Size = new System.Drawing.Size(62, 30);
            this.InSS.TabIndex = 7;
            this.InSS.UnderlineStyle = false;
            // 
            // LbSS
            // 
            this.LbSS.AutoSize = true;
            this.LbSS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbSS.Location = new System.Drawing.Point(0, 0);
            this.LbSS.Margin = new System.Windows.Forms.Padding(0);
            this.LbSS.Name = "LbSS";
            this.LbSS.Size = new System.Drawing.Size(66, 60);
            this.LbSS.TabIndex = 2;
            this.LbSS.Text = "Selected Signals:";
            this.LbSS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlCol4
            // 
            this.PnlCol4.Controls.Add(this.RbConfocal);
            this.PnlCol4.Controls.Add(this.RbInterfero);
            this.PnlCol4.Controls.Add(this.label3);
            this.PnlCol4.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlCol4.Location = new System.Drawing.Point(466, 3);
            this.PnlCol4.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.PnlCol4.Name = "PnlCol4";
            this.PnlCol4.Size = new System.Drawing.Size(205, 60);
            this.PnlCol4.TabIndex = 13;
            // 
            // RbConfocal
            // 
            this.RbConfocal.AutoSize = true;
            this.RbConfocal.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.RbConfocal.Location = new System.Drawing.Point(3, 30);
            this.RbConfocal.MinimumSize = new System.Drawing.Size(0, 21);
            this.RbConfocal.Name = "RbConfocal";
            this.RbConfocal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RbConfocal.Size = new System.Drawing.Size(86, 21);
            this.RbConfocal.TabIndex = 4;
            this.RbConfocal.TabStop = true;
            this.RbConfocal.Text = "Confocal";
            this.RbConfocal.UnCheckedColor = System.Drawing.Color.Gray;
            this.RbConfocal.UseVisualStyleBackColor = true;
            // 
            // RbInterfero
            // 
            this.RbInterfero.AutoSize = true;
            this.RbInterfero.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.RbInterfero.Location = new System.Drawing.Point(95, 30);
            this.RbInterfero.MinimumSize = new System.Drawing.Size(0, 21);
            this.RbInterfero.Name = "RbInterfero";
            this.RbInterfero.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RbInterfero.Size = new System.Drawing.Size(113, 21);
            this.RbInterfero.TabIndex = 3;
            this.RbInterfero.TabStop = true;
            this.RbInterfero.Text = "Interferometric";
            this.RbInterfero.UnCheckedColor = System.Drawing.Color.Gray;
            this.RbInterfero.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Measuring Methos:";
            // 
            // UC_AdvanceSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.PnlMainGrid);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_AdvanceSetting";
            this.Size = new System.Drawing.Size(900, 66);
            this.PnlMainGrid.ResumeLayout(false);
            this.PnlContentGrid.ResumeLayout(false);
            this.PnlCol1.ResumeLayout(false);
            this.PnlCol1.PerformLayout();
            this.PnlCol3.ResumeLayout(false);
            this.PnlCol3.PerformLayout();
            this.PnlCol2.ResumeLayout(false);
            this.PnlCol2.PerformLayout();
            this.PnlCol4.ResumeLayout(false);
            this.PnlCol4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel PnlMainGrid;
        private System.Windows.Forms.TableLayoutPanel PnlCol1;
        private DSM_TextBox InSR;
        private System.Windows.Forms.Label LbSR;
        private System.Windows.Forms.TableLayoutPanel PnlCol2;
        private DSM_TextBox InSS;
        private System.Windows.Forms.Label LbSS;
        private System.Windows.Forms.TableLayoutPanel PnlCol3;
        private DSM_TextBox InSC;
        private System.Windows.Forms.Label LbSC;
        private System.Windows.Forms.TableLayoutPanel PnlContentGrid;
        private System.Windows.Forms.Panel PnlCol4;
        private System.Windows.Forms.Label label3;
        private DSM_RadioButton RbInterfero;
        private DSM_RadioButton RbConfocal;
    }
}
