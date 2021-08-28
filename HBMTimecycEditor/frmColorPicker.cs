using System;
using System.Drawing;
using yt_DesignUI.Controls;

namespace HBMTimecycEditor
{
    public partial class frmColorPicker : ShadowedForm
    {
        public frmColorPicker()
        {
            InitializeComponent();
        }

        public Color SelectedColor
        {
            get { return googleColorPicker1.Color; }
            set
            {
                googleColorPicker1.Color = value;
                OnColorChanged(EventArgs.Empty);
            }
        }

        protected virtual void OnColorChanged(EventArgs e)
        {
            ColorChanged?.Invoke(this, e);
        }

        public event EventHandler ColorChanged;

        private void googleColorPicker1_ColorChanged(object sender, EventArgs e)
        {
            OnColorChanged(e);
        }
    }
}