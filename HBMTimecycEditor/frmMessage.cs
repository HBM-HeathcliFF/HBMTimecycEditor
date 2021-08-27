using System;
using System.Drawing;
using yt_DesignUI.Controls;

namespace HBMTimecycEditor
{
    public partial class frmMessage : ShadowedForm
    {
        public frmMessage()
        {
            InitializeComponent();
            lblMessage.Text = Program.Message;
            Size = new Size(lblMessage.Width + 10, Height);
            btnOk.Location = new Point(Width / 2 - btnOk.Width / 2, btnOk.Location.Y);

            if (Size.Width > lblMessage.Width + 10)
                lblMessage.Location = new Point(Width / 2 - lblMessage.Width / 2, btnOk.Location.Y - 47);
            else
                lblMessage.Location = new Point(5, btnOk.Location.Y - 47);

            MinimumSize = Size;
            MaximumSize = Size;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}