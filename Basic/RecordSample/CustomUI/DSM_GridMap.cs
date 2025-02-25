using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace TCHRLibBasicRecordSample.CustomUi
{
    public class DSM_GridMap : Control
    {
        // Fields
        //private int widthMap = 200;
        //private int heightMap = 200;
        private int gridSize = 25;

        private int borderSize = 2;
        private int lineSize = 1;
        private int mainLineSizeX = 2;
        private int mainLineSizeY = 2;

        private double coordinateX = 0F;
        private double coordinateY = 0F;

        private int pointSize = 20;

        private Color backGroundColor = Color.Gray;
        private Color borderColor = Color.SlateBlue;
        private Color lineColor = Color.White;
        private Color mainLineColor = Color.White;
        private Color pointColor = Color.Orange;

        //public int WidthMap 
        //{ get => widthMap; 
        //    set => 
        //        widthMap = value; 

        //}
        //public int HeightMap { get => heightMap; set => heightMap = value; }
        [Category("DSM Properties")]

        public int GridSize
        {
            get => gridSize;
            set
            {
                gridSize = value;
                Invalidate();
            }

        }
        [Category("DSM Properties")]

        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                Invalidate();
            }
        }
        [Category("DSM Properties")]

        public int LineSize
        {
            get => lineSize;
            set
            {
                lineSize = value;
                Invalidate();
            }
        }
        [Category("DSM Properties")]

        public int MainLineSizeX
        {
            get => mainLineSizeX;
            set
            {
                mainLineSizeX = value;
                Invalidate();
            }
        }
        [Category("DSM Properties")]

        public int MainLineSizeY
        {
            get => mainLineSizeY;
            set
            {
                mainLineSizeY = value;
                Invalidate();
            }
        }
        [Category("DSM Properties")]

        public double CoordinateX
        {
            get => coordinateX;
            set
            {
                coordinateX = value;
                Invalidate();
            }
        }
        [Category("DSM Properties")]

        public double CoordinateY
        {
            get => coordinateY;
            set
            {
                coordinateY = value;
                Invalidate();
            }
        }
        [Category("DSM Properties")]

        public int PointSize
        {
            get => pointSize;
            set
            {
                pointSize = value;
                Invalidate();
            }
        }
        [Category("DSM Properties")]

        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("DSM Properties")]

        public Color BackGroundColor
        {
            get => backGroundColor;
            set
            {
                backGroundColor = value;
                this.Invalidate();
            }
        }
        [Category("DSM Properties")]

        public Color LineColor
        {
            get => lineColor;
            set
            {
                lineColor = value;
                this.Invalidate();
            }
        }
        [Category("DSM Properties")]

        public Color MainLineColor
        {
            get => mainLineColor;
            set
            {
                mainLineColor = value;
                this.Invalidate();
            }
        }
        [Category("DSM Properties")]

        public Color PointColor
        {
            get => pointColor;
            set
            {
                pointColor = value;
                this.Invalidate();
            }
        }
        // Contructor
        public DSM_GridMap()
        {
            this.Size = new Size(100, 100);
            gridSize = 25;

            borderSize = 2;
            lineSize = 1;
            mainLineSizeX = 2;
            mainLineSizeY = 2;

            coordinateX = 0F;
            coordinateY = 0F;

            pointSize = 20;

            borderColor = Color.SlateBlue;
            lineColor = Color.White;
            mainLineColor = Color.White;
            pointColor = Color.Orange;
        }
        // Method

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            Graphics g = e.Graphics; // Declare the draw function
            ControlPaint.DrawBorder(g, this.ClientRectangle, borderColor, ButtonBorderStyle.Solid);

            int width = this.Width; // width of area
            int height = this.Height; // Height of area

            // Set up pens and brushes
            Pen axisPen = new Pen(mainLineColor, 1); // Pen(color, width of line)
            Pen gridPen = new Pen(lineColor, 1);

            // Origin point (center of the panel)
            Point origin = new Point(width / 2 - 1, height / 2 - 1);

            // Draw grid lines and labels
            int step = gridSize; // size of grid lines
            for (int i = 0; i < Math.Max(width, height); i += step)
            {
                // Vertical grid lines
                if (i < width || i != width / 2)
                {
                    g.DrawLine(gridPen, origin.X + i, 0, origin.X + i, height);
                    g.DrawLine(gridPen, origin.X - i, 0, origin.X - i, height);
                }
                // Horizontal grid lines
                if (i < height || i != height / 2)
                {
                    g.DrawLine(gridPen, 0, origin.Y - i, width, origin.Y - i);
                    g.DrawLine(gridPen, 0, origin.Y + i, width, origin.Y + i);

                }
            }
            Pen penBorder = new Pen(borderColor, 4);
            g.DrawRectangle(penBorder, 0, 0, width - 1F, height - 1F);

        }

    }
}
