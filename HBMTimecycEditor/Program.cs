using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace HBMTimecycEditor
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            if (Localization.Language == LocalizationLanguage.ENG)
                Registry.CurrentUser.CreateSubKey(@"Software\HBMDrawDistEditor").SetValue("language", "eng");
            else if (Localization.Language == LocalizationLanguage.RUS)
                Registry.CurrentUser.CreateSubKey(@"Software\HBMDrawDistEditor").SetValue("language", "rus");
        }

        public static bool[] Weathers { get; set; } = new bool[23];
        public static bool[] Times { get; set; } = new bool[8];
    }
}
