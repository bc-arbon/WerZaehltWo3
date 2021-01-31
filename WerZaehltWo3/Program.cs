using BCA.WerZaehltWo3.Forms;
using System;
using System.Windows.Forms;

namespace BCA.WerZaehltWo3
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
