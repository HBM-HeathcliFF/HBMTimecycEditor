using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using yt_DesignUI;
using yt_DesignUI.Controls;
using System.Drawing;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Linq;

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
        string[] timecyc;
        Position drawDist = new Position();
        Position fogDist = new Position();
        Position spriteBrght = new Position();
        Position lightOnGround = new Position();
        List<Position> positions = new List<Position>();
        const int OFFSET = 42;
        #endregion

        public frmMain()
        {
            InitializeComponent();
            
            #region Protection against restarting
            // Protection against restarting the application
            // with the subsequent activation of an existing window
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
            #endregion
            
            Animator.Start();

            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\HBMDrawDistEditor"))
                {
                    gtaPath = key.GetValue("path").ToString();
                }
                tbPath.Text = gtaPath;
                tbPath.SelectionStart = tbPath.TextLength;
                timecyc = File.ReadAllLines($@"{gtaPath}\data\timecyc.dat");
            }
            catch (Exception)
            {
                pnlDrawDist.Visible = false;
            }

            cbWeather.SelectedIndex = 0;
            cbTime.SelectedIndex = 0;

            Position lightOnGrnd = new Position(Number.LIGHT_ON_GROUND, ref tbLightOnGround);
            Position fogDist = new Position(Number.FOG_DIST_VALUE, ref tbFog);
            Position drawDist = new Position(Number.DRAW_DIST_VALUE, ref tbDraw);
            Position sprtBrght = new Position(Number.SPRITE_BRIGHT_VALUE, ref tbSpriteBright);

            positions.AddRange(new Position[] { lightOnGrnd, fogDist, drawDist, sprtBrght });
        }

        private async void TgglMultiselect_CheckedChanged(object sender)
        {
            int Y = pnlEdit.Location.Y, defHeight = this.Height;
            if (tgglMultiselect.Checked)
            {
                pnlOneSelect.Visible = false;
                while (pnlEdit.Location.Y > Y - OFFSET)
                {
                    await Task.Delay(1);
                    this.Height -= pnlEdit.Location.Y / 5;
                    pnlEdit.Location = new Point(pnlEdit.Location.X,
                        pnlEdit.Location.Y - pnlEdit.Location.Y / 5);
                }
                pnlEdit.Location = new Point(pnlEdit.Location.X, Y - OFFSET);
                this.Height = defHeight - OFFSET;

                tgglMultiselect.Text = "";
                btnChange.Visible = true;
                FreezeTgglMultiselect();
                new frmMultiselect(this).Show();
            }
            else
            {
                pnlOneSelect.Visible = true;
                while (pnlEdit.Location.Y < Y + OFFSET)
                {
                    await Task.Delay(1);
                    this.Height += (Y + OFFSET - pnlEdit.Location.Y) / 4 + 1;
                    pnlEdit.Location = new Point(pnlEdit.Location.X,
                        pnlEdit.Location.Y + (Y + OFFSET - pnlEdit.Location.Y) / 4 + 1);
                }
                pnlEdit.Location = new Point(pnlEdit.Location.X, Y + OFFSET);
                this.Height = defHeight + OFFSET;

                tgglMultiselect.Text = "Multiselect";
                btnChange.Visible = false;
            }
        }
        private void FreezeTgglMultiselect()
        {
            tgglMultiselect.Enabled = false;
            tgglMultiselect.BackColorON = Color.FromArgb(87, 175, 125);
            tgglMultiselect.Refresh();
        }

        #region ComboBoxes
        private void ComboBox_SelectedIndexChanged()
        {
            if (cbTime.SelectedIndex > 0 && cbWeather.SelectedIndex > 0)
            {
                GetPosition(cbWeather.SelectedIndex, cbTime.SelectedIndex, positions);
                tbDraw.Text = timecyc[drawDist.LineNum].Substring(drawDist.Index, drawDist.Length);
                tbFog.Text = timecyc[fogDist.LineNum].Substring(fogDist.Index, fogDist.Length);
                tbSpriteBright.Text = timecyc[spriteBrght.LineNum].Substring(spriteBrght.Index, spriteBrght.Length);
                tbLightOnGround.Text = timecyc[lightOnGround.LineNum].Substring(lightOnGround.Index, lightOnGround.Length);
            }
            else
            {
                tbDraw.Text = "";
                tbFog.Text = "";
                tbSpriteBright.Text = "";
                tbLightOnGround.Text = "";
            }
            tbSpriteBright.SelectionStart = tbSpriteBright.TextLength;
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

        #region TextBoxes
        private void Filter(EgoldsGoogleTextBox textBox)
        {
            if (Regex.IsMatch(textBox.Text, "[^0-9---.]"))
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                textBox.SelectionStart = textBox.TextLength;
            }
        }
        private void TbDraw_TextChanged(object sender, EventArgs e)
        {
            Filter(tbDraw);
        }
        private void TbFog_TextChanged(object sender, EventArgs e)
        {
            Filter(tbFog);
        }
        private void TbSpriteBright_TextChanged(object sender, EventArgs e)
        {
            Filter(tbSpriteBright);
        }
        private void TbLightOnGround_TextChanged(object sender, EventArgs e)
        {
            Filter(tbLightOnGround);
        }
        private void TbPath_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists($@"{tbPath.Text}\data\timecyc.dat"))
                UpdateFields();
            else
                pnlDrawDist.Visible = false;
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
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            #region DataValidation
            if (tbDraw.Text == "" && tbFog.Text == "" && tbSpriteBright.Text == "" && tbLightOnGround.Text == "")
            {
                MessageBox.Show("Enter a value in at least one of the fields");
                return;
            }
            else
            {
                if (tbDraw.Text != "" &&
                (double.Parse(tbDraw.Text.Replace(".", ",")) < -3600 ||
                double.Parse(tbDraw.Text.Replace(".", ",")) > 3600))
                {
                    MessageBox.Show("Enter a value between 3600 and -3600 in the Draw distance field");
                    tbDraw.Text = "";
                    return;
                }
                if (tbFog.Text != "" &&
                    (double.Parse(tbFog.Text.Replace(".", ",")) < -3600 ||
                    double.Parse(tbFog.Text.Replace(".", ",")) > 3600))
                {
                    MessageBox.Show("Enter a value between 3600 and -3600 in the Fog distance field");
                    tbFog.Text = "";
                    return;
                }
                if (tbSpriteBright.Text != "" &&
                    (double.Parse(tbSpriteBright.Text.Replace(".", ",")) < -0.1 ||
                    double.Parse(tbSpriteBright.Text.Replace(".", ",")) > 25.4))
                {
                    MessageBox.Show("Enter a value between -0.1 and 25.4 in the Sprite brightness field");
                    tbSpriteBright.Text = "";
                    return;
                }
                if (tbLightOnGround.Text != "" &&
                    (double.Parse(tbLightOnGround.Text.Replace(".", ",")) < -0.1 ||
                    double.Parse(tbLightOnGround.Text.Replace(".", ",")) > 25.4))
                {
                    MessageBox.Show("Enter a value between -0.1 and 25.4 in the Light on ground field");
                    tbLightOnGround.Text = "";
                    return;
                }
            }
            #endregion

            if (cbWeather.SelectedIndex > 0 && cbTime.SelectedIndex > 0)
            {
                ReplaceValues(positions);
            }
            else if (cbWeather.SelectedIndex == 0 && cbTime.SelectedIndex == 0)
            {
                for (int i = 1; i < cbWeather.Items.Count; i++)
                {
                    for (int j = 1; j < cbTime.Items.Count; j++)
                    {
                        GetPosition(i, j, positions);
                        ReplaceValues(positions);
                    }
                }
            }
            else
            {
                int count;
                if (cbWeather.SelectedIndex == 0)
                    count = cbWeather.Items.Count;
                else
                    count = cbTime.Items.Count;
                for (int i = 1; i < count; i++)
                {
                    if (cbWeather.SelectedIndex == 0)
                    {
                        GetPosition(i, cbTime.SelectedIndex, positions);
                    }
                    else
                    {
                        GetPosition(cbWeather.SelectedIndex, i, positions);
                    }
                    ReplaceValues(positions);
                }
            }

            File.WriteAllLines($@"{gtaPath}\data\timecyc.dat", timecyc);
            MessageBox.Show("Done!");
        }
        private void BtnChange_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMultisel"] == null)
            {
                FreezeTgglMultiselect();
                new frmMultiselect(this).Show();
            }
        }
        #endregion

        #region Remove focus
        private void FrmMain_Click(object sender, EventArgs e)
        {
            btnEdit.Focus();
        }
        private void PnlOneSelect_Click(object sender, EventArgs e)
        {
            btnEdit.Focus();
        }
        #endregion

        /// <summary>Gets: the starting index of the draw distance value and his length</summary>
        private void GetPosition(int weatherIndex, int timeIndex, List<Position> positions)
        {
            foreach (var position in positions)
            {
                for (position.LineNum = 0; position.LineNum < timecyc.Length; position.LineNum++)
                {
                    if (timecyc[position.LineNum].Contains($@"//{cbWeather.Items[weatherIndex]}") ||
                        timecyc[position.LineNum].Contains($@" {cbWeather.Items[weatherIndex]}"))
                    {
                        string[] numbers = null;
                        for (int i = 0; i < timeIndex;)
                        {
                            bool isNumbers = true;
                            timecyc[position.LineNum] = timecyc[position.LineNum].Replace("\t", " ");
                            numbers = timecyc[position.LineNum].Split(' ');
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
                            position.LineNum++;
                        }
                        position.LineNum--;

                        position.Index = 0;
                        for (int i = 0, num = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] != "" && (char.IsDigit(numbers[i].ToCharArray()[0]) ||
                                numbers[i].ToCharArray()[0] == '-'))
                                num++;
                            if (num == (int)position.NumberPos)
                            {
                                string substrBef = "";
                                for (int k = 0; k < i; k++)
                                {
                                    substrBef += $"{numbers[k]} ";
                                }
                                position.Index = substrBef.Length;
                                position.Length = numbers[i].Length;
                                break;
                            }
                        }

                        break;
                    }
                }
            }
            lightOnGround = positions[3];
            fogDist = positions[1];
            drawDist = positions[0];
            spriteBrght = positions[2];
        }
        /// <summary>Update path and draw dist value and re-read timecyc.dat</summary>
        private void UpdateFields()
        {
            gtaPath = tbPath.Text;
            timecyc = File.ReadAllLines($@"{gtaPath}\data\timecyc.dat");
            Registry.CurrentUser.CreateSubKey(@"Software\HBMDrawDistEditor").SetValue("path", gtaPath);
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
        private void ReplaceValues(List<Position> positions)
        {
            foreach (var position in positions)
            {
                if (position.EGTBox.Text != "")
                {
                    timecyc[position.LineNum] = timecyc[position.LineNum].Remove(position.Index, position.Length);
                    timecyc[position.LineNum] = timecyc[position.LineNum].Insert(position.Index, position.EGTBox.Text);
                }
            }
        }
    }
}