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
        readonly string backupDirectory = $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Temp\HBM Timecyc Editor";
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
                    if (editionValue.Type == EditionValueType.ILLUMINATION && editionValue.Index == 0)
                        editionValue.EGTextBox.Text = "0";
                    else
                        editionValue.EGTextBox.Text =
                           timecyc[editionValue.LineNumber].Substring(editionValue.Index, editionValue.Length);
                }
                SetBackColorOfPictureBoxes(pnlFields);
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
                        tbPath.Text = fbd.SelectedPath;
                    else
                        MessageBox.Show("Указанная папка не GTA", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void BtnReset_Click(object sender, EventArgs e)
        {
            File.Copy($@"{backupDirectory}\timecyc.dat", $@"{gtaPath}\data\timecyc.dat", true);
        }
        private async void BtnApply_Click(object sender, EventArgs e)
        {
            if (TextBoxesFilled())
            {
                await Task.Run(() =>
                {
                    pnlMain.Enabled = false;

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

                    pnlMain.Enabled = true;
                });
            }
        }
        #endregion

        #region PictureBoxes
        private void SetRGB(PictureBox pb, EgoldsGoogleTextBox tbR, EgoldsGoogleTextBox tbG, EgoldsGoogleTextBox tbB)
        {
            tbR.Text = pb.BackColor.R.ToString();
            tbG.Text = pb.BackColor.G.ToString();
            tbB.Text = pb.BackColor.B.ToString();
        }
        private void PbAmbient_BackColorChanged(object sender, EventArgs e)
        {
            SetRGB(pbAmbient, tbAmbientR, tbAmbientG, tbAmbientB);
        }
        private void PbAmbientObj_BackColorChanged(object sender, EventArgs e)
        {
            SetRGB(pbAmbientObj, tbAmbientObjR, tbAmbientObjG, tbAmbientObjB);
        }
        private void PbPostFX1_BackColorChanged(object sender, EventArgs e)
        {
            SetRGB(pbPostFX1, tbPostFX1R, tbPostFX1G, tbPostFX1B);
        }
        private void PbPostFX2_BackColorChanged(object sender, EventArgs e)
        {
            SetRGB(pbPostFX2, tbPostFX2R, tbPostFX2G, tbPostFX2B);
        }
        private void PbSkyBottom_BackColorChanged(object sender, EventArgs e)
        {
            SetRGB(pbSkyBottom, tbSkyBottomR, tbSkyBottomG, tbSkyBottomB);
        }
        private void PbSkyTop_BackColorChanged(object sender, EventArgs e)
        {
            SetRGB(pbSkyTop, tbSkyTopR, tbSkyTopG, tbSkyTopB);
        }
        private void PbFluffyClouds_Click(object sender, EventArgs e)
        {
            SetRGB(pbFluffyClouds, tbFluffyCloudsR, tbFluffyCloudsG, tbFluffyCloudsB);
        }
        private void PbLowClouds_BackColorChanged(object sender, EventArgs e)
        {
            SetRGB(pbLowClouds, tbLowCloudsR, tbLowCloudsG, tbLowCloudsB);
        }
        private void PbSunCorona_BackColorChanged(object sender, EventArgs e)
        {
            SetRGB(pbSunCorona, tbSunCoronaR, tbSunCoronaG, tbSunCoronaB);
        }
        private void PbSunCore_BackColorChanged(object sender, EventArgs e)
        {
            SetRGB(pbSunCore, tbSunCoreR, tbSunCoreG, tbSunCoreB);
        }
        private void PbWater_BackColorChanged(object sender, EventArgs e)
        {
            SetRGB(pbWater, tbWaterR, tbWaterG, tbWaterB);
        }
        #endregion

        private void TbPath_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists($@"{tbPath.Text}\data\timecyc.dat"))
            {
                gtaPath = tbPath.Text;
                timecyc = File.ReadAllLines($@"{gtaPath}\data\timecyc.dat");
                CopyTimecycForBackUp();
                pnlMain.Enabled = true;
                if (!btnApply.Enabled)
                    btnApply.Enabled = true;

                int wSel = cbWeather.SelectedIndex;
                if (cbWeather.SelectedIndex != 0)
                    cbWeather.SelectedIndex = 0;
                else
                    cbWeather.SelectedIndex = 1;
                cbWeather.SelectedIndex = wSel;
            }
            else
            {
                cbWeather.SelectedIndex = 0;
                cbTime.SelectedIndex = 0;
                pnlMain.Enabled = false;
            }
        }

        private async void TgglMultiselect_CheckedChanged(object sender)
        {
            int Y = pnlFields.Location.Y, defHeight = Height;

            MaximumSize = new Size(0, 0);
            MinimumSize = new Size(0, 0);

            if (tgglMultiselect.Checked)
            {
                pnlOneSelect.Visible = false;
                while (pnlFields.Location.Y > Y - OFFSET)
                {
                    await Task.Delay(10);
                    Height -= pnlFields.Location.Y / 5;
                    pnlFields.Location = new Point(pnlFields.Location.X,
                        pnlFields.Location.Y - pnlFields.Location.Y / 5);
                }
                pnlFields.Location = new Point(pnlFields.Location.X, Y - OFFSET);
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
                while (pnlFields.Location.Y < Y + OFFSET)
                {
                    await Task.Delay(10);
                    this.Height += (Y + OFFSET - pnlFields.Location.Y) / 4 + 1;
                    pnlFields.Location = new Point(pnlFields.Location.X,
                        pnlFields.Location.Y + (Y + OFFSET - pnlFields.Location.Y) / 4 + 1);
                }
                pnlFields.Location = new Point(pnlFields.Location.X, Y + OFFSET);
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
            toolTip.SetToolTip(tbShadow, "The visibility of the main shadow falling from moving and some fixed objects [0; 255]");
            toolTip.SetToolTip(tbLightShading, "Imaginary volume of the shadow. Works only at low effect settings [0; 255]");
            toolTip.SetToolTip(tbPoleShading, "Shadow falling from lamp posts at low effect settings [0; 255]");
            toolTip.SetToolTip(gbAmbient, "Ambient of the world [0; 255]");
            toolTip.SetToolTip(gbAmbientObj, "Ambient of skins and vehicles [0; 255]");
            toolTip.SetToolTip(gbPostFX1, "Post processing [0; 255]");
            toolTip.SetToolTip(gbPostFX2, "Post processing [0; 255]");
            toolTip.SetToolTip(tbSpriteSize, "Sprite size [-0.1; 12.7]");
            toolTip.SetToolTip(tbIllumination, "Brightness of directional lighting on moving objects [0; 2.55]");
            toolTip.SetToolTip(tbSunSize, "Sun size [-0.1; 12.7]");
            toolTip.SetToolTip(tbUpperCloudsAlpha, "Opacity of main clouds or cloud top [0; 255]");
            toolTip.SetToolTip(tbWaterFogAlpha, "The brightness and number of layers of white fog above the water [0; 255]");
            toolTip.SetToolTip(gbSunCore, "The color of the inside of the sun [0; 255]");
            toolTip.SetToolTip(gbSunCorona, "The color of the outer part of the sun, as well as the color of the glare emanating from it and the glare reflected on the water [0; 255]");
            toolTip.SetToolTip(gbSkyTop, "Upper sky color [0; 255]");
            toolTip.SetToolTip(gbSkyBottom, "The color of the lower part of the sky and fog [0; 255]");
            toolTip.SetToolTip(gbLowClouds, "The color of distant, oblong clouds [0; 255]");
            toolTip.SetToolTip(gbFluffyClouds, "The color of the top of the main, broad clouds. Not used in GTA SA [0; 255]");
            toolTip.SetToolTip(gbWater, "Water layer color [0; 255]");
            toolTip.SetToolTip(btnApply, "Make changes to timecyc.dat");

            #endregion

            editionValues.AddRange(new EditionValue[] 
            {
                new EditionValue(EditionValueType.ILLUMINATION, RangeType.UNSIGNED_DOUBLE, ref tbIllumination),
                new EditionValue(EditionValueType.WATER_FOG_ALPHA, RangeType.UNSIGNED_INT, ref tbWaterFogAlpha),
                new EditionValue(EditionValueType.UPPER_CLOUDS_ALPHA, RangeType.UNSIGNED_INT, ref tbUpperCloudsAlpha),
                new EditionValue(EditionValueType.POSTFX2_B, RangeType.UNSIGNED_INT, ref tbPostFX2B),
                new EditionValue(EditionValueType.POSTFX2_G, RangeType.UNSIGNED_INT, ref tbPostFX2G),
                new EditionValue(EditionValueType.POSTFX2_R, RangeType.UNSIGNED_INT, ref tbPostFX2R),
                new EditionValue(EditionValueType.POSTFX2_A, RangeType.UNSIGNED_INT, ref tbPostFX2A),
                new EditionValue(EditionValueType.POSTFX1_B, RangeType.UNSIGNED_INT, ref tbPostFX1B),
                new EditionValue(EditionValueType.POSTFX1_G, RangeType.UNSIGNED_INT, ref tbPostFX1G),
                new EditionValue(EditionValueType.POSTFX1_R, RangeType.UNSIGNED_INT, ref tbPostFX1R),
                new EditionValue(EditionValueType.POSTFX1_A, RangeType.UNSIGNED_INT, ref tbPostFX1A),
                new EditionValue(EditionValueType.WATER_A, RangeType.UNSIGNED_INT, ref tbWaterA),
                new EditionValue(EditionValueType.WATER_B, RangeType.UNSIGNED_INT, ref tbWaterB),
                new EditionValue(EditionValueType.WATER_G, RangeType.UNSIGNED_INT, ref tbWaterG),
                new EditionValue(EditionValueType.WATER_R, RangeType.UNSIGNED_INT, ref tbWaterR),
                new EditionValue(EditionValueType.FLUFFY_CLOUDS_B, RangeType.UNSIGNED_INT, ref tbFluffyCloudsB),
                new EditionValue(EditionValueType.FLUFFY_CLOUDS_G, RangeType.UNSIGNED_INT, ref tbFluffyCloudsG),
                new EditionValue(EditionValueType.FLUFFY_CLOUDS_R, RangeType.UNSIGNED_INT, ref tbFluffyCloudsR),
                new EditionValue(EditionValueType.LOW_CLOUDS_B, RangeType.UNSIGNED_INT, ref tbLowCloudsB),
                new EditionValue(EditionValueType.LOW_CLOUDS_G, RangeType.UNSIGNED_INT, ref tbLowCloudsG),
                new EditionValue(EditionValueType.LOW_CLOUDS_R, RangeType.UNSIGNED_INT, ref tbLowCloudsR),
                new EditionValue(EditionValueType.LIGHT_ON_GROUND, RangeType.UPPER_DOUBLE, ref tbLightOnGround),
                new EditionValue(EditionValueType.FOG_DIST, RangeType.INT, ref tbFog),
                new EditionValue(EditionValueType.DRAW_DIST, RangeType.INT, ref tbDraw),
                new EditionValue(EditionValueType.POLE_SHADING, RangeType.UNSIGNED_INT, ref tbPoleShading),
                new EditionValue(EditionValueType.LIGHT_SHADING, RangeType.UNSIGNED_INT, ref tbLightShading),
                new EditionValue(EditionValueType.SHADOW, RangeType.UNSIGNED_INT, ref tbShadow),
                new EditionValue(EditionValueType.SPRITE_BRIGHT, RangeType.UPPER_DOUBLE, ref tbSpriteBright),
                new EditionValue(EditionValueType.SPRITE_SIZE, RangeType.LOWER_DOUBLE, ref tbSpriteSize),
                new EditionValue(EditionValueType.SUN_SIZE, RangeType.LOWER_DOUBLE, ref tbSunSize),
                new EditionValue(EditionValueType.SUN_CORONA_B, RangeType.UNSIGNED_INT, ref tbSunCoronaB),
                new EditionValue(EditionValueType.SUN_CORONA_G, RangeType.UNSIGNED_INT, ref tbSunCoronaG),
                new EditionValue(EditionValueType.SUN_CORONA_R, RangeType.UNSIGNED_INT, ref tbSunCoronaR),
                new EditionValue(EditionValueType.SUN_CORE_B, RangeType.UNSIGNED_INT, ref tbSunCoreB),
                new EditionValue(EditionValueType.SUN_CORE_G, RangeType.UNSIGNED_INT, ref tbSunCoreG),
                new EditionValue(EditionValueType.SUN_CORE_R, RangeType.UNSIGNED_INT, ref tbSunCoreR),
                new EditionValue(EditionValueType.SKY_BOTTOM_B, RangeType.UNSIGNED_INT, ref tbSkyBottomB),
                new EditionValue(EditionValueType.SKY_BOTTOM_G, RangeType.UNSIGNED_INT, ref tbSkyBottomG),
                new EditionValue(EditionValueType.SKY_BOTTOM_R, RangeType.UNSIGNED_INT, ref tbSkyBottomR),
                new EditionValue(EditionValueType.SKY_TOP_B, RangeType.UNSIGNED_INT, ref tbSkyTopB),
                new EditionValue(EditionValueType.SKY_TOP_G, RangeType.UNSIGNED_INT, ref tbSkyTopG),
                new EditionValue(EditionValueType.SKY_TOP_R, RangeType.UNSIGNED_INT, ref tbSkyTopR),
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
            Click += (s, ea) => btnApply.Focus();
            AddClickEventOnPanels(this);

            AddClickEventOnAllPictureBoxes(pnlFields, null);

            AddEventsOnAllTextBoxes(pnlFields);
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

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Directory.Exists(backupDirectory))
                Directory.Delete(backupDirectory, true);
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
                }
            }
            catch (Exception)
            {
                pnlMain.Visible = false;
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
        /// <summary>Replace timecyc's draw distance value without rewrite timecyc.dat</summary>
        private void ReplaceValues(List<EditionValue> editionValues)
        {
            foreach (var editionValue in editionValues)
            {
                if (editionValue.EGTextBox.Text != "")
                {
                    if (editionValue.Type == EditionValueType.ILLUMINATION && editionValue.Index == 0)
                    {
                        timecyc[editionValue.LineNumber] = $"{timecyc[editionValue.LineNumber]} {editionValue.EGTextBox.Text}";
                    }
                    else
                    {
                        timecyc[editionValue.LineNumber] = timecyc[editionValue.LineNumber].Remove(editionValue.Index, editionValue.Length);
                        timecyc[editionValue.LineNumber] = timecyc[editionValue.LineNumber].Insert(editionValue.Index, editionValue.EGTextBox.Text);
                    }
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
                    btnApply.Focus();
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
                        btnApply.Focus();
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
        /// <summary>Recursive addition Click event on all PictureBoxes on the pnlEdit</summary>
        private void AddClickEventOnAllPictureBoxes(Control parent, Control pControl)
        {
            if (parent is PictureBox)
            {
                parent.Click += (s, e) =>
                {
                    using (var colorPicker = new frmColorPicker() { SelectedColor = parent.BackColor })
                    {
                        colorPicker.ColorChanged += (sen, ev) => parent.BackColor = colorPicker.SelectedColor;
                        colorPicker.StartPosition = FormStartPosition.Manual;
                        colorPicker.Location = new Point(pControl.Location.X + Location.X + pControl.Width,
                                                         pControl.Location.Y + Location.Y - pControl.Height);
                        var result = colorPicker.ShowDialog();
                    }
                };
            }
            foreach (Control control in parent.Controls)
            {
                AddClickEventOnAllPictureBoxes(control, parent);
            }
        }
        /// <summary>Recursive editing BackColor of all PictureBoxes on the pnlEdit</summary>
        private void SetBackColorOfPictureBoxes(Control parent)
        {
            if (parent is GroupBox)
            {
                int R = 0, G = 0, B = 0;
                foreach (var control in parent.Controls)
                {
                    if (control is EgoldsGoogleTextBox)
                    {
                        if (((EgoldsGoogleTextBox)control).TextPreview == "Red".Translate())
                            R = int.Parse(((EgoldsGoogleTextBox)control).Text);
                        if (((EgoldsGoogleTextBox)control).TextPreview == "Green".Translate())
                            G = int.Parse(((EgoldsGoogleTextBox)control).Text);
                        if (((EgoldsGoogleTextBox)control).TextPreview == "Blue".Translate())
                            B = int.Parse(((EgoldsGoogleTextBox)control).Text);
                    }
                }
                foreach (var control in parent.Controls)
                {
                    if (control is PictureBox)
                    {
                        ((PictureBox)control).BackColor = Color.FromArgb(R, G, B);
                    }
                }
            }
            foreach (Control control in parent.Controls)
            {
                SetBackColorOfPictureBoxes(control);
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
        /// <summary>Create a copy of the timecyc.dat for backup</summary>
        private void CopyTimecycForBackUp()
        {
            Directory.CreateDirectory(backupDirectory);
            File.Copy($@"{gtaPath}\data\timecyc.dat", $@"{backupDirectory}\timecyc.dat", true);
        }
    }
}