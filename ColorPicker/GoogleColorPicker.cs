using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class GoogleColorPicker : UserControl
    {

        public event EventHandler ColorChanged;

        public Color Color
        {
            get
            {
                return new HsvColor(panel.Hue, panel.Saturation, panel.Value).ToRgbColor();
            }
            set
            {
                var hsv = new HsvColor(value);
                panel.Hue = hsv.H;
                panel.Saturation = hsv.S;
                panel.Value = hsv.V;
                slider.Value = hsv.H;
                OnColorChanged(EventArgs.Empty);
            }
        }

        public GoogleColorPicker()
        {
            InitializeComponent();
            panel.Hue = slider.Value;
            OnColorChanged(EventArgs.Empty);
        }

        private void slider_ValueChanged(object sender, EventArgs e)
        {
            panel.Hue = slider.Value;
            OnColorChanged(EventArgs.Empty);
        }

        private void OnColorChanged(EventArgs e)
        {
            var color = Color;
            ColorChanged?.Invoke(this, e);
        }

        private void panel_ColorChanged(object sender, EventArgs e)
        {
            OnColorChanged(EventArgs.Empty);
        }
    }
}
