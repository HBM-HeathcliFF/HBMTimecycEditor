using Cyotek.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace ColorPicker
{
    public class HueSlider : HueColorSlider
    {
        #region Private Fields

        private static SolidBrush _nubBrush = new SolidBrush(Color.Empty);

        #endregion Private Fields

        #region Public Constructors

        public HueSlider()
        {
            BarBounds = new Rectangle(BarBounds.Location, new Size(BarBounds.Width, 8));
            NubSize = new Size(15, 15);
        }

        #endregion Public Constructors

        #region Public Properties

        public override ColorSliderNubStyle NubStyle { get => ColorSliderNubStyle.None; set => base.NubStyle = value; }

        public Color SelectedColor
        {
            get
            {
                return new HslColor(Value, 1, 0.5).ToRgbColor();
            }
            set
            {
                var hsl = new HslColor(value);
                if (hsl.H == Value) return;
                Value = (float)hsl.H;
            }
        }

        public override bool ShowValueDivider { get => false; set => base.ShowValueDivider = value; }

        #endregion Public Properties

        #region Protected Methods

        protected override Padding GetBarPadding()
        {
            int left;
            int top;
            int right;
            int bottom;

            left = 0;
            top = 0;
            right = 0;
            bottom = 0;
            {
                left = NubSize.Width / 2;
                right = NubSize.Width / 2;
                top = NubSize.Height / 2;
                bottom = NubSize.Height / 2;
            }
            return new Padding(left, top, right, bottom);
        }

        protected override void PaintAdornments(PaintEventArgs e)
        {
            var pt = ValueToPoint(Value);

            Rectangle rect;
            if (Orientation == Orientation.Horizontal)
            {
                rect = new Rectangle(new Point(pt.X - 5, BarBounds.Height / 2), NubSize);
            }
            else
                rect = new Rectangle(new Point(BarBounds.Width / 2, pt.Y - 5), NubSize);
            _nubBrush.Color = new HslColor(Value, 1, 0.5).ToRgbColor();
            e.Graphics.FillEllipse(Brushes.White, rect);
            rect.Inflate(-1, -1);
            e.Graphics.FillEllipse(_nubBrush, rect);
        }

        #endregion Protected Methods
    }
}