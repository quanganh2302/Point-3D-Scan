
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
            this.PnlCol1 = new System.Windows.Forms.TableLayoutPanel();
            this.LbConnect = new System.Windows.Forms.Label();
            this.InSR = new TCHRLibBasicRecordSample.Componets.DSM_TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.InSS = new TCHRLibBasicRecordSample.Componets.DSM_TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.InSC = new TCHRLibBasicRecordSample.Componets.DSM_TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlContentGrid = new System.Windows.Forms.TableLayoutPanel();
            this.PnlMainGrid.SuspendLayout();
            this.PnlCol1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.PnlContentGrid.SuspendLayout();
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
            // PnlCol1
            // 
            this.PnlCol1.ColumnCount = 2;
            this.PnlCol1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlCol1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlCol1.Controls.Add(this.InSR, 0, 0);
            this.PnlCol1.Controls.Add(this.LbConnect, 0, 0);
            this.PnlCol1.Location = new System.Drawing.Point(3, 3);
            this.PnlCol1.Name = "PnlCol1";
            this.PnlCol1.RowCount = 1;
            this.PnlCol1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlCol1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlCol1.Size = new System.Drawing.Size(196, 60);
            this.PnlCol1.TabIndex = 10;
            // 
            // LbConnect
            // 
            this.LbConnect.AutoSize = true;
            this.LbConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbConnect.Location = new System.Drawing.Point(0, 0);
            this.LbConnect.Margin = new System.Windows.Forms.Padding(0);
            this.LbConnect.Name = "LbConnect";
            this.LbConnect.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.LbConnect.Size = new System.Drawing.Size(98, 60);
            this.LbConnect.TabIndex = 2;
            this.LbConnect.Text = "Scanrate";
            this.LbConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InSR
            // 
            this.InSR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.InSR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.InSR.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.InSR.BorderSize = 1;
            this.InSR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.InSR.Location = new System.Drawing.Point(106, 13);
            this.InSR.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.InSR.Multiline = false;
            this.InSR.Name = "InSR";
            this.InSR.Padding = new System.Windows.Forms.Padding(8);
            this.InSR.PasswordChar = false;
            this.InSR.Size = new System.Drawing.Size(82, 33);
            this.InSR.TabIndex = 7;
            this.InSR.UnderlineStyle = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.InSS, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(205, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 60);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // InSS
            // 
            this.InSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InSS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.InSS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.InSS.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.InSS.BorderSize = 1;
            this.InSS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.InSS.Location = new System.Drawing.Point(108, 13);
            this.InSS.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.InSS.Multiline = false;
            this.InSS.Name = "InSS";
            this.InSS.Padding = new System.Windows.Forms.Padding(8);
            this.InSS.PasswordChar = false;
            this.InSS.Size = new System.Drawing.Size(84, 33);
            this.InSS.TabIndex = 7;
            this.InSS.UnderlineStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected Signals:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.InSC, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(411, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(193, 60);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // InSC
            // 
            this.InSC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InSC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.InSC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.InSC.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.InSC.BorderSize = 1;
            this.InSC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.InSC.Location = new System.Drawing.Point(104, 13);
            this.InSC.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.InSC.Multiline = false;
            this.InSC.Name = "InSC";
            this.InSC.Padding = new System.Windows.Forms.Padding(8);
            this.InSC.PasswordChar = false;
            this.InSC.Size = new System.Drawing.Size(81, 33);
            this.InSC.TabIndex = 7;
            this.InSC.UnderlineStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sample Count:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlContentGrid
            // 
            this.PnlContentGrid.ColumnCount = 3;
            this.PnlContentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlContentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlContentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlContentGrid.Controls.Add(this.PnlCol1, 0, 0);
            this.PnlContentGrid.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.PnlContentGrid.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.PnlContentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContentGrid.Location = new System.Drawing.Point(0, 1);
            this.PnlContentGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlContentGrid.Name = "PnlContentGrid";
            this.PnlContentGrid.RowCount = 1;
            this.PnlContentGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlContentGrid.Size = new System.Drawing.Size(900, 66);
            this.PnlContentGrid.TabIndex = 13;
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
            this.PnlCol1.ResumeLayout(false);
            this.PnlCol1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.PnlContentGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel PnlMainGrid;
        private System.Windows.Forms.TableLayoutPanel PnlCol1;
        private DSM_TextBox InSR;
        private System.Windows.Forms.Label LbConnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DSM_TextBox InSS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DSM_TextBox InSC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel PnlContentGrid;
    }
}
