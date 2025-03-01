using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace TCHRLibBasicRecordSample.CustomUi
{
    public class DSM_Button : Button
    {
        //Fields
        private int borderSize = 1;
        private int borderRadius = 8;
        private Color borderColor = Color.PaleVioletRed;
        private string textContent = "";

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

        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                if (value < this.Height)
                    borderRadius = value;
                else borderRadius = this.Height;
                this.Invalidate();
            }
        }
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

        public Color BackgroundColor
        {
            get => this.BackColor;
            set => this.BackColor = value;

        }
        [Category("DSM properties")]
        public Color TextColor
        {
            get => this.ForeColor;
            set => this.ForeColor = value;

        }

        [Category("DSM properties")]

        public string TextContent
        {
            get => textContent;
            set
            {
                textContent = value;
                this.Invalidate();
            }
        }

        // Contructor
        public DSM_Button()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.Cursor = Cursors.Hand;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(90, 36);
            this.BackColor = TRecordSample.BtnDefaultBg;
            this.ForeColor =  TRecordSample.ForeGroundWhite;
            this.borderColor = TRecordSample.ForeGroundWhite;
            this.Resize += new EventHandler(Button_Resize);
            this.Font = new Font(TRecordSample.CenturyGothic, this.Font.Size, FontStyle.Bold);
            this.Text = TextContent;
        }



        // Methods
        private GraphicsPath GetFigurPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.Text = TextContent;
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (borderRadius > 2) // Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurPath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurPath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    // Button surface
                    this.Region = new Region(pathSurface);
                    // Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    // Draw control border
                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                BorderRadius = this.Height;
        }
    }
}
