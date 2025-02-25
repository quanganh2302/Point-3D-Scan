using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TCHRLibBasicRecordSample.CustomUi
{
    public class DSM_Trackbar : Control
    {
        private int _value;
        private int _minimum = 0;
        private int _maximum = 100;
        private bool _isDragging = false;

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
        public TrackbarOrientation Orientation { get; set; } = TrackbarOrientation.Horizontal;

        public DSM_Trackbar()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.MouseDown += CustomSlider_MouseDown;
            this.MouseMove += CustomSlider_MouseMove;
            this.MouseUp += CustomSlider_MouseUp;
            this.MouseLeave += CustomSlider_MouseLeave;
        }


        private bool IsOverThumb(Point location)
        {
            int thumbSize = 20;
            if (Orientation == TrackbarOrientation.Horizontal)
            {
                int thumbX = (int)((float)(Value - MinimumPercent) / (MaximumPercent - MinimumPercent) * (Width - 20)) + 10;
                Rectangle thumbRect = new Rectangle(thumbX - thumbSize / 2, Height / 2 - thumbSize / 2, thumbSize, thumbSize);
                return thumbRect.Contains(location);
            }
            else // Vertical orientation
            {
                int thumbY = (int)((float)(Value - MinimumPercent) / (MaximumPercent - MinimumPercent) * (Height - 20));
                thumbY = Height - thumbY - 10;
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
                // Change cursor when hovering over the thumb (you'll need to adjust the hit-test code as well)
                if (IsOverThumb(e.Location))
                {
                    this.Cursor = Cursors.Hand;
                }
                else
                {
                    this.Cursor = Cursors.Default;
                }
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
            if (Orientation == TrackbarOrientation.Horizontal)
            {
                int newValue = (int)((float)(p.X - 10) / (Width - 20) * (MaximumPercent - MinimumPercent) + MinimumPercent);
                Value = newValue;
            }
            else // Vertical orientation
            {
                // In vertical mode, let’s assume the minimum is at the bottom and maximum at the top.
                int newValue = (int)((float)(Height - p.Y - 10) / (Height - 20) * (MaximumPercent - MinimumPercent) + MinimumPercent);
                Value = newValue;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            int thumbSize = 20;

            if (Orientation == TrackbarOrientation.Horizontal)
            {
                // Horizontal drawing as before
                int thumbX = (int)((float)(Value - MinimumPercent) / (MaximumPercent - MinimumPercent) * (Width - 20)) + 10;

                // Draw left track
                Rectangle leftTrackRect = new Rectangle(10, Height / 2 - 2, thumbX - 10, 4);
                using (Brush leftTrackBrush = new SolidBrush(TrackColorLeft))
                {
                    e.Graphics.FillRectangle(leftTrackBrush, leftTrackRect);
                }

                // Draw right track
                Rectangle rightTrackRect = new Rectangle(thumbX, Height / 2 - 2, Width - thumbX - 10, 4);
                using (Brush rightTrackBrush = new SolidBrush(TrackColorRight))
                {
                    e.Graphics.FillRectangle(rightTrackBrush, rightTrackRect);
                }

                // Draw thumb
                Rectangle thumbRect = new Rectangle(thumbX - thumbSize / 2, Height / 2 - thumbSize / 2, thumbSize, thumbSize);
                using (Brush thumbBrush = new SolidBrush(ThumbColor))
                {
                    e.Graphics.FillEllipse(thumbBrush, thumbRect);
                }
            }
            else // Vertical orientation
            {
                // Calculate thumb position vertically.
                // Here we assume MinimumPercent is at the bottom and MaximumPercent is at the top.
                int thumbY = (int)((float)(Value - MinimumPercent) / (MaximumPercent - MinimumPercent) * (Height - 20));
                thumbY = Height - thumbY - 10;  // Invert to get the proper coordinate

                // Draw lower track (from bottom up to the thumb)
                Rectangle lowerTrackRect = new Rectangle(Width / 2 - 2, thumbY, 4, Height - thumbY - 10);
                using (Brush lowerTrackBrush = new SolidBrush(TrackColorLeft))
                {
                    e.Graphics.FillRectangle(lowerTrackBrush, lowerTrackRect);
                }

                // Draw upper track (from thumb to top)
                Rectangle upperTrackRect = new Rectangle(Width / 2 - 2, 10, 4, thumbY - 10);
                using (Brush upperTrackBrush = new SolidBrush(TrackColorRight))
                {
                    e.Graphics.FillRectangle(upperTrackBrush, upperTrackRect);
                }

                // Draw thumb as a circle
                Rectangle thumbRect = new Rectangle(Width / 2 - thumbSize / 2, thumbY - thumbSize / 2, thumbSize, thumbSize);
                using (Brush thumbBrush = new SolidBrush(ThumbColor))
                {
                    e.Graphics.FillEllipse(thumbBrush, thumbRect);
                }
            }
        }

        protected virtual void OnValueChanged(EventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }
    }

}