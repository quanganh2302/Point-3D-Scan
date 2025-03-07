using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCHRLibBasicRecordSample.CustomUi
{
    [DefaultEvent("_TextChange")]
    public partial class DSM_TextBox : UserControl
    {
        //Fields
        private Color borderColor = TRecordSample.ForeGroundWhite;
        private int borderSize = 2;
        private bool underlineStyle = false;
        private Color borderForcusColor = TRecordSample.orange;
        private bool isFocused = false;
        public DSM_TextBox()
        {
            InitializeComponent();
            this.BackColor = TRecordSample.CardBg;
            this.ForeColor = TRecordSample.ForeGroundWhite;
            this.Font = new Font(TRecordSample.CenturyGothic, this.Font.Size, this.Font.Style);
            this.Padding = new Padding(8);
        }
        //Events
        public event EventHandler _TextChange;



        // Properties
        [Category("DSM properties")]

        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("DSM properties")]

        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("DSM properties")]

        public bool UnderlineStyle
        {
            get => underlineStyle;
            set
            {
                underlineStyle = value;
                this.Invalidate();
            }
        }

        [Category("DSM properties")]
        public bool PasswordChar
        {
            get => textBox1.UseSystemPasswordChar;
            set => textBox1.UseSystemPasswordChar = value;

        }

        [Category("DSM properties")]

        public bool Multiline
        {
            get => textBox1.Multiline;
            set => textBox1.Multiline = value;
        }
        [Category("DSM properties")]

        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
                this.Invalidate();

            }
        }
        [Category("DSM properties")]

        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
                this.Invalidate();

            }
        }
        [Category("DSM properties")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }
        [Category("DSM properties")]

        public override string Text { get => textBox1.Text; set => textBox1.Text = value; }
        [Category("DSM properties")]

        public Color BorderForcusColor { get => borderForcusColor; set => borderForcusColor = value; }


        // Overridden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            // Draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (!isFocused)
                {
                    if (underlineStyle)
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
                else
                {
                    penBorder.Color = borderForcusColor;
                    if (underlineStyle)
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }

            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChange != null)
                _TextChange.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {

            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }
    }
}
