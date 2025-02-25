using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Design;

namespace TCHRLibBasicRecordSample.CustomUi.TabControl
{
    class DSM_ComboBox : UserControl
    {

        // Fields
        private Color backColor = TRecordSample.BtnDefaultBg;
        private Color iconColor = TRecordSample.ForeGroundWhite;
        private Color listBackColor = TRecordSample.BtnChildBg;
        private Color listTextColor = TRecordSample.ForeGroundWhite;
        private Color borderColor = TRecordSample.ForeGroundWhite;
        private int dropDownHeight = 200;
        private int dropDownWidth = 200;


        private int borderSize = 1;

        // Items
        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;

        //Appearance
        //-> Appearance
        [Category("DSM Appearance")]
        public new Color BackColor
        {
            get => backColor;
            set
            {
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
                backColor = value;
            }
        }
        [Category("DSM Appearance")]
        public Color IconColor
        {
            get => iconColor;
            set
            {
                iconColor = value;
                btnIcon.Invalidate(); //Redraw icon
            }
        }
        [Category("DSM Appearance")]
        public Color ListBackColor
        {
            get => listBackColor;
            set
            {
                listBackColor = value;
                cmbList.BackColor = listBackColor;
            }
        }
        [Category("DSM Appearance")]
        public Color ListTextColor
        {
            get => listTextColor;
            set
            {
                listTextColor = value;
                cmbList.ForeColor = listTextColor;
            }
        }
        [Category("DSM Appearance")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {

                borderColor = value;
                base.BackColor = borderColor;
            }
        }
        [Category("DSM Appearance")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);
                AdjustComboBoxDimensions();
            }
        }
        [Category("DSM Appearance")]
        public int DropDownHeight
        {
            get => dropDownHeight;
            set
            {
                dropDownHeight = value;
            }
        }
        [Category("DSM Appearance")]
        public int DropDownWidth
        {
            get => dropDownWidth;
            set
            {
                dropDownWidth = value;
            }
        }
        [Category("DSM Appearance")]
        public override Color ForeColor { get => base.ForeColor; set { base.ForeColor = value; lblText.ForeColor = value; } }
        [Category("DSM Appearance")]
        public override Font Font { get => base.Font; set { base.Font = value; lblText.Font = value; cmbList.Font = value; } }

        public string Texts
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        [Category("DSM Appearance")]
        public ComboBoxStyle DropDownStyle
        {
            get { return cmbList.DropDownStyle; }
            set
            {
                if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }
        //-> Data
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]

        [Category("DSM Data")]
        public ComboBox.ObjectCollection Items
        {
            get { return cmbList.Items; }

        }
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]

        [Category("DSM Data")]
        public object DataSource
        {
            get { return cmbList.DataSource; }
            set { cmbList.DataSource = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]

        [Category("DSM Data")]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return cmbList.AutoCompleteCustomSource; }
            set { cmbList.AutoCompleteCustomSource = value; }
        }

        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]

        [Category("DSM Data")]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return cmbList.AutoCompleteSource; }
            set { cmbList.AutoCompleteSource = value; }
        }

        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]

        [Category("DSM Data")]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return cmbList.AutoCompleteMode; }
            set { cmbList.AutoCompleteMode = value; }
        }
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        [Category("DSM Data")]
        public object SelectedItem
        {
            get { return cmbList.SelectedItem; }
            set { cmbList.SelectedItem = value; }
        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        [Category("DSM Data")]
        public int SelectedIndex
        {
            get { return cmbList.SelectedIndex; }
            set { cmbList.SelectedIndex = value; }
        }
        //Event
        public event EventHandler OnSelectedIndexChange; // Default event

        //Constructor
        public DSM_ComboBox()
        {

            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();


            //ComboBox: Dropdown list
            cmbList.Visible = false;
            cmbList.BackColor = listBackColor;
            cmbList.Font = new Font(TRecordSample.CenturyGothic, 10F, FontStyle.Bold);
            cmbList.ForeColor = listTextColor;
            cmbList.Dock = DockStyle.Fill;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged); //DefaultEvent
            cmbList.TextChanged += new EventHandler(ComboBox_TextChange);
            cmbList.DropDownHeight = dropDownHeight;
            cmbList.DropDownWidth = dropDownWidth;
            //cmbList.DrawMode = DrawMode.OwnerDrawVariable;
     //       cmbList.DrawItem +=
     //new DrawItemEventHandler(ComboBox_DrawItem);
     //       cmbList.MeasureItem +=
     //           new MeasureItemEventHandler(ComboBox_MeasureItem);

            //Button Icon
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click);
            btnIcon.Paint += new PaintEventHandler(Icon_Paint); // Draw Icon
            if (SystemInformation.WorkingArea.Width < 1900)
            {
                btnIcon.Size = new Size(32, 30);
            }
            else
            {
                btnIcon.Size = new Size(46, 30);
            }

            //Label: Text
            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            if (SystemInformation.WorkingArea.Width < 1900)
            {
                lblText.Padding = new Padding(12, 0, 0, 0);
            }
            else
            {
                lblText.Padding = new Padding(16, 0, 0, 0);
            }
            lblText.Font = new Font(TRecordSample.CenturyGothic, 10F, FontStyle.Bold);
            //-> Attach label events to user control event
            lblText.Click += new EventHandler(Surface_Click); //Select combo box
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblText.MouseEnter += new EventHandler(Surface_MouseLeave);


            // User Control
            this.Controls.Add(lblText); //2
            this.Controls.Add(btnIcon); //1
            this.Controls.Add(cmbList); //0
            this.MinimumSize = new Size(40, 26);
            this.Size = new Size(200, 59);
            this.ForeColor = TRecordSample.ForeGroundWhite;
            this.Padding = new Padding(borderSize); // Border Size
            base.BackColor = listBackColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        //Private methods
        private void AdjustComboBoxDimensions()
        {
            cmbList.Width = lblText.Width;
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }

        // Event Methods
        //-> Default Even
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChange != null)
                OnSelectedIndexChange.Invoke(sender, e);
            // Refresh text
            lblText.Text = cmbList.Text;
        }



        // -> Draw icon
        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            //Fields
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidth) / 2, (btnIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;

            // Draw arrow down icon
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }


        private void ComboBox_TextChange(object sender, EventArgs e)
        {
            // Refresh text 
            lblText.Text = cmbList.Text;
        }

        // -> Items actions
        private void Icon_Click(object sender, EventArgs e)
        {
            // Open dropdown list
            cmbList.Select();
            cmbList.DroppedDown = true;
        }
        private void Surface_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            // Select combo box
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true; // Open dropdown list
        }
        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        // Overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }


        private void ComboBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0) return;
            switch (e.Index)
            {
                case 0:
                    e.ItemHeight = this.Height;
                    break;
                case 1:
                    e.ItemHeight = this.Height;
                    break;
                case 2:
                    e.ItemHeight = this.Height;
                    break;
                default:
                    e.ItemHeight = this.Height;
                    break;
            }
            Console.WriteLine("checking");
            //e.ItemHeight = this.Height;
            //e.ItemWidth = this.Width;
            //cmbList.DropDownHeight = 
        }

        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            //if (e.Index < 0) return;

            //float size = 0;
            //FontFamily family = FontFamily.GenericSansSerif;
            //Color itemColor;

            //switch (e.Index)
            //{
            //    case 0:
            //        size = 30;
            //        itemColor = TRecordSample.ForeGroundWhite;
            //        break;
            //    case 1:
            //        size = 10;
            //        itemColor = TRecordSample.ForeGroundWhite;
            //        family = FontFamily.GenericMonospace;
            //        break;
            //    case 2:
            //        size = 15;
            //        itemColor = TRecordSample.ForeGroundWhite;
            //        break;
            //    default:
            //        size = this.Font.Size;
            //        itemColor = TRecordSample.ForeGroundWhite;
            //        break;
            //}

            e.DrawBackground();

            //Rectangle rect = new Rectangle(2, e.Bounds.Top + 2, e.Bounds.Height, e.Bounds.Height - 4);
            //using (SolidBrush brush = new SolidBrush(itemColor))
            //{
            //    e.Graphics.FillRectangle(brush, rect);
            //}

            //using (Font itemFont = new Font(TRecordSample.CenturyGothic, size, FontStyle.Bold))
            //{
            //    RectangleF textRect = new RectangleF(
            //        e.Bounds.X + rect.Width,
            //        e.Bounds.Y,
            //        e.Bounds.Width - rect.Width,
            //        e.Bounds.Height);
            //    e.Graphics.DrawString(cmbList.Items[e.Index].ToString(), itemFont, Brushes.Black, this.Width, this.Height);
            //}
            this.ForeColor = TRecordSample.ForeGroundWhite;
            e.DrawFocusRectangle();
        }



    }
}
