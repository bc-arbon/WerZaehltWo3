using System;
using System.Windows.Forms;

namespace BCA.WerZaehltWo3.Tests.Gui.Forms
{
    static class Program
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