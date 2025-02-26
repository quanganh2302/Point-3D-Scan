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
        // Custom EventArgs to pass point coordinates.
        public class PointChangedEventArgs : EventArgs
        {
            public int X { get; }
            public int Y { get; }
            public PointChangedEventArgs(int x, int y)
            {
                X = x;
                Y = y;
            }
        }


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
        private int pointX = 0;
        private int pointY = 0;


        private Color backGroundColor = TRecordSample.BorderBtn;
        private Color borderColor = Color.SlateBlue;
        private Color lineColor = Color.White;
        private Color mainLineColor = Color.White;
        private Color pointColor = Color.Orange;

        // Dragging fields
        private bool isDragging = false;
        private Point dragOffset;

        private Timer gridTimer;
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
        [Category("DSM Properties")]

        public int PointX
        {
            get => pointX; set
            {
                pointX = value;
                this.Invalidate();
            }
        }
        [Category("DSM Properties")]

        public int PointY
        {
            get => pointY;
            set
            {
                pointY = value;
                this.Invalidate();
            }
        }
        // Define the event
        public event EventHandler<PointChangedEventArgs> PointChanged;
        // Contructor
        public DSM_GridMap()
        {
            this.DoubleBuffered = true; // Helps reduce flicker
            this.Click += DSM_GridMap_Click;
            this.MouseDown += DSM_GridMap_MouseDown;
            this.MouseMove += DSM_GridMap_MouseMove;
            this.MouseUp += DSM_GridMap_MouseUp;
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

        // Override OnPaintBackground to ensure full background clear
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Clear entire background with the set BackGroundColor.
            pevent.Graphics.Clear(backGroundColor);
        }



        // MouseDown: Begin dragging if the click is inside the point.
        private void DSM_GridMap_MouseDown(object sender, MouseEventArgs e)
        {
            // Determine if the mouse is within the point's area.
            Rectangle pointRect = new Rectangle(pointX - pointSize / 2, pointY - pointSize / 2, pointSize, pointSize);
            if (pointRect.Contains(e.Location))
            {
                isDragging = true;
                dragOffset = new Point(e.X - pointX, e.Y - pointY);
            }
        }
        // MouseMove: If dragging, update the point's position.
        private void DSM_GridMap_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Save the old point's rectangle.
                Rectangle oldRect = new Rectangle(pointX - pointSize / 2, pointY - pointSize / 2, pointSize, pointSize);

                // Calculate the new center using the stored drag offset.
                int newPointX = e.X - dragOffset.X;
                int newPointY = e.Y - dragOffset.Y;

                // Constrain the new position so the point stays completely within the control.
                newPointX = Math.Max(pointSize / 2, Math.Min(newPointX, this.Width - pointSize / 2));
                newPointY = Math.Max(pointSize / 2, Math.Min(newPointY, this.Height - pointSize / 2));

                pointX = newPointX;
                pointY = newPointY;

                // Get the new point rectangle.
                Rectangle newRect = new Rectangle(pointX - pointSize / 2, pointY - pointSize / 2, pointSize, pointSize);
                // Invalidate only the union of old and new rectangles (inflated slightly to avoid artifacts).
                Rectangle invalidRect = Rectangle.Union(oldRect, newRect);
                invalidRect.Inflate(2, 2);
                Invalidate(invalidRect);
            }
            else
            {
                // Update the cursor to a hand (pointer) if the mouse is over the point,
                // otherwise revert to the default cursor.
                Rectangle pointRect = new Rectangle(pointX - pointSize / 2, pointY - pointSize / 2, pointSize, pointSize);
                this.Cursor = pointRect.Contains(e.Location) ? Cursors.Hand : Cursors.Default;
            }
        }
        // MouseUp: Stop dragging.
        private void DSM_GridMap_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void DSM_GridMap_Click(object sender, EventArgs e)
        {
            Point mousePosition = this.PointToClient(Cursor.Position);
            //MessageBox.Show($"Mouse Position Relative to Form: X={mousePosition.X}, Y={mousePosition.Y}");
        }

        // Method

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            int width = this.Width;
            int height = this.Height;

            // Draw grid lines.
            using (Pen gridPen = new Pen(lineColor, 1))
            {
                Point origin = new Point(width / 2, height / 2);
                for (int i = 0; i < Math.Max(width, height); i += gridSize)
                {
                    if (i < width)
                    {
                        e.Graphics.DrawLine(gridPen, origin.X + i, 0, origin.X + i, height);
                        e.Graphics.DrawLine(gridPen, origin.X - i, 0, origin.X - i, height);
                    }
                    if (i < height)
                    {
                        e.Graphics.DrawLine(gridPen, 0, origin.Y + i, width, origin.Y + i);
                        e.Graphics.DrawLine(gridPen, 0, origin.Y - i, width, origin.Y - i);
                    }
                }
            }

            // Draw a thicker border around the control.
            using (Pen penBorder = new Pen(borderColor, 4))
            {
                e.Graphics.DrawRectangle(penBorder, 0, 0, width - 1, height - 1);
            }

            // Draw the draggable point as a bordered circle with a plus sign.
            Rectangle pointCircle = new Rectangle(pointX - pointSize / 2, pointY - pointSize / 2, pointSize, pointSize);
            // Draw the circle border.
            using (Pen circlePen = new Pen(pointColor, 2))
            {
                e.Graphics.DrawEllipse(circlePen, pointCircle);
            }

            // Determine the length of the plus sign lines (e.g. 60% of the point size)
            int plusLength = (int)(pointSize);
            int halfPlus = plusLength / 2;
            Point center = new Point(pointX, pointY);

            // Draw the plus sign using two perpendicular lines.
            using (Pen plusPen = new Pen(pointColor, 2))
            {
                // Horizontal line.
                e.Graphics.DrawLine(plusPen, center.X - halfPlus, center.Y, center.X + halfPlus, center.Y);
                // Vertical line.
                e.Graphics.DrawLine(plusPen, center.X, center.Y - halfPlus, center.X, center.Y + halfPlus);
            }
        }
    }
}