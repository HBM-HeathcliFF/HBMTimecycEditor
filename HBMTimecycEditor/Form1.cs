using Microsoft.Win32;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using yt_DesignUI;
using yt_DesignUI.Controls;

namespace HBMTimecycEditor
{
    public partial class Form1 : ShadowedForm
    {
        string gtaPath = "";
        string[] timecyc;
        int index, length, lineNum;

        public Form1()
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
        }

        #region ComboBoxes
        private void CBox_SelectedIndexChanged()
        {
            if (timeCB.SelectedIndex > 0 && weatherCB.SelectedIndex > 0)
            {
                GetDrawDistValuePosition(weatherCB.SelectedIndex, timeCB.SelectedIndex);
                drawTB.Text = timecyc[lineNum].Substring(index, length);
            }
            else
            {
                drawTB.Text = "";
            }
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
        private void DrawTB_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(drawTB.Text, "[^0-9]"))
            {
                drawTB.Text = drawTB.Text.Remove(drawTB.Text.Length - 1);
                drawTB.SelectionStart = drawTB.TextLength;
            }
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
            if (drawTB.Text == "" ||
                int.Parse(drawTB.Text) < -3600 ||
                int.Parse(drawTB.Text) > 3600)
            {
                MessageBox.Show("Enter a value between 3600 and -3600");
                drawTB.Text = "";
                return;
            }
            if (weatherCB.SelectedIndex > 0 && timeCB.SelectedIndex > 0)
            {
                ReplaceDDValue();
            }
            else if (weatherCB.SelectedIndex == 0 && timeCB.SelectedIndex == 0)
            {
                for (int i = 1; i < weatherCB.Items.Count; i++)
                {
                    for (int j = 1; j < timeCB.Items.Count; j++)
                    {
                        GetDrawDistValuePosition(i, j);
                        ReplaceDDValue();
                    }
                }
            }
            else
            {
                int count = 0;
                if (weatherCB.SelectedIndex == 0)
                    count = weatherCB.Items.Count;
                else
                    count = timeCB.Items.Count;
                for (int i = 1; i < count; i++)
                {
                    if (weatherCB.SelectedIndex == 0)
                        GetDrawDistValuePosition(i, timeCB.SelectedIndex);
                    else
                        GetDrawDistValuePosition(weatherCB.SelectedIndex, i);
                    ReplaceDDValue();
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
        private void GetDrawDistValuePosition(int weatherIndex, int timeIndex)
        {
            for (lineNum = 0; lineNum < timecyc.Length; lineNum++)
            {
                if (timecyc[lineNum].Contains($@"//{weatherCB.Items[weatherIndex]}") ||
                    timecyc[lineNum].Contains($@" {weatherCB.Items[weatherIndex]}"))
                {
                    string[] numbers = null;
                    for (int i = 0; i < timeIndex;)
                    {
                        bool isNumbers = true;
                        timecyc[lineNum] = timecyc[lineNum].Replace("\t", " ");
                        numbers = timecyc[lineNum].Split(' ');
                        for (int j = 0; j < numbers.Length; j++)
                        {
                            if (numbers[j] != "" && !(char.IsDigit(numbers[j].ToCharArray()[0]) ||
                                numbers[j].ToCharArray()[0] == '-'))
                            {
                                isNumbers = false;
                                break;
                            }
                        }
                        if (isNumbers)
                            i++;
                        lineNum++;
                    }
                    lineNum--;

                    index = 0;
                    for (int i = 0, k = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] != "" && (char.IsDigit(numbers[i].ToCharArray()[0]) ||
                            numbers[i].ToCharArray()[0] == '-'))
                            k++;
                        if (k == 28)
                        {
                            index = timecyc[lineNum].IndexOf(numbers[i]);
                            length = numbers[i].Length;
                            break;
                        }
                    }

                    break;
                }
            }
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
        private void ReplaceDDValue()
        {
            timecyc[lineNum] = timecyc[lineNum].Remove(index, length);
            timecyc[lineNum] = timecyc[lineNum].Insert(index, drawTB.Text + ".0");
        }
    }
}