
namespace TCHRLibBasicRecordSample.CustomUi.TabControl
{
    partial class UC_DefaultSetting
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
            this.LbConnect = new System.Windows.Forms.Label();
            this.PnlListRb = new System.Windows.Forms.Panel();
            this.InConnect = new TCHRLibBasicRecordSample.CustomUi.DSM_TextBox();
            this.BtnConnect = new TCHRLibBasicRecordSample.CustomUi.DSM_Button();
            this.RbCHR1 = new TCHRLibBasicRecordSample.CustomUi.DSM_RadioButton();
            this.RbCHR2 = new TCHRLibBasicRecordSample.CustomUi.DSM_RadioButton();
            this.RbCLS = new TCHRLibBasicRecordSample.CustomUi.DSM_RadioButton();
            this.RbCHRC = new TCHRLibBasicRecordSample.CustomUi.DSM_RadioButton();
            this.PnlMainGrid.SuspendLayout();
            this.PnlContentGrid.SuspendLayout();
            this.PnlCol1.SuspendLayout();
            this.PnlListRb.SuspendLayout();
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
            this.PnlMainGrid.TabIndex = 10;
            // 
            // PnlContentGrid
            // 
            this.PnlContentGrid.ColumnCount = 4;
            this.PnlContentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlContentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlContentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlContentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PnlContentGrid.Controls.Add(this.PnlCol1, 0, 0);
            this.PnlContentGrid.Controls.Add(this.PnlListRb, 3, 0);
            this.PnlContentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContentGrid.Location = new System.Drawing.Point(0, 1);
            this.PnlContentGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PnlContentGrid.Name = "PnlContentGrid";
            this.PnlContentGrid.RowCount = 1;
            this.PnlContentGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlContentGrid.Size = new System.Drawing.Size(900, 66);
            this.PnlContentGrid.TabIndex = 13;
            // 
            // PnlCol1
            // 
            this.PnlCol1.ColumnCount = 3;
            this.PnlCol1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.95786F));
            this.PnlCol1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.04214F));
            this.PnlCol1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.PnlCol1.Controls.Add(this.LbConnect, 0, 0);
            this.PnlCol1.Controls.Add(this.InConnect, 1, 0);
            this.PnlCol1.Controls.Add(this.BtnConnect, 2, 0);
            this.PnlCol1.Location = new System.Drawing.Point(3, 3);
            this.PnlCol1.Name = "PnlCol1";
            this.PnlCol1.RowCount = 1;
            this.PnlCol1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlCol1.Size = new System.Drawing.Size(378, 60);
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
            this.LbConnect.Size = new System.Drawing.Size(139, 60);
            this.LbConnect.TabIndex = 2;
            this.LbConnect.Text = "Connection info";
            this.LbConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlListRb
            // 
            this.PnlListRb.Controls.Add(this.RbCHR1);
            this.PnlListRb.Controls.Add(this.RbCHR2);
            this.PnlListRb.Controls.Add(this.RbCLS);
            this.PnlListRb.Controls.Add(this.RbCHRC);
            this.PnlListRb.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlListRb.Location = new System.Drawing.Point(385, 3);
            this.PnlListRb.Name = "PnlListRb";
            this.PnlListRb.Size = new System.Drawing.Size(282, 60);
            this.PnlListRb.TabIndex = 11;
            // 
            // InConnect
            // 
            this.InConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.InConnect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.InConnect.BorderForcusColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.InConnect.BorderSize = 1;
            this.InConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.InConnect.Location = new System.Drawing.Point(141, 12);
            this.InConnect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InConnect.Multiline = false;
            this.InConnect.Name = "InConnect";
            this.InConnect.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.InConnect.PasswordChar = false;
            this.InConnect.Size = new System.Drawing.Size(130, 36);
            this.InConnect.TabIndex = 7;
            this.InConnect.UnderlineStyle = false;
            this.InConnect._TextChange += new System.EventHandler(this.InConnect__TextChange);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnConnect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.BtnConnect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnConnect.BorderRadius = 8;
            this.BtnConnect.BorderSize = 1;
            this.BtnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConnect.FlatAppearance.BorderSize = 0;
            this.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnect.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnConnect.Location = new System.Drawing.Point(277, 12);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(97, 36);
            this.BtnConnect.TabIndex = 8;
            this.BtnConnect.Text = "Disconnect";
            this.BtnConnect.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.BtnConnect.UseVisualStyleBackColor = false;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // RbCHR1
            // 
            this.RbCHR1.AutoSize = true;
            this.RbCHR1.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.RbCHR1.Location = new System.Drawing.Point(81, 30);
            this.RbCHR1.MinimumSize = new System.Drawing.Size(0, 21);
            this.RbCHR1.Name = "RbCHR1";
            this.RbCHR1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RbCHR1.Size = new System.Drawing.Size(181, 23);
            this.RbCHR1.TabIndex = 0;
            this.RbCHR1.TabStop = true;
            this.RbCHR1.Text = "First Generation CHR";
            this.RbCHR1.UnCheckedColor = System.Drawing.Color.Gray;
            this.RbCHR1.UseVisualStyleBackColor = true;
            // 
            // RbCHR2
            // 
            this.RbCHR2.AutoSize = true;
            this.RbCHR2.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.RbCHR2.Location = new System.Drawing.Point(3, 30);
            this.RbCHR2.MinimumSize = new System.Drawing.Size(0, 21);
            this.RbCHR2.Name = "RbCHR2";
            this.RbCHR2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RbCHR2.Size = new System.Drawing.Size(75, 23);
            this.RbCHR2.TabIndex = 0;
            this.RbCHR2.TabStop = true;
            this.RbCHR2.Text = "CHR²";
            this.RbCHR2.UnCheckedColor = System.Drawing.Color.Gray;
            this.RbCHR2.UseVisualStyleBackColor = true;
            // 
            // RbCLS
            // 
            this.RbCLS.AutoSize = true;
            this.RbCLS.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.RbCLS.Location = new System.Drawing.Point(81, 3);
            this.RbCLS.MinimumSize = new System.Drawing.Size(0, 21);
            this.RbCLS.Name = "RbCLS";
            this.RbCLS.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RbCLS.Size = new System.Drawing.Size(172, 23);
            this.RbCLS.TabIndex = 0;
            this.RbCLS.TabStop = true;
            this.RbCLS.Text = "Multi-Channel CHR";
            this.RbCLS.UnCheckedColor = System.Drawing.Color.Gray;
            this.RbCLS.UseVisualStyleBackColor = true;
            // 
            // RbCHRC
            // 
            this.RbCHRC.AutoSize = true;
            this.RbCHRC.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.RbCHRC.Location = new System.Drawing.Point(3, 3);
            this.RbCHRC.MinimumSize = new System.Drawing.Size(0, 21);
            this.RbCHRC.Name = "RbCHRC";
            this.RbCHRC.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RbCHRC.Size = new System.Drawing.Size(85, 23);
            this.RbCHRC.TabIndex = 0;
            this.RbCHRC.TabStop = true;
            this.RbCHRC.Text = "CHR C";
            this.RbCHRC.UnCheckedColor = System.Drawing.Color.Gray;
            this.RbCHRC.UseVisualStyleBackColor = true;
            // 
            // UC_DefaultSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.PnlMainGrid);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_DefaultSetting";
            this.Size = new System.Drawing.Size(900, 66);
            this.PnlMainGrid.ResumeLayout(false);
            this.PnlContentGrid.ResumeLayout(false);
            this.PnlCol1.ResumeLayout(false);
            this.PnlCol1.PerformLayout();
            this.PnlListRb.ResumeLayout(false);
            this.PnlListRb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel PnlMainGrid;
        private System.Windows.Forms.TableLayoutPanel PnlContentGrid;
        private System.Windows.Forms.TableLayoutPanel PnlCol1;
        private DSM_TextBox InConnect;
        private System.Windows.Forms.Label LbConnect;
        private DSM_Button BtnConnect;
        private System.Windows.Forms.Panel PnlListRb;
        private TCHRLibBasicRecordSample.CustomUi.DSM_RadioButton RbCHR1;
        private TCHRLibBasicRecordSample.CustomUi.DSM_RadioButton RbCHR2;
        private TCHRLibBasicRecordSample.CustomUi.DSM_RadioButton RbCLS;
        private TCHRLibBasicRecordSample.CustomUi.DSM_RadioButton RbCHRC;
    }
}
