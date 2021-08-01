using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using yt_DesignUI;
using yt_DesignUI.Controls;

namespace HBMTimecycEditor
{
    public partial class frmMain : ShadowedForm
    {
        #region Variables
        string gtaPath = "";
        string[] timecyc;
        Position drawDist = new Position();
        Position fogDist = new Position();
        Position sprtBrght = new Position();
        List<Position> positions = new List<Position>();
        #endregion

        public frmMain()
        {
            InitializeComponent();
            Animator.Start();

            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\HBMDrawDistEditor"))
                {
                    gtaPath = key.GetValue("path").ToString();
                }
                pathTB.Text = gtaPath;
                pathTB.SelectionStart = pathTB.TextLength;
                timecyc = File.ReadAllLines($@"{gtaPath}\data\timecyc.dat");
            }
            catch (Exception)
            {
                DDpanel.Visible = false;
            }

            weatherCB.SelectedIndex = 0;
            timeCB.SelectedIndex = 0;

            Position drawDist = new Position(Number.DRAW_DIST_VALUE, ref drawTB);
            Position fogDist = new Position(Number.FOG_DIST_VALUE, ref fogTB);
            Position sprtBrght = new Position(Number.SPRITE_BRIGHT_VALUE, ref spbrTB);

            positions.AddRange(new Position[] { drawDist, fogDist, sprtBrght });
        }

        #region ComboBoxes
        private void CBox_SelectedIndexChanged()
        {
            if (timeCB.SelectedIndex > 0 && weatherCB.SelectedIndex > 0)
            {
                GetPosition(weatherCB.SelectedIndex, timeCB.SelectedIndex, positions);
                drawTB.Text = timecyc[drawDist.LineNum].Substring(drawDist.Index, drawDist.Length);
                fogTB.Text = timecyc[fogDist.LineNum].Substring(fogDist.Index, fogDist.Length);
                spbrTB.Text = timecyc[sprtBrght.LineNum].Substring(sprtBrght.Index, sprtBrght.Length);
            }
            else
            {
                drawTB.Text = "";
                fogTB.Text = "";
                spbrTB.Text = "";
            }
            spbrTB.SelectionStart = spbrTB.TextLength;
        }
        private void WeatherCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBox_SelectedIndexChanged();
        }
        private void TimeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBox_SelectedIndexChanged();
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
        private void DrawTB_TextChanged(object sender, EventArgs e)
        {
            Filter(drawTB);
        }
        private void FogTB_TextChanged(object sender, EventArgs e)
        {
            Filter(fogTB);
        }
        private void SpbrTB_TextChanged(object sender, EventArgs e)
        {
            Filter(spbrTB);
        }
        private void PathTB_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists($@"{pathTB.Text}\data\timecyc.dat"))
                UpdateFields();
            else
                DDpanel.Visible = false;
        }
        #endregion

        #region Buttons
        private void BrowseBtn_Click(object sender, EventArgs e)
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
                        pathTB.Text = fbd.SelectedPath;
                        UpdateFields();
                    }
                    else MessageBox.Show("Указанная папка не GTA", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            #region DataValidation
            if (drawTB.Text == "" && fogTB.Text == "" && spbrTB.Text == "")
            {
                MessageBox.Show("Enter a value in at least one of the fields");
                return;
            }
            else
            {
                if (drawTB.Text != "" &&
                (double.Parse(drawTB.Text.Replace(".", ",")) < -3600 ||
                double.Parse(drawTB.Text.Replace(".", ",")) > 3600))
                {
                    MessageBox.Show("Enter a value between 3600 and -3600 in the Draw distance field");
                    drawTB.Text = "";
                    return;
                }
                if (fogTB.Text != "" &&
                    (double.Parse(fogTB.Text.Replace(".", ",")) < -3600 ||
                    double.Parse(fogTB.Text.Replace(".", ",")) > 3600))
                {
                    MessageBox.Show("Enter a value between 3600 and -3600 in the Fog distance field");
                    fogTB.Text = "";
                    return;
                }
                if (spbrTB.Text != "" &&
                    (double.Parse(spbrTB.Text.Replace(".", ",")) < -0.1 ||
                    double.Parse(spbrTB.Text.Replace(".", ",")) > 25.4))
                {
                    MessageBox.Show("Enter a value between -0.1 and 25.4 in the Sprite brightness field");
                    spbrTB.Text = "";
                    return;
                }
            }
            #endregion

            if (weatherCB.SelectedIndex > 0 && timeCB.SelectedIndex > 0)
            {
                ReplaceValues(positions);
            }
            else if (weatherCB.SelectedIndex == 0 && timeCB.SelectedIndex == 0)
            {
                for (int i = 1; i < weatherCB.Items.Count; i++)
                {
                    for (int j = 1; j < timeCB.Items.Count; j++)
                    {
                        GetPosition(i, j, positions);
                        ReplaceValues(positions);
                    }
                }
            }
            else
            {
                int count;
                if (weatherCB.SelectedIndex == 0)
                    count = weatherCB.Items.Count;
                else
                    count = timeCB.Items.Count;
                for (int i = 1; i < count; i++)
                {
                    if (weatherCB.SelectedIndex == 0)
                    {
                        GetPosition(i, timeCB.SelectedIndex, positions);
                    }
                    else
                    {
                        GetPosition(weatherCB.SelectedIndex, i, positions);
                    }
                    ReplaceValues(positions);
                }
            }

            File.WriteAllLines($@"{gtaPath}\data\timecyc.dat", timecyc);
            MessageBox.Show("Done!");
        }
        #endregion

        #region Remove focus
        private void Form1_Click(object sender, EventArgs e)
        {
            editBtn.Focus();
        }
        private void DDpanel_Click(object sender, EventArgs e)
        {
            editBtn.Focus();
        }
        #endregion

        /// <summary>Gets: the starting index of the draw distance value and his length</summary>
        private void GetPosition(int weatherIndex, int timeIndex, List<Position> positions)
        {
            foreach (var position in positions)
            {
                for (position.LineNum = 0; position.LineNum < timecyc.Length; position.LineNum++)
                {
                    if (timecyc[position.LineNum].Contains($@"//{weatherCB.Items[weatherIndex]}") ||
                        timecyc[position.LineNum].Contains($@" {weatherCB.Items[weatherIndex]}"))
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
            drawDist = positions[0];
            fogDist = positions[1];
            sprtBrght = positions[2];
        }
        /// <summary>Update path and draw dist value and re-read timecyc.dat</summary>
        private void UpdateFields()
        {
            gtaPath = pathTB.Text;
            timecyc = File.ReadAllLines($@"{gtaPath}\data\timecyc.dat");
            Registry.CurrentUser.CreateSubKey(@"Software\HBMDrawDistEditor").SetValue("path", gtaPath);
            DDpanel.Visible = true;
            if (!editBtn.Enabled)
                editBtn.Enabled = true;

            int wSel = weatherCB.SelectedIndex;
            if (weatherCB.SelectedIndex != 0)
                weatherCB.SelectedIndex = 0;
            else
                weatherCB.SelectedIndex = 1;
            weatherCB.SelectedIndex = wSel;
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