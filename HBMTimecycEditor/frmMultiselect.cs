using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using yt_DesignUI.Controls;

namespace HBMTimecycEditor
{
    public partial class frmMultiselect : ShadowedForm
    {
        frmMain mainForm;
        CheckBox[] weathers;
        CheckBox[] times;

        public frmMultiselect(frmMain owner)
        {
            mainForm = owner;
            InitializeComponent();

            bool result = true;
            weathers = pnlWeather.Controls.OfType<CheckBox>().ToArray();
            times = pnlTime.Controls.OfType<CheckBox>().ToArray();

            for (int i = 0; i < weathers.Length; i++)
            {
                if (Program.Weathers[i])
                    weathers[i].Checked = true;
                else
                    weathers[i].Checked = false;
                result = result && weathers[i].Checked;
            }
            if (result)
                cbAllWeathers.Checked = true;

            result = true;
            for (int i = 0; i < times.Length; i++)
            {
                if (Program.Times[i])
                    times[i].Checked = true;
                else
                    times[i].Checked = false;
                result = result && times[i].Checked;
            }
            if (result)
                cbAllTimes.Checked = true;

            foreach (CheckBox checkBox in pnlWeather.Controls.OfType<CheckBox>())
            {
                checkBox.CheckedChanged += (s, ea) => CbWeather_Unchecked(checkBox);
            }
            foreach (CheckBox checkBox in pnlTime.Controls.OfType<CheckBox>())
            {
                checkBox.CheckedChanged += (s, ea) => CbTime_Unchecked(checkBox);
            }

            Localization.TranslateAllControls(this);
        }

        private void CbAllWeathers_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllWeathers.Checked)
            {
                foreach (CheckBox checkBox in pnlWeather.Controls.OfType<CheckBox>())
                {
                    checkBox.Checked = true;
                }
            }
        }
        private void CbAllTimes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllTimes.Checked)
            {
                foreach (CheckBox checkBox in pnlTime.Controls.OfType<CheckBox>())
                {
                    checkBox.Checked = true;
                }
            }
        }

        private void CbWeather_Unchecked(CheckBox checkBox)
        {
            if (!checkBox.Checked)
                cbAllWeathers.Checked = false;
        }
        private void CbTime_Unchecked(CheckBox checkBox)
        {
            if (!checkBox.Checked)
                cbAllTimes.Checked = false;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            cbAllTimes.Checked = false;
            cbAllWeathers.Checked = false;
            foreach (CheckBox checkBox in pnlWeather.Controls.OfType<CheckBox>())
            {
                checkBox.Checked = false;
            }
            foreach (CheckBox checkBox in pnlTime.Controls.OfType<CheckBox>())
            {
                checkBox.Checked = false;
            }
        }

        private void FrmMultiselect_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < weathers.Length; i++)
            {
                if (weathers[i].Checked)
                    Program.Weathers[i] = true;
                else
                    Program.Weathers[i] = false;
            }
            for (int i = 0; i < times.Length; i++)
            {
                if (times[i].Checked)
                    Program.Times[i] = true;
                else
                    Program.Times[i] = false;
            }

            mainForm.tgglMultiselect.BackColorON = Color.FromArgb(39, 174, 96);
            mainForm.tgglMultiselect.Enabled = true;
        }
    }
}