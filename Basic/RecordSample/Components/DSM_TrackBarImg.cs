using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TCHRLibBasicRecordSample.Componets
{
    public class DSM_TrackBarImg : Control
    {
        // Fields
        private int _value;
        private int _minimum = 0;
        private int _maximum = 100;
        private bool _isDragging = false;
        private int borderSize = 1;
        private int borderRadius = 8;
        private int thumbSizeDefault = 40;
        private Color borderColor = Color.PaleVioletRed;
        private Color borderInColor = Color.PaleVioletRed;


        public event EventHandler ValueChanged;

        [Category("DSM Properties")]
        public int MinimumPercent
        {
            get => _minimum;
            set
            {
                _minimum = value;
                Invalidate();
            }
        }
        [Category("DSM Properties")]
        public int MaximumPercent
        {
            get => _maximum;
            set
            {
                _maximum = value;
                Invalidate();
            }
        }
        public int Value
        {
            get => _value;
            set
            {
                if (_value != value)
                {
                    _value = Math.Max(_minimum, Math.Min(_maximum, value));
                    Invalidate();
                    OnValueChanged(EventArgs.Empty);
                }
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
        public int ThumbSize
        {
            get => thumbSizeDefault;
            set
            {
                thumbSizeDefault = value;
                Invalidate();
            }
        }
        [Category("DSM Properties")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                //if (value < this.Height)
                //    borderRadius = value;
                //else
                //    borderRadius = this.Height;
                borderRadius = value;
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
                Invalidate();
            }
        }
        [Category("DSM Properties")]
        public Color BorderInColor
        {
            get => borderInColor;
            set
            {
                borderInColor = value;
                Invalidate();
            }
        }
        [Category("DSM Properties")]
        public Color BackgroundColor
        {
            get => this.BackColor;
            set => this.BackColor = value;
        }
        [Category("DSM Properties")]
        public Color TrackColorLeft { get; set; } = Color.Blue;
        [Category("DSM Properties")]
        public Color TrackColorRight { get; set; } = Color.Gray;
        [Category("DSM Properties")]
        public Color ThumbColor { get; set; } = Color.Red;

        public enum TrackbarOrientation
        {
            Horizontal,
            Vertical
        }
        [Category("DSM Properties")]
        public bool VerticalReversed { get; set; } = false;
        [Category("DSM Properties")]
        public TrackbarOrientation Orientation { get; set; } = TrackbarOrientation.Horizontal;
        [Category("DSM Properties")]
        public Image ThumbImage { get; set; }
        [Category("DSM Properties")]
        public Image LimitImageStart { get; set; }
        [Category("DSM Properties")]
        public Image LimitImageEnd { get; set; }
        public DSM_TrackBarImg()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.MouseDown += CustomSlider_MouseDown;
            this.MouseMove += CustomSlider_MouseMove;
            this.MouseUp += CustomSlider_MouseUp;
            this.MouseLeave += CustomSlider_MouseLeave;

            this.Cursor = Cursors.Hand;
            this.Size = new Size(90, 36);
            this.BackColor = TRecordSample.BtnDefaultBg;
            this.ForeColor = TRecordSample.ForeGroundWhite;
            this.borderColor = TRecordSample.ForeGroundWhite;
            this.borderInColor = TRecordSample.ForeGroundWhite;
        }

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

        private bool IsOverThumb(Point location)
        {
            int thumbSize = thumbSizeDefault;
            if (Orientation == TrackbarOrientation.Horizontal)
            {
                int thumbX = (int)(((float)(Value - MinimumPercent) / (MaximumPercent - MinimumPercent)) * (Width - 20)) + 10;
                Rectangle thumbRect = new Rectangle(thumbX - thumbSize / 2, Height / 2 - thumbSize / 2, thumbSize, thumbSize);
                return thumbRect.Contains(location);
            }
            else // Vertical orientation
            {
                int margin = 10;
                int trackHeight = Height - 2 * margin;
                int thumbY;
                if (VerticalReversed)
                {
                    // Minimum at top
                    thumbY = margin + (int)(((float)(Value - MinimumPercent) / (MaximumPercent - MinimumPercent)) * trackHeight);
                }
                else
                {
                    // Minimum at bottom
                    thumbY = Height - margin - (int)(((float)(Value - MinimumPercent) / (MaximumPercent - MinimumPercent)) * trackHeight);
                }
                Rectangle thumbRect = new Rectangle(Width / 2 - thumbSize / 2, thumbY - thumbSize / 2, thumbSize, thumbSize);
                return thumbRect.Contains(location);
            }
        }

        private void CustomSlider_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = true;
                UpdateValueFromPosition(e.Location);
            }
        }
        private void CustomSlider_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                UpdateValueFromPosition(e.Location);
            }
            else
            {
                // Change cursor when hovering over the thumb
                this.Cursor = IsOverThumb(e.Location) ? Cursors.Hand : Cursors.Default;
            }
        }
        private void CustomSlider_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = false;
            }
        }
        private void CustomSlider_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void UpdateValueFromPosition(Point p)
        {
            int margin = thumbSizeDefault / 2;
            if (Orientation == TrackbarOrientation.Horizontal)
            {
                int newValue = (int)(((float)(p.X - margin) / (Width - 2 * margin)) * (MaximumPercent - MinimumPercent) + MinimumPercent);
                Value = newValue;
            }
            else // Vertical orientation
            {
                int trackHeight = Height - 2 * margin;
                int newValue;
                if (VerticalReversed)
                {
                    // Minimum at top: p.Y relative to top margin
                    newValue = (int)(((float)(p.Y - margin) / trackHeight) * (MaximumPercent - MinimumPercent) + MinimumPercent);
                }
                else
                {
                    // Minimum at bottom: invert p.Y relative to bottom margin
                    newValue = (int)(((float)(Height - p.Y - margin) / trackHeight) * (MaximumPercent - MinimumPercent) + MinimumPercent);
                }
                Value = newValue;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw control border/background (rounded)
            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);
            RectangleF rectBorder1 = new RectangleF(1 + borderSize, 1 + borderSize, this.Width - 0.8F - borderSize, this.Height - 1 - borderSize);


            if (borderRadius > 2) // Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurPath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurPath(rectBorder, borderRadius - 1F))
                using (GraphicsPath pathBorder1 = GetFigurPath(rectBorder1, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Pen penBorder1 = new Pen(borderInColor, 1))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    e.Graphics.DrawPath(penSurface, pathSurface);
                    if (borderSize >= 1)
                        e.Graphics.DrawPath(penBorder, pathBorder);
                    e.Graphics.DrawPath(penBorder1, pathBorder1);

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
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

            int thumbSize = thumbSizeDefault;
            int margin = thumbSize / 2;

            if (Orientation == TrackbarOrientation.Horizontal)
            {
                int trackWidth = Width - 2 * margin;
                int thumbX = margin + (int)(((float)(Value - MinimumPercent) / (MaximumPercent - MinimumPercent)) * trackWidth);

                // Draw left (filled) track
                Rectangle leftTrackRect = new Rectangle(margin, Height / 2 - 2, thumbX - margin, 4);
                using (Brush leftTrackBrush = new SolidBrush(TrackColorLeft))
                {
                    e.Graphics.FillRectangle(leftTrackBrush, leftTrackRect);
                }
                // Draw right (unfilled) track
                Rectangle rightTrackRect = new Rectangle(thumbX, Height / 2 - 2, Width - thumbX - margin, 4);
                using (Brush rightTrackBrush = new SolidBrush(TrackColorRight))
                {
                    e.Graphics.FillRectangle(rightTrackBrush, rightTrackRect);
                }
                // Draw thumb
                Rectangle thumbRect = new Rectangle(thumbX - thumbSize / 2, Height / 2 - thumbSize / 2, thumbSize, thumbSize);
                if (ThumbImage != null)
                {
                    e.Graphics.DrawImage(ThumbImage, thumbRect);
                }
                else
                {
                    using (Brush thumbBrush = new SolidBrush(ThumbColor))
                    {
                        e.Graphics.FillEllipse(thumbBrush, thumbRect);
                    }
                }
            }
            else // Vertical orientation
            {
                int trackHeight = Height - 2 * margin;
                int thumbY;
                if (VerticalReversed)
                {
                    // Minimum at top
                    thumbY = margin + (int)(((float)(Value - MinimumPercent) / (MaximumPercent - MinimumPercent)) * trackHeight);
                    // Draw filled track (from top to thumb)
                    Rectangle filledTrackRect = new Rectangle(Width / 2 - 2, margin, 4, thumbY - margin);
                    using (Brush filledBrush = new SolidBrush(TrackColorLeft))
                    {
                        e.Graphics.FillRectangle(filledBrush, filledTrackRect);
                    }
                    // Draw unfilled track (from thumb to bottom)
                    Rectangle unfilledTrackRect = new Rectangle(Width / 2 - 2, thumbY, 4, Height - margin - thumbY);
                    using (Brush unfilledBrush = new SolidBrush(TrackColorRight))
                    {
                        e.Graphics.FillRectangle(unfilledBrush, unfilledTrackRect);
                    }
                }
                else
                {
                    // Minimum at bottom
                    thumbY = Height - margin - (int)(((float)(Value - MinimumPercent) / (MaximumPercent - MinimumPercent)) * trackHeight);
                    // Draw filled track (from thumb to bottom)
                    Rectangle filledTrackRect = new Rectangle(Width / 2 - 2, thumbY, 4, Height - margin - thumbY);
                    using (Brush filledBrush = new SolidBrush(TrackColorLeft))
                    {
                        e.Graphics.FillRectangle(filledBrush, filledTrackRect);
                    }
                    // Draw unfilled track (from top to thumb)
                    Rectangle unfilledTrackRect = new Rectangle(Width / 2 - 2, margin, 4, thumbY - margin);
                    using (Brush unfilledBrush = new SolidBrush(TrackColorRight))
                    {
                        e.Graphics.FillRectangle(unfilledBrush, unfilledTrackRect);
                    }
                }

                // --- Draw the limit indicator images (cosmetic) ---
                // For horizontal orientation, draw one image at the left end and one at the right end.
                if (Orientation == TrackbarOrientation.Horizontal)
                {
                    // Draw left-end image (OppositeLimitImage)
                    if (LimitImageStart != null)
                    {
                        Rectangle leftImageRect = new Rectangle(
                            margin / 2,
                            (Height - LimitImageStart.Height) / 2,
                            LimitImageStart.Width,
                            LimitImageStart.Height);
                        e.Graphics.DrawImage(LimitImageStart, leftImageRect);
                    }
                    // Draw right-end image (LimitImage)
                    if (LimitImageEnd != null)
                    {
                        Rectangle rightImageRect = new Rectangle(
                            Width - LimitImageEnd.Width - margin / 2,
                            (Height - LimitImageEnd.Height) / 2,
                            LimitImageEnd.Width,
                            LimitImageEnd.Height);
                        e.Graphics.DrawImage(LimitImageEnd, rightImageRect);
                    }
                }
                else // Vertical orientation
                {
                    // In vertical mode the "ends" are the top and bottom.
                    if (VerticalReversed)
                    {
                        // For VerticalReversed: minimum is at top, maximum at bottom.
                        if (LimitImageStart != null)
                        {
                            // Draw image at the top (minimum)
                            Rectangle topImageRect = new Rectangle(
                                (Width - LimitImageStart.Width) / 2,
                                margin / 2,
                                LimitImageStart.Width,
                                LimitImageStart.Height);
                            e.Graphics.DrawImage(LimitImageStart, topImageRect);
                        }
                        if (LimitImageEnd != null)
                        {
                            // Draw image at the bottom (maximum)
                            Rectangle bottomImageRect = new Rectangle(
                                (Width - LimitImageEnd.Width) / 2,
                                Height - LimitImageEnd.Height - margin / 2,
                                LimitImageEnd.Width,
                                LimitImageEnd.Height);
                            e.Graphics.DrawImage(LimitImageEnd, bottomImageRect);
                        }
                    }
                    else
                    {
                        // For normal vertical: minimum is at bottom, maximum at top.
                        if (LimitImageStart != null)
                        {
                            // Draw image at the bottom (minimum)
                            Rectangle bottomImageRect = new Rectangle(
                                (Width - LimitImageStart.Width) / 2,
                                Height - LimitImageStart.Height - margin / 2,
                                LimitImageStart.Width,
                                LimitImageStart.Height);
                            e.Graphics.DrawImage(LimitImageStart, bottomImageRect);
                        }
                        if (LimitImageEnd != null)
                        {
                            // Draw image at the top (maximum)
                            Rectangle topImageRect = new Rectangle(
                                (Width - LimitImageEnd.Width) / 2,
                                margin / 2,
                                LimitImageEnd.Width,
                                LimitImageEnd.Height);
                            e.Graphics.DrawImage(LimitImageEnd, topImageRect);
                        }
                    }

                    // Draw thumb
                    Rectangle thumbRect = new Rectangle(Width / 2 - thumbSize / 2, thumbY - thumbSize / 2, thumbSize, thumbSize);
                if (ThumbImage != null)
                {
                    e.Graphics.DrawImage(ThumbImage, thumbRect);
                }
                else
                {
                    using (Brush thumbBrush = new SolidBrush(ThumbColor))
                    {
                        e.Graphics.FillEllipse(thumbBrush, thumbRect);
                    }
                }
               
                }
            }
        }

        protected virtual void OnValueChanged(EventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }
    }
}
