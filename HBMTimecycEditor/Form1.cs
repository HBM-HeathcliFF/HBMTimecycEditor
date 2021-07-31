using Microsoft.Win32;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HBMTimecycEditor
{
    public partial class Form1 : Form
    {
        string gtaPath = "";
        string[] timecyc;
        int index, length, lineNum;

        public Form1()
        {
            InitializeComponent();

            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\HBMDrawDistEditor"))
                {
                    gtaPath = key.GetValue("path").ToString();
                }
                pathTB.Text = gtaPath;
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
                GetDrawDist(weatherCB.SelectedIndex, timeCB.SelectedIndex);
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
            if (weatherCB.SelectedIndex > 0 && timeCB.SelectedIndex > 0)
            {
                ReplaceDD();
            }
            else if (weatherCB.SelectedIndex == 0 && timeCB.SelectedIndex == 0)
            {
                for (int i = 1; i < weatherCB.Items.Count; i++)
                {
                    for (int j = 1; j < timeCB.Items.Count; j++)
                    {
                        GetDrawDist(i, j);
                        ReplaceDD();
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
                        GetDrawDist(i, timeCB.SelectedIndex);
                    else
                        GetDrawDist(weatherCB.SelectedIndex, i);
                    ReplaceDD();
                }
            }

            File.WriteAllLines($@"{gtaPath}\data\timecyc.dat", timecyc);
            MessageBox.Show("Done!");
        }
        #endregion

        private void GetDrawDist(int weatherIndex, int timeIndex)
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
        private void ReplaceDD()
        {
            timecyc[lineNum] = timecyc[lineNum].Remove(index, length);
            timecyc[lineNum] = timecyc[lineNum].Insert(index, drawTB.Text + ".0");
        }
    }
}