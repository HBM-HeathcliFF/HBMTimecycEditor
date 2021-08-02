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
        }

        public static bool[] Weathers { get; set; } = new bool[23];
        public static bool[] Times { get; set; } = new bool[8];
    }
}
