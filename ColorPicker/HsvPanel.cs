using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ColorPicker
{
    [DefaultEvent("ColorChanged")]
    public class HsvPanel : Panel
    {
        #region Private Fields

        private static SolidBrush _hotspotBrush = new SolidBrush(Color.Empty);

        private static Size _hotspotSize = new Size(20, 20);

        private PointF _hotspot;

        private float _hue;

        private float _saturation;

        private float _value;

        #endregion Private Fields

        #region Public Constructors

        public HsvPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        #endregion Public Constructors

        #region Public Events

        public event EventHandler ColorChanged;

        #endregion Public Events

        #region Public Properties

        public float Hue
        {
            get { return _hue; }
            set
            {
                if (_hue != value)
                {
                    _hue = value;
                    OnColorChanged();
                }
            }
        }

        public float Saturation
        {
            get { return _saturation; }
            set
            {
                if (_saturation != value)
                {
                    _saturation = value > 1 ? 1 : value;
                    SetHotSpot(new PointF(ClientRectangle.Width * _saturation, _hotspot.Y));
                    OnColorChanged();
                }
            }
        }

        public float Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value > 1 ? 1 : value;
                    SetHotSpot(new PointF(_hotspot.X, ClientRectangle.Height * (1 - _value)));
                    OnColorChanged();
                }
            }
        }

        #endregion Public Properties

        #region Private Properties

        private HsvColor HsvColor => new HsvColor(_hue, _saturation, _value);

        #endregion Private Properties

        #region Protected Methods

        protected virtual void OnColorChanged()
        {
            ColorChanged?.Invoke(this, EventArgs.Empty);
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SetHotSpot(e.Location);
                OnColorChanged();
            }
            base.OnMouseClick(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point location = PointToClient(Cursor.Position);
                int x = e.Location.X, y = e.Location.Y;

                if (location.X > Width)
                    x = Width;
                else if (location.X < 0)
                    x = 0;

                if (location.Y > Height)
                    y = Height;
                else if (location.Y < 0)
                    y = 0;

                SetHotSpot(new PointF(x, y));
                OnColorChanged();
            }
            base.OnMouseMove(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var brush = GetBackgroundBrush())
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
                var rect = new RectangleF(_hotspot, _hotspotSize);
                rect.Offset(-_hotspotSize.Width / 2, -_hotspotSize.Height / 2);
                e.Graphics.FillEllipse(Brushes.White, rect);
                rect.Inflate(-2, -2);
                _hotspotBrush.Color = HsvColor;
                e.Graphics.FillEllipse(_hotspotBrush, rect);
            }
        }

        #endregion Protected Methods

        #region Private Methods

        private PathGradientBrush GetBackgroundBrush()
        {
            var points = new PointF[]
            {
                ClientRectangle.Location,
                new PointF(ClientRectangle.X + ClientRectangle.Width, ClientRectangle.Y),
                new Point(ClientRectangle.X + ClientRectangle.Width, ClientRectangle.Y + ClientRectangle.Height),
                new Point(ClientRectangle.X, ClientRectangle.Y + ClientRectangle.Height),
            };
            return new PathGradientBrush(points)
            {
                CenterColor = new HsvColor(Hue, 0.5, 0.5),
                CenterPoint = new PointF(ClientRectangle.Width / 2f, ClientRectangle.Height / 2f),
                SurroundColors = new Color[]
                {
                         new HsvColor(Hue, 0, 1),
                         new HsvColor(Hue, 1, 1),
                         new HsvColor(Hue, 1, 0),
                         new HsvColor(Hue, 0, 0)
                }
            };
        }

        private void SetHotSpot(PointF pt)
        {
            _hotspot = pt;
            _saturation = pt.X / ClientRectangle.Width;
            _value = 1 - pt.Y / ClientRectangle.Height;
        }

        #endregion Private Methods
    }
}