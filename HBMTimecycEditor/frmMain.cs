using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using yt_DesignUI;
using yt_DesignUI.Controls;

namespace HBMTimecycEditor
{
    public partial class frmMain : ShadowedForm
    {
        /* 5 steps to add a new field
         * 1) Add textbox to form
         * 2) Add type to enum of EditionValue (Add in order of timecyc.dat)
         * 3) Add ToolTip
         * 4) Localize
         * 5) Initialize an object of EditionValue in the form constructor (Initialize strictly in the reverse order of the timecyc.dat!)
        */

        #region WinAPI
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int ShowWindow_Restore = 9;
        #endregion

        #region Variables
        string gtaPath = "";
        string[] timecyc;
        List<EditionValue> editionValues = new List<EditionValue>();
        ToolTip toolTip = new ToolTip();
        const int OFFSET = 42;
        #endregion

        #region Controls

        #region ComboBoxes
        private void ComboBox_SelectedIndexChanged()
        {
            if (cbTime.SelectedIndex > 0 && cbWeather.SelectedIndex > 0)
            {
                GetPosition(cbWeather.SelectedIndex, cbTime.SelectedIndex, editionValues);

                foreach (var editionValue in editionValues)
                {
                    editionValue.EGTextBox.Text =
                        timecyc[editionValue.LineNumber].Substring(editionValue.Index, editionValue.Length);
                }
            }
            else if (!Localization.IsChanged)
            {
                foreach (var editionValue in editionValues)
                {
                    editionValue.EGTextBox.Text = "";
                }
            }
            Localization.IsChanged = false;
        }
        private void CbWeather_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox_SelectedIndexChanged();
        }
        private void CbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox_SelectedIndexChanged();
        }
        #endregion

        #region Buttons
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Выберите папку с GTA";
                if (gtaPath != "")
                    fbd.SelectedPath = gtaPath;
                else
                    fbd.RootFolder = Environment.SpecialFolder.MyComputer;

                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    if (File.Exists($@"{fbd.SelectedPath}\data\timecyc.dat"))
                    {
                        tbPath.Text = fbd.SelectedPath;
                        UpdateFields();
                    }
                    else MessageBox.Show("Указанная папка не GTA", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMultiselect"] == null)
            {
                FreezeTgglMultiselect();
                new frmMultiselect(this).Show();
            }
        }
        private void BtnLocalization_Click(object sender, EventArgs e)
        {
            if (btnLocalization.Text == "RUS".Translate())
            {
                Localization.Language = LocalizationLanguage.RUS;
                btnLocalization.Text = "АНГ";
                Localization.TranslateAllControlsWithToolTips(this, ref toolTip);
            }
            else
            {
                Localization.Language = LocalizationLanguage.ENG;
                btnLocalization.Text = "RUS";
                Localization.TranslateAllControlsWithToolTips(this, ref toolTip);
            }
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (TextBoxesFilled())
            {
                if (tgglMultiselect.Checked)
                {
                    for (int i = 0; i < Program.Weathers.Length; i++)
                    {
                        for (int j = 0; j < Program.Times.Length; j++)
                        {
                            if (Program.Weathers[i] && Program.Times[j])
                            {
                                GetPosition(i + 1, j + 1, editionValues);
                                ReplaceValues(editionValues);
                            }
                        }
                    }
                }
                else
                {
                    if (cbWeather.SelectedIndex > 0 && cbTime.SelectedIndex > 0)
                        ReplaceValues(editionValues);
                    else if (cbWeather.SelectedIndex == 0 && cbTime.SelectedIndex == 0)
                    {
                        for (int i = 1; i < cbWeather.Items.Count; i++)
                        {
                            for (int j = 1; j < cbTime.Items.Count; j++)
                            {
                                GetPosition(i, j, editionValues);
                                ReplaceValues(editionValues);
                            }
                        }
                    }
                    else
                    {
                        if (cbWeather.SelectedIndex == 0)
                        {
                            for (int i = 1; i < cbWeather.Items.Count; i++)
                            {
                                GetPosition(i, cbTime.SelectedIndex, editionValues);
                                ReplaceValues(editionValues);
                            }
                        }
                        else
                        {
                            for (int i = 1; i < cbTime.Items.Count; i++)
                            {
                                GetPosition(cbWeather.SelectedIndex, i, editionValues);
                                ReplaceValues(editionValues);
                            }
                        }
                    }
                }

                File.WriteAllLines($@"{gtaPath}\data\timecyc.dat", timecyc);
                Program.Message = "Done!".Translate();
                new frmMessage().ShowDialog();
            }
        }
        #endregion

        private async void TgglMultiselect_CheckedChanged(object sender)
        {
            int Y = pnlEdit.Location.Y, defHeight = Height;

            MaximumSize = new Size(0, 0);
            MinimumSize = new Size(0, 0);

            if (tgglMultiselect.Checked)
            {
                pnlOneSelect.Visible = false;
                while (pnlEdit.Location.Y > Y - OFFSET)
                {
                    await Task.Delay(10);
                    Height -= pnlEdit.Location.Y / 5;
                    pnlEdit.Location = new Point(pnlEdit.Location.X,
                        pnlEdit.Location.Y - pnlEdit.Location.Y / 5);
                }
                pnlEdit.Location = new Point(pnlEdit.Location.X, Y - OFFSET);
                Height = defHeight - OFFSET;

                MaximumSize = Size;
                MinimumSize = Size;

                tgglMultiselect.Text = "";
                btnShow.Visible = true;
                FreezeTgglMultiselect();
                new frmMultiselect(this).Show();
            }
            else
            {
                pnlOneSelect.Visible = true;
                while (pnlEdit.Location.Y < Y + OFFSET)
                {
                    await Task.Delay(10);
                    this.Height += (Y + OFFSET - pnlEdit.Location.Y) / 4 + 1;
                    pnlEdit.Location = new Point(pnlEdit.Location.X,
                        pnlEdit.Location.Y + (Y + OFFSET - pnlEdit.Location.Y) / 4 + 1);
                }
                pnlEdit.Location = new Point(pnlEdit.Location.X, Y + OFFSET);
                this.Height = defHeight + OFFSET;

                tgglMultiselect.Text = "Multiselect".Translate();
                btnShow.Visible = false;
            }
        }

        #endregion

        public frmMain()
        {
            ForbidMultipleLaunches();

            InitializeComponent();

            #region Adding ToolTips
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(tbPath, "Path to GTA where timecyc.dat will be edited");
            toolTip.SetToolTip(btnBrowse, "Open explorer to select a folder with GTA");
            toolTip.SetToolTip(btnLocalization, "Change application language");
            toolTip.SetToolTip(cbWeather, "Weather available for change");
            toolTip.SetToolTip(cbTime, "Time of day available for change");
            toolTip.SetToolTip(tgglMultiselect, "Multiple weather and time of day selection");
            toolTip.SetToolTip(btnShow, "Show a window for selecting several weather and time of day");
            toolTip.SetToolTip(tbDraw, "Draw distance [-3600; 3600]");
            toolTip.SetToolTip(tbFog, "Distance at which fog appears in the game [-3600; 3600]");
            toolTip.SetToolTip(tbSpriteBright, "Brightness of light from lanterns, traffic lights, etc. [-0.1; 25.4]");
            toolTip.SetToolTip(tbLightOnGround, "Brightness of the circles on the ground from lanterns, traffic lights, etc. [-0.1; 25.4]");
            toolTip.SetToolTip(tbShadow, "The visibility of the main shadow falling from moving and some fixed objects");
            toolTip.SetToolTip(tbLightShading, "Imaginary volume of the shadow. Works only at low effect settings");
            toolTip.SetToolTip(tbPoleShading, "Shadow falling from lamp posts at low effect settings");
            toolTip.SetToolTip(gbAmbient, "Ambient of the world [0; 255]");
            toolTip.SetToolTip(gbAmbientObj, "Ambient of skins and vehicles [0; 255]");
            toolTip.SetToolTip(gbPF1, "Post processing [0; 255]");
            toolTip.SetToolTip(gbPF2, "Post processing [0; 255]");
            toolTip.SetToolTip(btnEdit, "Make changes to timecyc.dat");

            #endregion

            editionValues.AddRange(new EditionValue[21] 
            {
                new EditionValue(EditionValueType.POSTFX2_B, RangeType.UNSIGNED_INT, ref tbPF2B),
                new EditionValue(EditionValueType.POSTFX2_G, RangeType.UNSIGNED_INT, ref tbPF2G),
                new EditionValue(EditionValueType.POSTFX2_R, RangeType.UNSIGNED_INT, ref tbPF2R),
                new EditionValue(EditionValueType.POSTFX2_A, RangeType.UNSIGNED_INT, ref tbPF2A),
                new EditionValue(EditionValueType.POSTFX1_B, RangeType.UNSIGNED_INT, ref tbPF1B),
                new EditionValue(EditionValueType.POSTFX1_G, RangeType.UNSIGNED_INT, ref tbPF1G),
                new EditionValue(EditionValueType.POSTFX1_R, RangeType.UNSIGNED_INT, ref tbPF1R),
                new EditionValue(EditionValueType.POSTFX1_A, RangeType.UNSIGNED_INT, ref tbPF1A),
                new EditionValue(EditionValueType.LIGHT_ON_GROUND, RangeType.DOUBLE, ref tbLightOnGround),
                new EditionValue(EditionValueType.FOG_DIST, RangeType.INT, ref tbFog),
                new EditionValue(EditionValueType.DRAW_DIST, RangeType.INT, ref tbDraw),
                new EditionValue(EditionValueType.POLE_SHADING, RangeType.INT, ref tbPoleShading),
                new EditionValue(EditionValueType.LIGHT_SHADING, RangeType.INT, ref tbLightShading),
                new EditionValue(EditionValueType.SHADOW, RangeType.INT, ref tbShadow),
                new EditionValue(EditionValueType.SPRITE_BRIGHT, RangeType.DOUBLE, ref tbSpriteBright),
                new EditionValue(EditionValueType.AMBIENT_OBJ_B, RangeType.UNSIGNED_INT, ref tbAmbientObjB),
                new EditionValue(EditionValueType.AMBIENT_OBJ_G, RangeType.UNSIGNED_INT, ref tbAmbientObjG),
                new EditionValue(EditionValueType.AMBIENT_OBJ_R, RangeType.UNSIGNED_INT, ref tbAmbientObjR),
                new EditionValue(EditionValueType.AMBIENT_B, RangeType.UNSIGNED_INT, ref tbAmbientB),
                new EditionValue(EditionValueType.AMBIENT_G, RangeType.UNSIGNED_INT, ref tbAmbientG),
                new EditionValue(EditionValueType.AMBIENT_R, RangeType.UNSIGNED_INT, ref tbAmbientR)
            });

            Animator.Start();

            GetSettingsFromRegisty();

            #region Adding events
            // Remove focus from controls when clicking on a panel/form
            Click += (s, ea) => btnEdit.Focus();
            AddClickEventOnPanels(this);

            AddEventsOnAllTextBoxes(pnlEdit);
            foreach (var editionValue in editionValues)
            {
                editionValue.EGTextBox.Click += (s, e) =>
                {
                    EditionValue.CheckValidData(editionValues);
                };
                editionValue.EGTextBox.TextChanged += (s, ea) =>
                {
                    editionValue.Filter();
                };
            }
            #endregion

            cbWeather.SelectedIndex = 0;
            cbTime.SelectedIndex = 0;

            Localization.TranslateAllControlsWithToolTips(this, ref toolTip);
        }

        /// <summary>Protection against restarting the application with the subsequent activation of an existing window</summary>
        private void ForbidMultipleLaunches()
        {
            Process this_process = Process.GetCurrentProcess();
            Process[] other_processes =
                Process.GetProcessesByName(this_process.ProcessName).Where(pr => pr.Id != this_process.Id).ToArray();

            foreach (var pr in other_processes)
            {
                pr.WaitForInputIdle(1000);

                IntPtr hWnd = pr.MainWindowHandle;
                if (hWnd == IntPtr.Zero) continue;

                ShowWindow(hWnd, ShowWindow_Restore);
                SetForegroundWindow(hWnd);
                Environment.Exit(0);
            }
        }
        /// <summary>Reading the registry to get settings for an application</summary>
        private void GetSettingsFromRegisty()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\HBMTimecycEditor"))
                {
                    switch (key.GetValue("language").ToString())
                    {
                        case "eng":
                            Localization.Language = LocalizationLanguage.ENG;
                            btnLocalization.Text = "RUS";
                            break;
                        case "rus":
                            Localization.Language = LocalizationLanguage.RUS;
                            btnLocalization.Text = "АНГ";
                            break;
                    }
                    gtaPath = key.GetValue("path").ToString();
                }
                tbPath.Text = gtaPath;
                timecyc = File.ReadAllLines($@"{gtaPath}\data\timecyc.dat");
            }
            catch (Exception)
            {
                pnlDrawDist.Visible = false;
            }
        }
        /// <summary>Turns off toggle switch with dimming</summary>
        private void FreezeTgglMultiselect()
        {
            tgglMultiselect.Enabled = false;
            tgglMultiselect.BackColorON = Color.FromArgb(87, 175, 125);
            tgglMultiselect.Refresh();
        }
        /// <summary>Get: required lines, indexes and lengths</summary>
        private void GetPosition(int weatherIndex, int timeIndex, List<EditionValue> editionValues)
        {
            foreach (var editionValue in editionValues)
            {
                for (editionValue.LineNumber = 0; editionValue.LineNumber < timecyc.Length; editionValue.LineNumber++)
                {
                    if (timecyc[editionValue.LineNumber].Contains($@"//{cbWeather.Items[weatherIndex]}") ||
                        timecyc[editionValue.LineNumber].Contains($@" {cbWeather.Items[weatherIndex]}"))
                    {
                        #region Finding the required line
                        string[] numbers = null;
                        for (int i = 0; i < timeIndex;)
                        {
                            bool isNumbers = true;
                            timecyc[editionValue.LineNumber] = timecyc[editionValue.LineNumber].Replace("\t", " ");
                            numbers = timecyc[editionValue.LineNumber].Split(' ');
                            for (int j = 0; j < numbers.Length; j++)
                            {
                                if (numbers[j] != "" && !(char.IsDigit(numbers[j].ToCharArray()[0])) &&
                                    numbers[j].ToCharArray()[0] != '-')
                                {
                                    isNumbers = false;
                                    break;
                                }
                            }
                            if (isNumbers)
                                i++;
                            editionValue.LineNumber++;
                        }
                        editionValue.LineNumber--;
                        #endregion

                        #region Finding the required index and length
                        editionValue.Index = 0;
                        for (int i = 0, number = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] != "" && (char.IsDigit(numbers[i].ToCharArray()[0]) ||
                                numbers[i].ToCharArray()[0] == '-'))
                                number++;
                            if (number == (int)editionValue.Type)
                            {
                                // Substring up to the desired value
                                string substrBef = "";
                                for (int k = 0; k < i; k++)
                                {
                                    substrBef += $"{numbers[k]} ";
                                }
                                editionValue.Index = substrBef.Length;
                                editionValue.Length = numbers[i].Length;
                                break;
                            }
                        }
                        #endregion

                        break;
                    }
                }
            }
        }
        /// <summary>Update path and draw dist value and re-read timecyc.dat</summary>
        private void UpdateFields()
        {
            gtaPath = tbPath.Text;
            timecyc = File.ReadAllLines($@"{gtaPath}\data\timecyc.dat");
            Registry.CurrentUser.CreateSubKey(@"Software\HBMTimecycEditor").SetValue("path", gtaPath);
            pnlDrawDist.Visible = true;
            if (!btnEdit.Enabled)
                btnEdit.Enabled = true;

            int wSel = cbWeather.SelectedIndex;
            if (cbWeather.SelectedIndex != 0)
                cbWeather.SelectedIndex = 0;
            else
                cbWeather.SelectedIndex = 1;
            cbWeather.SelectedIndex = wSel;
        }
        /// <summary>Replace timecyc's draw distance value without rewrite timecyc.dat</summary>
        private void ReplaceValues(List<EditionValue> editionValues)
        {
            foreach (var editionValue in editionValues)
            {
                if (editionValue.EGTextBox.Text != "")
                {
                    timecyc[editionValue.LineNumber] = timecyc[editionValue.LineNumber].Remove(editionValue.Index, editionValue.Length);
                    timecyc[editionValue.LineNumber] = timecyc[editionValue.LineNumber].Insert(editionValue.Index, editionValue.EGTextBox.Text);
                }
            }
        }
        /// <summary>Recursive addition Click event on all panels</summary>
        private void AddClickEventOnPanels(Control parent)
        {
            if (parent is Panel)
                parent.Click += (s, e) => 
                {
                    EditionValue.CheckValidData(editionValues);
                    btnEdit.Focus();
                };
            foreach (Panel panel in parent.Controls.OfType<Panel>())
            {
                AddClickEventOnPanels(panel);
            }
        }
        /// <summary>Recursive addition Click and KeyDown events on all TextBoxes on the pnlEdit</summary>
        private void AddEventsOnAllTextBoxes(Control parent)
        {
            if (parent is TextBox)
            {
                parent.KeyDown += (s, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        EditionValue.CheckValidData(editionValues);
                        btnEdit.Focus();
                    }
                };
                parent.LostFocus += (s, e) =>
                {
                    EditionValue.CheckValidData(editionValues);
                };
            }
            foreach (Control control in parent.Controls)
            {
                AddEventsOnAllTextBoxes(control);
            }
        }
        /// <summary>Checking the completeness of TextBoses</summary>
        private bool TextBoxesFilled()
        {
            bool existNotEmpty = false;
            for (int i = 0; i < editionValues.Count; i++)
            {
                if (editionValues[i].EGTextBox.Text != "")
                {
                    existNotEmpty = true;
                    break;
                }
            }

            if (!existNotEmpty)
            {
                Program.Message = "Enter a value in at least one of the fields".Translate();
                new frmMessage().ShowDialog();
                return false;
            }

            return existNotEmpty;
        }
    }
}