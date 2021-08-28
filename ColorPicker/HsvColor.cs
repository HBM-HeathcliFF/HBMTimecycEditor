using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace ColorPicker
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public struct HsvColor
    {
        #region Instance Fields

        private int _alpha;

        private float _hue;

        private float _value;

        private float _saturation;

        #endregion
        #region Static Constructors

        static HsvColor()
        {
            Empty = new HsvColor
            {
                IsEmpty = true
            };
        }

        #endregion
        #region Constructors

        /// <summary>
        /// Конструктор HsvColor
        /// </summary>
        /// <param name="hue">Цветовой тон [0, 360]</param>
        /// <param name="saturation">Насыщенность [0, 1]</param>
        /// <param name="value">Яркость [0, 1]</param>
        public HsvColor(double hue, double saturation, double value)
          : this(255, hue, saturation, value)
        { }

        /// <summary>
        /// Конструктор HsvColor с альфа-каналом
        /// </summary>
        /// <param name="alpha">Альфа-канал [0, 255]</param>
        /// <param name="hue">Цветовой тон [0, 360]</param>
        /// <param name="saturation">Насыщенность [0, 1]</param>
        /// <param name="value">Яркость [0, 1]</param>
        public HsvColor(int alpha, double hue, double saturation, double value)
        {
            _hue = (float)Math.Min(360, hue);
            _saturation = (float)Math.Min(1, saturation);
            _value = (float)Math.Min(1, value);
            _alpha = alpha;
            _isEmpty=false;
        }

        public HsvColor(Color color)
        {
            float r;
            float g;
            float b;
            float max;
            float min;
            float delta;

            _alpha = color.A;
            r = (color.R / 255f);                   //RGB from 0 to 255
            g = (color.G / 255f);
            b = (color.B / 255f);

            min = Math.Min(r, Math.Min(g, b));  //Min. value of RGB
            max = Math.Max(r, Math.Max(g, b));  //Max. value of RGB
            delta = max - min;        //Delta RGB value 

            _value = max;
            _hue = 60 * (r - g) / delta + 240;
            if (max == min)
            {
                _hue = 0;
            }
            else if (max == r && g >= b)
            {
                _hue = 60 * (g - b) / delta;
            }
            else if (max == r && g < b)
            {
                _hue = 60 * (g - b) / delta + 360;
            }
            else if (max == g)
            {
                _hue = 60 * (b - r) / delta + 120;
            }

            _saturation = max == 0 ? 0 : 1 - min / max;
            _isEmpty = false;
        }

        #endregion

        #region Operators

        public static bool operator ==(HsvColor left, HsvColor right)
        {
            return (left.H == right.H && left.V == right.V && left.S == right.S && left.A == right.A);
        }

        public static bool operator !=(HsvColor left, HsvColor right)
        {
            return !(left == right);
        }

        public static implicit operator Color(HsvColor color)
        {
            return color.ToRgbColor();
        }

        public static implicit operator HsvColor(Color color)
        {
            return new HsvColor(color);
        }
        #endregion

        #region Overridden Members

        public override bool Equals(object obj)
        {
            bool result;

            if (obj is HsvColor)
            {
                HsvColor color;

                color = (HsvColor)obj;
                result = (this == color);
            }
            else
                result = false;

            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder builder;

            builder = new StringBuilder();
            builder.Append(base.GetType().Name);
            builder.Append(" [");
            builder.Append("H=");
            builder.Append(H);
            builder.Append(", S=");
            builder.Append(S);
            builder.Append(", V=");
            builder.Append(V);
            builder.Append("]");

            return builder.ToString();
        }

        #endregion

        #region Properties
        public static readonly HsvColor Empty;
        private bool _isEmpty;

        public int A
        {
            get { return _alpha; }
            set { _alpha = value; }
        }

        public float H
        {
            get { return _hue; }
            set
            {
                _hue = value;

                if (_hue < 0)
                    _hue += 360;
                if (_hue > 360)
                    _hue -= 360;
            }
        }

        public float V
        {
            get { return _value; }
            set { _value = Math.Min(1, Math.Max(0, value)); }
        }

        public float S
        {
            get { return _saturation; }
            set { _saturation = Math.Min(1, Math.Max(0, value)); }
        }

        public bool IsEmpty
        {
            get { return _isEmpty; }
            set { _isEmpty = value; }
        }
        #endregion

        #region Members

        public Color ToRgbColor()
        {
            return ToRgbColor(A);
        }

        public Color ToRgbColor(int alpha)
        {
            double r = 0, g = 0, b = 0;

            if (S == 0)
            {
                r = V;
                g = V;
                b = V;
            }
            else
            {
                int i;
                double f, p, q, t;

                if (H == 360)
                    H = 0;
                else
                    H /= 60;

                i = (int)Math.Truncate(H);
                f = H - i;

                p = V * (1.0 - S);
                q = V * (1.0 - (S * f));
                t = V * (1.0 - (S * (1.0 - f)));

                switch (i)
                {
                    case 0:
                        r = V;
                        g = t;
                        b = p;
                        break;

                    case 1:
                        r = q;
                        g = V;
                        b = p;
                        break;

                    case 2:
                        r = p;
                        g = V;
                        b = t;
                        break;

                    case 3:
                        r = p;
                        g = q;
                        b = V;
                        break;

                    case 4:
                        r = t;
                        g = p;
                        b = V;
                        break;

                    default:
                        r = V;
                        g = p;
                        b = q;
                        break;
                }

            }

            return Color.FromArgb(alpha, (byte)(r * 255), (byte)(g * 255), (byte)(b * 255));
        }

        #endregion
    }

}
